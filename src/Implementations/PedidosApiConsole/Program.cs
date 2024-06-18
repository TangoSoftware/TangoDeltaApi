using TangoDeltaApi.CommonServices.Articulo;
using TangoDeltaApi.CommonServices.ClasificacionDeComprobantes;
using TangoDeltaApi.CommonServices.cliente;
using TangoDeltaApi.CommonServices.condicionVentas;
using TangoDeltaApi.CommonServices.Deposito;
using TangoDeltaApi.CommonServices.listadepreciosventas;
using TangoDeltaApi.CommonServices.Moneda;
using TangoDeltaApi.CommonServices.pedidos;
using TangoDeltaApi.CommonServices.Pedidos.Model;
using TangoDeltaApi.CommonServices.transporte;
using TangoDeltaApi.CommonServices.vendedor;
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

// Alta de nuevo pedido.
PedidoData pedido = new PedidoData();
// talonario pedido. 
pedido.ID_GVA43_TALON_PED = 6; // Talonario = 5
pedido.FECHA_PEDIDO = DateTime.Now;
pedido.FECHA_ENTREGA = DateTime.Now.AddDays(10);
// condicion de venta
pedido.ID_GVA01 = condicionVentaServices.GetByFilter("GVA01.COND_VTA = 1").Single().IdGva01;
// Lista de precios
pedido.ID_GVA10 = listaDePreciosVentasServices.GetByFilter("gva10.NOMBRE_LIS = 'Venta Mayorista'").Single().IdGva10;
// Clientes: F
pedido.ID_GVA14 = clienteServices.GetByFilter("AXV_CLIENTE.COD_GVA14= '010001'").Single().IdGva14; // 1 = Lombardi , cod_client = 010001, 30-22641901-9
pedido.ES_CLIENTE_HABITUAL = true;
pedido.ID_DIRECCION_ENTREGA = 1;
// Vendedor
pedido.ID_GVA23 = vendedorServices.GetByFilter("cod_vended = 1").Single().IdGva23;
// transporte
pedido.ID_GVA24 = transporteServices.GetByFilter("Gva24.cod_transp = '01'").Single().IdGva24;
// clasificacion de comprobante
int idClasificacionCoprobante = clasificacionDeComprobantesServices.GetByFilter("GVA81.COD_CLASIF = '1'").Single().IdGva81; // 1 = Campaña de TV. 
pedido.ID_GVA81 = idClasificacionCoprobante;
//moneda
pedido.ID_MONEDA = monedaServices.GetByFilter("MONEDA.COD_MONEDA = 'PES'").Single().IdMoneda; // 1 = Peso Argentino. Cod_moneda = 01
//deposito
int idDeposito = depositoServices.GetByFilter("STA22.COD_STA22 = 1").Single().IdSta22; // 1 = deposito principal. Cod_deposito = 01
pedido.ID_STA22 = idDeposito;
pedido.ESTADO = 2; // hay que poner una lista de estados posibles...
// Cargamos los renglones del pedido
pedido.RENGLON_DTO = new List<RenglonDto>();
pedido.RENGLON_DTO.Add(new RenglonDto()
{
    //ID_STA22 = idDeposito,
    ID_STA11 = articuloServices.GetByFilter("AXV_ARTICULO.COD_STA11 = '0100100134'").Single().IdSta11,
    //IdGva81 = idClasificacionCoprobante,
    MODULO_UNIDAD_MEDIDA = "GV",
    CANTIDAD_PEDIDA = 10,
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
