using TangoDeltaApi.CommonServices.ventas.condicionVentas.model;
using TangoDeltaApi.Core.Service;
using TangoDeltaApiCore.Service;

namespace TangoDeltaApi.CommonServices.ventas.condicionVentas;

public interface ICondicionVentaServices: IBaseServices<CondicionVentaQueryRecord, CondicionVentaData>
    , IHasGetByCode<int, CondicionVentaQueryRecord>
{
}
