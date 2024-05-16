using Newtonsoft.Json;
using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.pedidos.model;

public class PedidoQueryRecord : BaseQueryRecord
{
    public override int GetId()
    {
        throw new NotImplementedException();
    }

    [JsonProperty("ID_GVA21")]
    public int IdGva21 { get; set; }

    [JsonProperty("NRO_PEDIDO")]
    public string? NroPedido { get; set; }

    [JsonProperty("TIPO_CLIENTE")]
    public string? TipoCliente { get; set; }

    [JsonProperty("CODIGO_CLIENTE")]
    public string? CodigoCliente { get; set; }

    [JsonProperty("RAZON_SOCIAL_CLIENTE")]
    public string? RazonSocialCliente { get; set; }

    [JsonProperty("CUIT_CLIENTE")]
    public string? CuitCliente { get; set; }

    [JsonProperty("FECHA_PEDI")]
    public DateTime FechaPedi { get; set; }

    [JsonProperty("ESTADO")]
    public long Estado { get; set; }

    [JsonProperty("COTIZ")]
    public decimal Cotiz { get; set; }

    [JsonProperty("FECHA_ENTR")]
    public DateTime? FechaEntr { get; set; }

    [JsonProperty("NRO_OC_COMP")]
    public string? NroOcComp { get; set; }

    [JsonProperty("FECHA_O_COMP")]
    public DateTime? FechaOComp { get; set; }

    [JsonProperty("N_REMITO")]
    public string? NRemito { get; set; }

    [JsonProperty("ACTIVIDAD_COMPROBANTE_AFIP")]
    public string? ActividadComprobanteAfip { get; set; }

    [JsonProperty("NUMERO_DOCUMENTO_PAGADOR")]
    public string? NumeroDocumentoPagador { get; set; }

    [JsonProperty("LEYENDA_1")]
    public string? Leyenda1 { get; set; }

    [JsonProperty("LEYENDA_2")]
    public string? Leyenda2 { get; set; }

    [JsonProperty("LEYENDA_3")]
    public string? Leyenda3 { get; set; }

    [JsonProperty("LEYENDA_4")]
    public string? Leyenda4 { get; set; }

    [JsonProperty("LEYENDA_5")]
    public string? Leyenda5 { get; set; }

    [JsonProperty("PORC_DESC")]
    public decimal PorcDesc { get; set; }

    [JsonProperty("IMPORTE_DESCUENTO_GENERAL")]
    public decimal ImporteDescuentoGeneral { get; set; }

    [JsonProperty("PORCENTAJE_RECARGO_GENERAL")]
    public decimal PorcentajeRecargoGeneral { get; set; }

    [JsonProperty("IMPORTE_RECARGO_GENERAL")]
    public decimal ImporteRecargoGeneral { get; set; }

    [JsonProperty("PORCENTAJE_FLETE")]
    public decimal PorcentajeFlete { get; set; }

    [JsonProperty("IMPORTE_FLETE")]
    public decimal ImporteFlete { get; set; }

    [JsonProperty("PORCENTAJE_INTERES")]
    public decimal PorcentajeInteres { get; set; }

    [JsonProperty("IMPORTE_INTERES")]
    public decimal ImporteInteres { get; set; }

    [JsonProperty("SIMBOLO_MONEDA")]
    public string? SimboloMoneda { get; set; }

    [JsonProperty("TOTAL_PEDI")]
    public decimal TotalPedi { get; set; }

    [JsonProperty("TOTAL_PEDI_CON_IMPUESTOS")]
    public decimal TotalPediConImpuestos { get; set; }

    [JsonProperty("TOTAL_PEDI_EXTRANJERA")]
    public decimal TotalPediExtranjera { get; set; }

    [JsonProperty("TOTAL_PEDI_EXTRANJERA_CON_IMPUESTOS")]
    public decimal TotalPediExtranjeraConImpuestos { get; set; }

    [JsonProperty("TOTAL")]
    public decimal Total { get; set; }

    [JsonProperty("TOTAL_CON_IMPUESTOS")]
    public decimal TotalConImpuestos { get; set; }

    [JsonProperty("TALONARIO_PEDIDO")]
    public short TalonarioPedido { get; set; }

    [JsonProperty("DESCRIPCION_TALONARIO_PEDIDO")]
    public string? DescripcionTalonarioPedido { get; set; }

