using TangoDeltaApi.CommonServices.procesosgenerales.tiposdeauxiliarescontables.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.tiposdeauxiliarescontables;

public class TiposDeAuxiliaresContablesServices(ITangoConfig config)
    : BaseServices<TiposDeAuxiliaresContablesQueryRecord, TiposDeAuxiliaresContablesData>(config), ITiposDeAuxiliaresContablesServices
{
    protected override string ProcessId => "1656";
}
