using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WeatherAPI.Base
{
    public interface IApiRequestor
    {
        #region Properties
        /// <summary>
        /// Gets the API key used for authenticating with the API.
        /// </summary>
        string ApiKey { get; }

        /// <summary>
        /// Gets or sets the base API URI.
        /// </summary>
        Uri BaseApiUri { get; set; }

        /// <summary>
        /// Gets the API client's underlying HTTP client.
        /// </summary>
        HttpClient HttpClient { get; }

        /// <summary>
        /// Gets or sets how many times an operation should be retried for transient failures.
        /// </summary>
        int RetryCount { get; set; }

        /// <summary>
        /// Gets or sets how long to wait between retrying operations.
        /// </summary>
        TimeSpan RetryDelay { get; set; }
        #endregion

        #region REST Methods
        /// <summary>
        /// Sends a raw REST request to the API. Includes error handling logic but no retry logic.
        /// </summary>
        /// <param name="method">The request method.</param>
        /// <param name="path">The request path.</param>
        /// <param name="queryParamaters">The query parameters, if any.</param>
        /// <param name="content">The request content, if any.</param>
        Task<HttpResponseMessage> RawRequestAsync(HttpMethod method, string path, string[] queryParameters, HttpContent content, CancellationToken cancellationToken);

        /// <summary>
        /// Sends a REST request to the API. Includes retry logic.
        /// </summary>
        /// <param name="method">The request method.</param>
        /// <param name="path">The request path.</param>
        /// <param name="queryParameters">The query parameters, if any.</param>
        /// <param name="content">The request content, if any.</param>
        Task<HttpResponseMessage> RequestAsync<TRequest>(HttpMethod method, string path, string[] queryParameters, TRequest content, CancellationToken cancellationToken);

        /// <summary>
        /// Sends a REST request to the API. Includes retry logic.
        /// </summary>
        /// <param name="method">The request method.</param>
        /// <param name="path">The request path.</param>
        /// <param name="queryParameters">The query parameters, if any.</param>
        /// <param name="content">The request content, if any.</param>
        Task<HttpResponseMessage> RequestAsync(HttpMethod method, string path, string[] queryParameters, HttpContent content, CancellationToken cancellationToken);

        /// <summary>
        /// Request a serialized object response with content.
        /// </summary>
        /// <param name="method">The request method.</param>
        /// <param name="path">The request path.</param>
        /// <param name="content">The request content.</param>
        /// <param name="queryParameters">The query parameters, if any.</param>
        Task<TResponse> RequestJsonSerializedAsync<TResponse>(HttpMethod method, string path, HttpContent content, CancellationToken cancellationToken, params string[] queryParameters);
        #endregion
    }
}
