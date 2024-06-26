using TangoDeltaApi.CommonServices.ventas.vendedor.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.ventas.vendedor;

public class VendedorServices(ITangoConfig config)
    : BaseServices<VendedorQueryRecord, VendedorData>(config), IVendedorServices
{
    protected override string ProcessId => "952";

    public VendedorQueryRecord GetByCode(string code)
    {
        return GetByFilter($"GVA23.COD_VENDED = '{code}'").Single();
    }

    public int GetIdByCode(string code)
    {
        return GetByCode(code).IdGva23;
    }
}
