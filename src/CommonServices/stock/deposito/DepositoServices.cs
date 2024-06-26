using TangoDeltaApi.CommonServices.stock.deposito.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.stock.deposito;

public class DepositoServices(ITangoConfig config)
    : BaseServices<DepositoQueryRecord, DepositoData>(config), IDepositoServices
{
    protected override string ProcessId => "2941";

    public DepositoQueryRecord GetByCode(string code)
    {
        return GetByFilter($"STA22.COD_STA22 = '{code}'").Single();
    }

    public int GetIdByCode(string code)
    {
        return GetByCode(code).IdSta22;
    }
}
