using System.Collections.Generic;

namespace WeatherAPI.Entities.Base
{
    public abstract class BaseRequestEntity
    {
        #region Fields
        private readonly List<string> _parameters = new();
        #endregion

        #region Internal Methods
        /// <summary>
        /// Adds a parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        internal void AddParameter(string parameter)
        {
            lock (_parameters)
                _parameters.Add(parameter);
        }

        /// <summary>
        /// Gets the parameters as an array.
        /// </summary>
        internal string[] GetParameters()
        {
            lock (_parameters)
                return _parameters.ToArray();
        }

        /// <summary>
        /// Removes a parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        internal void RemoveParameter(string parameter)
        {
            lock (parameter)
                _parameters.Remove(parameter);
        }
        #endregion

        #region Constructors
        protected BaseRequestEntity()
        {
        }
        #endregion
    }
}
