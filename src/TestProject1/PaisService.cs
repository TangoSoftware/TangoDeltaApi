using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiLibrary.servicesBase;

namespace TestProject1
{
    internal class PaisService(ITangoConfig config, IAxHttpClient? axHttpClient = null)
        : BaseServices<PaisQuery, PaisData>(config, axHttpClient)
    {
        protected override string ProcessId => "1097";
    }
}
