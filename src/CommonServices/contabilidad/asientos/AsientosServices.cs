using TangoDeltaApi.CommonServices.contabilidad.asientos.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.contabilidad.asientos;

public class AsientoAnaliticoServices(ITangoConfig config)
    : BaseServices<AsientoAnaliticoQueryRecord, AsientoAnaliticoData>(config), IAsientoAnaliticoServices
{
    protected override string ProcessId => "1664";
}
