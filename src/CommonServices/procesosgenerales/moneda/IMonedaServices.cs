using TangoDeltaApi.CommonServices.procesosgenerales.moneda.model;
using TangoDeltaApi.Core.Service;
using TangoDeltaApiCore.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.moneda;

public interface IMonedaServices: IBaseServices<MonedaQueryRecord, MonedaData>
    , IHasGetByCode<string, MonedaQueryRecord>
{
}
