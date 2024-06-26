using TangoDeltaApi.CommonServices.ventas.cliente.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.ventas.cliente;

public class ClienteServices(ITangoConfig config)
    : BaseServices<ClienteQueryRecord, ClienteData>(config), IClienteServices
{
    protected override string ProcessId => "2117";

    public ClienteQueryRecord GetByCode(string code)
    {
        return GetByFilter($"AXV_CLIENTE.COD_GVA14 = '{code}'").Single();
    }

    public int GetIdByCode(string code)
    {
        return GetByCode(code).IdGva14;
    }
}
