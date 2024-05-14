﻿using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.pedidos;
using TangoRestApiClient.services.pedidos.model;
using TangoRestApiClient.services.condicionVentas;

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

// Obtengo los pedidos de la vista principal de pedidos.
PedidoQuery data = pedidosServices.GetData();

if (data.Succeeded)
{
    foreach (var item in data.ResultData.List)
    {
        Console.WriteLine($"Pedido: {item.IdGva21} - NroPedido: {item.NroPedido} - Cliente: {item.RazonSocialCliente}");
    }
}
else
{
    Console.WriteLine($"Error al obtener los pedidos. ({data.Message})");
}

// Alta de nuevo pedido.

PedidoDataset pedido = new PedidoDataset();

// talonario pedido. 
pedido.IdGva43TalonPed = 6; // Talonario = 5
//pedido.NroPedido = " 0000000000042"; // voy a probarlo sin cargar nro de pedido
pedido.FechaPedido = DateTime.Now;
pedido.FechaEntrega = DateTime.Now.AddDays(10);
// condicion de venta
pedido.IdGva01 =  condicionVentaServices.GetIdByFilter("GVA01.COND_VTA = 1"); // 1 = CONTADO, gva01.cond_vta = 1
// Lista de precios
pedido.IdGva10 = 1; // 1 = Venta Mayorista. Nro_de_Lis = 1
// Clientes
pedido.IdGva14 = 1; // 1 = Lombardi , cod_client = 010001
pedido.EsClienteHabitual = true;
pedido.IdDireccionEntrega = 1;
// Vendedor
pedido.IdGva23 = 1; // 1 = Vendedor Walter arevalo. Cod_vended = 1
// transporte
pedido.IdGva24 = 1; // 1 = Transporte propio. Cod_transp = "01"
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
TransactionResultModel transactionResult = pedidosServices.Insert(pedido);

if (transactionResult.Succeeded)
{
    Console.WriteLine($"Id Pedido {transactionResult.SavedId} creado con exito!");
}
else
{
    Console.WriteLine($"Error al crear el pedido {pedido.NroPedido}. ({transactionResult.Message})");
    Console.WriteLine($"Title: ({transactionResult.ExceptionInfo.Title}), Messeges: {transactionResult.ExceptionInfo.Messages.FirstOrDefault()}");
}
