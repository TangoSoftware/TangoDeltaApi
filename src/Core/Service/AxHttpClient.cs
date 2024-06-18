using System.Net.Http.Headers;

namespace TangoDeltaApi.Core.Service;

public interface IAxHttpClient
{
    public HttpRequestHeaders DefaultRequestHeaders { get; }
    public Task<HttpResponseMessage> DeleteAsync(Uri? requestUri);
    public Task<HttpResponseMessage> GetAsync(Uri? requestUri);
    public Task<HttpResponseMessage> PostAsync(Uri? requestUri, HttpContent? content);
    public Task<HttpResponseMessage> PutAsync(Uri? requestUri, HttpContent? content);
}

public class AxHttpClient : HttpClient, IAxHttpClient
{
}
