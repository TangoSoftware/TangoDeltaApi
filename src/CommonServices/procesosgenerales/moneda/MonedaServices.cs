using TangoDeltaApi.CommonServices.procesosgenerales.moneda.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.moneda;

public class MonedaServices(ITangoConfig config)
    : BaseServices<MonedaQueryRecord, MonedaData>(config), IMonedaServices
{
    protected override string ProcessId => "1660";
}
