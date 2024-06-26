﻿using TangoDeltaApi.CommonServices.ventas.cliente;
using TangoDeltaApi.CommonServices.ventas.cliente.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

// Configuracion de conexión a Tango Delta.
ITangoConfig config = new TangoConfig()
{
    TangoUrl = "http://euforia24.axoft.com:17000",
    ApiAuthorization = "fa0d52d3-7f54-47a3-8327-4fc830fe82c4",
    CompanyId = "1"
};

// Instancia de ClienteServices
IClienteServices clienteServices = new ClienteServices(config);

// Obtener todos los clientes (como si fuese la VISTA del ABM)
List<ClienteQueryRecord> data = clienteServices.Get(1000, 0);

foreach (var item in data)
{
    Console.WriteLine($"Id: {item.IdGva14} - Código: {item.CodGva14} - Razon Social: {item.RazonSoci} - Nom comercial: {item.NomCom} - CUIT: {item.Cuit}");
}

// Crear un nuevo cliente
ClienteData cliente = new ClienteData{ CodGva14  = "330010"};

cliente.RazonSoci = "Cliente Prueba";
cliente.NomCom = "Api Fiendly S.A.";
cliente.Cuit = "20330042999";
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
try
{
    int savedId = clienteServices.Create(cliente);
    Console.WriteLine($"Id Cliente (gva14) {savedId} creado con exito!");
}
catch (TransactionException axCloudException)
{
    var fallo = axCloudException.exceptionInfo;
    Console.WriteLine($"Title: ({fallo.Title}), Messeges: {fallo.Messages.FirstOrDefault()}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al crear el cliente {cliente.CodGva14}. ({ex.Message})");
}

// Actualizar el cliente ingresado. 
// Vamos a buscar al cliente por codigo y luego actualizamos las observaciones del mismo
int idGva14ToUpdate = clienteServices.GetByFilter($"COD_GVA14 = '{cliente.CodGva14}'").Single().IdGva14;
ClienteData clienteToUpdate = clienteServices.GetById(idGva14ToUpdate);

if (clienteToUpdate == null)
{
    Console.WriteLine($"No se encontro el cliente con el codigo {cliente.CodGva14}");
    return;
}

// Modificamos en cliente. En este caso solo las observaciones
clienteToUpdate.Observaciones = "Observaciones actualizadas para el cliente";

try
{
    //Llamo al metodo Edit para actualizar el cliente
    clienteServices.Update(clienteToUpdate);
    Console.WriteLine($"Id Cliente (gva14) {clienteToUpdate.IdGva14} editado con exito!");
}
catch (TransactionException axCloudException)
{
    var fallo = axCloudException.exceptionInfo;
    Console.WriteLine($"Title: ({fallo.Title}), Messeges: {fallo.Messages.FirstOrDefault()}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al crear el cliente {clienteToUpdate.CodGva14}. ({ex.Message})");
};
  
// Eliminamos el cliente ingresado. 
// Vamos a buscar al cliente por codigo para luego eliminarlo
int idGva14ToDelte = clienteServices.GetByFilter($"COD_GVA14 = '{cliente.CodGva14}'").Single().IdGva14;

if (idGva14ToDelte == 0)
{
    Console.WriteLine($"No se encontro el cliente con el código {cliente.CodGva14}");
    return;
}

try
{
    //Eliminamos el cliente por su id
    clienteServices.Delete(idGva14ToDelte);
    Console.WriteLine($"Id Cliente (gva14) {idGva14ToDelte} eliminado con éxito!");
}
catch (TransactionException axCloudException)
{
    // Si el cliente tiene movimientos no se puede eliminar y se lanza una excepción.
    var fallo = axCloudException.exceptionInfo;
    Console.WriteLine($"Title: ({fallo.Title}), Messeges: {fallo.Messages.FirstOrDefault()}");
}
catch (Exception ex)
{
    // Si ocurre un error en la eliminación se lanza una excepción genérica.
    Console.WriteLine($"Error al crear el cliente {clienteToUpdate.CodGva14}. ({ex.Message})");
};
  