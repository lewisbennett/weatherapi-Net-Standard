using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.NET.Base;
using WeatherAPI.NET.Entities;
using WeatherAPI.NET.Operations;

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
            if (astronomyResponseEntity is CustomAstronomyResponseEntity customAstronomyEntity)
                customAstronomyEntity.DoSomethingCustom();

            return astronomyResponseEntity;
        }

        public CustomAstronomyOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
    }
}
