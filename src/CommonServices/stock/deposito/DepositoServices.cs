using TangoDeltaApi.CommonServices.stock.deposito.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.stock.deposito;

public class DepositoServices(ITangoConfig config)
    : BaseServices<DepositoQueryRecord, DepositoData>(config), IDepositoServices
{
    protected override string ProcessId => "2941";
}
