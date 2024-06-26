using TangoDeltaApi.CommonServices.procesosgenerales.moneda.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.moneda;

public class MonedaServices(ITangoConfig config)
    : BaseServices<MonedaQueryRecord, MonedaData>(config), IMonedaServices
{
    protected override string ProcessId => "1660";

    public MonedaQueryRecord GetByCode(string code)
    {
        return GetByFilter($"MONEDA.COD_MONEDA = '{code}'").Single();
    }

    public int GetIdByCode(string code)
    {
        return GetByCode(code).IdMoneda;
    }
}
