using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.ClasificacionDeComprobantes.model;

namespace TangoRestApiClient.services.ClasificacionDeComprobantes;

public class ClasificacionDeComprobantesServices(ITangoConfig config)
    : BaseServices<ClasificacionDeComprobantesQueryRecord, ClasificacionDeComprobantesData>(config), IClasificacionDeComprobantesServices
{
    protected override string ProcessId => "326";
}
