using TangoRestApiClient.Common.Model;
using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.condicionVentas.model;
using TangoRestApiClient.services.baseServices;

namespace TangoRestApiClient.services.condicionVentas;

public class CondicionVentaServices : BaseServices, ICondicionVentaServices
{
    public CondicionVentaServices(ITangoConfig config) : base(config)
    {
        ProcessId = "2497";
    }

    public CondicionVentaQuery GetData()
    {
        var dataJson = ServiceGetData();
        CondicionVentaQuery data = Newtonsoft.Json.JsonConvert.DeserializeObject<CondicionVentaQuery>(dataJson.Result);
        return data;
    }

    public CondicionVentaDataset GetDataById(int id)
    {
        throw new System.NotImplementedException();
    }

    public TransactionResultModel Insert(CondicionVentaDataset data)
    {
        string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        string resultJson = ServicePostData(jsonData).Result;
        TransactionResultModel result = Newtonsoft.Json.JsonConvert.DeserializeObject<TransactionResultModel>(resultJson);
        return result;
    }

    public TransactionResultModel Edit(CondicionVentaDataset data)
    {
        throw new System.NotImplementedException();
    }

    public TransactionResultModel Delete(int id)
    {
        throw new System.NotImplementedException();
    }

    public int GetIdByFilter(string filter)
    {
        var dataJson = ServiceGetDataFilter(filter);
        ResultData data = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultData>(dataJson.Result);
        if (data.List.Count() > 0)
        {
            return data.List[0].IdGva01;
        }
        return 0;
    }
}

