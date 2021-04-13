using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Base;
using WeatherAPI.Entities;
using WeatherAPI.Operations.Base;

namespace WeatherAPI.Operations
{
    public class IPLookupOperations : BaseOperations, IIPLookupOperations
    {
        #region Public Methods
        /// <summary>
        /// Looks up location information about an IP address. Supports IPv4 and IPv6.
        /// </summary>
        /// <param name="ipAddress">The IP address to look up.</param>
        public virtual Task<IPLookupEntity> LookIPAddressAsync(string ipAddress, CancellationToken cancellationToken = default)
        {
            return ((IIPLookupOperations)this).LookIPAddressAsync<IPLookupEntity>(ipAddress, cancellationToken);
        }

        /// <summary>
        /// Looks up location information about an IP address. Supports IPv4 and IPv6.
        /// </summary>
        /// <param name="ipAddress">The IP address to look up.</param>
        public virtual Task<TIPLookupEntity> LookIPAddressAsync<TIPLookupEntity>(string ipAddress, CancellationToken cancellationToken = default)
            where TIPLookupEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TIPLookupEntity>(HttpMethod.Get, "ip.json", new[] { $"q={ipAddress}" }, null, cancellationToken);
        }
        #endregion

        #region Constructors
        public IPLookupOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
        #endregion
    }
}
