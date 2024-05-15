using TangoRestApiClient.Common.Model;
using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.transporte.model;
using TangoRestApiClient.services.baseServices;

namespace TangoRestApiClient.services.transporte;

public class TransporteServices : BaseServices, ITransporteServices
{
    public TransporteServices(ITangoConfig config) : base(config)
    {
        ProcessId = "960";
    }

    public TransporteQuery GetData()
    {
        var dataJson = ServiceGetData();
        if (dataJson.Result != null)
        {
            try
            {
                TransporteQuery data = Newtonsoft.Json.JsonConvert.DeserializeObject<TransporteQuery>(dataJson.Result);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar el resultado de la transacción: {ex.Message}");
                return new TransporteQuery();
            }
        }
        else
        {

            Console.WriteLine($"dataJson.Result is null");
            return new TransporteQuery();
        }
    }

    public TransporteDataset GetDataById(int id)
    {
        throw new System.NotImplementedException();
    }

    public TransactionResultModel Insert(TransporteDataset data)
    {
        string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        string resultJson = ServicePostData(jsonData).Result;
        if (resultJson != null)
        {
            try 
            {
                TransactionResultModel result = Newtonsoft.Json.JsonConvert.DeserializeObject<TransactionResultModel>(resultJson);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar el resultado de la transacción: {ex.Message}");
                return new TransactionResultModel();
            }
        }
        else
        {
            // Devuelve un nuevo TransactionResultModel en lugar de lanzar una excepción
            return new TransactionResultModel();
        }
    }

    public TransactionResultModel Edit(TransporteDataset data)
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
        if (dataJson.Result != null)
        {
            ResultData data = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultData>(dataJson.Result);
            if ((data.List != null) && (data.List.Count()) > 0)
            {
                return data.List[0].IdGva24;
            }
        }
        return 0;
    }
}
