using TangoDeltaApi.CommonServices.condicionVentas.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.condicionVentas;

public class CondicionVentaServices(ITangoConfig config)
    : BaseServices<CondicionVentaQueryRecord, CondicionVentaData>(config), ICondicionVentaServices
{
    protected override string ProcessId => "2497";
}
