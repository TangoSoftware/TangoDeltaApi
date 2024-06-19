using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.stock.Articulo.Model;

public class ArticuloQueryRecord : BaseQueryRecord
{
    [JsonProperty("COD_STA11")]
    public string? CodSta11 { get; set; }

    [JsonProperty("DESCRIPCIO")]
    public string? Descripcio { get; set; }

    [JsonProperty("SINONIMO")]
    public string? Sinonimo { get; set; }

    [JsonProperty("COD_BARRA")]
    public string? CodBarra { get; set; }

    [JsonProperty("FECHA_ALTA")]
    public DateTime? FechaAlta { get; set; }

    [JsonProperty("FAMILIA")]
    public string? Familia { get; set; }

    [JsonProperty("GRUPO")]
    public string? Grupo { get; set; }

    [JsonProperty("COMENTARIOS")]
    public string? Comentarios { get; set; }

    [JsonProperty("CLASIFICACION")]
    public string? Clasificacion { get; set; }

    [JsonProperty("ID_STA11")]
    public int IdSta11 { get; set; }

    [JsonProperty("PROMO_MENU")]
    public string? PromoMenu { get; set; }

    [JsonProperty("USA_ESC")]
    public string? UsaEsc { get; set; }

    [JsonProperty("DESC_ADIC")]
    public string? DescAdic { get; set; }

    [JsonProperty("PERFIL")]
    public string? Perfil { get; set; }

    [JsonProperty("STOCK")]
    public bool Stock { get; set; }

    [JsonProperty("LLEVA_DOBLE_UNIDAD_MEDIDA")]
    public bool LlevaDobleUnidadMedida { get; set; }

    [JsonProperty("USA_PARTID")]
    public bool UsaPartid { get; set; }

    [JsonProperty("DESCARGA_NEGATIVO_STOCK")]
    public bool DescargaNegativoStock { get; set; }

    [JsonProperty("MET_DES_PA")]
    public string? MetDesPa { get; set; }

    [JsonProperty("ORD_DES_PA")]
    public string? OrdDesPa { get; set; }

    [JsonProperty("EGRESO_MODIFICA_PARTIDA_PROPUESTA")]
    public string? EgresoModificaPartidaPropuesta { get; set; }

    [JsonProperty("USA_SERIE")]
    public bool UsaSerie { get; set; }

    [JsonProperty("USA_SCRAP")]
    public bool UsaScrap { get; set; }

    [JsonProperty("PORC_SCRAP")]
    public long PorcScrap { get; set; }

    [JsonProperty("COMISION_V")]
    public long ComisionV { get; set; }

    [JsonProperty("DESCUENTO")]
    public long Descuento { get; set; }

    [JsonProperty("PORC_UTILI")]
    public long PorcUtili { get; set; }

    [JsonProperty("DESVIO_CIERRE_PEDIDOS")]
    public long DesvioCierrePedidos { get; set; }

    [JsonProperty("DESCARGA_NEGATIVO_VENTAS")]
    public bool DescargaNegativoVentas { get; set; }

    [JsonProperty("REMITIBLE")]
    public string? Remitible { get; set; }

    [JsonProperty("FACT_IMPOR")]
    public bool FactImpor { get; set; }

    [JsonProperty("PORC_DESVI")]
    public long PorcDesvi { get; set; }

    [JsonProperty("USA_CTRPRE")]
    public bool UsaCtrpre { get; set; }

    [JsonProperty("AFECTA_AF")]
    public bool AfectaAf { get; set; }

    [JsonProperty("TIPO_PROMO")]
    public string? TipoPromo { get; set; }

    [JsonProperty("PROMODESDE")]
    public string? Promodesde { get; set; }

    [JsonProperty("PROMOHASTA")]
    public string? Promohasta { get; set; }

    [JsonProperty("STOCK_MAXI")]
    public decimal StockMaxi { get; set; }

    [JsonProperty("STOCK_MINI")]
    public decimal StockMini { get; set; }

    [JsonProperty("PTO_PEDIDO")]
    public decimal PtoPedido { get; set; }

