using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.pedidos.model;

namespace TangoRestApiClient.services.pedidos;

public class PedidosServices(ITangoConfig config)
    : BaseServices<PedidoQueryRecord, PedidoData>(config), IPedidosServices
{
    protected override string ProcessId => "19845";
}
