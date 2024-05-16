using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.listadepreciosventas.model;

namespace TangoRestApiClient.services.listadepreciosventas;

public class ListaDePreciosVentasServices(ITangoConfig config)
    : BaseServices<ListaDePreciosVentasQuery, ListaDePreciosVentasData, ListaDePreciosVentasDataset, ListaDePreciosVentasQueryRecord, ResultData>(config), IListaDePreciosVentasServices
{
    protected override string ProcessId => "984";
}
