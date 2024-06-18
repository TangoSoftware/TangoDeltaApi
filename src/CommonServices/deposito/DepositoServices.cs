using TangoDeltaApi.CommonServices.Deposito.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.Deposito;

public class DepositoServices(ITangoConfig config)
    : BaseServices<DepositoQueryRecord, DepositoData>(config), IDepositoServices
{
    protected override string ProcessId => "2941";
}
