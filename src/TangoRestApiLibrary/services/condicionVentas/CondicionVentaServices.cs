using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.condicionVentas.model;

namespace TangoRestApiClient.services.condicionVentas;

public class CondicionVentaServices(ITangoConfig config) : BaseServices(config), ICondicionVentaServices
{
    protected override string ProcessId => "2497";

    public CondicionVentaQuery GetData()
    {
        var dataJson = ServiceGetData();
        CondicionVentaQuery data = Newtonsoft.Json.JsonConvert.DeserializeObject<CondicionVentaQuery>(dataJson.Result);
        return data;
    }

    public CondicionVentaDataset GetDataById(int id)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public TransactionResultModel Delete(int id)
    {
        throw new NotImplementedException();
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
