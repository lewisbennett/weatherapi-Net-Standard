using WeatherAPI.Base;

namespace WeatherAPI.Operations.Base
{
    public interface IOperations
    {
        #region Properties
        /// <summary>
        /// Gets the API requestor for communicating with the API.
        /// </summary>
        public IApiRequestor ApiRequestor { get; }
        #endregion
    }
}
