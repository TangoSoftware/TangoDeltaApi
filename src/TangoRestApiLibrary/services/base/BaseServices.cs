using System.Net.Http.Headers;
using System.Text;
using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.baseServices;

/// <summary>
/// 
/// </summary>
/// <typeparam name="Q">Query</typeparam>
/// <typeparam name="D">Dataset</typeparam>
/// <typeparam name="QR">QueryRecord</typeparam>
/// <param name="config"></param>
public abstract class BaseServices<Q, D, QR>(ITangoConfig config)
    : IBaseServices<Q, D>
    where Q : new()
    where QR : BaseQueryRecord
{
    protected readonly ITangoConfig _config = config;

    protected abstract string ProcessId { get; }

    #region private
    private async Task<string> ServiceGetData()
    {
        var builder = new UriBuilder(_config.TangoUrl);
        builder.Path = "api/Get";
        builder.Query = $"process={ProcessId}&pageSize={100}&pageIndex={0}&view=";

        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("Company", _config.CompanyId);
        client.DefaultRequestHeaders.Add("ApiAuthorization", _config.ApiAuthorization);
        var response = await client.GetAsync(builder.Uri);
        try
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            return "No data found";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "An error ocurred";
        }
    }

    private async Task<string> ServiceGetDataFilter(string filter)
    {
        var builder = new UriBuilder(_config.TangoUrl);
        builder.Path = "api/GetByFilter";
        builder.Query = $"process={ProcessId}&view=&filtroSql=WHERE%20{System.Net.WebUtility.UrlEncode(filter)}";

        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("Company", _config.CompanyId);
        client.DefaultRequestHeaders.Add("ApiAuthorization", _config.ApiAuthorization);
        var response = await client.GetAsync(builder.Uri);
        try
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            return "No data found";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "An error ocurred";
        }
    }

    private async Task<string> ServicePostData(string jsonData)
    {
        var builder = new UriBuilder(_config.TangoUrl);
        builder.Path = "api/Create";
        builder.Query = $"process={ProcessId}";
        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("Company", _config.CompanyId);
        client.DefaultRequestHeaders.Add("ApiAuthorization", _config.ApiAuthorization);

        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(builder.Uri, content);

        try
        {
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            return "No data found";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "An error occurred";
        }
    }

    private async Task<string> ServicePutData(string jsonData)
    {
        var builder = new UriBuilder(_config.TangoUrl);
        builder.Path = "api/Update";
        builder.Query = $"process={ProcessId}";
        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("Company", _config.CompanyId);
        client.DefaultRequestHeaders.Add("ApiAuthorization", _config.ApiAuthorization);

        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var response = await client.PutAsync(builder.Uri, content);

        try
        {
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            return "No data found";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "An error occurred";
        }
    }

    private async Task<string> ServiceGetDataById(int idValue)
    {
        var builder = new UriBuilder(_config.TangoUrl);
        builder.Path = "api/GetById";
        builder.Query = $"process={ProcessId}&view=&id={idValue}";

        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("Company", _config.CompanyId);
        client.DefaultRequestHeaders.Add("ApiAuthorization", _config.ApiAuthorization);
        var response = await client.GetAsync(builder.Uri);
        try
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            return "No data found";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "An error ocurred";
        }
    }

    #endregion

    public Q GetData()
    {
        var dataJson = ServiceGetData();
        if ((dataJson != null) && (dataJson.Result != null))
        {
            try
            {
                Q? data = Newtonsoft.Json.JsonConvert.DeserializeObject<Q>(dataJson.Result);
                ThrowExceptionIfDataIsNull(data);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar el resultado de la transacci�n: {ex.Message}");
                throw new Exception("Error al deserializar (GetData): " + ex.Message);
            }
        }
        else
        {

            Console.WriteLine($"dataJson.Result is null GetData");
            throw new Exception("dataJson.Result is null GetData");
        }
    }

    private static void ThrowExceptionIfDataIsNull(object? data)
    {
        if (data == null)
        {
            throw new Exception("Error al deserializar (GetData)");
        }
    }

    public D GetDataById(int id)
    {
        var dataJson = ServiceGetDataById(id);
        if (dataJson.Result != null)
        {
            try
            {
                D? data = Newtonsoft.Json.JsonConvert.DeserializeObject<D>(dataJson.Result);
                ThrowExceptionIfDataIsNull(data);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar el resultado de la transacci�n: {ex.Message}");
                throw new Exception("Error al deserializar (GetDataById): " + ex.Message);
            }
        }
        else
        {

            Console.WriteLine($"dataJson.Result is null");
            throw new Exception("dataJson.Result is null");
        }
    }

    public int GetIdByFilter(string filter)
    {
        var dataJson = ServiceGetDataFilter(filter);
        if (dataJson.Result != null)
        {
            BaseResultData<QR> data = Newtonsoft.Json.JsonConvert.DeserializeObject<BaseResultData<QR>>(dataJson.Result);
            if ((data.List != null) && (data.List.Count()) > 0)
            {
                return data.List[0].GetId();
            }
        }
        return 0;
    }

    public TransactionResultModel Insert(D data)
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
                Console.WriteLine($"Error al deserializar el resultado de la transacci�n: {ex.Message}");
                return new TransactionResultModel();
            }
        }
        else
        {
            // Devuelve un nuevo TransactionResultModel en lugar de lanzar una excepci�n
            return new TransactionResultModel();
        }
    }

    public TransactionResultModel Edit(D data)
    {
        string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        string resultJson = ServicePutData(jsonData).Result;
        if (resultJson != null)
        {
            try
            {
                TransactionResultModel? result = Newtonsoft.Json.JsonConvert.DeserializeObject<TransactionResultModel>(resultJson);
                ThrowExceptionIfDataIsNull(result);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar el resultado de la transacci�n: {ex.Message}");
                throw new Exception("Error al deserializar (Edit): " + ex.Message);
            }
        }
        else
        {
            // Devuelve un nuevo TransactionResultModel en lugar de lanzar una excepci�n
            throw new Exception("resultJson is null");
        }
    }

    public TransactionResultModel Delete(int id)
    {
        throw new NotImplementedException();
    }
}
