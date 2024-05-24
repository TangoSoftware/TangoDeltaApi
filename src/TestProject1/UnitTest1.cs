using Moq;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiLibrary.servicesBase;

namespace TestProject1
{
    public class UnitTest1
    {
        #region constantes para los tests
        readonly string tangoUrl = "http://localhost:17123";
        readonly string apiAuthorization = "C98BEF0B-F23F-4D0B-BBF3-49F4AF8F65DB";
        readonly string companyId = "7";
        readonly int processId = 1097;
        readonly int paisId = 456;
        readonly string nombrePais = "nombre del pais";
        readonly string codigoDeArea = "código de area";
        readonly string codigoDgi = "codigoDgi";
        #endregion

        private readonly Mock<IAxHttpClient> axHttpClientMock;
        private readonly ITangoConfig tangoConfig;

        #region Ctor
        public UnitTest1()
        {
            // config
            tangoConfig = new TangoConfig()
            {
                TangoUrl = tangoUrl,
                ApiAuthorization = apiAuthorization,
                CompanyId = companyId
            };

            axHttpClientMock = new();
            setupMock();
        }

        private void setupMock()
        {
            // mock del httpClient
            HttpRequestHeaders httpRequestHeaders = new HttpClient().DefaultRequestHeaders;
            axHttpClientMock.Setup(m => m.DefaultRequestHeaders).Returns(httpRequestHeaders);
        }
        #endregion

        #region testImplementations
        private static Task<HttpResponseMessage> GetHttpResponseMessage(int savedId)
        {
            TransactionResultModel transactionResultModel = new()
            {
                Succeeded = true,
                SavedId = savedId
            };
            var responseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(JsonConvert.SerializeObject(transactionResultModel), Encoding.UTF8, "application/json")
            };
            Task<HttpResponseMessage> task = Task.FromResult(responseMessage);
            return task;
        }

