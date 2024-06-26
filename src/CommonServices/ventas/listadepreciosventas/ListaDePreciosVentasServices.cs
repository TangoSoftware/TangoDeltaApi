using TangoDeltaApi.CommonServices.ventas.listadepreciosventas.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.ventas.listadepreciosventas;

public class ListaDePreciosVentasServices(ITangoConfig config)
    : BaseServices<ListaDePreciosVentasQueryRecord, ListaDePreciosVentasData>(config), IListaDePreciosVentasServices
{
    protected override string ProcessId => "984";

    public ListaDePreciosVentasQueryRecord GetByCode(int code)
    {
        return GetByFilter($"GVA10.NRO_DE_LIS = {code}").Single();
    }

    public int GetIdByCode(int code)
    {
        return GetByCode(code).IdGva10;
    }
}
