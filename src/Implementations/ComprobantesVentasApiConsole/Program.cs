using TangoDeltaApi.CommonServices.ventas.comprobantesregistracion;
using TangoDeltaApi.CommonServices.ventas.comprobantesregistracion.model;
using TangoDeltaApi.CommonServices.ventas.pedidos.Model;
using TangoDeltaApi.CommonServices.ventas.pedidos;
using TangoDeltaApi.Core.Config;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TangoDeltaApi.Core.Service;

// Configuracion de conexión a Tango Delta.
ITangoConfig config = new TangoConfig()
{
    TangoUrl = "http://miServerTango.com:17000",
    ApiAuthorization = "00000000-0000-0000-0000-000000000000",
    CompanyId = "1"
};

// Instancia de ComprobanteDeVentasServices
IComprobantesResgistracionServices comprobantesRegistracionServices = new ComprobantesRegistracionServices(config);


#region FacturaEfectivo
ComprobantesRegistracionData facturaEfectivo = new ComprobantesRegistracionData();
facturaEfectivo.CodigoTipoComprobante = "FAC";
facturaEfectivo.NumeroComprobante = "A0000100000148";
facturaEfectivo.CodigoTalonario = "1";
facturaEfectivo.CodigoCliente = "010001";
facturaEfectivo.CodigoCondicionDeVenta = 1;
facturaEfectivo.NumeroDeProyecto = "";
facturaEfectivo.CodigoOperacionRG3685 = "";
facturaEfectivo.CodigoClasificacion = "";
facturaEfectivo.FechaComprobante = new DateTime(2024, 2, 1);
facturaEfectivo.FechaCierreTesoreria = new DateTime(2024, 2, 01);
facturaEfectivo.CodigoListaPrecio = "2";
facturaEfectivo.LeyendaCotizacion = "";
facturaEfectivo.CodigoContracuenta = 20;
facturaEfectivo.CodigoDeposito = "2";
facturaEfectivo.CodigoVendedor = "3";
facturaEfectivo.CodigoMotivo = "3";
facturaEfectivo.CodigoAsiento = "";
facturaEfectivo.CodigoFlete = "01";
facturaEfectivo.Leyenda1 = "Leyenda 1";
facturaEfectivo.Leyenda2 = "Leyenda 2";
facturaEfectivo.Leyenda3 = "Leyenda 3";
facturaEfectivo.Leyenda4 = "Leyenda 4";
facturaEfectivo.Leyenda5 = "Leyenda 5";
facturaEfectivo.EsMonedaExtranjera = false;
facturaEfectivo.Total = 242.00M;
facturaEfectivo.TotalSinImpuestos = 200.00M;
facturaEfectivo.TotalExento = 0.00M;
facturaEfectivo.TotalIva = 42.00M;
facturaEfectivo.Subtotal = 242.00M;
facturaEfectivo.SubtotalSinImpuestos = 200;
facturaEfectivo.DescuentoPorcentaje = 0;
facturaEfectivo.DescuentoMonto = 0;
facturaEfectivo.DescuentoMontoSinIva = 0;
facturaEfectivo.RecargoPorcentaje = 0;
facturaEfectivo.RecargoMonto = 0;
facturaEfectivo.RecargoMontoSinIva = 0;
facturaEfectivo.RecargoFletePorcentaje = 0;
facturaEfectivo.RecargoFleteMonto = 0;
facturaEfectivo.RecargoFleteMontoSinIva = 0;
facturaEfectivo.InteresesPorcentaje = 0;
facturaEfectivo.InteresesMontoSinIva = 0;
facturaEfectivo.Observaciones = "";
facturaEfectivo.Rg3668TipoIdentificacionFirmante = null;
facturaEfectivo.Rg3668CodigoIdentificacionFirmante = "DNI";
facturaEfectivo.Rg3668MotivoDeExcepcion = null;
facturaEfectivo.Rg3668CodigoWeb = "666";
facturaEfectivo.CitiOpera = "O";
facturaEfectivo.CitiTipo = "B";

facturaEfectivo.Items = new List<Items>();
Items items = new Items();
items.Codigo = "0200200033";
items.DescargaStock = true;
items.Descripcion = "POLEA 30cm DE LAS OTRAS";
items.CodigoTasaIva = 1;
items.Cantidad = 2;
items.CodigoDeposito = "2";
items.CodigoUM = "UNI";
items.Precio = 121.00M;
items.Importe = 242.00M;
items.ImporteSinImpuestos = 200.00M;
items.ImporteIva = 42.00M;
facturaEfectivo.Items.Add(items);

