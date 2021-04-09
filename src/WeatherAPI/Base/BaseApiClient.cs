using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeatherAPI.Base
{
    public abstract class BaseApiClient : IApiRequestor
    {
        #region Properties
        /// <summary>
        /// Gets the API key used for authenticating with the API.
        /// </summary>
        public string ApiKey { get; }

        /// <summary>
        /// Gets or sets the base URI to use for the API.
        /// </summary>
        public Uri BaseApiUri { get; set; }

        /// <summary>
        /// Gets the API client's underlying HTTP client.
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// Gets or sets how many times an operation should be retried for transient failures. Default value: 3.
        /// </summary>
        public int RetryCount { get; set; } = 3;

        /// <summary>
        /// Gets or sets how long to wait between retrying operations. Default value: 3 seconds.
        /// </summary>
        public TimeSpan RetryDelay { get; set; } = TimeSpan.FromSeconds(3);
        #endregion

        #region REST Methods
        /// <summary>
        /// Sends a raw REST request to the API. Includes error handling logic but no retry logic.
        /// </summary>
        /// <param name="method">The request method.</param>
        /// <param name="path">The request path.</param>
        /// <param name="queryParamaters">The query parameters, if any.</param>
        /// <param name="content">The request content, if any.</param>
        async Task<HttpResponseMessage> IApiRequestor.RawRequestAsync(HttpMethod method, string path, string[] queryParameters, HttpContent content, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (string.IsNullOrWhiteSpace(ApiKey))
                throw new InvalidOperationException("No authentication provided.");

            // Add the base API URI to the path and add the API key.
            path = $"{BaseApiUri}{path}?key={ApiKey}";

            // Add any provided query parameters.
            if (queryParameters != null && queryParameters.Length > 0)
                path += string.Join("&", queryParameters);

            // Build the request using provided HTTP method, and build the request URI using the base API URI, provided path, and validated API key.
            var request = new HttpRequestMessage(method, path);

            // Assign request content, if supported by HTTP method.
            if (method != HttpMethod.Get)
                request.Content = content;

            var response = await HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);

            // Happy days! Return the response.
            if (response.IsSuccessStatusCode)
                return response;

            // If we're here, an exception of some description will be thrown.

            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                var apiError = JsonConvert.DeserializeObject<ApiError>(responseString);

                throw new ApiException("An error occurred with the request.", response, apiError);
            }
            catch
            {
                throw ApiException.InvalidServerResponse(response);
            }
        }

        /// <summary>
        /// Sends a REST request to the API. Includes retry logic.
        /// </summary>
        /// <param name="method">The request method.</param>
        /// <param name="path">The request path.</param>
        /// <param name="queryParamaters">The query parameters, if any.</param>
        /// <param name="content">The request content, if any.</param>
        Task<HttpResponseMessage> IApiRequestor.RequestAsync<TRequest>(HttpMethod method, string path, string[] queryParamaters, TRequest content, CancellationToken cancellationToken)
        {
            return ((IApiRequestor)this).RequestAsync(method, path, queryParamaters, SerializeContent(content), cancellationToken);
        }

        /// <summary>
        /// Sends a REST request to the API. Includes retry logic.
        /// </summary>
        /// <param name="method">The request method.</param>
        /// <param name="path">The request path.</param>
        /// <param name="queryParamaters">The query parameters, if any.</param>
        /// <param name="content">The request content, if any.</param>
        async Task<HttpResponseMessage> IApiRequestor.RequestAsync(HttpMethod method, string path, string[] queryParamaters, HttpContent content, CancellationToken cancellationToken)
        {
            for (var i = 0; i < RetryCount; i++)
            {
                try
                {
                    var response = await ((IApiRequestor)this).RawRequestAsync(method, path, queryParamaters, content, cancellationToken).ConfigureAwait(false);

                    return response;
                }
                catch (ApiException e)
                    when (e.StatusCode == HttpStatusCode.BadGateway && i < RetryCount - 1)
                {
                    await Task.Delay(RetryDelay).ConfigureAwait(false);

                    continue;
                }
            }

            throw new NotImplementedException("Unreachable.");
        }

        /// <summary>
        /// Request a serialized object response with content.
        /// </summary>
        /// <param name="method">The request method.</param>
        /// <param name="path">The request path.</param>
        /// <param name="content">The request content.</param>
        async Task<TResponse> IApiRequestor.RequestJsonSerializedAsync<TResponse>(HttpMethod method, string path, string[] queryParameters, HttpContent content, CancellationToken cancellationToken)
        {
            var response = await ((IApiRequestor)this).RequestAsync(method, path, queryParameters, content, cancellationToken).ConfigureAwait(false);

            if (!response.Content.Headers.ContentType.MediaType.StartsWith("application/json", StringComparison.CurrentCultureIgnoreCase))
                throw ApiException.InvalidServerResponse(response);

            return JsonConvert.DeserializeObject<TResponse>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new WeatherAPI API client with an optional custom base URI.
        /// </summary>
        /// <param name="baseApiUri">The base URI to use for the API, or null for default.</param>
        protected BaseApiClient(Uri baseApiUri = null)
        {
            BaseApiUri = baseApiUri ?? DefaultBaseApiUri;

            HttpClient = new HttpClient();
        }
        #endregion

        #region Private Methods
        private HttpContent SerializeContent<TContent>(TContent content)
        {
            return new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
        }
        #endregion

        #region Constant Values
        public static readonly Uri DefaultBaseApiUri = new("https://api.weatherapi.com/v1");
        #endregion
    }
}
