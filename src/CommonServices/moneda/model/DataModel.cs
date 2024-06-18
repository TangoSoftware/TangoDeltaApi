using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.Moneda.model;

public class MonedaData : BaseData
{
        [JsonProperty("ID_MONEDA")]
        public int IdMoneda{ get; set; }
     
        [JsonProperty("COD_MONEDA", Required = Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? COD_MONEDA { get; set; }

        [JsonProperty("DESC_MONEDA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string? DESC_MONEDA { get; set; }

        [JsonProperty("TIPO_MONEDA", Required = Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string? TIPO_MONEDA { get; set; }

        [JsonProperty("SIMBOLO_MONEDA", Required = Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? SIMBOLO_MONEDA { get; set; }

        [JsonProperty("CANT_DECIMAL_MONEDA", Required = Required.Always)]
        public int CANT_DECIMAL_MONEDA { get; set; }

        [JsonProperty("ID_SBA43", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ID_SBA43 { get; set; }

        [JsonProperty("ID_TIPO_MONEDA_AFIP", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ID_TIPO_MONEDA_AFIP { get; set; }

        [JsonProperty("ID_EJERCICIO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ID_EJERCICIO { get; set; }

        [JsonProperty("ID_CUENTA_TENENCIA_POSITIVO_MDA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ID_CUENTA_TENENCIA_POSITIVO_MDA { get; set; }

        [JsonProperty("ID_CUENTA_TENENCIA_NEGATIVO_MDA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ID_CUENTA_TENENCIA_NEGATIVO_MDA { get; set; }

        [JsonProperty("ID_CUENTA_TRASLACION", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ID_CUENTA_TRASLACION { get; set; }

        [JsonProperty("ID_TIPO_ASIENTO_TENENCIA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ID_TIPO_ASIENTO_TENENCIA { get; set; }

        [JsonProperty("ID_TIPO_ASIENTO_CONVERSION", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ID_TIPO_ASIENTO_CONVERSION { get; set; }

        [JsonProperty("ID_TIPO_COTIZACION", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ID_TIPO_COTIZACION { get; set; }

        [JsonProperty("EDITA_TIPO_COTIZACION", Required = Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? EDITA_TIPO_COTIZACION { get; set; }

        [JsonProperty("EDITA_COTIZACION", Required = Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? EDITA_COTIZACION { get; set; }

        [JsonProperty("CANT_DECIMAL_COTIZACION", Required = Required.Always)]
        public int CANT_DECIMAL_COTIZACION { get; set; }

        [JsonProperty("COD_AFIP_EX", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? COD_AFIP_EX { get; set; }

        [JsonProperty("COD_AFIP", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? COD_AFIP { get; set; }

        [JsonProperty("OBSERVACIONES", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string? OBSERVACIONES { get; set; }

        [JsonProperty("COD_DESCRIP", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? COD_DESCRIP { get; set; }

}
