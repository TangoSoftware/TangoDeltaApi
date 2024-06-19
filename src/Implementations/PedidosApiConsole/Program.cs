using TangoDeltaApi.CommonServices.stock.Articulo;
using TangoDeltaApi.CommonServices.procesosgenerales.ClasificacionDeComprobantes;
using TangoDeltaApi.CommonServices.ventas.cliente;
using TangoDeltaApi.CommonServices.ventas.condicionVentas;
using TangoDeltaApi.CommonServices.stock.Deposito;
using TangoDeltaApi.CommonServices.ventas.listadepreciosventas;
using TangoDeltaApi.CommonServices.procesosgenerales.Moneda;
using TangoDeltaApi.CommonServices.ventas.pedidos;
using TangoDeltaApi.CommonServices.ventas.pedidos.Model;
using TangoDeltaApi.CommonServices.ventas.transporte;
using TangoDeltaApi.CommonServices.ventas.vendedor;
using TangoDeltaApi.Core.Config;

// Configuracion de conexión a Tango Delta.
ITangoConfig config = new TangoConfig()
{
    TangoUrl = "http://euforia24.axoft.com:17000",
    ApiAuthorization = "fa0d52d3-7f54-47a3-8327-4fc830fe82c4",
    CompanyId = "1"
};

// Instancia de PedidosServices
IPedidosServices pedidosServices = new PedidosServices(config);

// Servicios para hacer consultas de tablas relacionadas
ICondicionVentaServices condicionVentaServices = new CondicionVentaServices(config);
IListaDePreciosVentasServices listaDePreciosVentasServices = new ListaDePreciosVentasServices(config);
ITransporteServices transporteServices = new TransporteServices(config);
IVendedorServices vendedorServices = new VendedorServices(config);
IClienteServices clienteServices = new ClienteServices(config);
IClasificacionDeComprobantesServices clasificacionDeComprobantesServices = new ClasificacionDeComprobantesServices(config);
IMonedaServices monedaServices = new MonedaServices(config);
IDepositoServices depositoServices = new DepositoServices(config);
IArticuloServices articuloServices = new ArticuloServices(config);

// Obtengo los pedidos de la vista principal de pedidos.
List<PedidoQueryRecord> data = pedidosServices.Get(1000, 0);
foreach (var item in data)
{
    Console.WriteLine($"Pedido: {item.IdGva21} - NroPedido: {item.NroPedido} - Cliente: {item.RazonSocialCliente}");
}

/* ******************************************************************************************************************** 
   Crear un pedido con un cliente habitual.
   ********************************************************************************************************************/
PedidoData pedido = new PedidoData();
// talonario pedido. 
pedido.ID_GVA43_TALON_PED = 6; // Talonario = 5
pedido.FECHA_PEDIDO = DateTime.Now;
pedido.FECHA_ENTREGA = DateTime.Now.AddDays(10);
// condicion de venta: Busco el ID de la condicion de venta que tenga el campo COND_VTA = 1
pedido.ID_GVA01 = condicionVentaServices.GetByFilter("GVA01.COND_VTA = 1").Single().IdGva01;
// Lista de precios: Busco el ID de la lista de precios que tenga el campo NOMBRE_LIS = 'Venta Mayorista'
pedido.ID_GVA10 = listaDePreciosVentasServices.GetByFilter("gva10.NOMBRE_LIS = 'Venta Mayorista'").Single().IdGva10;
// Clientes: Busco el ID del cliente que tenga el campo COD_GVA14 = '010001'
pedido.ID_GVA14 = clienteServices.GetByFilter("AXV_CLIENTE.COD_GVA14= '010001'").Single().IdGva14; 
pedido.ES_CLIENTE_HABITUAL = true;
pedido.ID_DIRECCION_ENTREGA = 1;
// Vendedor: Busco el ID del vendedor que tenga el campo cod_vended = 1
pedido.ID_GVA23 = vendedorServices.GetByFilter("cod_vended = 1").Single().IdGva23;
// Transporte: Busco el ID del transporte que tenga el campo cod_transp = '01'
pedido.ID_GVA24 = transporteServices.GetByFilter("Gva24.cod_transp = '01'").Single().IdGva24;
// Clasificacion de comprobante: Busco el ID de la clasificacion de comprobante que tenga el campo COD_CLASIF = '1' (Campaña de TV.)
int idClasificacionCoprobante = clasificacionDeComprobantesServices.GetByFilter("GVA81.COD_CLASIF = '1'").Single().IdGva81;  
pedido.ID_GVA81 = idClasificacionCoprobante;
// Moneda: Busco el ID de la moneda que tenga el campo COD_MONEDA = 'PES'
pedido.ID_MONEDA = monedaServices.GetByFilter("MONEDA.COD_MONEDA = 'PES'").Single().IdMoneda; 
// Depósito: Busco el ID del depósito que tenga el campo COD_STA22 = 1
int idDeposito = depositoServices.GetByFilter("STA22.COD_STA22 = 1").Single().IdSta22; 
pedido.ID_STA22 = idDeposito;
pedido.ESTADO = 2; 
// Cargamos los renglones del pedido
pedido.RENGLON_DTO = new List<RenglonDto>();
pedido.RENGLON_DTO.Add(new RenglonDto()
{
    // Artículo: Busco el ID del artículo que tenga el campo COD_STA11 = '0100100134'
    ID_STA11 = articuloServices.GetByFilter("AXV_ARTICULO.COD_STA11 = '0100100134'").Single().IdSta11,
    MODULO_UNIDAD_MEDIDA = "GV",
    CANTIDAD_PEDIDA = 10,
    // Precio: en este ejemplo pongo un precio especifico. En caso de no tenerlo, se puede buscar el precio por lista de precios automáticamente
    PRECIO = 100
});

