using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.transporte.model;

namespace TangoRestApiClient.services.transporte;

public class TransporteServices(ITangoConfig config)
    : BaseServices<TransporteQuery, TransporteDataset, TransporteQueryRecord>(config), ITransporteServices
{
    protected override string ProcessId => "960";
}
