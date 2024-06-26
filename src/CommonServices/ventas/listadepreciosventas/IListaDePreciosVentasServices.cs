using TangoDeltaApi.CommonServices.ventas.listadepreciosventas.model;
using TangoDeltaApi.Core.Service;
using TangoDeltaApiCore.Service;

namespace TangoDeltaApi.CommonServices.ventas.listadepreciosventas;

public interface IListaDePreciosVentasServices : IBaseServices<ListaDePreciosVentasQueryRecord, ListaDePreciosVentasData>
    , IHasGetByCode<int, ListaDePreciosVentasQueryRecord>
{
}
