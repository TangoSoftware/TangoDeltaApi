﻿using TangoRestApiClient.Common.Config;
using TangoRestApiClient.services.pedidos;
using TangoRestApiClient.services.pedidos.model;
using TangoRestApiClient.services.condicionVentas;
using TangoRestApiClient.services.listadepreciosventas;
using TangoRestApiClient.services.transporte;
using TangoRestApiClient.services.vendedor;

// Configuracion de conexión a Tango Delta.
ITangoConfig config = new TangoConfig()
{
    TangoUrl = "http://euforia19.axoft.com:17000",
    ApiAuthorization = "F61B1448-486D-4C20-964B-EB30157976FD",
    CompanyId = "1"
};

// Instancia de PedidosServices
IPedidosServices pedidosServices = new PedidosServices(config);

// Servicios para hacer consultas de tablas relacionadas
ICondicionVentaServices condicionVentaServices = new CondicionVentaServices(config);
IListaDePreciosVentasServices listaDePreciosVentasServices = new ListaDePreciosVentasServices(config);
ITransporteServices transporteServices = new TransporteServices(config);
IVendedorServices vendedorServices = new VendedorServices(config);

// Obtengo los pedidos de la vista principal de pedidos.
List<PedidoQueryRecord> data = pedidosServices.Get(1000, 0);

foreach (var item in data)
{
    Console.WriteLine($"Pedido: {item.IdGva21} - NroPedido: {item.NroPedido} - Cliente: {item.RazonSocialCliente}");
}

// Alta de nuevo pedido.
PedidoData pedido = new PedidoData();
// talonario pedido. 
pedido.IdGva43TalonPed = 6; // Talonario = 5
pedido.FechaPedido = DateTime.Now;
pedido.FechaEntrega = DateTime.Now.AddDays(10);
// condicion de venta
pedido.IdGva01 =  condicionVentaServices.GetByFilter("GVA01.COND_VTA = 1").Single().IdGva01; 
// Lista de precios
pedido.IdGva10 = listaDePreciosVentasServices.GetByFilter("gva10.NOMBRE_LIS = 'Venta Mayorista'").Single().IdGva10; 
// Clientes
pedido.IdGva14 = 1; // 1 = Lombardi , cod_client = 010001
pedido.EsClienteHabitual = true;
pedido.IdDireccionEntrega = 1;
// Vendedor
pedido.IdGva23 = vendedorServices.GetByFilter("cod_vended = 1").Single().IdGva23;
// transporte
pedido.IdGva24 = transporteServices.GetByFilter("Gva24.cod_transp = '01'").Single().IdGva24;
// clasificacion de comprobante
pedido.IdGva81 = 1; // 1 = casa central. 
//moneda
pedido.IdMoneda = 1; // 1 = Peso Argentino. Cod_moneda = 01
//deposito
pedido.IdSta22 = 1; // 1 = deposito principal. Cod_deposito = 01
pedido.Estado = 2; // hay que poner una lista de estados posibles...
// Cargamos los renglones del pedido
pedido.RenglonDto = new List<RenglonDto>();
pedido.RenglonDto.Add(new RenglonDto() { IdSta22 = 1,  IdSta11 = 33, IdGva81 = 1, ModuloUnidadMedida = "GV",  CantidadPedida = 10, Precio = 100 });

// Enviamos a insertar el pedido cargado.
try
{
    int savedId = pedidosServices.Create(pedido);
    Console.WriteLine($"Id Pedido {savedId} creado con exito!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al crear el pedido {pedido.NroPedido}. ({ex.Message})");
//    Console.WriteLine($"Title: ({transactionResult.ExceptionInfo.Title}), Messeges: {transactionResult.ExceptionInfo.Messages.FirstOrDefault()}");
}
