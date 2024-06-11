using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.Moneda.model;

namespace TangoRestApiClient.services.Moneda;

public interface IMonedaServices: IBaseServices<MonedaQueryRecord, MonedaData>
{
}
