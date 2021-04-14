using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.NET.Base;
using WeatherAPI.NET.Entities;
using WeatherAPI.NET.Operations.Base;

namespace WeatherAPI.NET.Operations
{
    public class AstronomyOperations : BaseOperations, IAstronomyOperations
    {
        #region Public Methods
        /// <summary>
        /// Gets the current astronomy information using automatic location.
        /// </summary>
        public virtual Task<AstronomyResponseEntity> GetAstronomyAsync(CancellationToken cancellationToken = default)
        {
            return ((IAstronomyOperations)this).GetAstronomyAsync<AstronomyResponseEntity>(cancellationToken);
        }

        /// <summary>
        /// Gets the current astronomy information using automatic location.
        /// </summary>
        public virtual Task<TAstronomyResponseEntity> GetAstronomyAsync<TAstronomyResponseEntity>(CancellationToken cancellationToken = default)
            where TAstronomyResponseEntity : class
        {
            return ((IAstronomyOperations)this).GetAstronomyAsync<TAstronomyResponseEntity>(new RequestEntity(), cancellationToken);
        }

        /// <summary>
        /// Gets the current astronomy information.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<AstronomyResponseEntity> GetAstronomyAsync(RequestEntity request, CancellationToken cancellationToken = default)
        {
            return ((IAstronomyOperations)this).GetAstronomyAsync<AstronomyResponseEntity>(request, cancellationToken);
        }

        /// <summary>
        /// Gets the current astronomy information.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<TAstronomyResponseEntity> GetAstronomyAsync<TAstronomyResponseEntity>(RequestEntity request, CancellationToken cancellationToken = default)
            where TAstronomyResponseEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TAstronomyResponseEntity>(HttpMethod.Get, "astronomy.json", request.GetQueryParameters(), null, cancellationToken);
        }
        #endregion

        #region Constructors
        public AstronomyOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
        #endregion
    }
}
