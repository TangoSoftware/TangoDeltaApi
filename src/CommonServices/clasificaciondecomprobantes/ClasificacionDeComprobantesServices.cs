using TangoDeltaApi.CommonServices.ClasificacionDeComprobantes.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.ClasificacionDeComprobantes;

public class ClasificacionDeComprobantesServices(ITangoConfig config)
    : BaseServices<ClasificacionDeComprobantesQueryRecord, ClasificacionDeComprobantesData>(config), IClasificacionDeComprobantesServices
{
    protected override string ProcessId => "326";
}
