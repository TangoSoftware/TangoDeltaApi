using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.pedidos.model;

namespace TangoRestApiClient.services.pedidos;

public class PedidosServices(ITangoConfig config) : BaseServices(config), IPedidosServices
{
    protected override string ProcessId => "19845";

    public PedidoQuery GetData()
    {
        var dataJson = ServiceGetData();
        PedidoQuery data = Newtonsoft.Json.JsonConvert.DeserializeObject<PedidoQuery>(dataJson.Result);
        return data;
    }

    public PedidoDataset GetDataById(int id)
    {
        throw new NotImplementedException();
    }

    
    public TransactionResultModel Insert(PedidoDataset data)
    {
        string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        string resultJson = ServicePostData(jsonData).Result;
        TransactionResultModel result = Newtonsoft.Json.JsonConvert.DeserializeObject<TransactionResultModel>(resultJson);
        return result;
    }
    public TransactionResultModel Edit(PedidoDataset data)
    {
        throw new NotImplementedException();
    }

    public TransactionResultModel Delete(int id)
    {
        throw new NotImplementedException();
    }
}
