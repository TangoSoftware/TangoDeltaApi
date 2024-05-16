using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.cliente.model;

namespace TangoRestApiClient.services.cliente;

public class ClienteServices(ITangoConfig config)
    : BaseServices<ClienteQueryRecord, ClienteData>(config), IClienteServices
{
    protected override string ProcessId => "2117";
}