facturaEfectivo.Pagos = new List<Pagos>();
Pagos pago = new Pagos();
pago.Tipo = "Efectivo";
pago.CodigoDeCuenta = "1";
pago.DescuentoPorcentaje = 0;
pago.RecargoPorcentaje = 0;
pago.Monto = 242.00M;
facturaEfectivo.Pagos.Add(pago);

// Enviamos a insertar el comprobante cargado.
try
{
    var comprobantes = new List<ComprobantesRegistracionData>() { facturaEfectivo };
    int savedId = comprobantesRegistracionServices.Create(comprobantes);
    Console.WriteLine($"Id Factura {savedId} creada con exito!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al crear el comprobante {facturaEfectivo.CodigoTipoComprobante}-{facturaEfectivo.NumeroComprobante}. ({ex.Message})");
}

#endregion


#region Multiple comprobantes

#region Factura Cta Cte

ComprobantesRegistracionData facturaCuentaCorriente = new ComprobantesRegistracionData();

facturaCuentaCorriente.CodigoTipoComprobante = "FAC";
facturaCuentaCorriente.NumeroComprobante = "A0000100000499";
facturaCuentaCorriente.CodigoTalonario = "1";
facturaCuentaCorriente.CodigoCliente = "020031";
facturaCuentaCorriente.CodigoCondicionDeVenta = 2;
facturaCuentaCorriente.NumeroDeProyecto = "";
facturaCuentaCorriente.CodigoOperacionRG3685 = "";
facturaCuentaCorriente.CodigoClasificacion = "";
facturaCuentaCorriente.FechaComprobante = new DateTime(2024, 10, 6);
facturaCuentaCorriente.FechaCierreTesoreria = new DateTime(2024, 10, 6);
facturaCuentaCorriente.CodigoListaPrecio = "2";
facturaCuentaCorriente.LeyendaCotizacion = "";
facturaCuentaCorriente.CodigoContracuenta = 20;
facturaCuentaCorriente.CodigoDeposito = "2";
facturaCuentaCorriente.CodigoVendedor = "3";
facturaCuentaCorriente.CodigoAsiento = "";
facturaCuentaCorriente.CodigoFlete = "01";
facturaCuentaCorriente.Leyenda1 = "Leyenda 1";
facturaCuentaCorriente.Leyenda2 = "Leyenda 2";
facturaCuentaCorriente.Leyenda3 = "Leyenda 3";
facturaCuentaCorriente.Leyenda4 = "Leyenda 4";
facturaCuentaCorriente.Leyenda5 = "Leyenda 5";
facturaCuentaCorriente.EsMonedaExtranjera = false;
facturaCuentaCorriente.Total = 266.20M;
facturaCuentaCorriente.TotalSinImpuestos = 220.00M;
facturaCuentaCorriente.TotalExento = 0.00M;
facturaCuentaCorriente.TotalIva = 46.20M;
facturaCuentaCorriente.Subtotal = 242.00M;
facturaCuentaCorriente.SubtotalSinImpuestos = 200.00M;
facturaCuentaCorriente.DescuentoPorcentaje = 0;
facturaCuentaCorriente.DescuentoMonto = 0;
facturaCuentaCorriente.DescuentoMontoSinIva = 0;
facturaCuentaCorriente.RecargoPorcentaje = 0;
facturaCuentaCorriente.RecargoMonto = 0;
facturaCuentaCorriente.RecargoMontoSinIva = 0;
facturaCuentaCorriente.RecargoFletePorcentaje = 0;
facturaCuentaCorriente.RecargoFleteMonto = 0;
facturaCuentaCorriente.RecargoFleteMontoSinIva = 0;
facturaCuentaCorriente.InteresesPorcentaje = 10.00M;
facturaCuentaCorriente.InteresesMontoSinIva = 20.00M;
facturaCuentaCorriente.Observaciones = "";
facturaCuentaCorriente.Rg3668TipoIdentificacionFirmante = null;
facturaCuentaCorriente.Rg3668CaracterDelFirmante = null;
facturaCuentaCorriente.Rg3668CodigoIdentificacionFirmante = "";
facturaCuentaCorriente.Rg3668MotivoDeExcepcion = null;
facturaCuentaCorriente.Rg3668CodigoWeb = "666";

//Agregamos los artiulos
facturaCuentaCorriente.Items = new List<Items>();
Items item = new Items();
item.Codigo = "0200200033";
item.Descripcion = "POLEA 30cm DE LAS OTRAS";
item.DescargaStock = true;
item.CodigoTasaIva = 1;
item.Cantidad = 2;
item.CodigoDeposito = "2";
item.CodigoUM = "UNI";
item.Precio = 121.00M;
item.Importe = 242.00M;
item.ImporteSinImpuestos = 200.00M;
item.ImporteIva = 42.00M;

