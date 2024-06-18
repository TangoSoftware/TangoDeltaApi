using TangoDeltaApi.CommonServices.transporte.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.transporte;

public class TransporteServices(ITangoConfig config)
    : BaseServices<TransporteQueryRecord, TransporteData>(config), ITransporteServices
{
    protected override string ProcessId => "960";
}
