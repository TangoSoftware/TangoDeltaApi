using TangoDeltaApi.CommonServices.listadepreciosventas.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.listadepreciosventas;

public class ListaDePreciosVentasServices(ITangoConfig config)
    : BaseServices<ListaDePreciosVentasQueryRecord, ListaDePreciosVentasData>(config), IListaDePreciosVentasServices
{
    protected override string ProcessId => "984";
}
