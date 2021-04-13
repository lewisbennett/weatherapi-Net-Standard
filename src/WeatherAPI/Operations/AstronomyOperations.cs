using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Base;
using WeatherAPI.Entities;
using WeatherAPI.Operations.Base;

namespace WeatherAPI.Operations
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
            return ((IAstronomyOperations)this).GetAstronomyAsync<TAstronomyResponseEntity>(RequestEntity.CreateFromAutoIP(), cancellationToken);
        }

        /// <summary>
        /// Gets the current astronomy information.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        public virtual Task<AstronomyResponseEntity> GetAstronomyAsync(RequestEntity query, CancellationToken cancellationToken = default)
        {
            return ((IAstronomyOperations)this).GetAstronomyAsync<AstronomyResponseEntity>(query, cancellationToken);
        }

        /// <summary>
        /// Gets the current astronomy information.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        public virtual Task<TAstronomyResponseEntity> GetAstronomyAsync<TAstronomyResponseEntity>(RequestEntity query, CancellationToken cancellationToken = default)
            where TAstronomyResponseEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TAstronomyResponseEntity>(HttpMethod.Get, "astronomy.json", null, cancellationToken, query.LanguageQueryParameter, query.QueryQueryParameter);
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
