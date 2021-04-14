using System;
using System.Collections.Generic;

namespace WeatherAPI.NET.Entities.Base
{
    public abstract class BaseRequestEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the language parameter, if any.
        /// </summary>
        public string Language { get; internal set; }

        /// <summary>
        /// Gets or sets the query parameter.
        /// </summary>
        public string Query { get; internal set; }
        #endregion

        #region Internal Methods
        /// <summary>
        /// Gets the configuration as formatted query parameters.
        /// </summary>
        internal virtual string[] GetQueryParameters()
        {
            ValidateConfiguration();

            var queryParameters = new List<string>();

            AddQueryParameters(queryParameters);

            return queryParameters.ToArray();
        }
        #endregion

        #region Protected Methods
        protected virtual void AddQueryParameters(List<string> queryParameters)
        {
            queryParameters.Add($"q={Query}");

            if (!string.IsNullOrWhiteSpace(Language))
                queryParameters.Add($"lang={Language}");
        }

        protected virtual void ValidateConfiguration()
        {
            if (string.IsNullOrWhiteSpace(Query))
                throw new InvalidOperationException("The location for the request is invalid.");
        }
        #endregion

        #region Constructors
        protected BaseRequestEntity()
        {
            // Default query for location.
            this.WithAutoIP();
        }
        #endregion
    }
}
