using TangoDeltaApi.CommonServices.ventas.vendedor.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.ventas.vendedor;

public class VendedorServices(ITangoConfig config)
    : BaseServices<VendedorQueryRecord, VendedorData>(config), IVendedorServices
{
    protected override string ProcessId => "952";
}
