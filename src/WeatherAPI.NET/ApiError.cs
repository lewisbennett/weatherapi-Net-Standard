using Newtonsoft.Json;

namespace WeatherAPI.NET
{
    public sealed class ApiError
    {
        #region Properties
        /// <summary>
        /// Gets the error code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; }
        #endregion

        #region Constructors
        public ApiError(string code, string message)
        {
            Code = code;
            Message = message;
        }
        #endregion
    }
}
