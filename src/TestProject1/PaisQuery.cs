using TangoRestApiLibrary.services.basemodel;

namespace TestProject1
{
    internal class PaisQuery: BaseQueryRecord
    {
        public int ID_PAIS { get; set; }
        public string PAIS1 { get; set; }
        public string COD_DGI { get; set; }
        public string COD_AREA { get; set; }
    }
}