using WeatherAPI.Base;

namespace WeatherAPI.Operations.Base
{
    public abstract class BaseOperations : IOperations
    {
        #region Properties
        /// <summary>
        /// Gets the API requestor for communicating with the API.
        /// </summary>
        public IApiRequestor ApiRequestor { get; }
        #endregion

        #region Constructors
        protected BaseOperations(IApiRequestor apiRequestor)
            : base()
        {
            ApiRequestor = apiRequestor;
        }
        #endregion
    }
}
