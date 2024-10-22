using TangoDeltaApi.Core.Service;
namespace TangoDeltaApi.CommonServices.contabilidad.asientos.model;


[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class ASIENTO_COTIZACION_ANALITICO_CN
{
    [Newtonsoft.Json.JsonProperty("ID_MONEDA", Required = Newtonsoft.Json.Required.Always)]
    public int ID_MONEDA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.Always)]
    public int ID_TIPO_COTIZACION { get; set; }

    [Newtonsoft.Json.JsonProperty("COTIZACION_ALTERNATIVA", Required = Newtonsoft.Json.Required.Always)]
    public decimal COTIZACION_ALTERNATIVA { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class RENGLON_ANALITICO_DTO
{
   // [Newtonsoft.Json.JsonProperty("NRO_RENGLON_ANALITICO", Required = Newtonsoft.Json.Required.Always)]
   // public int NRO_RENGLON_ANALITICO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA", Required = Newtonsoft.Json.Required.Always)]
    public int ID_CUENTA { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPORTE_DEBE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? IMPORTE_DEBE { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPORTE_HABER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? IMPORTE_HABER { get; set; }

    [Newtonsoft.Json.JsonProperty("FECHA_ORIGEN", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public System.DateTimeOffset? FECHA_ORIGEN { get; set; }

    [Newtonsoft.Json.JsonProperty("DESC_LEYENDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? DESC_LEYENDA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_COTIZACION { get; set; }

    [Newtonsoft.Json.JsonProperty("COTIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? COTIZACION { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPORTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? IMPORTE { get; set; }

    [Newtonsoft.Json.JsonProperty("CANTIDAD", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? CANTIDAD { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_VALORIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_VALORIZACION { get; set; }

    [Newtonsoft.Json.JsonProperty("VALORIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? VALORIZACION { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_COTIZACION_CORRIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_COTIZACION_CORRIENTE { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPORTE_CORRIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? IMPORTE_CORRIENTE { get; set; }

    [Newtonsoft.Json.JsonProperty("COTIZACION_CORRIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? COTIZACION_CORRIENTE { get; set; }

    [Newtonsoft.Json.JsonProperty("TIPO_AUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<TIPO_AUXILIAR_DTO>? TIPO_AUXILIAR { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class TIPO_AUXILIAR_DTO
{
    [Newtonsoft.Json.JsonProperty("ID_REGLA_APROPIACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_REGLA_APROPIACION { get; set; }

    [Newtonsoft.Json.JsonProperty("AUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<AUXILIAR_DTO>? AUXILIAR { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class AUXILIAR_DTO
{
    [Newtonsoft.Json.JsonProperty("ID_AUXILIAR", Required = Newtonsoft.Json.Required.Always)]
    public int ID_AUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("PORC_APROPIACION", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Range(0D, 100D)]
    public decimal PORC_APROPIACION { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPORTE_RENGLON", Required = Newtonsoft.Json.Required.Always)]
    public decimal IMPORTE_RENGLON { get; set; }

    [Newtonsoft.Json.JsonProperty("LEYENDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? LEYENDA { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPORTE_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? IMPORTE_ADICIONAL { get; set; }

    [Newtonsoft.Json.JsonProperty("CANTIDAD_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? CANTIDAD_ADICIONAL { get; set; }

    [Newtonsoft.Json.JsonProperty("SUBAUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<SUBAUXILIAR_DTO>? SUBAUXILIAR { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class SUBAUXILIAR_DTO
{
    [Newtonsoft.Json.JsonProperty("ID_SUBAUXILIAR", Required = Newtonsoft.Json.Required.Always)]
    public int ID_SUBAUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("PORC_APROPIACION", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Range(0D, 100D)]
    public decimal PORC_APROPIACION { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPORTE_RENGLON", Required = Newtonsoft.Json.Required.Always)]
    public decimal IMPORTE_RENGLON { get; set; }

    [Newtonsoft.Json.JsonProperty("LEYENDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? LEYENDA { get; set; }

    [Newtonsoft.Json.JsonProperty("EDITA_APROPIACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? EDITA_APROPIACION { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPORTE_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? IMPORTE_ADICIONAL { get; set; }

    [Newtonsoft.Json.JsonProperty("CANTIDAD_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? CANTIDAD_ADICIONAL { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class AsientoAnaliticoData : BaseData
{
    [Newtonsoft.Json.JsonProperty("ID_ASIENTO_ANALITICO_CN", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ID_ASIENTO_ANALITICO_CN { get; set; }

    [Newtonsoft.Json.JsonProperty("FECHA_ASIENTO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public System.DateTimeOffset FECHA_ASIENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("NRO_ASIENTO_ANALITICO")]
    public decimal? NRO_ASIENTO_ANALITICO { get; set; }

    [Newtonsoft.Json.JsonProperty("ORIGEN_ASIENTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string ORIGEN_ASIENTO { get; set; }
    
    [Newtonsoft.Json.JsonProperty("CLASE_ASIENTO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? CLASE_ASIENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_ASIENTO", Required = Newtonsoft.Json.Required.Always)]
    public int ID_TIPO_ASIENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("ESTADO_ASIENTO_ANALITICO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? ESTADO_ASIENTO_ANALITICO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_MONEDA_ASIENTO", Required = Newtonsoft.Json.Required.Always)]
    public int ID_MONEDA_ASIENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("DESC_ASIENTO_ANALITICO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? DESC_ASIENTO_ANALITICO { get; set; }

    [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? OBSERVACIONES { get; set; }

    [Newtonsoft.Json.JsonProperty("ASIENTO_COTIZACION_ANALITICO_CN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<ASIENTO_COTIZACION_ANALITICO_CN>? ASIENTO_COTIZACION_ANALITICO_CN { get; set; }

    [Newtonsoft.Json.JsonProperty("RENGLON_ANALITICO_DTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<RENGLON_ANALITICO_DTO>? RENGLON_ANALITICO_DTO { get; set; }
}
