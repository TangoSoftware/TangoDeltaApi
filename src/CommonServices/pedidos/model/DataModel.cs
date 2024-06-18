using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.Pedidos.Model;

public class PedidoData: BaseData
{
    [JsonProperty("ID_GVA21")]
    public int IdGva21 { get; set; }

    [JsonProperty("ID_GVA43_TALON_PED")]
    public int IdGva43TalonPed { get; set; }

    [JsonProperty("NRO_PEDIDO")]
    public string? NroPedido { get; set; }

    [JsonProperty("FECHA_PEDIDO")]
    public DateTimeOffset FechaPedido { get; set; }

    [JsonProperty("ESTADO")]
    public int Estado { get; set; }

    [JsonProperty("ID_GVA14")]
    public int IdGva14 { get; set; }

    [JsonProperty("ID_MONEDA")]
    public int IdMoneda { get; set; }

    [JsonProperty("COTIZACION")]
    public decimal Cotizacion { get; set; }

    [JsonProperty("ID_GVA01")]
    public int IdGva01 { get; set; }

    [JsonProperty("ID_GVA23")]
    public int IdGva23 { get; set; }

    [JsonProperty("ID_STA22")]
    public int IdSta22 { get; set; }

    [JsonProperty("ID_GVA10")]
    public int IdGva10 { get; set; }

    [JsonProperty("ID_GVA24")]
    public int IdGva24 { get; set; }

    [JsonProperty("FECHA_ENTREGA")]
    public DateTimeOffset FechaEntrega { get; set; }

    [JsonProperty("ID_ASIENTO_MODELO_GV")]
    public int IdAsientoModeloGv { get; set; }

    [JsonProperty("ID_GVA43_TALONARIO_FACTURA")]
    public int? IdGva43TalonarioFactura { get; set; }

    [JsonProperty("ID_DIRECCION_ENTREGA")]
    public int IdDireccionEntrega { get; set; }

    [JsonProperty("ID_GVA81")]
    public int IdGva81 { get; set; }

    [JsonProperty("NRO_ORDEN_COMPRA")]
    public string? NroOrdenCompra { get; set; }

    [JsonProperty("FECHA_ORDEN_COMPRA")]
    public DateTimeOffset? FechaOrdenCompra { get; set; }

    [JsonProperty("NRO_REMITO")]
    public string? NroRemito { get; set; }

    [JsonProperty("ID_ACTIVIDAD_EMPRESA_AFIP")]
    public int IdActividadEmpresaAfip { get; set; }

    [JsonProperty("ACTIVIDAD_COMPROBANTE_AFIP")]
    public string? ActividadComprobanteAfip { get; set; }

// hablar con Ruiz para ver si se puede sacar
    [JsonProperty("ID_TIPO_DOCUMENTO_GV")]
    public int? IdTipoDocumentoGv { get; set; }

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

    [JsonProperty("APLICA_DESCUENTO_CLIENTE")]
    public bool AplicaDescuentoCliente { get; set; }

    [JsonProperty("PORCENTAJE_DESCUENTO_GENERAL")]
    public decimal PorcentajeDescuentoGeneral { get; set; }

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

    [JsonProperty("COMENTARIO")]
    public string? Comentario { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("COMPROMETE_STOCK")]
    public bool ComprometeStock { get; set; }

    [JsonProperty("ID_SUCURSAL_DESTINO")]
    public int? IdSucursalDestino { get; set; }

    [JsonProperty("RENGLON_DTO")]
    public List<RenglonDto>? RenglonDto { get; set; }

    [JsonProperty("ES_CLIENTE_HABITUAL")]
    public bool EsClienteHabitual { get; set; }

    [JsonProperty("CALCULA_PROMOCIONES")]
    public bool CalculaPromociones { get; set; }

    [JsonProperty("VALIDAR_LIMITE_CREDITO")]
    public bool ValidarLimiteCredito { get; set; }

    [JsonProperty("ID_SBA01")]
    public int? IdSba01 { get; set; }

    [JsonProperty("CLIENTE_OCASIONAL_DTO")]
    public string? ClienteOcasionalDto { get; set; }

    [JsonProperty("NOTA_PEDIDO_DTO")]
    public string? NotaPedidoDto { get; set; }
}

public class RenglonDto
{
    [JsonProperty("ID_RENGLON")]
    public int IdRenglon { get; set; }

    [JsonProperty("CANTIDAD_A_DESCARGAR")]
    public decimal CantidadADescargar { get; set; }

    [JsonProperty("CANTIDAD_A_FACTURAR")]
    public decimal CantidadAFacturar { get; set; }

    [JsonProperty("CANTIDAD_PEDIDA")]
    public decimal CantidadPedida { get; set; }

    [JsonProperty("PORCENTAJE_BONIFICACION")]
    public decimal PorcentajeBonificacion { get; set; }

    [JsonProperty("PRECIO")]
    public decimal Precio { get; set; }

    [JsonProperty("ID_STA11")]
    public int IdSta11 { get; set; }

    [JsonProperty("ID_STA22")]
    public int IdSta22 { get; set; }

    [JsonProperty("ID_GVA81")]
    public int IdGva81 { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("DESCRIPCION_ARTICULO")]
    public string? DescripcionArticulo { get; set; }

    [JsonProperty("DESCRIPCION_ADICIONAL_ARTICULO")]
    public string? DescripcionAdicionalArticulo { get; set; }

    [JsonProperty("PLAN_DE_ENTREGA_DTO")]
    public string? PlanDeEntregaDto { get; set; }

    [JsonProperty("DESCRIPCION_ADICIONAL_DTO")]
    public string? DescripcionAdicionalDto { get; set; }

    [JsonProperty("MODULO_UNIDAD_MEDIDA")]
    public string? ModuloUnidadMedida { get; set; }
}
