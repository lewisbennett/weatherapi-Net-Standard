using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Entities;

namespace WeatherAPI.Operations.Base
{
    public interface IRealtimeOperations : IOperations
    {
        #region Methods
        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        Task<CurrentEntity> GetCurrentAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        Task<TCurrentEntity> GetCurrentAsync<TCurrentEntity>(CancellationToken cancellationToken = default)
            where TCurrentEntity : class;

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<CurrentEntity> GetCurrentAsync(RequestEntity request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<TCurrentEntity> GetCurrentAsync<TCurrentEntity>(RequestEntity request, CancellationToken cancellationToken = default)
            where TCurrentEntity : class;
        #endregion
    }
}
