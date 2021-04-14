using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Base;
using WeatherAPI.Entities;
using WeatherAPI.Operations;

namespace Sample.Extending
{
    public class CustomAstronomyOperations : AstronomyOperations
    {
        /// <summary>
        /// Gets the current astronomy information.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public override async Task<TAstronomyResponseEntity> GetAstronomyAsync<TAstronomyResponseEntity>(RequestEntity request, CancellationToken cancellationToken = default)
        {
            var astronomyResponseEntity = await base.GetAstronomyAsync<TAstronomyResponseEntity>(request, cancellationToken);

            // Do something custom, if the entity allows it.
            if (astronomyResponseEntity is CustomAstronomyEntity customAstronomyEntity)
                customAstronomyEntity.DoSomethingCustom();

            return astronomyResponseEntity;
        }

        public CustomAstronomyOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
    }
}
