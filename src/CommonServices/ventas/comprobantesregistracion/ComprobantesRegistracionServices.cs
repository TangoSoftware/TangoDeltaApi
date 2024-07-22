using TangoDeltaApi.CommonServices.ventas.comprobantesregistracion.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.ventas.comprobantesregistracion;

public class ComprobantesRegistracionServices(ITangoConfig config)
    : BaseServices<ComprobantesRegistracionQueryRecord, ComprobantesRegistracionData>(config), IComprobantesResgistracionServices
{
    protected override string ProcessId => "20412";
}
