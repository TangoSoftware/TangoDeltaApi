using TangoDeltaApi.CommonServices.ventas.condicionVentas.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.ventas.condicionVentas;

public class CondicionVentaServices(ITangoConfig config)
    : BaseServices<CondicionVentaQueryRecord, CondicionVentaData>(config), ICondicionVentaServices
{
    protected override string ProcessId => "2497";

    public CondicionVentaQueryRecord GetByCode(int code)
    {
        return GetByFilter($"GVA01.COND_VTA = {code}").Single();
    }

    public int GetIdByCode(int code)
    {
        return GetByCode(code).IdGva01;
    }
}