    [JsonProperty("EQUIVALENCIA_STOCK_2")]
    public decimal EquivalenciaStock2 { get; set; }

    [JsonProperty("RELACION_UNIDADES_STOCK")]
    public string? RelacionUnidadesStock { get; set; }

    [JsonProperty("USA_CONTROL_UNIDADES_STOCK")]
    public bool UsaControlUnidadesStock { get; set; }

    [JsonProperty("DESVIO_CONTROL_UNIDADES_STOCK")]
    public decimal DesvioControlUnidadesStock { get; set; }

    [JsonProperty("EQUIVALE_V")]
    public decimal EquivaleV { get; set; }

    [JsonProperty("IMPUESTO_I")]
    public decimal ImpuestoI { get; set; }

    [JsonProperty("IMP_II_V_2")]
    public decimal ImpIiV2 { get; set; }

    [JsonProperty("GEN_IB")]
    public bool GenIb { get; set; }

    [JsonProperty("GEN_IB3")]
    public bool GenIb3 { get; set; }

    [JsonProperty("PERC_NO_CA")]
    public bool PercNoCa { get; set; }

    [JsonProperty("IMPUEST_IC")]
    public decimal ImpuestIc { get; set; }

    [JsonProperty("GENERACOT")]
    public bool Generacot { get; set; }

    [JsonProperty("PRODUCTO_TERMINADO_COT")]
    public string? ProductoTerminadoCot { get; set; }

    [JsonProperty("RENTA_UM_S")]
    public string? RentaUmS { get; set; }

    [JsonProperty("RENTA_EQ_S")]
    public decimal RentaEqS { get; set; }

    [JsonProperty("RENTA_UM_V")]
    public string? RentaUmV { get; set; }

    [JsonProperty("RENTA_EQ_V")]
    public decimal RentaEqV { get; set; }

    [JsonProperty("AFIP_EQ_S")]
    public decimal AfipEqS { get; set; }

    [JsonProperty("AFIP_EQ_V")]
    public decimal AfipEqV { get; set; }

    [JsonProperty("COD_NCM")]
    public string? CodNcm { get; set; }

    [JsonProperty("NOMBRE_TYP")]
    public string? NombreTyp { get; set; }

    [JsonProperty("DESC_TYPS")]
    public string? DescTyps { get; set; }

    [JsonProperty("STA11_BASE_COD_STA11")]
    public string? Sta11BaseCodSta11 { get; set; }

    [JsonProperty("STA11_BASE_DESCRIPCIO")]
    public string? Sta11BaseDescripcio { get; set; }

    [JsonProperty("STA32_ESCALA1_COD")]
    public string? Sta32Escala1Cod { get; set; }

    [JsonProperty("STA32_ESCALA1_DESCRIP")]
    public string? Sta32Escala1Descrip { get; set; }

    [JsonProperty("STA32_ESCALA2_COD")]
    public string? Sta32Escala2Cod { get; set; }

    [JsonProperty("STA32_ESCALA2_DESCRIP")]
    public string? Sta32Escala2Descrip { get; set; }

    [JsonProperty("COD_ACTIVI")]
    public int? CodActivi { get; set; }

    [JsonProperty("DESC_ACTIV")]
    public string? DescActiv { get; set; }

    [JsonProperty("COD_PLANTI")]
    public string? CodPlanti { get; set; }

    [JsonProperty("DES_PLANTI")]
    public string? DesPlanti { get; set; }

    [JsonProperty("STA33_VALOR1_COD")]
    public string? Sta33Valor1Cod { get; set; }

    [JsonProperty("STA33_VALOR1_DESC")]
    public string? Sta33Valor1Desc { get; set; }

    [JsonProperty("STA33_VALOR2_COD")]
    public string? Sta33Valor2Cod { get; set; }

    [JsonProperty("STA33_VALOR2_DESC")]
    public string? Sta33Valor2Desc { get; set; }

    [JsonProperty("MEDIDA_STOCK_CODIGO")]
    public string? MedidaStockCodigo { get; set; }