        private static Task<HttpResponseMessage> GetHttpResponseMessage()
        {
            TransactionResultModel transactionResultModel = new()
            {
                Succeeded = true,
            };
            var responseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(JsonConvert.SerializeObject(transactionResultModel), Encoding.UTF8, "application/json")
            };
            Task<HttpResponseMessage> task = Task.FromResult(responseMessage);
            return task;
        }

        private static void SetUpHttpMethodAsync(Mock<IAxHttpClient> axHttpClientMock,
            Expression<Func<IAxHttpClient, Task<HttpResponseMessage>>> expression,
            int responseId,
            string companyId, string apiAuthorization, string tangoUrl, string action, int processId, PaisData paisData)
        {
            axHttpClientMock
                .Setup(expression)
                .Returns(GetHttpResponseMessage(responseId)) // seteo del response message con el paisId esperado
                .Callback(async (Uri uri, HttpContent content) =>
                {
                    await CallbackPostPutAsserts(axHttpClientMock, companyId, apiAuthorization, tangoUrl, action, processId, GetHttpRequestMessage(uri, content), paisData);
                });
        }

        private static void SetUpPostAsync(Mock<IAxHttpClient> axHttpClientMock,
            int responseId,
            string companyId, string apiAuthorization, string tangoUrl, int processId, PaisData paisData)
        {
            SetUpHttpMethodAsync(axHttpClientMock,
                m => m.PostAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()),
                responseId,
                companyId, apiAuthorization, tangoUrl, "Create", processId, paisData);
        }

        private static void SetUpPutAsync(Mock<IAxHttpClient> axHttpClientMock,
            int responseId,
            string companyId, string apiAuthorization, string tangoUrl, int processId, PaisData paisData)
        {
            SetUpHttpMethodAsync(axHttpClientMock,
                m => m.PutAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()),
                responseId,
                companyId, apiAuthorization, tangoUrl, "Update", processId, paisData);
        }

        private static void SetUpDeleteAsync(Mock<IAxHttpClient> axHttpClientMock, string companyId, string apiAuthorization,
            string tangoUrl, int processId, int paisId)
        {
            axHttpClientMock
                .Setup(m => m.DeleteAsync(It.IsAny<Uri>()))
                .Returns(GetHttpResponseMessage())
                .Callback((Uri uri) =>
                {
                    AssertHeaders(axHttpClientMock, companyId, apiAuthorization);
                    Assert.Equal($"{tangoUrl}/api/Delete?process={processId}&id={paisId}", uri.AbsoluteUri); // URI es la url correcta según el config, action y process
                });
        }

        private static HttpRequestMessage GetHttpRequestMessage(Uri uri, HttpContent content)
        {
            return new HttpRequestMessage
            {
                RequestUri = uri,
                Content = content,
            };
        }

        private static async Task CallbackPostPutAsserts(Mock<IAxHttpClient> axHttpClientMock, string companyId, string apiAuthorization,
            string tangoUrl, string action, int processId, HttpRequestMessage requestMessage,
            PaisData paisData)
        {
            AssertHeaders(axHttpClientMock, companyId, apiAuthorization);
            // Se verifica que cuando se llama al PostAsync sea con los parámetros correctos
            Assert.Equal($"{tangoUrl}/api/{action}?process={processId}", requestMessage?.RequestUri?.AbsoluteUri); // URI es la url correcta según el config, action y process
            Assert.Equal(JsonConvert.SerializeObject(paisData), await requestMessage.Content.ReadAsStringAsync()); // Content es un json del país que queremos dar dar de alta
        }

        private static void AssertHeaders(Mock<IAxHttpClient> axHttpClientMock, string companyId, string apiAuthorization)
        {
            // Verifico que al momento de ejecutar el post los headers sean los correctos
            HttpRequestHeaders headers = axHttpClientMock.Object.DefaultRequestHeaders;
            Assert.Equal(companyId, headers.GetValues("Company").Single()); // El header contiene el CompanyId
            Assert.Equal(apiAuthorization, headers.GetValues("ApiAuthorization").Single()); // El header contiene el ApiAuth 
        }
        #endregion

        #region Tests
        [Fact]
        public void Create_Ok()
        {
            // entidad que vamos a dar de alta
            PaisData paisData = new()
            {
                PAIS1 = nombrePais,
                COD_AREA = codigoDeArea,
                COD_DGI = codigoDgi
            };

            // setup del mock con el paisData que daremos de alta
            // contiene un callback con los asserts del header, uri y content del ApiPost
            // Los parámetros se corresponden con todos los datos que tienen un assert
            SetUpPostAsync(axHttpClientMock, paisId, companyId, apiAuthorization, tangoUrl, processId, paisData);

            // instanciamos un paisService con el mock del axHttpClientMock
            PaisService paisService = new(tangoConfig, axHttpClientMock.Object);

            // llamamos al método create del paisService con el país que queremos crear como parámetro
            // Verificamos que el savedId que nos devuelve el Create sea el mismo que el SavedId dentro del TransactionResultModel del content del responseMessage
            Assert.Equal(paisId, paisService.Create(paisData));

            // Verificamos que llamamos sólo una vez al método PostAsync. La verificación de que los parámetros sean los correctos está en el callback del mock.
            axHttpClientMock.Verify(m => m.PostAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()), Times.Once);
        }

        [Fact]
        public void Update_Ok()
        {
            PaisData paisData = new()
            {
                ID_PAIS = paisId,
                PAIS1 = nombrePais,
                COD_AREA = codigoDeArea,
                COD_DGI = codigoDgi
            };
            SetUpPutAsync(axHttpClientMock, paisId, companyId, apiAuthorization, tangoUrl, processId, paisData);
            PaisService paisService = new(tangoConfig, axHttpClientMock.Object);
            paisService.Update(paisData);
            axHttpClientMock.Verify(m => m.PutAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()), Times.Once);
        }

        [Fact]
        public void Update_ErrorNoEsperado_IdDelResponseNoCoincide()
        {
            throw new NotImplementedException("Implementame porfa");
        }        

        [Fact]
        public void Delete_Ok()
        {
            SetUpDeleteAsync(axHttpClientMock, companyId, apiAuthorization, tangoUrl, processId, paisId);
            PaisService paisService = new(tangoConfig, axHttpClientMock.Object);
            paisService.Delete(paisId);
            axHttpClientMock.Verify(m => m.DeleteAsync(It.IsAny<Uri>()), Times.Once);
        }
        #endregion
    }
}
