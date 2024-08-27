using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.tipodeasientos.model;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class DETAIL_TOOLBAR_GROUP
{
    [Newtonsoft.Json.JsonProperty("COD_MODULO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? COD_MODULO { get; set; }

    [Newtonsoft.Json.JsonProperty("Habilitado", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? Habilitado { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class LEYENDA_ENCABEZADO_TIPO_ASIENTO
{
    [Newtonsoft.Json.JsonProperty("ID_LEYENDA_ENCABEZADO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ID_LEYENDA_ENCABEZADO { get; set; }

    [Newtonsoft.Json.JsonProperty("LEYENDA_DEFECTO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? LEYENDA_DEFECTO { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class TiposDeAsientosData : BaseData
{
    [Newtonsoft.Json.JsonProperty("COD_TIPO_ASIENTO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? COD_TIPO_ASIENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("DESC_TIPO_ASIENTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(40)]
    public string? DESC_TIPO_ASIENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("HABILITADO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? HABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("GENERA_ASIENTO_RESUMEN", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? GENERA_ASIENTO_RESUMEN { get; set; }

    [Newtonsoft.Json.JsonProperty("ESTADO_INICIAL_ASIENTOS", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? ESTADO_INICIAL_ASIENTOS { get; set; }

    [Newtonsoft.Json.JsonProperty("EDITA_ESTADO_ASIENTOS", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? EDITA_ESTADO_ASIENTOS { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_AGRUPACION_ASIENTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_AGRUPACION_ASIENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? OBSERVACIONES { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_DESCRIP { get; set; }

    [Newtonsoft.Json.JsonProperty("DETAIL_TOOLBAR_GROUP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<DETAIL_TOOLBAR_GROUP>? DETAIL_TOOLBAR_GROUP { get; set; }

    [Newtonsoft.Json.JsonProperty("LEYENDA_ENCABEZADO_TIPO_ASIENTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<LEYENDA_ENCABEZADO_TIPO_ASIENTO>? LEYENDA_ENCABEZADO_TIPO_ASIENTO { get; set; }
}
