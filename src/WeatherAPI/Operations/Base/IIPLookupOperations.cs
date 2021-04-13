using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Entities;

namespace WeatherAPI.Operations.Base
{
    public interface IIPLookupOperations : IOperations
    {
        #region Methods
        /// <summary>
        /// Looks up location information about an IP address. Supports IPv4 and IPv6.
        /// </summary>
        /// <param name="ipAddress">The IP address to look up.</param>
        Task<IPLookupEntity> LookIPAddressAsync(string ipAddress, CancellationToken cancellationToken = default);

        /// <summary>
        /// Looks up location information about an IP address. Supports IPv4 and IPv6.
        /// </summary>
        /// <param name="ipAddress">The IP address to look up.</param>
        Task<TIPLookupEntity> LookIPAddressAsync<TIPLookupEntity>(string ipAddress, CancellationToken cancellationToken = default)
            where TIPLookupEntity : class;
        #endregion
    }
}
