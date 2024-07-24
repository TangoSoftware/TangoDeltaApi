using TangoDeltaApi.CommonServices.contabilidad.asientos.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.contabilidad.asientos;

public class AsientosServices(ITangoConfig config)
    : BaseServices<AsientosQueryRecord, AsientosData>(config), IAsientosServices
{
    protected override string ProcessId => "1664";
}