// Enviamos a insertar el pedido cargado.
try
{
    int savedId = pedidosServices.Create(pedido);
    Console.WriteLine($"Id Pedido {savedId} creado con exito!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al crear el pedido {pedido.NRO_PEDIDO}. ({ex.Message})");
}

/* ******************************************************************************************************************** 
   Crear un pedido con un cliente Ocasional con artículos con descripciones adicionales
   ********************************************************************************************************************/

PedidoData pedidoClienteOcasional = new PedidoData();
// talonario pedido. 
pedidoClienteOcasional.ID_GVA43_TALON_PED = 6; // Talonario = 5
pedidoClienteOcasional.FECHA_PEDIDO = DateTime.Now;
pedidoClienteOcasional.FECHA_ENTREGA = DateTime.Now.AddDays(10);
// condicion de venta: Busco el ID de la condicion de venta que tenga el campo COND_VTA = 1
pedidoClienteOcasional.ID_GVA01 = condicionVentaServices.GetByFilter("GVA01.COND_VTA = 1").Single().IdGva01;
// Lista de precios: Busco el ID de la lista de precios que tenga el campo NOMBRE_LIS = 'Venta Mayorista'
pedidoClienteOcasional.ID_GVA10 = listaDePreciosVentasServices.GetByFilter("gva10.NOMBRE_LIS = 'Venta Mayorista'").Single().IdGva10;
// Clientes ocasional
pedidoClienteOcasional.ES_CLIENTE_HABITUAL = false;
pedidoClienteOcasional.CLIENTE_OCASIONAL_DTO = new List<ClienteOcasionalApiDto>();
pedidoClienteOcasional.CLIENTE_OCASIONAL_DTO.Add(
new ClienteOcasionalApiDto()
{
    RAZON_SOCIAL = "Axoft Arg. S.A.",
    DOMICILIO = "Cerrito 1186",
    LOCALIDAD = "CABA",
    CODIGO_POSTAL = "1010", 
    TELEFONO1_ENTREGA =  "91187649445",
    E_MAIL = "proveedores@axoft.com",
    ID_TIPO_DOCUMENTO_GV = 23, // corresponde a CUIT. Ver en la tabla TIPO_DOCUMENTO_GV
    ID_CATEGORIA_IVA = 1, // corresponde a Responsable Inscripto. Ver en la tabla CATEGORIA_IVA
    NRO_DOCUMENTO = "30631658810",
    ID_GVA18_PROVINCIA = 1,// corresponde a Buenos Aires. Ver en la tabla PROVINCIA
    ID_GVA18_PROVINCIA_ENTREGA = 1// corresponde a Buenos Aires. Ver en la tabla PROVINCIA
}
);
// Vendedor: Busco el ID del vendedor que tenga el campo cod_vended = 1
pedidoClienteOcasional.ID_GVA23 = vendedorServices.GetByFilter("cod_vended = 1").Single().IdGva23;
// Transporte: Busco el ID del transporte que tenga el campo cod_transp = '01'
pedidoClienteOcasional.ID_GVA24 = transporteServices.GetByFilter("Gva24.cod_transp = '01'").Single().IdGva24;
// Clasificacion de comprobante: Busco el ID de la clasificacion de comprobante que tenga el campo COD_CLASIF = '1' (Campaña de TV.)
pedidoClienteOcasional.ID_GVA81 = clasificacionDeComprobantesServices.GetByFilter("GVA81.COD_CLASIF = '1'").Single().IdGva81;  ;
// Moneda: Busco el ID de la moneda que tenga el campo COD_MONEDA = 'PES'
pedidoClienteOcasional.ID_MONEDA = monedaServices.GetByFilter("MONEDA.COD_MONEDA = 'PES'").Single().IdMoneda; 
// Depósito: Busco el ID del depósito que tenga el campo COD_STA22 = 1
pedidoClienteOcasional.ID_STA22 = depositoServices.GetByFilter("STA22.COD_STA22 = 1").Single().IdSta22; ;
pedidoClienteOcasional.ESTADO = 2; 
// Cargamos los renglones del pedido
pedidoClienteOcasional.RENGLON_DTO = new List<RenglonDto>();
pedidoClienteOcasional.RENGLON_DTO.Add(new RenglonDto()
{
    // Artículo: Busco el ID del artículo que tenga el campo COD_STA11 = '0100100134'
    ID_STA11 = articuloServices.GetByFilter("AXV_ARTICULO.COD_STA11 = '0100100134'").Single().IdSta11,
    MODULO_UNIDAD_MEDIDA = "GV",
    CANTIDAD_PEDIDA = 10,
    // Precio: en este ejemplo pongo un precio especifico. En caso de no tenerlo, se puede buscar el precio por lista de precios automáticamente
    PRECIO = 100
});

// Enviamos a insertar el pedido cargado.
try
{
    int savedId = pedidosServices.Create(pedidoClienteOcasional);
    Console.WriteLine($"Id Pedido {savedId} creado con exito!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al crear el pedido {pedidoClienteOcasional.NRO_PEDIDO}. ({ex.Message})");
}