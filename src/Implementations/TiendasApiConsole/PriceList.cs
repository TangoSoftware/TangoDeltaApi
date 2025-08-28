namespace TiendasApiConsole
{
    public class PriceList
    {
        public int Id { get; set; }

        public int PriceListNumber { get; set; }

        public string Description { get; set; }

        public bool CommonCurrency { get; set; }

        public bool IvaIncluded { get; set; }

        public bool InternalTaxIncluded { get; set; }

        public DateTime? ValidityDateSince { get; set; }

        public DateTime? ValidityDateUntil { get; set; }

        public bool Enabled { get; set; }
    }
}
