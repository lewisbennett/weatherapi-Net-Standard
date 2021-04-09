using System;

namespace WeatherAPI.Entities.Base
{
    public abstract class BaseRequestEntityBuilder
    {
        #region Fields
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

        /// <summary>
        /// Configures the request.
        /// </summary>
        /// <param name="request">The request.</param>
        internal virtual void ConfigureRequest(RequestEntity request)
        {
            request.AddParameter($"q={Query}");

            if (!string.IsNullOrWhiteSpace(Language))
                request.AddParameter($"lang={Language}");
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
}
