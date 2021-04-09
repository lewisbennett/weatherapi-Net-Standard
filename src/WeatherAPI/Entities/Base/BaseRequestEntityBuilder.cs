using System;

namespace WeatherAPI.Entities.Base
{
    public abstract class BaseRequestEntityBuilder
    {
        #region Properties
        /// <summary>
        /// Gets the request query.
        /// </summary>
        public string Query { get; internal set; }

        /// <summary>
        /// Gets the request language.
        /// </summary>
        public string Language { get; internal set; }
        #endregion

        #region Internal Methods
        /// <summary>
        /// Checks that the provided parameters are valid, ahead of constructing the request.
        /// </summary>
        internal virtual void CheckParameters()
        {
            if (string.IsNullOrWhiteSpace(Query))
                throw new InvalidOperationException("The location for the request is invalid.");
        }
        #endregion

        #region Constructors
        protected BaseRequestEntityBuilder()
        {
            // Configure request defaults.
            this.WithAutoIP();
        }
        #endregion
    }

    public abstract class BaseRequestEntityBuilder<TRequestEntity> : BaseRequestEntityBuilder
        where TRequestEntity : BaseRequestEntity, new()
    {
        #region Public Methods
        /// <summary>
        /// Builds the request configuration.
        /// </summary>
        public virtual TRequestEntity Build()
        {
            CheckParameters();

            var request = new TRequestEntity();

            ConfigureRequest(request);

            return request;
        }
        #endregion

        #region Internal Methods
        /// <summary>
        /// Configures the request.
        /// </summary>
        /// <param name="request">The request.</param>
        internal virtual void ConfigureRequest(TRequestEntity request)
        {
            request.AddParameter($"q={Query}");

            if (!string.IsNullOrWhiteSpace(Language))
                request.AddParameter($"lang={Language}");
        }
        #endregion
    }
}
