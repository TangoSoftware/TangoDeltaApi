using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;
using System.ComponentModel.DataAnnotations;

namespace TangoDeltaApi.CommonServices.Pedidos.Model;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class PedidoData : BaseData
{
    [JsonProperty("ID_GVA21", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int ID_GVA21 { get; set; }

    [JsonProperty("ID_GVA43_TALON_PED", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA43_TALON_PED { get; set; }

    [JsonProperty("NRO_PEDIDO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(14)]
    public string? NRO_PEDIDO { get; set; }

    [JsonProperty("ESTADO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ESTADO { get; set; }

    [JsonProperty("FECHA_PEDIDO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? FECHA_PEDIDO { get; set; }

    [JsonProperty("ID_GVA14", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA14 { get; set; }

    [JsonProperty("ES_CLIENTE_HABITUAL", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ES_CLIENTE_HABITUAL { get; set; }

    [JsonProperty("ID_GVA01", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA01 { get; set; }

    [JsonProperty("ID_GVA23", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA23 { get; set; }

    [JsonProperty("ID_STA22", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_STA22 { get; set; }

    [JsonProperty("ID_GVA24", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA24 { get; set; }

    [JsonProperty("ID_MONEDA", Required = Required.Always)]
    public int ID_MONEDA { get; set; }

    [JsonProperty("COTIZACION", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public decimal? COTIZACION { get; set; }

    [JsonProperty("ID_GVA10", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA10 { get; set; }

    [JsonProperty("ID_DIRECCION_ENTREGA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_DIRECCION_ENTREGA { get; set; }

    [JsonProperty("FECHA_ENTREGA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? FECHA_ENTREGA { get; set; }

    [JsonProperty("ID_ASIENTO_MODELO_GV", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_ASIENTO_MODELO_GV { get; set; }

    [JsonProperty("ID_GVA81", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA81 { get; set; }

    [JsonProperty("ID_GVA43_TALONARIO_FACTURA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA43_TALONARIO_FACTURA { get; set; }

    [JsonProperty("NRO_ORDEN_COMPRA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(18)]
    public string? NRO_ORDEN_COMPRA { get; set; }

    [JsonProperty("FECHA_ORDEN_COMPRA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? FECHA_ORDEN_COMPRA { get; set; }

    [JsonProperty("ID_SUCURSAL_DESTINO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_SUCURSAL_DESTINO { get; set; }

    [JsonProperty("COMPROMETE_STOCK", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? COMPROMETE_STOCK { get; set; }

    [JsonProperty("ID_ACTIVIDAD_EMPRESA_AFIP", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_ACTIVIDAD_EMPRESA_AFIP { get; set; }

    [JsonProperty("ACTIVIDAD_COMPROBANTE_AFIP", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(1)]
    public string? ACTIVIDAD_COMPROBANTE_AFIP { get; set; }

    [JsonProperty("ID_TIPO_DOCUMENTO_GV", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_TIPO_DOCUMENTO_GV { get; set; }

    [JsonProperty("NUMERO_DOCUMENTO_PAGADOR", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(20)]
    public string? NUMERO_DOCUMENTO_PAGADOR { get; set; }

    [JsonProperty("LEYENDA_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(60)]
    public string? LEYENDA_1 { get; set; }

    [JsonProperty("LEYENDA_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(60)]
    public string? LEYENDA_2 { get; set; }

    [JsonProperty("LEYENDA_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(60)]
    public string? LEYENDA_3 { get; set; }

    [JsonProperty("LEYENDA_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(60)]
    public string? LEYENDA_4 { get; set; }

    [JsonProperty("LEYENDA_5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(60)]
    public string? LEYENDA_5 { get; set; }

    [JsonProperty("PORCENTAJE_DESCUENTO_GENERAL", Required = Required.Always)]
    public decimal PORCENTAJE_DESCUENTO_GENERAL { get; set; }

    [JsonProperty("IMPORTE_DESCUENTO_GENERAL", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public decimal IMPORTE_DESCUENTO_GENERAL { get; set; }

    [JsonProperty("PORCENTAJE_RECARGO_GENERAL", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public decimal PORCENTAJE_RECARGO_GENERAL { get; set; }

    [JsonProperty("IMPORTE_RECARGO_GENERAL", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public decimal IMPORTE_RECARGO_GENERAL { get; set; }

    [JsonProperty("APLICA_DESCUENTO_CLIENTE", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool APLICA_DESCUENTO_CLIENTE { get; set; }

    [JsonProperty("CALCULA_PROMOCIONES", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool CALCULA_PROMOCIONES { get; set; }

    [JsonProperty("VALIDA_LIMITE_CREDITO", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool VALIDA_LIMITE_CREDITO { get; set; }

    [JsonProperty("ID_SBA01", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_SBA01 { get; set; }

    [JsonProperty("OBSERVACIONES", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(8000)]
    public string? OBSERVACIONES { get; set; }

    [JsonProperty("RENGLON_DTO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RenglonDto>? RENGLON_DTO { get; set; }

    [JsonProperty("CLIENTE_OCASIONAL_DTO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ClienteOcasionalApiDto>? CLIENTE_OCASIONAL_DTO { get; set; }

    [JsonProperty("NOTA_PEDIDO_DTO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<NotaPedidoDto>? NOTA_PEDIDO_DTO { get; set; }
}

public class ClienteOcasionalApiDto
{
    [JsonProperty("ID_TIPO_DOCUMENTO_GV", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int ID_TIPO_DOCUMENTO_GV { get; set; }

    [JsonProperty("NRO_DOCUMENTO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(20)]
    public string? NRO_DOCUMENTO { get; set; }

    [JsonProperty("RAZON_SOCIAL", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(60)]
    public string? RAZON_SOCIAL { get; set; }

    [JsonProperty("DOMICILIO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(30)]
    public string? DOMICILIO { get; set; }

    [JsonProperty("LOCALIDAD", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(20)]
    public string? LOCALIDAD { get; set; }

    [JsonProperty("CODIGO_POSTAL", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(8)]
    public string? CODIGO_POSTAL { get; set; }

    [JsonProperty("ID_GVA18_PROVINCIA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA18_PROVINCIA { get; set; }

    [JsonProperty("ACTIVIDAD", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(160)]
    public string? ACTIVIDAD { get; set; }

    [JsonProperty("ID_CATEGORIA_IVA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int ID_CATEGORIA_IVA { get; set; }

    [JsonProperty("IDENTIFICACION_TRIBUTARIA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(50)]
    public string? IDENTIFICACION_TRIBUTARIA { get; set; }

    [JsonProperty("REGIMEN_INGRESOS_BRUTOS", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(1)]
    public string? REGIMEN_INGRESOS_BRUTOS { get; set; }

    [JsonProperty("NRO_INGRESOS_BRUTOS", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(20)]
    public string? NRO_INGRESOS_BRUTOS { get; set; }

    [JsonProperty("E_MAIL", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(60)]
    public string? E_MAIL { get; set; }

    [JsonProperty("WEB_CLIENTE", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(60)]
    public string? WEB_CLIENTE { get; set; }

    [JsonProperty("NUMERO_INSCRIPCION_RG1817", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(15)]
    public string? NUMERO_INSCRIPCION_RG1817 { get; set; }

    [JsonProperty("FECHA_VENCIMIENTO_INSCRIPCION_RG1817", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? FECHA_VENCIMIENTO_INSCRIPCION_RG1817 { get; set; }

    [JsonProperty("ID_GVA41_ALICUOTA_NO_CATEGORIZADA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA41_ALICUOTA_NO_CATEGORIZADA { get; set; }

    [JsonProperty("CALCULA_PERCEPCION_IVA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CALCULA_PERCEPCION_IVA { get; set; }

    [JsonProperty("PORCENTAJE_EXCLUSION", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public decimal? PORCENTAJE_EXCLUSION { get; set; }

    [JsonProperty("LIQUIDA_IMPUESTOS_INTERNOS", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LIQUIDA_IMPUESTOS_INTERNOS { get; set; }

    [JsonProperty("DISCRIMINA_IMPUESTOS_INTERNOS", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DISCRIMINA_IMPUESTOS_INTERNOS { get; set; }

    [JsonProperty("CALCULA_PERCEPCION_IMPUESTOS_INTERNOS", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CALCULA_PERCEPCION_IMPUESTOS_INTERNOS { get; set; }

    [JsonProperty("ID_GVA41_ALICUOTA_FIJA_PERCEPCION_IIBB", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA41_ALICUOTA_FIJA_PERCEPCION_IIBB { get; set; }

    [JsonProperty("LIQUIDA_PERCEPCION_INGRESOS_BRUTOS", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LIQUIDA_PERCEPCION_INGRESOS_BRUTOS { get; set; }

    [JsonProperty("CONSIDERA_IVA_BASE_CALCULO_IIBB", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CONSIDERA_IVA_BASE_CALCULO_IIBB { get; set; }

    [JsonProperty("ID_GVA41_ALICUOTA_ADICIONAL_PERCEPCION_IIBB", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA41_ALICUOTA_ADICIONAL_PERCEPCION_IIBB { get; set; }

    [JsonProperty("CONSIDERA_IVA_BASE_CALCULO_IIBB_ADIC", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CONSIDERA_IVA_BASE_CALCULO_IIBB_ADIC { get; set; }

    [JsonProperty("LIQUIDA_PERCEPCION_INGRESOS_BRUTOS_59_98", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool LIQUIDA_PERCEPCION_INGRESOS_BRUTOS_59_98 { get; set; }

    [JsonProperty("ID_GVA41_ALICUOTA_FIJA_PERCEPCION_IIBB_59_98", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA41_ALICUOTA_FIJA_PERCEPCION_IIBB_59_98 { get; set; }

    [JsonProperty("INCLUYE_IMPUESTOS_INTERNOS", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool INCLUYE_IMPUESTOS_INTERNOS { get; set; }

    [JsonProperty("DIRECCION_ENTREGA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(200)]
    public string? DIRECCION_ENTREGA { get; set; }

    [JsonProperty("LOCALIDAD_ENTREGA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(100)]
    public string? LOCALIDAD_ENTREGA { get; set; }

    [JsonProperty("CODIGO_POSTAL_ENTREGA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(10)]
    public string? CODIGO_POSTAL_ENTREGA { get; set; }

    [JsonProperty("ID_GVA18_PROVINCIA_ENTREGA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA18_PROVINCIA_ENTREGA { get; set; }

    [JsonProperty("TELEFONO1_ENTREGA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(100)]
    public string? TELEFONO1_ENTREGA { get; set; }

    [JsonProperty("TELEFONO2_ENTREGA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(100)]
    public string? TELEFONO2_ENTREGA { get; set; }

    [JsonProperty("CLIENTE_OCASIONAL_PERCEPCIONES_DEFINIBLES_DTO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PercepcionesDefiniblesDto>? CLIENTE_OCASIONAL_PERCEPCIONES_DEFINIBLES_DTO { get; set; }
}

public class PercepcionesDefiniblesDto
{
    [JsonProperty("ID_PERCEPCION_VENTAS", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public int ID_PERCEPCION_VENTAS { get; set; }

    [JsonProperty("ID_PERCEPCION_VENTAS_ALICUOTA", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public int ID_PERCEPCION_VENTAS_ALICUOTA { get; set; }

    [JsonProperty("LEYENDA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LEYENDA { get; set; }
}

public partial class NotaPedidoDto
{
    [JsonProperty("MENSAJE", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(1000)]
    public string? MENSAJE { get; set; }
}

public class PlanDeEntregaDto
{
    [JsonProperty("CANTIDAD", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public decimal? CANTIDAD { get; set; }

    [JsonProperty("FECHA_DE_ENTREGA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? FECHA_DE_ENTREGA { get; set; }
}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class DescripcionAdicionalDto
{
    [JsonProperty("DESCRIPCION", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(50)]
    public string? DESCRIPCION { get; set; }

    [JsonProperty("DESCRIPCION_ADICIONAL", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(20)]
    public string? DESCRIPCION_ADICIONAL { get; set; }
}

public class RenglonDto
{
    [JsonProperty("ID_STA11", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_STA11 { get; set; }

    [JsonProperty("ID_STA22", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_STA22 { get; set; }

    [JsonProperty("ID_GVA81", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ID_GVA81 { get; set; }

    [JsonProperty("DESCRIPCION_ARTICULO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(50)]
    public string? DESCRIPCION_ARTICULO { get; set; }

    [JsonProperty("DESCRIPCION_ADICIONAL_ARTICULO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(20)]
    public string? DESCRIPCION_ADICIONAL_ARTICULO { get; set; }

    [JsonProperty("MODULO_UNIDAD_MEDIDA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MODULO_UNIDAD_MEDIDA { get; set; }

    [JsonProperty("CANTIDAD_PEDIDA", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public decimal? CANTIDAD_PEDIDA { get; set; }

    [JsonProperty("CANTIDAD_A_FACTURAR", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public decimal? CANTIDAD_A_FACTURAR { get; set; }

    [JsonProperty("CANTIDAD_A_DESCARGAR", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public decimal? CANTIDAD_A_DESCARGAR { get; set; }

    [JsonProperty("PRECIO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public decimal? PRECIO { get; set; }

    [JsonProperty("PORCENTAJE_BONIFICACION", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public decimal? PORCENTAJE_BONIFICACION { get; set; }

    [JsonProperty("OBSERVACIONES", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(8000)]
    public string? OBSERVACIONES { get; set; }

    [JsonProperty("PLAN_DE_ENTREGA_DTO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PlanDeEntregaDto>? PLAN_DE_ENTREGA_DTO { get; set; }

    [JsonProperty("DESCRIPCION_ADICIONAL_DTO", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DescripcionAdicionalDto>? DESCRIPCION_ADICIONAL_DTO { get; set; }
}
