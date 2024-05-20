using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    private UriBuilder GetNewUriBuilder(string actionPath, string queryParams = "")
    {
        var builder = new UriBuilder(_config.TangoUrl)
        {
            Path = $"api/{actionPath}",
            Query = $"process={ProcessId}{queryParams}"
        };
        return builder;
    }

    /// <summary>
    /// DeleteAsync api/Delete
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    private async Task<string> ApiDeleteAsync(int id)
    {
        var builder = GetNewUriBuilder("Delete", $"&id={id}");

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

    /// <summary>
    /// GetAsync api/Get
    /// </summary>
    /// <param name="pageSize"></param>
    /// <param name="pageIndex"></param>
    /// <returns></returns>
    private async Task<string> ApiGetAsync(int pageSize, int pageIndex)
    {
        var builder = GetNewUriBuilder("Get", $"&pageSize={pageSize}&pageIndex={pageIndex}&view=");

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

    /// <summary>
    /// GetAsync api/GetByFilter
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    private async Task<string> ApiGetByFilterAsync(string filter)
    {
        // revisar el where
        var builder = GetNewUriBuilder("GetByFilter", $"&view=&filtroSql=WHERE%20{System.Net.WebUtility.UrlEncode(filter)}");

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

    /// <summary>
    /// PostAsync api/Create
    /// </summary>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    private async Task<string> ApiCreateAsync(string jsonData)
    {
        var builder = GetNewUriBuilder("Create");

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

    /// <summary>
    /// PutAsync api/Update
    /// </summary>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    private async Task<string> ApiUpdateAsync(string jsonData)
    {
        var builder = GetNewUriBuilder("Update");

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

    /// <summary>
    /// GetAsync api/GetById
    /// </summary>
    /// <param name="idValue"></param>
    /// <returns></returns>
    private async Task<string> ApiGetByIdAsync(int idValue)
    {
        var builder = GetNewUriBuilder("GetById", $"&view=&id={idValue}");

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

    public List<QR> Get(int pageSize, int pageIndex)
    {
        string apiGetResponse = ApiGetAsync(pageSize, pageIndex).Result;
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

    public D GetById(int id)
    {
        var dataJson = ApiGetByIdAsync(id).Result;
        //JToken.Parse(dataJson.Result).Value<D>();
        D? data = JToken.Parse(dataJson).SelectToken("value").ToObject<D>();
        ThrowExceptionIfDataIsNull(data);
        return data;
    }

    public IQueryable<QR> GetByFilter(string filter)
    {
        /// ver esto, de no enmascarar
        var response = ApiGetByFilterAsync(filter).Result;

        List<QR> data = JToken.Parse(response).SelectToken("list").ToObject<List<QR>>();
        ThrowExceptionIfDataIsNull(data);
        return data.AsQueryable();
    }

    public int Create(D data)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        string resultJson = ApiCreateAsync(jsonData).Result;
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

    public void Update(D data)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        string resultJson = ApiUpdateAsync(jsonData).Result;
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
        string resultJson = ApiDeleteAsync(id).Result;
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
