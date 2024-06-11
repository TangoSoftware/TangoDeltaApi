using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.Articulo.model;

namespace TangoRestApiClient.services.Articulo;

public class ArticuloServices(ITangoConfig config)
    : BaseServices<ArticuloQueryRecord, ArticuloData>(config), IArticuloServices
{
    protected override string ProcessId => "87";
}