facturaCuentaCorriente.Items.Add(item);

//Agregamos los vencimientos/cuotas de Factura
facturaCuentaCorriente.CuotasCuentaCorriente = new List<CuotasCuentaCorriente>();
CuotasCuentaCorriente cuota1 = new CuotasCuentaCorriente()
{
    FechaVencimiento = new DateTime(2019, 7, 10),
    Importe = 66.55M
};

CuotasCuentaCorriente cuota2 = new CuotasCuentaCorriente()
{
    FechaVencimiento = new DateTime(2019, 8, 10),
    Importe = 199.65M
};

facturaCuentaCorriente.CuotasCuentaCorriente.Add(cuota1);
facturaCuentaCorriente.CuotasCuentaCorriente.Add(cuota2);

#endregion

#region Factura Cliente Ocacional
ComprobantesRegistracionData facturaClienteOcacional = new ComprobantesRegistracionData();
facturaClienteOcacional.CodigoTipoComprobante = "FAC";
facturaClienteOcacional.NumeroComprobante = "A0000100000109";
facturaClienteOcacional.CodigoTalonario = "1";
facturaClienteOcacional.CodigoCliente = "000000";
facturaClienteOcacional.MailDestinatario = "xyz@789.com";
facturaClienteOcacional.ClienteOcasional = new ClienteOcasional()
{
RazonSocial = "SISTEMAS ELECTRONICOS DE REGISTRACION S A",
TipoDocumento = 80,
Documento = "30-59198525-2",
Responsabilidad = 0,
DiscriminaIva = true,
LiquidaIva = true,
Domicilio = "LOYOLA 554 Piso:2",
Localidad = "Villa Crespo",
CodigoProvincia = "01",
CodigoPostal = "1416",
Telefono = "",
FechaDeNacimiento = new DateTime(1996, 1, 1),
Sexo = "F",
Mail = "abc@123.com",
MailDestinatario = "def@456.com",
DomicilioEntrega = "Gorriti 69",
LocalidadEntrega = "Palermo",
CodigoProvinciaEntrega = "01",
CodigoPostalEntrega = "1416",
PaisEntrega = "Argentina",
TelefonoEntrega = "48018668"
};
facturaClienteOcacional.CodigoCondicionDeVenta = 1;
facturaClienteOcacional.NumeroDeProyecto = "";
facturaClienteOcacional.CodigoOperacionRG3685 = "";
facturaClienteOcacional.CodigoClasificacion = "";
facturaClienteOcacional.FechaComprobante = new DateTime(2021, 7, 19);
facturaClienteOcacional.FechaCierreTesoreria = new DateTime(2021, 6, 7);
facturaClienteOcacional.CodigoListaPrecio = "2";
facturaClienteOcacional.LeyendaCotizacion = "";
facturaClienteOcacional.CodigoContracuenta = 20;
facturaClienteOcacional.CodigoDeposito = "2";
facturaClienteOcacional.CodigoVendedor = "3";
facturaClienteOcacional.CodigoAsiento = "";
facturaClienteOcacional.CodigoFlete = "01";
facturaClienteOcacional.Leyenda1 = "";
facturaClienteOcacional.Leyenda2 = "";
facturaClienteOcacional.Leyenda3 = "";
facturaClienteOcacional.Leyenda4 = "";
facturaClienteOcacional.Leyenda5 = "";
facturaClienteOcacional.Total = 121.00M;
facturaClienteOcacional.TotalSinImpuestos = 100.00M;
facturaClienteOcacional.TotalExento = 0.00M;
facturaClienteOcacional.TotalIva = 21.00M;
facturaClienteOcacional.Subtotal = 121.00M;
facturaClienteOcacional.SubtotalSinImpuestos = 100.00M;
facturaClienteOcacional.Rg3668TipoIdentificacionFirmante = null;
facturaClienteOcacional.Rg3668CaracterDelFirmante = null;
facturaClienteOcacional.Rg3668CodigoIdentificacionFirmante = "";
facturaClienteOcacional.Rg3668MotivoDeExcepcion = null;
facturaClienteOcacional.Rg3668CodigoWeb = "666";

facturaClienteOcacional.Items = new List<Items>();
Items itemClienteOcacional = new Items()
{
Codigo = "0200200033",
CodigoDeposito = "1",
CodigoTasaIva = 1,
Cantidad = 1,
Precio = 121,
Importe = 121,
ImporteSinImpuestos = 100M,
ImporteIva = 21M,
};

facturaClienteOcacional.Items.Add(itemClienteOcacional);

