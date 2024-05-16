﻿using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.cliente;
using TangoRestApiClient.services.cliente.model;

// Configuracion de conexión a Tango Delta.
ITangoConfig config = new TangoConfig()
{
    TangoUrl = "http://euforia19.axoft.com:17000",
    ApiAuthorization = "F61B1448-486D-4C20-964B-EB30157976FD",
    CompanyId = "1"
};

// Instancia de ClienteServices
IClienteServices clienteServices = new ClienteServices(config);



// Obtener todos los clientes (como si fuese la VISTA del ABM)
ClienteQuery data = clienteServices.GetData();

if (data.Succeeded)
{
    foreach (var item in data.ResultData.List)
    {
        Console.WriteLine($"Id: {item.IdGva14} - Código: {item.CodGva14} - Razon Social: {item.RazonSoci} - Nom comercial: {item.NomCom} - CUIT: {item.Cuit}");
    }
}
else
{
    Console.WriteLine($"Error al obtener los clientes. ({data.Message})");
}

// Crear un nuevo cliente

ClienteDataset cliente = new ClienteDataset{ CodGva14  = "330004"};

cliente.RazonSoci = "Cliente Prueba";
cliente.NomCom = "Api Fiendly S.A.";
cliente.Cuit = "20330041111";
cliente.CupoCredi=0;
cliente.Exporta=true;
cliente.IiD="N";
cliente.IiL="N";
cliente.IvaD="S";
cliente.IvaL="S";
cliente.PorcDesc = 0;
cliente.PorcExcl = 0;
cliente.SobreIi = "N";
cliente.SobreIva = "N";
cliente.Telefono1 = "011-1234-5678";
cliente.TipoDoc = "80";
cliente.MonCte = true;
cliente.SucurOri = 1;
cliente.IdiomaCte = "1";
cliente.DetArtic="A";
cliente.IncComent = "N";
cliente.AplicaMora = "S";
cliente.PublicaWebClientes = "N";
cliente.CobraDomingo = "N";
cliente.CobraLunes = "N";
cliente.CobraMartes = "N";
cliente.CobraMiercoles = "N";
cliente.CobraJueves = "N";
cliente.CobraViernes = "N";
cliente.CobraSabado = "N";
cliente.IdCategoriaIva = 1;
cliente.TypFex="H";
cliente.TypNcex="H";
cliente.TypNdex="H";
cliente.Rg3572_EmpresaVinculadaCliente = false;
cliente.InhabilitadoNexoPedidos = "N";
cliente.InhabilitadoNexoCobranzas = "N";
cliente.IdGva18 = 1;
cliente.IdGva05 = 1;
cliente.IdTipoDocumentoGv = 26;
cliente.IdGva01 = 1;
cliente.IdSucursal = 1;

// agregamos la direccion de entrega al cliente
cliente.DireccionEntrega = new List<DireccionEntrega>();

DireccionEntrega direccionEntrega = new DireccionEntrega{
    CodDireccionEntrega = "PRINCIPAL",
    Habitual = "S",
    Habilitado = "S",
    TomaImpuestoHabitual = "S",
    EntregaLunes = "S",
    EntregaMartes = "S",
    EntregaMiercoles = "S",
    EntregaJueves = "S",
    EntregaViernes = "S",
    EntregaSabado = "N",
    EntregaDomingo = "N",
    IdGva18 = 1,
    Direccion = "Calle Falsa 123", 
    Localidad = "Capital Federal",
    CodigoPostal = "1234",
    Observaciones = "Observaciones de la dirección de entrega principal"
};

cliente.DireccionEntrega.Add(direccionEntrega);

// Insertamos el nuevo cliente por API
TransactionResultModel transactionResult = clienteServices.Insert(cliente);

if (transactionResult.Succeeded)
{
    Console.WriteLine($"Id Cliente (gva14) {transactionResult.SavedId} creado con exito!");
}
else
{
    Console.WriteLine($"Error al crear el cliente {cliente.CodGva14}. ({transactionResult.Message})");
    Console.WriteLine($"Title: ({transactionResult.ExceptionInfo.Title}), Messeges: {transactionResult.ExceptionInfo.Messages.FirstOrDefault()}");
}


// Actualizar el cliente ingresado. 
// Vamos a buscar al cliente por codigo y luego actualizamos las observaciones del mismo
int idGva14 = clienteServices.GetIdByFilter($"COD_GVA14 = '{cliente.CodGva14}'");
ClienteDataset clienteToUpdate = clienteServices.GetDataById(idGva14);

if (clienteToUpdate == null)
{
    Console.WriteLine($"No se encontro el cliente con el codigo {cliente.CodGva14}");
    return;
}

clienteToUpdate.Observaciones = "Observaciones actualizadas para el cliente";

TransactionResultModel transactionResultUpdate = clienteServices.Edit(clienteToUpdate);

if (transactionResult.Succeeded)
{
    Console.WriteLine($"Id Cliente (gva14) {transactionResult.SavedId} creado con exito!");
}
else
{
    Console.WriteLine($"Error al crear el cliente {clienteToUpdate.CodGva14}. ({transactionResult.Message})");
    Console.WriteLine($"Title: ({transactionResult.ExceptionInfo.Title}), Messeges: {transactionResult.ExceptionInfo.Messages.FirstOrDefault()}");
}