    [JsonProperty("MEDIDA_STOCK_DESCRIPCION")]
    public string? MedidaStockDescripcion { get; set; }

    [JsonProperty("MEDIDA_STOCK2_CODIGO")]
    public string? MedidaStock2Codigo { get; set; }

    [JsonProperty("MEDIDA_STOCK2_DESCRIPCION")]
    public string? MedidaStock2Descripcion { get; set; }

    [JsonProperty("MEDIDA_STOCK_SIGLA")]
    public string? MedidaStockSigla { get; set; }

    [JsonProperty("MEDIDA_STOCK_CONTROL")]
    public string? MedidaStockControl { get; set; }

    [JsonProperty("MEDIDA_STOCK2_SIGLA")]
    public string? MedidaStock2Sigla { get; set; }

    [JsonProperty("MEDIDA_VENTAS_CODIGO")]
    public string? MedidaVentasCodigo { get; set; }

    [JsonProperty("MEDIDA_VENTAS_DESCRIPCION")]
    public string? MedidaVentasDescripcion { get; set; }

    [JsonProperty("COD_UNIDAD_MEDIDA_AFIP_UMEX_S")]
    public int? CodUnidadMedidaAfipUmexS { get; set; }

    [JsonProperty("DESC_UNIDAD_MEDIDA_AFIP_UMEX_S")]
    public string? DescUnidadMedidaAfipUmexS { get; set; }

    [JsonProperty("COD_UNIDAD_MEDIDA_AFIP_UMEX_V")]
    public long? CodUnidadMedidaAfipUmexV { get; set; }

    [JsonProperty("DESC_UNIDAD_MEDIDA_AFIP_UMEX_V")]
    public string? DescUnidadMedidaAfipUmexV { get; set; }

    [JsonProperty("COD_UNIDAD_MEDIDA_AFIP_UM_S")]
    public long? CodUnidadMedidaAfipUmS { get; set; }

    [JsonProperty("DESC_UNIDAD_MEDIDA_AFIP_UM_S")]
    public string? DescUnidadMedidaAfipUmS { get; set; }

    [JsonProperty("COD_UNIDAD_MEDIDA_AFIP_UM_V")]
    public long? CodUnidadMedidaAfipUmV { get; set; }

    [JsonProperty("DESC_UNIDAD_MEDIDA_AFIP_UM_V")]
    public string? DescUnidadMedidaAfipUmV { get; set; }

    [JsonProperty("GVA41_COD_IVA")]
    public int? Gva41CodIva { get; set; }

    [JsonProperty("GVA41_DESC_IVA")]
    public string? Gva41DescIva { get; set; }

    [JsonProperty("GVA41_COD_S_IVA")]
    public long? Gva41CodSIva { get; set; }

    [JsonProperty("GVA41_DESC_S_IVA")]
    public string? Gva41DescSIva { get; set; }

    [JsonProperty("GVA41_COD_II")]
    public long? Gva41CodIi { get; set; }

    [JsonProperty("GVA41_DESC_II")]
    public string? Gva41DescIi { get; set; }

    [JsonProperty("GVA41_COD_S_II")]
    public long? Gva41CodSIi { get; set; }

    [JsonProperty("GVA41_DESC_S_II")]
    public string? Gva41DescSIi { get; set; }

    [JsonProperty("GVA41_COD_II_V_2")]
    public string? Gva41CodIiV2 { get; set; }

    [JsonProperty("GVA41_DESC_II_V_2")]
    public string? Gva41DescIiV2 { get; set; }

    [JsonProperty("GVA41_COD_SII_V2")]
    public string? Gva41CodSiiV2 { get; set; }

    [JsonProperty("GVA41_DESC_SII_V2")]
    public string? Gva41DescSiiV2 { get; set; }

    [JsonProperty("GVA41_COD_IB")]
    public long? Gva41CodIb { get; set; }

    [JsonProperty("GVA41_DESC_IB")]
    public string? Gva41DescIb { get; set; }

