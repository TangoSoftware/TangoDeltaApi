using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.condicionVentas.model;

namespace TangoRestApiClient.services.condicionVentas;

public class CondicionVentaServices(ITangoConfig config)
    : BaseServices<CondicionVentaQuery, CondicionVentaDataset, CondicionVentaQueryRecord>(config), ICondicionVentaServices
{
    protected override string ProcessId => "2497";
}
