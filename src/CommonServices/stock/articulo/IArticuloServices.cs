using TangoDeltaApi.CommonServices.stock.Articulo.Model;
using TangoDeltaApi.CommonServices.stock.deposito.model;
using TangoDeltaApi.Core.Service;
using TangoDeltaApiCore.Service;

namespace TangoDeltaApi.CommonServices.stock.Articulo;

public interface IArticuloServices : IBaseServices<ArticuloQueryRecord, ArticuloData>
    , IHasGetByCode<string, ArticuloQueryRecord>
{
}
