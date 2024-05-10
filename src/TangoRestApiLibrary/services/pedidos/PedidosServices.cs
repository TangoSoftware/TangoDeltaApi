using TangoRestApiClient.services.pedidos.model;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using System.Collections.Generic;

namespace TangoRestApiClient.services.pedidos;

public class PedidosServices : BaseServices, IPedidosServices
{

    public PedidosServices(ITangoConfig config) : base(config)
    {
        ProcessId = "19845";
    }

    public PedidoQuery GetData()
    {
        var dataJson = ServiceGetData();
        PedidoQuery data = Newtonsoft.Json.JsonConvert.DeserializeObject<PedidoQuery>(dataJson.Result);
        return data;
    }

    public PedidoDataset GetDataById(int id)
    {
        throw new System.NotImplementedException();
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
        throw new System.NotImplementedException();
    }

    public TransactionResultModel Delete(int id)
    {
        throw new System.NotImplementedException();
    }
}


