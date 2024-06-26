using TangoDeltaApi.CommonServices.stock.Articulo.Model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.stock.Articulo;


public class ArticuloServices(ITangoConfig config)
    : BaseServices<ArticuloQueryRecord, ArticuloData>(config), IArticuloServices
{
    protected override string ProcessId => "87";

    public ArticuloQueryRecord GetByCode(string code)
    {
        return GetByFilter($"AXV_ARTICULO.COD_STA11 = '{code}'").Single();
    }

    public int GetIdByCode(string code)
    {
        return GetByCode(code).IdSta11;
    }
}