    [JsonProperty("GVA41_COD_IB3")]
    public string? Gva41CodIb3 { get; set; }

    [JsonProperty("GVA41_DESC_IB3")]
    public string? Gva41DescIb3 { get; set; }

    [JsonProperty("GVA41_COD_ALI_NO_CAT")]
    public string? Gva41CodAliNoCat { get; set; }

    [JsonProperty("COD_MODELO_PERCEPCION_VENTAS")]
    public string? CodModeloPercepcionVentas { get; set; }

    [JsonProperty("DESCRIPCION_MVP")]
    public string? DescripcionMvp { get; set; }

    [JsonProperty("GVA41_DESC_ALI_NO_CAT")]
    public string? Gva41DescAliNoCat { get; set; }

    [JsonProperty("CPA14_COD_IVA_CO")]
    public int? Cpa14CodIvaCo { get; set; }

    [JsonProperty("CPA14_DESC_IVA_CO")]
    public string? Cpa14DescIvaCo { get; set; }

    [JsonProperty("CPA14_COD_S_IV_C")]
    public int? Cpa14CodSIvC { get; set; }

    [JsonProperty("CPA14_DESC_S_IV_C")]
    public string? Cpa14DescSIvC { get; set; }

    [JsonProperty("CPA14_COD_II_CO")]
    public long? Cpa14CodIiCo { get; set; }

    [JsonProperty("CPA14_DESC_II_CO")]
    public string? Cpa14DescIiCo { get; set; }

    [JsonProperty("CPA14_COD_S_II_C")]
    public string? Cpa14CodSIiC { get; set; }

    [JsonProperty("CPA14_DESC_S_II_C")]
    public string? Cpa14DescSIiC { get; set; }

    [JsonProperty("TIPO_ITEM_AFIP_CODIGO")]
    public string? TipoItemAfipCodigo { get; set; }

    [JsonProperty("TIPO_ITEM_AFIP_DESCRIPCION")]
    public string? TipoItemAfipDescripcion { get; set; }

    [JsonProperty("CODIGO_ITEM_TURISMO_CODIGO")]
    public string? CodigoItemTurismoCodigo { get; set; }

    [JsonProperty("CODIGO_ITEM_TURISMO_DESCRIPCION")]
    public string? CodigoItemTurismoDescripcion { get; set; }

    [JsonProperty("GVA125_RENTA_PROD")]
    public string? Gva125RentaProd { get; set; }

    [JsonProperty("GVA125_DESCRIPCION")]
    public string? Gva125Descripcion { get; set; }

    [JsonProperty("TIPO_UNIDAD_TURISMO_CODIGO")]
    public string? TipoUnidadTurismoCodigo { get; set; }

    [JsonProperty("TIPO_UNIDAD_TURISMO_DESCRIPCION")]
    public string? TipoUnidadTurismoDescripcion { get; set; }

    [JsonProperty("COD_ACTIVIDAD_DGI")]
    public string? CodActividadDgi { get; set; }

    [JsonProperty("DESC_ACTIVIDAD_DGI")]
    public string? DescActividadDgi { get; set; }

    [JsonProperty("CLASIFICACION_SIAP_GV_CODIGO")]
    public string? ClasificacionSiapGvCodigo { get; set; }

    [JsonProperty("CLASIFICACION_SIAP_GV_DESCRIPCION")]
    public string? ClasificacionSiapGvDescripcion { get; set; }

    [JsonProperty("CLASIFICACION_SIAP_CP_CODIGO")]
    public string? ClasificacionSiapCpCodigo { get; set; }

    [JsonProperty("CLASIFICACION_SIAP_CP_DESCRIPCION")]
    public string? ClasificacionSiapCpDescripcion { get; set; }

    [JsonProperty("COD_TIPO_BIEN")]
    public string? CodTipoBien { get; set; }

    [JsonProperty("DESC_TIPO_BIEN")]
    public string? DescTipoBien { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("ADMITE_VENTA_FRACCIONADA")]
    public bool AdmiteVentaFraccionada { get; set; }

}