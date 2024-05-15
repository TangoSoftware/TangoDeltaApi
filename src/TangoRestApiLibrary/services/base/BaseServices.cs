using System.Net.Http.Headers;
using System.Text;
using TangoRestApiClient.Common.Config;

namespace TangoRestApiClient.services.baseServices;

public abstract class BaseServices(ITangoConfig config)
{
    protected readonly ITangoConfig _config = config;

    protected abstract string ProcessId { get; }

    public async Task<string> ServiceGetData(){
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

   public async Task<string> ServiceGetDataFilter(string filter){
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

    public async Task<string> ServicePostData(string jsonData)
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
}