facturaClienteOcacional.Pagos = new List<Pagos>();
Pagos pagoFacturaOcacional = new Pagos()
{
Tipo = "Efectivo",
CodigoDeCuenta = "1",
DescuentoPorcentaje = 0.00M,
RecargoPorcentaje = 0.00M,
Monto = 121.00M
};
facturaClienteOcacional.Pagos.Add(pagoFacturaOcacional);

#endregion


#region Guardar Comprobantes
// Enviamos a insertar los comprobantes cargados.
try
{
    List<BaseData> comprobantes = new List<BaseData>();

    comprobantes.Add(facturaCuentaCorriente);
    comprobantes.Add(facturaClienteOcacional);

    int savedId = comprobantesRegistracionServices.Create(comprobantes);
    Console.WriteLine($"Id Factura {savedId} creada con exito!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al crear el comprobante {facturaCuentaCorriente.CodigoTipoComprobante}-{facturaCuentaCorriente.NumeroComprobante}. ({ex.Message})");
}

#endregion

#endregion


#region Guardar Nota de Credito con ref

ComprobantesRegistracionData NcConReferencia = new ComprobantesRegistracionData();

NcConReferencia.CodigoTipoComprobante = "CDE";
NcConReferencia.NumeroComprobante = "A0000100000109";
NcConReferencia.CodigoTalonario = "1";
NcConReferencia.CodigoCliente = "020025";
NcConReferencia.CodigoCondicionDeVenta = 1;
NcConReferencia.NumeroDeProyecto = "";
NcConReferencia.CodigoOperacionRG3685 = "";
NcConReferencia.CodigoClasificacion = "";
NcConReferencia.FechaComprobante = new DateTime(2024, 11, 11);
NcConReferencia.FechaCierreTesoreria = new DateTime(2024, 11, 10);
NcConReferencia.CodigoListaPrecio = "2";
NcConReferencia.CodigoDeposito = "2";
NcConReferencia.CodigoVendedor = "3";
NcConReferencia.CodigoAsiento = "11";
NcConReferencia.CodigoMotivo = "03";
NcConReferencia.CodigoTipoComprobanteDeReferencia = "FAC";
NcConReferencia.NumeroDeComprobanteDeReferencia = "A0000100000499";
NcConReferencia.ComprobanteCanceladoCompletamente = false;
NcConReferencia.Leyenda1 = "";
NcConReferencia.Leyenda2 = "";
NcConReferencia.Leyenda3 = "";
NcConReferencia.Leyenda4 = "";
NcConReferencia.Leyenda5 = "";
NcConReferencia.Total = 242M;
NcConReferencia.TotalSinImpuestos = 200.00M;
NcConReferencia.TotalExento = 0.00M;
NcConReferencia.TotalIva = 42.00M;
NcConReferencia.Subtotal = 242.00M;
NcConReferencia.SubtotalSinImpuestos = 200.00M;
NcConReferencia.Rg3668TipoIdentificacionFirmante = null;
NcConReferencia.Rg3668CaracterDelFirmante = null;
NcConReferencia.Rg3668CodigoIdentificacionFirmante = "";
NcConReferencia.Rg3668MotivoDeExcepcion = null;
NcConReferencia.Rg3668CodigoWeb = "666";
NcConReferencia.Pagos = new List<Pagos>();

var pagoNcConRef = new Pagos()
{
    Tipo = "Efectivo",
    CodigoDeCuenta = "1",
    DescuentoPorcentaje = 0.00M,
    RecargoPorcentaje = 0.00M,
    Monto = 242.00M,
};
NcConReferencia.Pagos.Add(pagoNcConRef);

NcConReferencia.CuotasCuentaCorriente = new List<CuotasCuentaCorriente>();

CuotasCuentaCorriente cuotaNcConRef = new CuotasCuentaCorriente()
{
    FechaVencimiento = new DateTimeOffset(2024, 11, 14, 0, 0, 0, TimeSpan.FromHours(-3)),
    Importe = 242.00M
};

NcConReferencia.CuotasCuentaCorriente.Add(cuotaNcConRef);

// Enviamos a generar el comprobante cargado.
try
{
    List<BaseData> comprobantes = new List<BaseData>() { NcConReferencia };

    int savedId = comprobantesRegistracionServices.Create(comprobantes);
    Console.WriteLine($"{NcConReferencia.CodigoTipoComprobante}-{NcConReferencia.NumeroComprobante} se generó con exito!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al generar el comprobante {NcConReferencia.CodigoTipoComprobante}-{NcConReferencia.NumeroComprobante}. ({ex.Message})");
}

#endregion

