using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;
using System.ComponentModel.DataAnnotations;

namespace TangoDeltaApi.CommonServices.ventas.comprobantesregistracion.model;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public class ComprobantesRegistracionData : BaseData
{
    [Newtonsoft.Json.JsonProperty("CodigoTipoComprobante", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoTipoComprobante { get; set; }

    [Newtonsoft.Json.JsonProperty("NumeroComprobante", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? NumeroComprobante { get; set; }

    [Newtonsoft.Json.JsonProperty("FechaComprobante", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset FechaComprobante { get; set; }

    [Newtonsoft.Json.JsonProperty("FechaCierreTesoreria", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset FechaCierreTesoreria { get; set; }

    [Newtonsoft.Json.JsonProperty("FechaVtoCAE", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset FechaVtoCAE { get; set; }

    [Newtonsoft.Json.JsonProperty("Items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<Items>? Items { get; set; }

    [Newtonsoft.Json.JsonProperty("Pagos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<Pagos>? Pagos { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoCondicionDeVenta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? CodigoCondicionDeVenta { get; set; }

    [Newtonsoft.Json.JsonProperty("CuotasCuentaCorriente", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<CuotasCuentaCorriente>? CuotasCuentaCorriente { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoListaPrecio", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoListaPrecio { get; set; }

    [Newtonsoft.Json.JsonProperty("Cotizacion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? Cotizacion { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoCliente", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoCliente { get; set; }

    [Newtonsoft.Json.JsonProperty("ClienteOcasional", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public ClienteOcasional? ClienteOcasional { get; set; }

    [Newtonsoft.Json.JsonProperty("MailDestinatario", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? MailDestinatario { get; set; }

    [Newtonsoft.Json.JsonProperty("IdDomicilioDeEntrega", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? IdDomicilioDeEntrega { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoDireccionEntrega", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoDireccionEntrega { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoDeposito", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoDeposito { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoVendedor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoVendedor { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoMotivo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoMotivo { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoAsiento", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoAsiento { get; set; }

    [Newtonsoft.Json.JsonProperty("EvitarGenerarAsiento", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool EvitarGenerarAsiento { get; set; }

    [Newtonsoft.Json.JsonProperty("Subtotal", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Subtotal { get; set; }

    [Newtonsoft.Json.JsonProperty("SubtotalSinImpuestos", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal SubtotalSinImpuestos { get; set; }

    [Newtonsoft.Json.JsonProperty("Total", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Total { get; set; }

    [Newtonsoft.Json.JsonProperty("TotalMonedaExtranjera", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? TotalMonedaExtranjera { get; set; }

    [Newtonsoft.Json.JsonProperty("TotalExento", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal TotalExento { get; set; }

    [Newtonsoft.Json.JsonProperty("TotalIva", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal TotalIva { get; set; }

    [Newtonsoft.Json.JsonProperty("TotalSinImpuestos", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal TotalSinImpuestos { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoTalonario", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoTalonario { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoTalonarioRemito", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoTalonarioRemito { get; set; }

    [Newtonsoft.Json.JsonProperty("Cae", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Cae { get; set; }

    [Newtonsoft.Json.JsonProperty("XmlTyp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? XmlTyp { get; set; }

    [Newtonsoft.Json.JsonProperty("EstadoComprobanteElectronico", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? EstadoComprobanteElectronico { get; set; }

    [Newtonsoft.Json.JsonProperty("EsMonedaExtranjera", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool EsMonedaExtranjera { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoFlete", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoFlete { get; set; }

    [Newtonsoft.Json.JsonProperty("Leyenda1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Leyenda1 { get; set; }

    [Newtonsoft.Json.JsonProperty("Leyenda2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Leyenda2 { get; set; }

    [Newtonsoft.Json.JsonProperty("Leyenda3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Leyenda3 { get; set; }

    [Newtonsoft.Json.JsonProperty("Leyenda4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Leyenda4 { get; set; }

    [Newtonsoft.Json.JsonProperty("Leyenda5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Leyenda5 { get; set; }

    [Newtonsoft.Json.JsonProperty("LeyendaCotizacion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? LeyendaCotizacion { get; set; }

    [Newtonsoft.Json.JsonProperty("NumeroDeProyecto", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? NumeroDeProyecto { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoOperacionRG3685", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoOperacionRG3685 { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoClasificacion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoClasificacion { get; set; }

    [Newtonsoft.Json.JsonProperty("Observaciones", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Observaciones { get; set; }

    [Newtonsoft.Json.JsonProperty("DescuentoPorcentaje", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal DescuentoPorcentaje { get; set; }

    [Newtonsoft.Json.JsonProperty("DescuentoMonto", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal DescuentoMonto { get; set; }

    [Newtonsoft.Json.JsonProperty("DescuentoMontoSinIva", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal DescuentoMontoSinIva { get; set; }

    [Newtonsoft.Json.JsonProperty("RecargoPorcentaje", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal RecargoPorcentaje { get; set; }

    [Newtonsoft.Json.JsonProperty("RecargoMonto", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal RecargoMonto { get; set; }

    [Newtonsoft.Json.JsonProperty("RecargoMontoSinIva", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal RecargoMontoSinIva { get; set; }

    [Newtonsoft.Json.JsonProperty("RecargoFletePorcentaje", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal RecargoFletePorcentaje { get; set; }

    [Newtonsoft.Json.JsonProperty("RecargoFleteMonto", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal RecargoFleteMonto { get; set; }

    [Newtonsoft.Json.JsonProperty("RecargoFleteMontoSinIva", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal RecargoFleteMontoSinIva { get; set; }

    [Newtonsoft.Json.JsonProperty("InteresesPorcentaje", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal InteresesPorcentaje { get; set; }

    [Newtonsoft.Json.JsonProperty("InteresesMontoSinIva", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal InteresesMontoSinIva { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoContracuenta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public long CodigoContracuenta { get; set; }

    [Newtonsoft.Json.JsonProperty("LeyendaContracuenta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? LeyendaContracuenta { get; set; }

    [Newtonsoft.Json.JsonProperty("ConceptoContracuenta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? ConceptoContracuenta { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3971IdPaisReceptor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Rg3971IdPaisReceptor { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3971IdRelecionEmisorReceptor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Rg3971IdRelecionEmisorReceptor { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3971CuitHotel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Rg3971CuitHotel { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3971IdTipoFormaPagoTurismo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Rg3971IdTipoFormaPagoTurismo { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3971CodigoSwift", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Rg3971CodigoSwift { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3971NumeroCuenta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Rg3971NumeroCuenta { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3971NumeroTarjeta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Rg3971NumeroTarjeta { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3971IdTipoCuentaPagoTurismo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Rg3971IdTipoCuentaPagoTurismo { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3668TipoIdentificacionFirmante", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? Rg3668TipoIdentificacionFirmante { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3668CaracterDelFirmante", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? Rg3668CaracterDelFirmante { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3668CodigoIdentificacionFirmante", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Rg3668CodigoIdentificacionFirmante { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3668MotivoDeExcepcion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? Rg3668MotivoDeExcepcion { get; set; }

    [Newtonsoft.Json.JsonProperty("Rg3668CodigoWeb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Rg3668CodigoWeb { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoTipoComprobanteDeReferencia", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CodigoTipoComprobanteDeReferencia { get; set; }

    [Newtonsoft.Json.JsonProperty("NumeroDeComprobanteDeReferencia", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? NumeroDeComprobanteDeReferencia { get; set; }

    [Newtonsoft.Json.JsonProperty("ComprobanteCanceladoCompletamente", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool ComprobanteCanceladoCompletamente { get; set; }

    [Newtonsoft.Json.JsonProperty("CuitDestino", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CuitDestino { get; set; }

    [Newtonsoft.Json.JsonProperty("TipoExpo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? TipoExpo { get; set; }

    [Newtonsoft.Json.JsonProperty("PaisAfip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PaisAfip { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoIncoterms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoIncoterms { get; set; }

    [Newtonsoft.Json.JsonProperty("DescripcionIncoterms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string DescripcionIncoterms { get; set; }

    [Newtonsoft.Json.JsonProperty("PermisosEmbarque", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<PermisosEmbarque> PermisosEmbarque { get; set; }

    [Newtonsoft.Json.JsonProperty("RemitosTabaco", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<RemitosTabaco> RemitosTabaco { get; set; }

    [Newtonsoft.Json.JsonProperty("CitiOpera", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CitiOpera { get; set; }

    [Newtonsoft.Json.JsonProperty("CitiTipo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CitiTipo { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class Items
{
    [Newtonsoft.Json.JsonProperty("Codigo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Codigo { get; set; }

    [Newtonsoft.Json.JsonProperty("Descripcion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Descripcion { get; set; }

    [Newtonsoft.Json.JsonProperty("DescripcionAdicional", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string DescripcionAdicional { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoTasaIva", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? CodigoTasaIva { get; set; }

    [Newtonsoft.Json.JsonProperty("Cantidad", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Cantidad { get; set; }

    [Newtonsoft.Json.JsonProperty("Precio", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? Precio { get; set; }

    [Newtonsoft.Json.JsonProperty("Bonificacion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? Bonificacion { get; set; }

    [Newtonsoft.Json.JsonProperty("Importe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? Importe { get; set; }

    [Newtonsoft.Json.JsonProperty("ImporteSinImpuestos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? ImporteSinImpuestos { get; set; }

    [Newtonsoft.Json.JsonProperty("ImporteIva", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal? ImporteIva { get; set; }

    [Newtonsoft.Json.JsonProperty("ImpuestoInterno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public ImpuestoInterno ImpuestoInterno { get; set; }

    [Newtonsoft.Json.JsonProperty("ImpuestoInternoAdicional", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public ImpuestoInterno ImpuestoInternoAdicional { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoUM", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoUM { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoDeposito", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoDeposito { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoClasificacion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoClasificacion { get; set; }

    [Newtonsoft.Json.JsonProperty("DescargaStock", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? DescargaStock { get; set; }

    [Newtonsoft.Json.JsonProperty("Percepciones", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<Percepciones> Percepciones { get; set; }

    [Newtonsoft.Json.JsonProperty("Partidas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<Partidas> Partidas { get; set; }

    [Newtonsoft.Json.JsonProperty("Componentes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<Items> Componentes { get; set; }

    [Newtonsoft.Json.JsonProperty("Observaciones", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Observaciones { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class Pagos
{
    [Newtonsoft.Json.JsonProperty("Tipo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Tipo { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoDeCuenta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoDeCuenta { get; set; }

    [Newtonsoft.Json.JsonProperty("DescuentoPorcentaje", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal DescuentoPorcentaje { get; set; }

    [Newtonsoft.Json.JsonProperty("RecargoPorcentaje", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal RecargoPorcentaje { get; set; }

    [Newtonsoft.Json.JsonProperty("Monto", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Monto { get; set; }

    [Newtonsoft.Json.JsonProperty("Leyenda", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Leyenda { get; set; }

    [Newtonsoft.Json.JsonProperty("Fecha", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset Fecha { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class CuotasCuentaCorriente
{
    [Newtonsoft.Json.JsonProperty("FechaVencimiento", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset FechaVencimiento { get; set; }

    [Newtonsoft.Json.JsonProperty("Importe", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Importe { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class ClienteOcasional
{
    [Newtonsoft.Json.JsonProperty("RazonSocial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string RazonSocial { get; set; }

    [Newtonsoft.Json.JsonProperty("TipoDocumento", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int TipoDocumento { get; set; }

    [Newtonsoft.Json.JsonProperty("Documento", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Documento { get; set; }

    [Newtonsoft.Json.JsonProperty("Domicilio", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Domicilio { get; set; }

    [Newtonsoft.Json.JsonProperty("Localidad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Localidad { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoProvincia", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoProvincia { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoPostal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoPostal { get; set; }

    [Newtonsoft.Json.JsonProperty("Mail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Mail { get; set; }

    [Newtonsoft.Json.JsonProperty("MailDestinatario", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string MailDestinatario { get; set; }

    [Newtonsoft.Json.JsonProperty("Responsabilidad", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Responsabilidad { get; set; }

    [Newtonsoft.Json.JsonProperty("DiscriminaIva", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool DiscriminaIva { get; set; }

    [Newtonsoft.Json.JsonProperty("LiquidaIva", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool LiquidaIva { get; set; }

    [Newtonsoft.Json.JsonProperty("Telefono", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Telefono { get; set; }

    [Newtonsoft.Json.JsonProperty("Sexo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Sexo { get; set; }

    [Newtonsoft.Json.JsonProperty("FechaDeNacimiento", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset FechaDeNacimiento { get; set; }

    [Newtonsoft.Json.JsonProperty("DomicilioEntrega", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string DomicilioEntrega { get; set; }

    [Newtonsoft.Json.JsonProperty("LocalidadEntrega", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string LocalidadEntrega { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoProvinciaEntrega", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoProvinciaEntrega { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoPostalEntrega", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoPostalEntrega { get; set; }

    [Newtonsoft.Json.JsonProperty("PaisEntrega", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PaisEntrega { get; set; }

    [Newtonsoft.Json.JsonProperty("TelefonoEntrega", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string TelefonoEntrega { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class PermisosEmbarque
{
    [Newtonsoft.Json.JsonProperty("CodigoDespacho", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoDespacho { get; set; }

    [Newtonsoft.Json.JsonProperty("PaisAfip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PaisAfip { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class RemitosTabaco
{
    [Newtonsoft.Json.JsonProperty("TipoRemito", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string TipoRemito { get; set; }

    [Newtonsoft.Json.JsonProperty("NumeroComprobante", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string NumeroComprobante { get; set; }

    [Newtonsoft.Json.JsonProperty("CuitRemito", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CuitRemito { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class ImpuestoInterno
{
    [Newtonsoft.Json.JsonProperty("Codigo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Codigo { get; set; }

    [Newtonsoft.Json.JsonProperty("Porcentaje", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Porcentaje { get; set; }

    [Newtonsoft.Json.JsonProperty("Importe", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Importe { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class Percepciones
{
    [Newtonsoft.Json.JsonProperty("CodigoAlicuota", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int CodigoAlicuota { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoPercepcion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoPercepcion { get; set; }

    [Newtonsoft.Json.JsonProperty("Porcentaje", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Porcentaje { get; set; }

    [Newtonsoft.Json.JsonProperty("Base", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Base { get; set; }

    [Newtonsoft.Json.JsonProperty("Importe", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public decimal Importe { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class Partidas
{
    [Newtonsoft.Json.JsonProperty("Numero", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Numero { get; set; }

    [Newtonsoft.Json.JsonProperty("CodigoArticulo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CodigoArticulo { get; set; }

    [Newtonsoft.Json.JsonProperty("Cantidad", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public long Cantidad { get; set; }

    [Newtonsoft.Json.JsonProperty("Series", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<Series> Series { get; set; }


}

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
public partial class Series
{
    [Newtonsoft.Json.JsonProperty("Numero", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Numero { get; set; }
}
