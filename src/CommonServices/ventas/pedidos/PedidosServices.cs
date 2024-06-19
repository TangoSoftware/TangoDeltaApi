using TangoDeltaApi.CommonServices.ventas.pedidos.Model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.ventas.pedidos;

public class PedidosServices(ITangoConfig config)
    : BaseServices<PedidoQueryRecord, PedidoData>(config), IPedidosServices
{
    protected override string ProcessId => "19845";
}
