using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.Deposito.model;

namespace TangoRestApiClient.services.Deposito;

public class DepositoServices(ITangoConfig config)
    : BaseServices<DepositoQueryRecord, DepositoData>(config), IDepositoServices
{
    protected override string ProcessId => "2941";
}
