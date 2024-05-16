using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.vendedor.model;

namespace TangoRestApiClient.services.vendedor;

public class VendedorServices(ITangoConfig config)
    : BaseServices<VendedorQuery, VendedorData, VendedorDataset, VendedorQueryRecord, ResultData>(config), IVendedorServices
{
    protected override string ProcessId => "952";
}
