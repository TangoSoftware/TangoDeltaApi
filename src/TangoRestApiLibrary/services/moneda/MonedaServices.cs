using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.Moneda.model;

namespace TangoRestApiClient.services.Moneda;

public class MonedaServices(ITangoConfig config)
    : BaseServices<MonedaQueryRecord, MonedaData>(config), IMonedaServices
{
    protected override string ProcessId => "1660";
}