    [JsonProperty("TALONARIO_FACTURA")]
    public short? TalonarioFactura { get; set; }

    [JsonProperty("DESCRIPCION_TALONARIO_FACTURA")]
    public string? DescripcionTalonarioFactura { get; set; }

    [JsonProperty("MON_CTE")]
    public bool MonCte { get; set; }

    [JsonProperty("COD_MONEDA")]
    public string? CodMoneda { get; set; }

    [JsonProperty("DESC_MONEDA")]
    public string? DescMoneda { get; set; }

    [JsonProperty("COND_VTA")]
    public string? CondVta { get; set; }

    [JsonProperty("DESCRIPCION_CONDICION_VENTA")]
    public string? DescripcionCondicionVenta { get; set; }

    [JsonProperty("COD_GVA23")]
    public string? CodGva23 { get; set; }

    [JsonProperty("NOMBRE_VEN")]
    public string? NombreVen { get; set; }

    [JsonProperty("COD_STA22")]
    public long CodSta22 { get; set; }

    [JsonProperty("NOMBRE_SUC")]
    public string? NombreSuc { get; set; }

    [JsonProperty("NRO_DE_LIS")]
    public long NroDeLis { get; set; }

    [JsonProperty("NOMBRE_LIS")]
    public string? NombreLis { get; set; }

    [JsonProperty("COD_GVA24")]
    public string? CodGva24 { get; set; }

    [JsonProperty("NOMBRE_TRA")]
    public string? NombreTra { get; set; }

    [JsonProperty("COD_ASIENTO_MODELO_GV")]
    public string? CodAsientoModeloGv { get; set; }

    [JsonProperty("DESC_ASIENTO_MODELO_GV")]
    public string? DescAsientoModeloGv { get; set; }

    [JsonProperty("COD_DIRECCION_ENTREGA")]
    public string? CodDireccionEntrega { get; set; }

    [JsonProperty("DIRECCION")]
    public string? Direccion { get; set; }

    [JsonProperty("COD_GVA81")]
    public string? CodGva81 { get; set; }

    [JsonProperty("DESCRIPCION_GVA81")]
    public string? DescripcionGva81 { get; set; }

    [JsonProperty("COD_ACTIVIDAD_EMPRESA_AFIP")]
    public string? CodActividadEmpresaAfip { get; set; }

    [JsonProperty("DESC_ACTIVIDAD_EMPRESA_AFIP")]
    public string? DescActividadEmpresaAfip { get; set; }

    [JsonProperty("COD_TIPO_DOCUMENTO_GV")]
    public string? CodTipoDocumentoGv { get; set; }

    [JsonProperty("DESC_TIPO_DOCUMENTO_GV")]
    public string? DescTipoDocumentoGv { get; set; }

    [JsonProperty("NRO_SUCURSAL")]
    public string? NroSucursal { get; set; }

    [JsonProperty("DESC_SUCURSAL")]
    public string? DescSucursal { get; set; }

    [JsonProperty("USUARIO_INGRESO")]
    public string? UsuarioIngreso { get; set; }

    [JsonProperty("TERMINAL_INGRESO")]
    public string? TerminalIngreso { get; set; }

    [JsonProperty("COD_GVA121")]
    public string? CodGva121 { get; set; }

    [JsonProperty("DESCRIP_GVA121")]
    public string? DescripGva121 { get; set; }

    [JsonProperty("TIENDA")]
    public string? Tienda { get; set; }

    [JsonProperty("TIENDA_QUE_VENDE")]
    public string? TiendaQueVende { get; set; }

    [JsonProperty("USUARIO_TIENDA")]
    public string? UsuarioTienda { get; set; }

    [JsonProperty("USUARIO_TIENDA_VENDEDOR")]
    public string? UsuarioTiendaVendedor { get; set; }

    [JsonProperty("ORDER_NRO_TIENDA")]
    public string? OrderNroTienda { get; set; }

    [JsonProperty("EMAIL_COMPRADOR")]
    public string? EmailComprador { get; set; }

    [JsonProperty("ES_PEDIDO_WEB")]
    public bool EsPedidoWeb { get; set; }

    [JsonProperty("EXPORTADO")]
    public bool Exportado { get; set; }
}
