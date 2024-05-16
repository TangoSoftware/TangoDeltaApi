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
    // Simplificar el modelo, debería tener sólo una clase para la query, y una clase para el model
    // el resto de lios tiene que resolverse dentro
{
    protected readonly ITangoConfig _config = config;

    protected abstract string ProcessId { get; }

    #region private
    private UriBuilder GetNewUriBuilder(string Path, string queryParams)
    {
        return new UriBuilder(_config.TangoUrl)
        {
            Path = Path,
            Query = $"process={ProcessId}{queryParams}"
        };
    }

    private HttpClient GetNewHttpClient()
    {
        HttpClient client = new();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("Company", _config.CompanyId);
        client.DefaultRequestHeaders.Add("ApiAuthorization", _config.ApiAuthorization);
        return client;
    }

    private async Task<string> ServiceGetData(int pageSize, int pageIndex){
        var builder = GetNewUriBuilder("api/Get", $"&pageSize={pageSize}&pageIndex={pageIndex}&view=");
        var client = GetNewHttpClient();
        var response = await client.GetAsync(builder.Uri);
        try
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            return "No data found"; // tiene que tirar error
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // puede no haber consola.
            return "An error ocurred"; // tiene que tirar error
        }
    }

    private async Task<string> ServiceGetDataFilter(string filter){
        var builder = GetNewUriBuilder("api/GetByFilter", $"&view=&filtroSql=WHERE%20{System.Net.WebUtility.UrlEncode(filter)}");
        var client = GetNewHttpClient();
        var response = await client.GetAsync(builder.Uri);
        try
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            return "No data found"; // tiene que tirar error
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // puede no haber consola
            return "An error ocurred"; // tiene que tirar error
        }
    }

    private async Task<string> ServicePostData(string jsonData)
    {
        var builder = GetNewUriBuilder("api/Create", "");
        var client = GetNewHttpClient();
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(builder.Uri, content);
        
        try
        {
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            return "No data found"; // tiene que tirar error
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // puede no haber consola
            return "An error occurred"; // tiene que tirar error
        }
    }
    #endregion

    /// <summary>
    /// Llenar el summary con lo que hace
    /// En este caso hace un GET
    /// </summary>
    /// <returns></returns>
    public Q GetData(int pageSize = 100, int pageIndex = 0)
    {
        var dataJson = ServiceGetData(pageSize, pageIndex);
        if (dataJson.Result != null)
        {
            try
            {
                Q data = Newtonsoft.Json.JsonConvert.DeserializeObject<Q>(dataJson?.Result);
                return data; // fix el null tiene que tirar error
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar el resultado de la transacción: {ex.Message}"); // puede no haber consola
                return new Q(); // tirar error
            }
        }
        else
        {

            Console.WriteLine($"dataJson.Result is null"); // puede no haber consola
            return new Q();  // tirar error
        }
    }

    public D GetDataById(int id)
    {
        throw new NotImplementedException();
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
            } // tirar error con los nulls
        }
        return 0; // el cero no vale, tirar error
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
                return result; // ver si toca tirar error
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar el resultado de la transacción: {ex.Message}"); // no consola
                return new TransactionResultModel(); // tirar error
            }
        }
        else
        {
            // Devuelve un nuevo TransactionResultModel en lugar de lanzar una excepción
            return new TransactionResultModel();
            // el insert tiene que devolver un id
        }
    }

    public TransactionResultModel Edit(D data)
    {
        throw new NotImplementedException();
    }

    public TransactionResultModel Delete(int id)
    {
        throw new NotImplementedException();
    }
}
