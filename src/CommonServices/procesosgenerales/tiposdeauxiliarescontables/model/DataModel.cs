using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.tiposdeauxiliarescontables.model;


[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class AUXILIAR
{
    public int ID_AUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_AUXILIAR", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(17)]
    public string? COD_AUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("DESC_AUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(40)]
    public string? DESC_AUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("HABILITADO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? HABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("DESFE_INHABILITADO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? DESFE_INHABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("HASFE_INHABILITADO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? HASFE_INHABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_DESCRIP { get; set; }

    [Newtonsoft.Json.JsonProperty("SUBAUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<SUBAUXILIAR>? SUBAUXILIAR { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class SUBAUXILIAR
{
    public int ID_SUBAUXILIAR { get; set; }
    [Newtonsoft.Json.JsonProperty("COD_SUBAUXILIAR", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(17)]
    public string? COD_SUBAUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("DESC_SUBAUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(40)]
    public string? DESC_SUBAUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("HABILITADO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? HABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("DESFE_INHABILITADO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? DESFE_INHABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("HASFE_INHABILITADO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? HASFE_INHABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_DESCRIP { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class TiposDeAuxiliaresContablesData : BaseData
{
    public int ID_TIPO_AUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_TIPO_AUXILIAR", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? COD_TIPO_AUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("DESC_TIPO_AUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(40)]
    public string? DESC_TIPO_AUXILIAR { get; set; }

    [Newtonsoft.Json.JsonProperty("TIPO_AUXILIAR1", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? TIPO_AUXILIAR1 { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_AUXILIAR_AUTOMATICO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_AUXILIAR_AUTOMATICO { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_SUBAUXILIARES_CONTABLES", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? USA_SUBAUXILIARES_CONTABLES { get; set; }

    [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? OBSERVACIONES { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_DESCRIP { get; set; }

    [Newtonsoft.Json.JsonProperty("AUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<AUXILIAR>? AUXILIAR { get; set; }
}
