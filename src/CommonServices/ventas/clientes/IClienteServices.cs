using TangoDeltaApi.CommonServices.ventas.cliente.model;
using TangoDeltaApi.Core.Service;
using TangoDeltaApiCore.Service;

namespace TangoDeltaApi.CommonServices.ventas.cliente;

public interface IClienteServices: IBaseServices<ClienteQueryRecord, ClienteData>
    , IHasGetByCode<string, ClienteQueryRecord>
{
}
