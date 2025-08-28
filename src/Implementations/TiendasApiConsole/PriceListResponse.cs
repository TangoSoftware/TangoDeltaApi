namespace TiendasApiConsole
{
    // Clase para representar la respuesta de la API que contiene una lista de PriceList y metadatos de paginación
    public class PriceListResponse
    {
        public List<PriceList>? Data { get; set; }

        public int pageNumber;
        public int pageSize;
        public bool hasNextPage;
        public List<string>? message; // O hay pricelist o hay message
        public OrderErrorDto orderError;
        public bool Succeeded;
    }

    // Clase para representar errores específicos relacionados con órdenes
    public class OrderErrorDto
    {
        public string Orders { get; set; }

        public string Message { get; set; }
    }
}
