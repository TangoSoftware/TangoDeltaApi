using TangoDeltaApi.CommonServices.Articulo.Model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.Articulo;


public class ArticuloServices(ITangoConfig config)
    : BaseServices<ArticuloQueryRecord, ArticuloData>(config), IArticuloServices
{
    protected override string ProcessId => "87";
}
