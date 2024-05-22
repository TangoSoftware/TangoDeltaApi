using System.Net.Http.Headers;
using TangoRestApiClient.Common.Config;

namespace TangoRestApiLibrary.servicesBase
{
    public interface IAxHttpClient
    {
        public Task<HttpResponseMessage> DeleteAsync(Uri? requestUri);
        public Task<HttpResponseMessage> GetAsync(Uri? requestUri);
        public Task<HttpResponseMessage> PostAsync(Uri? requestUri, HttpContent? content);
        public Task<HttpResponseMessage> PutAsync(Uri? requestUri, HttpContent? content);
    }

    public class AxHttpClient: HttpClient, IAxHttpClient
    {
        public AxHttpClient(ITangoConfig config) : base()
        {
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            DefaultRequestHeaders.Add("Company", config.CompanyId);
            DefaultRequestHeaders.Add("ApiAuthorization", config.ApiAuthorization);
        }
    }
}
