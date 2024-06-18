using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.Moneda.model;

public class MonedaQueryRecord : BaseQueryRecord
{
        [JsonProperty("MONEDA_CONTABLE")]
        public string? MonedaContable { get; set; }

        [JsonProperty("MONEDA_ALTERNATIVA")]
        public string? MonedaAlternativa { get; set; }

        [JsonProperty("ID_MONEDA")]
        public int IdMoneda { get; set; }

        [JsonProperty("COD_MONEDA")]
        public string? CodMoneda { get; set; }

        [JsonProperty("DESC_MONEDA")]
        public string? DescMoneda { get; set; }

        [JsonProperty("TIPO_MONEDA")]
        public string? TipoMoneda { get; set; }

        [JsonProperty("SIMBOLO_MONEDA")]
        public string? SimboloMoneda { get; set; }

        [JsonProperty("CANT_DECIMAL_MONEDA")]
        public int CantDecimalMoneda { get; set; }

        [JsonProperty("ID_SBA43")]
        public int? IdSba43 { get; set; }

        [JsonProperty("ID_TIPO_MONEDA_AFIP")]
        public int? IdTipoMonedaAfip { get; set; }

        [JsonProperty("ID_EJERCICIO")]
        public int? IdEjercicio { get; set; }

        [JsonProperty("ID_CUENTA_TENENCIA_POSITIVO_MDA")]
        public int? IdCuentaTenenciaPositivoMda { get; set; }

        [JsonProperty("ID_CUENTA_TENENCIA_NEGATIVO_MDA")]
        public int? IdCuentaTenenciaNegativoMda { get; set; }

        [JsonProperty("ID_CUENTA_TRASLACION")]
        public int? IdCuentaTraslacion { get; set; }

        [JsonProperty("ID_TIPO_ASIENTO_TENENCIA")]
        public int? IdTipoAsientoTenencia { get; set; }

        [JsonProperty("ID_TIPO_ASIENTO_CONVERSION")]
        public int? IdTipoAsientoConversion { get; set; }

        [JsonProperty("ID_TIPO_COTIZACION")]
        public int? IdTipoCotizacion { get; set; }

        [JsonProperty("EDITA_TIPO_COTIZACION")]
        public string? EditaTipoCotizacion { get; set; }

        [JsonProperty("EDITA_COTIZACION")]
        public string? EditaCotizacion { get; set; }

        [JsonProperty("CANT_DECIMAL_COTIZACION")]
        public int CantDecimalCotizacion { get; set; }

        [JsonProperty("COD_AFIP_EX")]
        public string? CodAfipEx { get; set; }

        [JsonProperty("COD_AFIP")]
        public string? CodAfip { get; set; }

        [JsonProperty("OBSERVACIONES")]
        public object? Observaciones { get; set; }

        [JsonProperty("COD_DESCRIP")]
        public string? CodDescrip { get; set; }
   }
