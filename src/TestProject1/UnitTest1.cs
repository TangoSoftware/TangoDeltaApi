using Moq;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiLibrary.servicesBase;

namespace TestProject1
{
    public class UnitTest1
    {
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

        private static ITangoConfig NewConfig() => new TangoConfig()
        {
            TangoUrl = "http://localhost:17000/",
            ApiAuthorization = "C98BEF0B-F23F-4D0B-BBF3-49F4AF8F65DC",
            CompanyId = "4"
        };

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
            axHttpClientMock
                .Setup(m => m.PostAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()))
                .Returns(GetHttpResponseMessage(expectedSavedId)) // seteo del response message con el "savedId" esperado
                .Callback(async (Uri uri, HttpContent content) =>
                {   // Se verifica que cuando se llama al PostAsync sea con los par�metros correctos
                    Assert.Equal("http://localhost:17000/api/Create?process=1097", uri.AbsoluteUri); // URI es la url correcta seg�n el config, action=Create, y process=1097
                    Assert.Equal(JsonConvert.SerializeObject(paisData), await content.ReadAsStringAsync()); // content es el pa�s que queremos dar dar de alta
                });

            // instanciamos un paisService
            PaisService paisService = new(config, axHttpClientMock.Object);

            // llamamos al m�todo create del paisService con el pa�s que queremos crear como par�metro
            int savedId = paisService.Create(paisData);

            // Verificamos que el savedId que nos devuelve el Create sea el mismo que el SavedId dentro del TransactionResultModel del content del responseMessage
            Assert.Equal(expectedSavedId, savedId);

            // Verificamos que llamamos s�lo una vez al m�todo PostAsync. La verificaci�n de que los par�metros sean los correctos est� en el callback del mock.
            axHttpClientMock.Verify(m => m.PostAsync(It.IsAny<Uri>(), It.IsAny<HttpContent>()), Times.Once);
        }
    }
}