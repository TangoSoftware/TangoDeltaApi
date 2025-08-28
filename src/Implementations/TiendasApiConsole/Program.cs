using Newtonsoft.Json;
using TiendasApiConsole;
using System.Net.Http.Headers;

public class TiendasApiClient
{
    private static readonly HttpClient client = new HttpClient();
    private const string Llave = "00000X-XYZ"; // Reemplaza con tu llave de acceso a la API.
    private const string BaseUrl = $"https://{Llave}.connect.axoft.com/api/tiendas/"; // Cambia esto por la URL base de la API.
    private const string ApiToken = "tu_token_de_desarrollador"; // Token de desarrollador.
    private const int CompanyId = 1; // ID de la empresa.

    public TiendasApiClient()
    {
        // Configuración inicial de encabezados comunes.
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("ApiAuthorization", ApiToken);
        client.DefaultRequestHeaders.Add("Company", CompanyId.ToString());
    }

    // Este ejemplo es válido para los métodos GET, para conocer parámetros y detalles u observaciones, así como los resultados esperados, consultar la documentación de la API en el pdf adjunto.
    public static async Task GetPriceList(string pageSize)
    {
        try
        {
            string endpoint = $"{BaseUrl}/PriceList?pageSize={pageSize}";

            // Realizar la solicitud GET.
            HttpResponseMessage response = await client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                // Leer y deserializar el contenido de la respuesta.
                string deserealizedResponse = await response.Content.ReadAsStringAsync();

                // Deserializar el JSON a un objeto PriceListResponse.
                var priceListResponse = JsonConvert.DeserializeObject<PriceListResponse>(deserealizedResponse);

                // La consulta maneja errores, pero se puede agregar una validación adicional.
                if (priceListResponse == null)
                {
                    throw new Exception("No se pudo obtener la respuesta.");
                }

                // Si hay datos en la respuesta, procesarlos.
                if (priceListResponse.data != null)
                { 
                    // Por cada PriceList en la respuesta, imprimir sus detalles.
                    foreach (PriceList priceList in priceListResponse.data)
                    {
                        Console.WriteLine($"{priceList.Id}");
                        Console.WriteLine($"{priceList.PriceListNumber}");
                        Console.WriteLine($"{priceList.Description}");
                        Console.WriteLine($"{priceList.CommonCurrency}");
                        Console.WriteLine($"{priceList.IvaIncluded}");
                        Console.WriteLine($"{priceList.InternalTaxIncluded}");
                        Console.WriteLine($"{priceList.ValidityDateSince}");
                        Console.WriteLine($"{priceList.ValidityDateUntil}");
                        Console.WriteLine($"{priceList.Enabled}");
                    }
                }

                // Imprimir detalles de paginación y estado.
                Console.WriteLine(priceListResponse.pageNumber);
                Console.WriteLine(priceListResponse.pageSize);
                Console.WriteLine(priceListResponse.hasNextPage);

                // Si no hay datos y hay un mensaje, imprimir el mensaje.
                if (priceListResponse.message != null)
                {
                    Console.WriteLine($"{priceListResponse.message}");
                }

                // Imprimir información de errores y estado de la operación.
                Console.WriteLine(priceListResponse.orderError);
                Console.WriteLine(priceListResponse.Succeeded);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Excepción: {ex.Message}");
        }
    }

    public static async Task PostOrder(string jsonOrderBody)
    {
        try
        {
            string endpoint = $"{BaseUrl}/Order";

            // Preparar el contenido JSON para la solicitud POST.
            var content = new StringContent(jsonOrderBody, System.Text.Encoding.UTF8, "application/json");

            // Realizar la solicitud POST.
            HttpResponseMessage response = await client.PostAsync(endpoint, content);

            // Leer y mostrar la respuesta, que puede ser exitosa o fallida.
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                Console.WriteLine("Respuesta del servidor:");
                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Excepción: {ex.Message}");
        }
    }
}

