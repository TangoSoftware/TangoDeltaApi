using TangoDeltaApi.CommonServices.stock.Articulo.Model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.stock.Articulo;


public class ArticuloServices(ITangoConfig config)
    : BaseServices<ArticuloQueryRecord, ArticuloData>(config), IArticuloServices
{
    protected override string ProcessId => "87";
}
