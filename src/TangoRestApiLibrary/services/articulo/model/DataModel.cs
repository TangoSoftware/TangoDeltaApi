using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.Articulo.model;

public class ArticuloData : BaseData
{

    [Newtonsoft.Json.JsonProperty("ID_STA11", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_STA11 { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_STA11", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(17)]
    public string? COD_STA11 { get; set; }

    [Newtonsoft.Json.JsonProperty("DESCRIPCIO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string? DESCRIPCIO { get; set; }

    [Newtonsoft.Json.JsonProperty("SINONIMO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? SINONIMO { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_BARRA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(40)]
    public string? COD_BARRA { get; set; }

    [Newtonsoft.Json.JsonProperty("FECHA_ALTA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? FECHA_ALTA { get; set; }

    [Newtonsoft.Json.JsonProperty("FECHA_MODI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? FECHA_MODI { get; set; }

    [Newtonsoft.Json.JsonProperty("STOCK_NEG", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? STOCK_NEG { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_DESCRIP { get; set; }

    [Newtonsoft.Json.JsonProperty("PROMO_MENU", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? PROMO_MENU { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_ESC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? USA_ESC { get; set; }

    [Newtonsoft.Json.JsonProperty("DESC_ADIC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? DESC_ADIC { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_STA11_BASE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_STA11_BASE { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_STA33_VALOR1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_STA33_VALOR1 { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_STA33_VALOR2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_STA33_VALOR2 { get; set; }

    [Newtonsoft.Json.JsonProperty("PERFIL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? PERFIL { get; set; }

    [Newtonsoft.Json.JsonProperty("STOCK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? STOCK { get; set; }

    [Newtonsoft.Json.JsonProperty("LLEVA_DOBLE_UNIDAD_MEDIDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? LLEVA_DOBLE_UNIDAD_MEDIDA { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_PARTID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? USA_PARTID { get; set; }

    [Newtonsoft.Json.JsonProperty("DESCARGA_NEGATIVO_STOCK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? DESCARGA_NEGATIVO_STOCK { get; set; }

    [Newtonsoft.Json.JsonProperty("MET_DES_PA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(3)]
    public string? MET_DES_PA { get; set; }

    [Newtonsoft.Json.JsonProperty("ORD_DES_PA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? ORD_DES_PA { get; set; }

    [Newtonsoft.Json.JsonProperty("EGRESO_MODIFICA_PARTIDA_PROPUESTA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? EGRESO_MODIFICA_PARTIDA_PROPUESTA { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_SERIE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? USA_SERIE { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_SCRAP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? USA_SCRAP { get; set; }

    [Newtonsoft.Json.JsonProperty("PORC_SCRAP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? PORC_SCRAP { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TYPS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TYPS { get; set; }

    [Newtonsoft.Json.JsonProperty("COMISION_V", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? COMISION_V { get; set; }

    [Newtonsoft.Json.JsonProperty("DESCUENTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? DESCUENTO { get; set; }

    [Newtonsoft.Json.JsonProperty("PORC_UTILI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? PORC_UTILI { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA22", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA22 { get; set; }

    [Newtonsoft.Json.JsonProperty("DESVIO_CIERRE_PEDIDOS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? DESVIO_CIERRE_PEDIDOS { get; set; }

    [Newtonsoft.Json.JsonProperty("DESCARGA_NEGATIVO_VENTAS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? DESCARGA_NEGATIVO_VENTAS { get; set; }

    [Newtonsoft.Json.JsonProperty("REMITIBLE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? REMITIBLE { get; set; }

    [Newtonsoft.Json.JsonProperty("FACT_IMPOR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? FACT_IMPOR { get; set; }

    [Newtonsoft.Json.JsonProperty("PORC_DESVI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? PORC_DESVI { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_CTRPRE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? USA_CTRPRE { get; set; }

    [Newtonsoft.Json.JsonProperty("AFECTA_AF", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? AFECTA_AF { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_BIEN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_BIEN { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_STA115", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_STA115 { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_STA32_ESCALA_1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_STA32_ESCALA_1 { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_STA32_ESCALA_2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_STA32_ESCALA_2 { get; set; }

    [Newtonsoft.Json.JsonProperty("TIPO_PROMO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? TIPO_PROMO { get; set; }

    [Newtonsoft.Json.JsonProperty("PROMODESDE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? PROMODESDE { get; set; }

    [Newtonsoft.Json.JsonProperty("PROMOHASTA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? PROMOHASTA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_MEDIDA_STOCK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_MEDIDA_STOCK { get; set; }

    [Newtonsoft.Json.JsonProperty("STOCK_MAXI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? STOCK_MAXI { get; set; }

    [Newtonsoft.Json.JsonProperty("STOCK_MINI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? STOCK_MINI { get; set; }

    [Newtonsoft.Json.JsonProperty("PTO_PEDIDO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? PTO_PEDIDO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_MEDIDA_STOCK_2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_MEDIDA_STOCK_2 { get; set; }

    [Newtonsoft.Json.JsonProperty("EQUIVALENCIA_STOCK_2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? EQUIVALENCIA_STOCK_2 { get; set; }

    [Newtonsoft.Json.JsonProperty("RELACION_UNIDADES_STOCK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? RELACION_UNIDADES_STOCK { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_CONTROL_UNIDADES_STOCK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? USA_CONTROL_UNIDADES_STOCK { get; set; }

    [Newtonsoft.Json.JsonProperty("DESVIO_CONTROL_UNIDADES_STOCK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? DESVIO_CONTROL_UNIDADES_STOCK { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_MEDIDA_VENTAS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_MEDIDA_VENTAS { get; set; }

    [Newtonsoft.Json.JsonProperty("EQUIVALE_V", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? EQUIVALE_V { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA41_COD_IVA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA41_COD_IVA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA41_COD_S_IVA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA41_COD_S_IVA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA41_COD_II", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA41_COD_II { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPUESTO_I", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? IMPUESTO_I { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA41_COD_S_II", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA41_COD_S_II { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA41_COD_II_V_2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA41_COD_II_V_2 { get; set; }

    [Newtonsoft.Json.JsonProperty("IMP_II_V_2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? IMP_II_V_2 { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA41_COD_SII_V2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA41_COD_SII_V2 { get; set; }

    [Newtonsoft.Json.JsonProperty("GEN_IB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? GEN_IB { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA41_COD_IB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA41_COD_IB { get; set; }

    [Newtonsoft.Json.JsonProperty("GEN_IB3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? GEN_IB3 { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA41_COD_IB3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA41_COD_IB3 { get; set; }

    [Newtonsoft.Json.JsonProperty("PERC_NO_CA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? PERC_NO_CA { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA41_ALI_NO_CAT", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA41_ALI_NO_CAT { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CPA14_COD_IVA_CO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CPA14_COD_IVA_CO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CPA14_COD_S_IV_C", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CPA14_COD_S_IV_C { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CPA14_COD_II_CO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CPA14_COD_II_CO { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPUEST_IC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? IMPUEST_IC { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CPA14_COD_S_II_C", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CPA14_COD_S_II_C { get; set; }

    [Newtonsoft.Json.JsonProperty("GENERACOT", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? GENERACOT { get; set; }

    [Newtonsoft.Json.JsonProperty("PRODUCTO_TERMINADO_COT", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? PRODUCTO_TERMINADO_COT { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA125", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA125 { get; set; }

    [Newtonsoft.Json.JsonProperty("RENTA_UM_S", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? RENTA_UM_S { get; set; }

    [Newtonsoft.Json.JsonProperty("RENTA_EQ_S", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? RENTA_EQ_S { get; set; }

    [Newtonsoft.Json.JsonProperty("RENTA_UM_V", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? RENTA_UM_V { get; set; }

    [Newtonsoft.Json.JsonProperty("RENTA_EQ_V", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? RENTA_EQ_V { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_UNIDAD_MEDIDA_AFIP_UM_S", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_UNIDAD_MEDIDA_AFIP_UM_S { get; set; }

    [Newtonsoft.Json.JsonProperty("AFIP_EQ_S", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? AFIP_EQ_S { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_UNIDAD_MEDIDA_AFIP_UM_V", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_UNIDAD_MEDIDA_AFIP_UM_V { get; set; }

    [Newtonsoft.Json.JsonProperty("AFIP_EQ_V", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? AFIP_EQ_V { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_NCM", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(11)]
    public string? COD_NCM { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_UNIDAD_MEDIDA_AFIP_UMEX_S", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_UNIDAD_MEDIDA_AFIP_UMEX_S { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_UNIDAD_MEDIDA_AFIP_UMEX_V", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_UNIDAD_MEDIDA_AFIP_UMEX_V { get; set; }

    [Newtonsoft.Json.JsonProperty("AFIP_UMEX_S", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? AFIP_UMEX_S { get; set; }

    [Newtonsoft.Json.JsonProperty("AFIP_UMEX_V", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? AFIP_UMEX_V { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_ITEM_AFIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_ITEM_AFIP { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CODIGO_ITEM_TURISMO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CODIGO_ITEM_TURISMO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_TIPO_UNIDAD_TURISMO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_TIPO_UNIDAD_TURISMO { get; set; }

    [Newtonsoft.Json.JsonProperty("CL_SIAP_GV", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(3)]
    public string? CL_SIAP_GV { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CLASIFICACION_SIAP_CL_SIAP_GV", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CLASIFICACION_SIAP_CL_SIAP_GV { get; set; }

    [Newtonsoft.Json.JsonProperty("CL_SIAP_CP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(3)]
    public string? CL_SIAP_CP { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_CLASIFICACION_SIAP_CL_SIAP_CP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_CLASIFICACION_SIAP_CL_SIAP_CP { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_ACTIVIDAD_DGI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_ACTIVIDAD_DGI { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_MODELO_PERCEPCION_VENTAS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_MODELO_PERCEPCION_VENTAS { get; set; }

    [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(8000)]
    public string? OBSERVACIONES { get; set; }

    [Newtonsoft.Json.JsonProperty("ALI_NO_CAT", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ALI_NO_CAT { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_ACTIVI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_ACTIVI { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_IB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_IB { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_IB3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_IB3 { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_II", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_II { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_II_CO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_II_CO { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_IVA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_IVA { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_IVA_CO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_IVA_CO { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_S_II", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_S_II { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_S_II_C", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_S_II_C { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_S_IVA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_S_IVA { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_S_IV_C", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_S_IV_C { get; set; }

    [Newtonsoft.Json.JsonProperty("CTA_COMPRA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? CTA_COMPRA { get; set; }

    [Newtonsoft.Json.JsonProperty("CTA_VENTAS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? CTA_VENTAS { get; set; }

    [Newtonsoft.Json.JsonProperty("CTO_COMPRA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? CTO_COMPRA { get; set; }

    [Newtonsoft.Json.JsonProperty("CTO_VENTAS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? CTO_VENTAS { get; set; }

    [Newtonsoft.Json.JsonProperty("DESTI_ART", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? DESTI_ART { get; set; }

    [Newtonsoft.Json.JsonProperty("ESCALA_1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(2)]
    public string? ESCALA_1 { get; set; }

    [Newtonsoft.Json.JsonProperty("ESCALA_2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(2)]
    public string? ESCALA_2 { get; set; }

    [Newtonsoft.Json.JsonProperty("RET_RNI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? RET_RNI { get; set; }

    [Newtonsoft.Json.JsonProperty("RET_RNI_CO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? RET_RNI_CO { get; set; }

    [Newtonsoft.Json.JsonProperty("RENTA_PROD", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(6)]
    public string? RENTA_PROD { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_II_V_2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_II_V_2 { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_SII_V2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? COD_SII_V2 { get; set; }

    [Newtonsoft.Json.JsonProperty("BASE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? BASE { get; set; }

    [Newtonsoft.Json.JsonProperty("VALOR1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? VALOR1 { get; set; }

    [Newtonsoft.Json.JsonProperty("VALOR2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? VALOR2 { get; set; }

    [Newtonsoft.Json.JsonProperty("AFIP_UM_S", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? AFIP_UM_S { get; set; }

    [Newtonsoft.Json.JsonProperty("AFIP_UM_V", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? AFIP_UM_V { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_PLANTI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? COD_PLANTI { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_TIPOB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? COD_TIPOB { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_MEDIDA_CONTROL_STOCK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_MEDIDA_CONTROL_STOCK { get; set; }

    [Newtonsoft.Json.JsonProperty("SERIE_DESC_ADICIONAL_1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(25)]
    public string? SERIE_DESC_ADICIONAL_1 { get; set; }

    [Newtonsoft.Json.JsonProperty("SERIE_DESC_ADICIONAL_2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(25)]
    public string? SERIE_DESC_ADICIONAL_2 { get; set; }

    [Newtonsoft.Json.JsonProperty("PUBLICA_WEB_PEDIDO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? PUBLICA_WEB_PEDIDO { get; set; }

    [Newtonsoft.Json.JsonProperty("SINCRONIZA_WEB_PEDIDO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? SINCRONIZA_WEB_PEDIDO { get; set; }

    [Newtonsoft.Json.JsonProperty("FILLER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? FILLER { get; set; }

    [Newtonsoft.Json.JsonProperty("ADMITE_VENTA_FRACCIONADA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? ADMITE_VENTA_FRACCIONADA { get; set; }

    [Newtonsoft.Json.JsonProperty("CONTROL_STOCK_NOTMAPPED", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CONTROL_STOCK_NOTMAPPED { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_STA11_DEFECTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_STA11_DEFECTO { get; set; }

    [Newtonsoft.Json.JsonProperty("ACTUALIZAR_PRECIOS_COMBINACIONES", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool ACTUALIZAR_PRECIOS_COMBINACIONES { get; set; }

    [Newtonsoft.Json.JsonProperty("PRECIO_MODIFICADO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool PRECIO_MODIFICADO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_STA11_DEFECTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_STA11_DEFECTO { get; set; }

    [Newtonsoft.Json.JsonProperty("DECIMALES_GVA17", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? DECIMALES_GVA17 { get; set; }

    [Newtonsoft.Json.JsonProperty("STA_ARTICULO_UNIDAD_COMPRA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<STA_ARTICULO_UNIDAD_COMPRA>? STA_ARTICULO_UNIDAD_COMPRA { get; set; }

    [Newtonsoft.Json.JsonProperty("CTA_ARTICULO_POR_SUCURSAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<CTA_ARTICULO_POR_SUCURSAL>? CTA_ARTICULO_POR_SUCURSAL { get; set; }

    [Newtonsoft.Json.JsonProperty("GVA17", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<GVA17>? GVA17 { get; set; }

    [Newtonsoft.Json.JsonProperty("GVA11", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<GVA11>? GVA11 { get; set; }

    [Newtonsoft.Json.JsonProperty("CPA15", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<CPA15>? CPA15 { get; set; }

    [Newtonsoft.Json.JsonProperty("STA83", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<STA83>? STA83 { get; set; }




}




[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class STA_ARTICULO_UNIDAD_COMPRA
{
    [Newtonsoft.Json.JsonProperty("ID_MEDIDA_COMPRA", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ID_MEDIDA_COMPRA { get; set; }

    [Newtonsoft.Json.JsonProperty("EQUIVALENCIA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? EQUIVALENCIA { get; set; }

    [Newtonsoft.Json.JsonProperty("HABITUAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? HABITUAL { get; set; }

    [Newtonsoft.Json.JsonProperty("FILLER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? FILLER { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class CTA_ARTICULO_POR_SUCURSAL
{
    [Newtonsoft.Json.JsonProperty("FILLER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? FILLER { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_SUCURSAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_SUCURSAL { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_STA11", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(17)]
    public string? COD_STA11 { get; set; }

    [Newtonsoft.Json.JsonProperty("CTA_COMPRA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? CTA_COMPRA { get; set; }

    [Newtonsoft.Json.JsonProperty("CTA_VENTAS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? CTA_VENTAS { get; set; }

    [Newtonsoft.Json.JsonProperty("CTO_COMPRA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? CTO_COMPRA { get; set; }

    [Newtonsoft.Json.JsonProperty("CTO_VENTAS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? CTO_VENTAS { get; set; }

    [Newtonsoft.Json.JsonProperty("STOCK_MAXIMO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? STOCK_MAXIMO { get; set; }

    [Newtonsoft.Json.JsonProperty("STOCK_MINIMO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? STOCK_MINIMO { get; set; }

    [Newtonsoft.Json.JsonProperty("PUNTO_DE_PEDIDO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? PUNTO_DE_PEDIDO { get; set; }

    [Newtonsoft.Json.JsonProperty("IMPRIME", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? IMPRIME { get; set; }

    [Newtonsoft.Json.JsonProperty("MODALIDAD_DESCARGA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? MODALIDAD_DESCARGA { get; set; }

    [Newtonsoft.Json.JsonProperty("BAJA_STK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(2)]
    public string? BAJA_STK { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_DEPOSITO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(2)]
    public string? COD_DEPOSITO { get; set; }

    [Newtonsoft.Json.JsonProperty("FAVORITO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? FAVORITO { get; set; }

    [Newtonsoft.Json.JsonProperty("PROMODESDE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? PROMODESDE { get; set; }

    [Newtonsoft.Json.JsonProperty("PROMOHASTA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? PROMOHASTA { get; set; }

    [Newtonsoft.Json.JsonProperty("PERFIL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? PERFIL { get; set; }

    [Newtonsoft.Json.JsonProperty("CARGA_RAPIDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? CARGA_RAPIDA { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class GVA17
{
    [Newtonsoft.Json.JsonProperty("NRO_DE_LIS", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int NRO_DE_LIS { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_ARTICU", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? COD_ARTICU { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_GVA10", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA10 { get; set; }

    [Newtonsoft.Json.JsonProperty("PRECIO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? PRECIO { get; set; }

    [Newtonsoft.Json.JsonProperty("BASE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? BASE { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_MAESTRO_GVA17", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ID_MAESTRO_GVA17 { get; set; }

    [Newtonsoft.Json.JsonProperty("FILLER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? FILLER { get; set; }

    [Newtonsoft.Json.JsonProperty("GVA13", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<GVA13>? GVA13 { get; set; }

    [Newtonsoft.Json.JsonProperty("TRA100", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<TRA100>? TRA100 { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class GVA13
{
    [Newtonsoft.Json.JsonProperty("ID_GVA14", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ID_GVA14 { get; set; }

    [Newtonsoft.Json.JsonProperty("FILLER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? FILLER { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_ARTICU", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? COD_ARTICU { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_CLIENT", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(6)]
    public string? COD_CLIENT { get; set; }

    [Newtonsoft.Json.JsonProperty("NRO_LISTA", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int NRO_LISTA { get; set; }

    [Newtonsoft.Json.JsonProperty("PRECIO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? PRECIO { get; set; }

    [Newtonsoft.Json.JsonProperty("ACTUALIZADO_EN_ACT_GLOBAL", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool ACTUALIZADO_EN_ACT_GLOBAL { get; set; }

    [Newtonsoft.Json.JsonProperty("PRECIO_ANTERIOR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? PRECIO_ANTERIOR { get; set; }

    [Newtonsoft.Json.JsonProperty("PROCESO_MODIFICADOR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? PROCESO_MODIFICADOR { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class TRA100
{
    [Newtonsoft.Json.JsonProperty("ID_STA11_COD_INSUMO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ID_STA11_COD_INSUMO { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_STA11_COD_ARTICU", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ID_STA11_COD_ARTICU { get; set; }

    [Newtonsoft.Json.JsonProperty("PRECIO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? PRECIO { get; set; }

    [Newtonsoft.Json.JsonProperty("FILLER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? FILLER { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_ARTICU", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? COD_ARTICU { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_INSUMO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? COD_INSUMO { get; set; }

    [Newtonsoft.Json.JsonProperty("NRO_LISTA", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int NRO_LISTA { get; set; }

    [Newtonsoft.Json.JsonProperty("ACTUALIZADO_EN_ACT_GLOBAL", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool ACTUALIZADO_EN_ACT_GLOBAL { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class GVA11
{
    [Newtonsoft.Json.JsonProperty("ID_GVA14", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_GVA14 { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_GVA14_CLIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? COD_GVA14_CLIENTE { get; set; }

    [Newtonsoft.Json.JsonProperty("BONIF", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? BONIF { get; set; }

    [Newtonsoft.Json.JsonProperty("SINONIMO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? SINONIMO { get; set; }

    [Newtonsoft.Json.JsonProperty("DESC_SINON", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? DESC_SINON { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_ARTICU", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? COD_ARTICU { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_CLIENT", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(6)]
    public string? COD_CLIENT { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class CPA15
{
    [Newtonsoft.Json.JsonProperty("ID_CPA01", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ID_CPA01 { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_CPA01_PROVEEDOR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_CPA01_PROVEEDOR { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_PROVEE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_PROVEE { get; set; }

    [Newtonsoft.Json.JsonProperty("PROV_HABITUAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? PROV_HABITUAL { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_ARTICU", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_ARTICU { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_SINONI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? COD_SINONI { get; set; }

    [Newtonsoft.Json.JsonProperty("USA_ESC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? USA_ESC { get; set; }

    [Newtonsoft.Json.JsonProperty("TIPO_COD", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? TIPO_COD { get; set; }

    [Newtonsoft.Json.JsonProperty("CODART_XML", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(35)]
    public string? CODART_XML { get; set; }

    [Newtonsoft.Json.JsonProperty("DESCR_XML", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(80)]
    public string? DESCR_XML { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_MEDIDA_COMPRA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_MEDIDA_COMPRA { get; set; }

    [Newtonsoft.Json.JsonProperty("UNIDAD_MEDIDA_SELECCIONADA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1)]
    public string? UNIDAD_MEDIDA_SELECCIONADA { get; set; }

    [Newtonsoft.Json.JsonProperty("SINONIMO_MEDIDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(25)]
    public string? SINONIMO_MEDIDA { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class STA83
{
    [Newtonsoft.Json.JsonProperty("COD_ARTICU", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(15)]
    public string? COD_ARTICU { get; set; }

    [Newtonsoft.Json.JsonProperty("FILLER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? FILLER { get; set; }

    [Newtonsoft.Json.JsonProperty("NRO_RENGL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? NRO_RENGL { get; set; }

    [Newtonsoft.Json.JsonProperty("TEXTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(200)]
    public string? TEXTO { get; set; }
}