// Programa principal para probar el método.
public class Program
{
    public static async Task Main(string[] args)
    {
        var apiClient = new TiendasApiClient();
        await TiendasApiClient.GetPriceList(pageSize: "500");

        #region jsonBody
        // Reemplazá esto por el contenido real de tu JSON.
        string jsonBody = @"{
                          ""Date"": ""2025-07-16T00:00:00"",
                          ""Total"": 8523.0,
                          ""TotalDiscount"": 77.0,
                          ""PaidTotal"": 8523.0,
                          ""FinancialSurcharge"": 200.0,
                          ""WarehouseCode"": ""2"",
                          ""SellerCode"": ""1"",
                          ""TransportCode"": ""01"",
                          ""SaleConditionCode"": 1,
                          ""InvoiceCounterfoil"": 1,
                          ""OrderID"": ""1"",
                          ""OrderNumber"": ""7"",
                          ""ValidateTotalWithPaidTotal"": true,
                          ""Customer"": {
                            ""CustomerID"": 1,
                            ""DocumentType"": ""80"",
                            ""DocumentNumber"": ""115454111111"",
                            ""IVACategoryCode"": ""CF"",
                            ""User"": ""ADMIN"",
                            ""Email"": ""api@axoft.com"",
                            ""FirstName"": ""Juan"",
                            ""LastName"": ""Perez"",
                            ""BusinessName"": ""Empresa"",
                            ""Street"": ""Cerrrito"",
                            ""HouseNumber"": ""1186"",
                            ""Floor"": ""2"",
                            ""Apartment"": ""1"",
                            ""City"": ""CABA"",
                            ""ProvinceCode"": ""01"",
                            ""PostalCode"": ""1122"",
                            ""PhoneNumber1"": ""12459856"",
                            ""PhoneNumber2"": ""42563698"",
                            ""Bonus"": 0.0,
                            ""MobilePhoneNumber"": ""165952141"",
                            ""WebPage"": null,
                            ""BusinessAddress"": ""Cerrito 1186"",
                            ""Comments"": ""Comentario"",
                            ""NumberListPrice"": 0,
                            ""Removed"": false,
                            ""DateUpdate"": ""0001-01-01T00:00:00"",
                            ""Disable"": ""0001-01-01T00:00:00""
                          },
                          ""CancelOrder"": false,
                          ""OrderItems"": [
                            {
                              ""ProductCode"": ""203"",
                              ""SKUCode"": ""0100200659"",
                              ""VariantCode"": null,
                              ""Description"": ""LAVARROPAS AUTOM. MOD.BLUE "",
                              ""VariantDescription"": null,
                              ""Quantity"": 1.0,
                              ""UnitPrice"": 7700.0,
                              ""DiscountPercentage"": 0.0
                            },
                            {
                              ""ProductCode"": ""104"",
                              ""SKUCode"": ""0100100269"",
                              ""VariantCode"": null,
                              ""Description"": ""CÁMARA DIGITAL 4X MARCA TCL"",
                              ""VariantDescription"": null,
                              ""Quantity"": 1.0,
                              ""UnitPrice"": 300.0,
                              ""DiscountPercentage"": 0.0
                            }
                          ],
                          ""Shipping"": {
                            ""ShippingID"": 71906,
                            ""Street"": ""9 de Julio"",
                            ""HouseNumber"": ""1186"",
                            ""Floor"": ""1"",
                            ""Apartment"": ""1"",
                            ""City"": ""CABA"",
                            ""ProvinceCode"": ""01"",
                            ""PostalCode"": ""1122"",
                            ""PhoneNumber1"": ""125165151"",
                            ""PhoneNumber2"": ""12345678"",
                            ""ShippingCost"": 400.0,
                            ""DeliversMonday"": ""S"",
                            ""DeliversTuesday"": ""S"",
                            ""DeliversWednesday"": ""S"",
                            ""DeliversThursday"": ""S"",
                            ""DeliversFriday"": ""S"",
                            ""DeliversSaturday"": ""S"",
                            ""DeliversSunday"": ""S"",
                            ""DeliveryHours"": ""8""
                          },
                          ""CashPayments"": [
                          {
                          ""PaymentID"": 385612,
                          ""PaymentMethod"": ""A02"",
                          ""PaymentTotal"": 123.0
                          }
                          ],
                          ""Payments"": [
                            {
                              ""PaymentId"": 385663,
                              ""TransactionDate"": ""2025-07-16T00:00:00"",
                              ""AuthorizationCode"": ""52"",
                              ""TransactionNumber"": ""998595"",
                              ""Installments"": 1,
                              ""InstallmentAmount"": 8100.0,
                              ""Total"": 8100.0,
                              ""CardCode"": ""01"",
                              ""CardPlanCode"": ""1"",
                              ""VoucherNo"": 48,
                              ""CardPromotionCode"": ""2""
                            },
                            {
                              ""PaymentId"": 385614,
                              ""TransactionDate"": ""2025-07-16T00:00:00"",
                              ""AuthorizationCode"": ""53"",
                              ""TransactionNumber"": ""5849849"",
                              ""Installments"": 2,
                              ""InstallmentAmount"": 250.0,
                              ""Total"": 300.0,
                              ""CardCode"": ""DI"",
                              ""CardPlanCode"": ""2"",
                              ""VoucherNo"": 49,
                              ""CardPromotionCode"": ""1""
                            }
                          ]

                        }";
        #endregion

        await TiendasApiClient.PostOrder(jsonBody);
    }
}
