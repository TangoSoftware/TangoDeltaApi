using TangoDeltaApi.CommonServices.stock.deposito.model;
using TangoDeltaApi.Core.Service;
using TangoDeltaApiCore.Service;

namespace TangoDeltaApi.CommonServices.stock.deposito;

public interface IDepositoServices : IBaseServices<DepositoQueryRecord, DepositoData>
    , IHasGetByCode<string, DepositoQueryRecord>
{
}
