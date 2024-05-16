using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.transporte.model;

namespace TangoRestApiClient.services.transporte;

public class TransporteServices(ITangoConfig config)
    : BaseServices<TransporteQueryRecord, TransporteData>(config), ITransporteServices
{
    protected override string ProcessId => "960";
}
