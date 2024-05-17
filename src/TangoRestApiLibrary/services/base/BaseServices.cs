using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.baseServices;

/// <summary>
/// 
/// </summary>
/// <typeparam name="QR">QueryRecord</typeparam>
/// /// <typeparam name="D">Data</typeparam>
/// <param name="config"></param>
public abstract class BaseServices<QR, D>(ITangoConfig config)
    : IBaseServices<QR, D>
    where QR : BaseQueryRecord
    where D : BaseData
{
    protected readonly ITangoConfig _config = config;

    protected abstract string ProcessId { get; }

    #region private

    private async Task<string> ApiDeleteTask(int id)
    {
        var builder = new UriBuilder(_config.TangoUrl);
        builder.Path = "api/Delete";
        builder.Query = $"process={ProcessId}&id={id}";

        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("Company", _config.CompanyId);
        client.DefaultRequestHeaders.Add("ApiAuthorization", _config.ApiAuthorization);
        var response = await client.DeleteAsync(builder.Uri);
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

    private async Task<string> ApiGetTask()
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

    private async Task<string> ApiGetByFilterTask(string filter)
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

    private async Task<string> ApiCreateTask(string jsonData)
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

    private async Task<string> ApiUpdateTask(string jsonData)
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

    private async Task<string> ApiGetByIdTask(int idValue)
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

    private static void ThrowExceptionIfDataIsNull(object? data)
    {
        if (data == null)
        {
            throw new Exception("Error al deserializar (GetData)");
        }
    }

    public List<QR> GetData()
    {
        string apiGetResponse = ApiGetTask().Result;
        try
        {
            // TODO: mejorar esto
            List<QR> data = JToken.Parse(apiGetResponse).SelectToken("resultData.list").ToObject<List<QR>>();
            ThrowExceptionIfDataIsNull(data);
            return data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al deserializar el resultado de la transacci�n: {ex.Message}");
            throw new Exception("Error al deserializar (GetData): " + ex.Message);
        }
    }

    public D GetDataById(int id)
    {
        var dataJson = ApiGetByIdTask(id).Result;
        //JToken.Parse(dataJson.Result).Value<D>();
        D? data = JToken.Parse(dataJson).SelectToken("value").ToObject<D>();
        ThrowExceptionIfDataIsNull(data);
        return data;
    }

    public int GetIdByFilter(string filter)
    {
        var response = ApiGetByFilterTask(filter).Result;

        List<QR> data = JToken.Parse(response).SelectToken("list").ToObject<List<QR>>();
        ThrowExceptionIfDataIsNull(data);
        return data.Single().GetId();
    }

    public int Insert(D data)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        string resultJson = ApiCreateTask(jsonData).Result;
        try
        {
            TransactionResultModel result = JsonConvert.DeserializeObject<TransactionResultModel>(resultJson);
            if (result.Succeeded) {
                return result.SavedId;
            } else
            {
                throw new TransactionException(result.Message, result.ExceptionInfo);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al deserializar el resultado de la transacci�n: {ex.Message}");
            throw ex;
        }
    }

    public void Edit(D data)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        string resultJson = ApiUpdateTask(jsonData).Result;
        if (resultJson != null)
        {
            try
            {
                TransactionResultModel? result = JsonConvert.DeserializeObject<TransactionResultModel>(resultJson);
                ThrowExceptionIfDataIsNull(result);
                if (!result.Succeeded)
                {
                    throw new TransactionException(result.Message, result.ExceptionInfo);
                }
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

    public void Delete(int id)
    {
        string resultJson = ApiDeleteTask(id).Result;
        if (resultJson != null)
        {
            try
            {
                TransactionResultModel? result = JsonConvert.DeserializeObject<TransactionResultModel>(resultJson);
                ThrowExceptionIfDataIsNull(result);
                if (!result.Succeeded)
                {
                    throw new TransactionException(result.Message, result.ExceptionInfo);
                }
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
}
