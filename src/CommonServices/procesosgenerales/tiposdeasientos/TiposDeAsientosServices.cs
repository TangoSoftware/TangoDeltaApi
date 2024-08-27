using TangoDeltaApi.CommonServices.procesosgenerales.tipodeasientos.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.tipodeasientos;

public class TiposDeAsientosServices(ITangoConfig config)
    : BaseServices<TiposDeAsientosQueryRecord, TiposDeAsientosData>(config), ITiposDeAsientosServices
{
    protected override string ProcessId => "1622";
}
