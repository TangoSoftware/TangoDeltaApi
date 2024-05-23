using Moq;
using Newtonsoft.Json;
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
        const string tangoUrl = "http://localhost:17123";
        const string apiAuthorization = "C98BEF0B-F23F-4D0B-BBF3-49F4AF8F65DB";
        const string companyId = "7";
        const int processId = 1097;
        const int paisId = 456;
        const string nombrePais = "nombre del pais";
        const string codigoDeArea = "código de area";
        const string codigoDgi = "codigoDgi";
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

        private void SetUpPostAsync(PaisData paisData)
        {
            axHttpClientMock
                .Setup(m => m.PostAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()))
                .Returns(GetHttpResponseMessage(paisId)) // seteo del response message con el paisId esperado
                .Callback(async (Uri uri, HttpContent content) =>
                {
                    var requestMessage = new HttpRequestMessage
                    {
                        RequestUri = uri,
                        Content = content,
                    };
                    HttpRequestHeaders headers = axHttpClientMock.Object.DefaultRequestHeaders;

                    await CallbackAsserts(paisData, requestMessage, headers);
                });
        }

        private static async Task CallbackAsserts(PaisData paisData, HttpRequestMessage requestMessage, HttpRequestHeaders headers)
        {
            // Verifico que al momento de ejecutar el post los headers sean los correctos
            Assert.Equal(companyId, headers.GetValues("Company").Single()); // El header contiene el CompanyId
            Assert.Equal(apiAuthorization, headers.GetValues("ApiAuthorization").Single()); // El header contiene el ApiAuth                                       

            // Se verifica que cuando se llama al PostAsync sea con los parámetros correctos
            Assert.Equal($"{tangoUrl}/api/Create?process={processId}", requestMessage.RequestUri.AbsoluteUri); // URI es la url correcta según el config, action=Create, y process de paises
            Assert.Equal(JsonConvert.SerializeObject(paisData), await requestMessage.Content.ReadAsStringAsync()); // Content es un json del país que queremos dar dar de alta
        }
        #endregion

        [Fact]
        public void CreateExitoso()
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
            SetUpPostAsync(paisData);

            // instanciamos un paisService con el mock del axHttpClientMock
            PaisService paisService = new(tangoConfig, axHttpClientMock.Object);

            // llamamos al método create del paisService con el país que queremos crear como parámetro
            // Verificamos que el savedId que nos devuelve el Create sea el mismo que el SavedId dentro del TransactionResultModel del content del responseMessage
            Assert.Equal(paisId, paisService.Create(paisData));

            // Verificamos que llamamos sólo una vez al método PostAsync. La verificación de que los parámetros sean los correctos está en el callback del mock.
            axHttpClientMock.Verify(m => m.PostAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()), Times.Once);
        }
    }
}