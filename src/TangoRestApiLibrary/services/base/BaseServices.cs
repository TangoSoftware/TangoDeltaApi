using System.Net.Http.Headers;
using System.Text;
using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiLibrary.services.DTO;

namespace TangoRestApiClient.services.baseServices;

public abstract class BaseServices<Q, D, QR>(ITangoConfig config)
    where QR : BaseQueryRecord
{
    protected readonly ITangoConfig _config = config;

    protected abstract string ProcessId { get; }

    #region private members
    private async Task<string> ServiceGetData(){
        var builder = new UriBuilder(_config.TangoUrl)
        {
            Path = "api/Get",
            Query = $"process={ProcessId}&pageSize={100}&pageIndex={0}&view="
        };

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

    private async Task<string> ServiceGetDataFilter(string filter){
        var builder = new UriBuilder(_config.TangoUrl)
        {
            Path = "api/GetByFilter",
            Query = $"process={ProcessId}&view=&filtroSql=WHERE%20{System.Net.WebUtility.UrlEncode(filter)}"
        };

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
        var builder = new UriBuilder(_config.TangoUrl)
        {
            Path = "api/Create",
            Query = $"process={ProcessId}"
        };
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
    #endregion

    /// <summary>
    /// Ejecuta ApiGetProcess
    /// mejorar summary
    /// </summary>
    /// <returns></returns>
    public Q GetData()
    {
        var dataJson = ServiceGetData();
        Q data = Newtonsoft.Json.JsonConvert.DeserializeObject<Q>(dataJson.Result);
        return data;
    }

    /// <summary>
    /// escribir summary bien
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public D GetDataById(int id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// escribir summary bien
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public int GetIdByFilter(string filter)
    {
        var dataJson = ServiceGetDataFilter(filter);
        BaseResultData<QR> data = Newtonsoft.Json.JsonConvert.DeserializeObject<BaseResultData<QR>>(dataJson.Result);
        if (data.List.Count() > 0)
        {
            return data.List[0].GetId();
        }
        return 0;
    }

    /// <summary>
    /// completame porfa
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public TransactionResultModel Insert(D data)
    {
        string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        string resultJson = ServicePostData(jsonData).Result;
        TransactionResultModel result = Newtonsoft.Json.JsonConvert.DeserializeObject<TransactionResultModel>(resultJson);
        return result;
    }

    /// <summary>
    /// completame porfa
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public TransactionResultModel Edit(D data)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// completame porfa
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public TransactionResultModel Delete(int id)
    {
        throw new NotImplementedException();
    }
}
