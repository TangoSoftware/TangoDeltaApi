using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.cuentascontables.model;


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
public class LEYENDA_MOVIMIENTO_CUENTA
{
    [Newtonsoft.Json.JsonProperty("ID_LEYENDA_MOVIMIENTO", Required = Newtonsoft.Json.Required.Always)]
    public int ID_LEYENDA_MOVIMIENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("D_H", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public string? D_H { get; set; }

    [Newtonsoft.Json.JsonProperty("LEYENDA_DEFECTO", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? LEYENDA_DEFECTO { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class CuentasContablesData : BaseData
{
    public int ID_CUENTA { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_CUENTA", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? COD_CUENTA { get; set; }

    [Newtonsoft.Json.JsonProperty("DESC_CUENTA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(60)]
    public string? DESC_CUENTA { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_CUENTA_ALTERNATIVO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(40)]
    public string? COD_CUENTA_ALTERNATIVO { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_AUXILIARES_CONTABLES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? USA_AUXILIARES_CONTABLES { get; set; }

    [Newtonsoft.Json.JsonProperty("REGISTRACION_AUTOMATICA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? REGISTRACION_AUTOMATICA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CLASE_CUENTA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CLASE_CUENTA { get; set; }

    [Newtonsoft.Json.JsonProperty("TIPO_CUENTA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? TIPO_CUENTA { get; set; }

    [Newtonsoft.Json.JsonProperty("SALDO_HABITUAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(8)]
    public string? SALDO_HABITUAL { get; set; }

    [Newtonsoft.Json.JsonProperty("HABILITADO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? HABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("DESFE_INHABILITADO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? DESFE_INHABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("HASFE_INHABILITADO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? HASFE_INHABILITADO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_RDO_EJ_POSITIVO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_RDO_EJ_POSITIVO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_RDO_EJ_NEGATIVO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_RDO_EJ_NEGATIVO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_RESULTADOS_ACUMULADOS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_RESULTADOS_ACUMULADOS { get; set; }

    [Newtonsoft.Json.JsonProperty("AFECTA_AJUSTE_INFLACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? AFECTA_AJUSTE_INFLACION { get; set; }

    [Newtonsoft.Json.JsonProperty("AFECTA_COMPROBACION_AJUSTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? AFECTA_COMPROBACION_AJUSTE { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_INDICE_COMPROBACION_AJUSTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_INDICE_COMPROBACION_AJUSTE { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_UNIDAD_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? USA_UNIDAD_ADICIONAL { get; set; }

    [Newtonsoft.Json.JsonProperty("AFECTA_CONVERSION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? AFECTA_CONVERSION { get; set; }

    [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? OBSERVACIONES { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_DESCRIP { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_RDO_INFLAC_POSITIVO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_RDO_INFLAC_POSITIVO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_RDO_INFLAC_NEGATIVO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_RDO_INFLAC_NEGATIVO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_PROPORCION_AJUSTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_PROPORCION_AJUSTE { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_INDICE_AJUSTE_INFLACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_INDICE_AJUSTE_INFLACION { get; set; }

    [Newtonsoft.Json.JsonProperty("TIPO_UNIDAD_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? TIPO_UNIDAD_ADICIONAL { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_MONEDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_MONEDA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_UNIDAD_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_UNIDAD_ADICIONAL { get; set; }

    [Newtonsoft.Json.JsonProperty("AFECTA_RESULTADO_TENENCIA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? AFECTA_RESULTADO_TENENCIA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_RDO_TENENCIA_POSITIVO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_RDO_TENENCIA_POSITIVO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_RDO_TENENCIA_NEGATIVO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_RDO_TENENCIA_NEGATIVO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_TENENCIA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_TENENCIA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_ASIENTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_ASIENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("TIPO_CONVERSION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? TIPO_CONVERSION { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_COTIZACION { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_ASIENTO_CONVERSION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_ASIENTO_CONVERSION { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_CONVERSION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_CONVERSION { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_TRASLACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_TRASLACION { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CUENTA_RUBRO_COPIA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CUENTA_RUBRO_COPIA { get; set; }

    [Newtonsoft.Json.JsonProperty("PERMITE_MOD_CODIGO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool PERMITE_MOD_CODIGO { get; set; }

    [Newtonsoft.Json.JsonProperty("DETAIL_TOOLBAR_GROUP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<DETAIL_TOOLBAR_GROUP>? DETAIL_TOOLBAR_GROUP { get; set; }

    [Newtonsoft.Json.JsonProperty("LEYENDA_MOVIMIENTO_CUENTA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<LEYENDA_MOVIMIENTO_CUENTA>? LEYENDA_MOVIMIENTO_CUENTA { get; set; }
}
