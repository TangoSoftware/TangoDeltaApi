using Moq;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Timers;
using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiLibrary.servicesBase;

namespace TestProject1
{
    public class UnitTest1
    {
        private static ITangoConfig NewConfig()
        {
            return new TangoConfig()
            {
                TangoUrl = "http://localhost:17000/",
                ApiAuthorization = "C98BEF0B-F23F-4D0B-BBF3-49F4AF8F65DC",
                CompanyId = "4"
            };
        }

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

        [Fact]
        public void CreateExitoso()
        {
            // "config" para tests
            var config = NewConfig();

            // entidad que vamos a dar de alta
            PaisData paisData = new()
            {
                COD_AREA = "asd",
                COD_DGI = "gdfgfd",
                PAIS1 = "nombredelpais"
            };

            // id que esperamos que se genere
            int expectedSavedId = 456;

            // mock del httpClient
            Mock<IAxHttpClient> axHttpClientMock = new();
            HttpClient client = new();
            HttpRequestHeaders httpRequestHeaders = client.DefaultRequestHeaders;
            axHttpClientMock.Setup(m => m.DefaultRequestHeaders).Returns(httpRequestHeaders);

            axHttpClientMock
                .Setup(m => m.PostAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()))
                .Returns(GetHttpResponseMessage(expectedSavedId)) // seteo del response message con el "savedId" esperado
                .Callback(async (Uri uri, HttpContent content) =>
                {   
                    var requestMessage = new HttpRequestMessage
                    {
                        RequestUri = uri,
                        Content = content,
                    };

                    // Verifico que al momento de ejecutar el post los headers sean los correctos
                    Assert.Equal(config.CompanyId, axHttpClientMock.Object.DefaultRequestHeaders.GetValues("Company").Single()); // El header contiene el CompanyId
                    Assert.Equal(config.ApiAuthorization, axHttpClientMock.Object.DefaultRequestHeaders.GetValues("ApiAuthorization").Single()); // El header contiene el ApiAuth                                       

                    // Se verifica que cuando se llama al PostAsync sea con los parámetros correctos
                    Assert.Equal("http://localhost:17000/api/Create?process=1097", requestMessage.RequestUri.AbsoluteUri); // URI es la url correcta según el config, action=Create, y process=1097                    
                    Assert.Equal(JsonConvert.SerializeObject(paisData), await requestMessage.Content.ReadAsStringAsync()); // Content contiene el país que queremos dar dar de alta
                });

            // instanciamos un paisService
            PaisService paisService = new(config, axHttpClientMock.Object);

            // llamamos al método create del paisService con el país que queremos crear como parámetro
            int savedId = paisService.Create(paisData);

            // Verificamos que el savedId que nos devuelve el Create sea el mismo que el SavedId dentro del TransactionResultModel del content del responseMessage
            Assert.Equal(expectedSavedId, savedId);

            // Verificamos que llamamos sólo una vez al método PostAsync. La verificación de que los parámetros sean los correctos está en el callback del mock.
            axHttpClientMock.Verify(m => m.PostAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()), Times.Once);
        }
    }
}