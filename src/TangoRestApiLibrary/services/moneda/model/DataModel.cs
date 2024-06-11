using Newtonsoft.Json;
using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.Moneda.model;

public class MonedaData : BaseData
{
        [JsonProperty("ID_MONEDA")]
        public int IdMoneda{ get; set; }
     
        [Newtonsoft.Json.JsonProperty("COD_MONEDA", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? COD_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("DESC_MONEDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string? DESC_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("TIPO_MONEDA", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string? TIPO_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("SIMBOLO_MONEDA", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? SIMBOLO_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("CANT_DECIMAL_MONEDA", Required = Newtonsoft.Json.Required.Always)]
        public int CANT_DECIMAL_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_SBA43", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_SBA43 { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_MONEDA_AFIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_MONEDA_AFIP { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_EJERCICIO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_EJERCICIO { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_CUENTA_TENENCIA_POSITIVO_MDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_CUENTA_TENENCIA_POSITIVO_MDA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_CUENTA_TENENCIA_NEGATIVO_MDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_CUENTA_TENENCIA_NEGATIVO_MDA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_CUENTA_TRASLACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_CUENTA_TRASLACION { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_ASIENTO_TENENCIA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_ASIENTO_TENENCIA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_ASIENTO_CONVERSION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_ASIENTO_CONVERSION { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? EDITA_TIPO_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_COTIZACION", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? EDITA_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("CANT_DECIMAL_COTIZACION", Required = Newtonsoft.Json.Required.Always)]
        public int CANT_DECIMAL_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("COD_AFIP_EX", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? COD_AFIP_EX { get; set; }

        [Newtonsoft.Json.JsonProperty("COD_AFIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? COD_AFIP { get; set; }

        [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string? OBSERVACIONES { get; set; }

        [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? COD_DESCRIP { get; set; }

}
