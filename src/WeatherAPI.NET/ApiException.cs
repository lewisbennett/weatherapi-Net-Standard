using System;
using System.Net;
using System.Net.Http;

namespace WeatherAPI.NET
{
    public sealed class ApiException : Exception
    {
        #region Fields
        private readonly ApiError[] _errors;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the relevant errors, or empty.
        /// </summary>
        public ApiError[] Errors => _errors ?? Array.Empty<ApiError>();

        /// <summary>
        /// Gets the response message that generated the exception, if any.
        /// </summary>
        public HttpResponseMessage ResponseMessage { get; private set; }

        /// <summary>
        /// Gets the status code of the response that generated the exception, if any.
        /// </summary>
        public HttpStatusCode StatusCode => ResponseMessage?.StatusCode ?? 0;
        #endregion

        #region Constructors
        public ApiException()
            : this(null)
        {
        }

        public ApiException(string message)
            : this(message, (Exception)null)
        {
        }

        public ApiException(string message, Exception innerException)
            : this(message, innerException, null)
        {
        }

        public ApiException(string message, HttpResponseMessage responseMessage, params ApiError[] errors)
            : this(message, null, responseMessage, errors)
        {
        }

        public ApiException(string message, Exception innerException, HttpResponseMessage responseMessage, params ApiError[] errors)
            : base(message, innerException)
        {
            _errors = errors;

            ResponseMessage = responseMessage;
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// A formatted 'invalid server response' API exception.
        /// </summary>
        /// <param name="responseMessage">The response that generated the exception.</param>
        internal static ApiException InvalidServerResponse(HttpResponseMessage responseMessage)
        {
            return new ApiException($"Invalid server response: {(int)responseMessage.StatusCode} {responseMessage.StatusCode}.", responseMessage);
        }
        #endregion
    }
}
