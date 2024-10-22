using TangoDeltaApi.CommonServices.contabilidad.asientos;
using TangoDeltaApi.CommonServices.contabilidad.asientos.model;
using TangoDeltaApi.CommonServices.procesosgenerales.moneda;
using TangoDeltaApi.CommonServices.procesosgenerales.cuentascontables;
using TangoDeltaApi.CommonServices.procesosgenerales.tipodeasientos;
//using TangoDeltaApi.CommonServices.contabilidad.asientos.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

// Configuracion de conexión a Tango Delta.
ITangoConfig config = new TangoConfig()
{
    TangoUrl = "http://euforia24.axoft.com:17000",
    ApiAuthorization = "f1fe08df-3cb4-4a90-9cf4-2f55aba9f81e",
    CompanyId = "6"
};


// Instanciar el servicio de asientos contables.
IAsientoAnaliticoServices asientosServices = new AsientoAnaliticoServices(config);

IMonedaServices monedaServices = new MonedaServices(config);
ITiposDeAsientosServices tipoAsientosServices = new TiposDeAsientosServices(config);
ICuentasContablesServices cuentasContablesServices = new CuentasContablesServices(config);

// Obtener todos los asientos contables (como si fuese la VISTA del ABM)
List<AsientoAnaliticoQueryRecord> data = asientosServices.Get(1000, 0);

foreach (var item in data)
{
    Console.WriteLine($"Id: {item.IdAsientoAnaliticoCn} - Fecha Asiento: {item.FechaAsiento} - Nro Ejercicio: {item.NroEjercicio} - Nro Asiento: {item.NroAsientoAnalitico} - Desc: {item.DescAsientoAnalitico}");
}

/* ******************************************************************************************************************** 
   creando un asiento de ejemplo de alquileres. En moneda de ingreso Pesos Argentinos, sin auxiliares, sin unidades adicionales
   ********************************************************************************************************************/

AsientoAnaliticoData asiento = new AsientoAnaliticoData();

asiento.CLASE_ASIENTO = "Básico";
asiento.FECHA_ASIENTO = new DateTime(2024, 10, 10);
asiento.ESTADO_ASIENTO_ANALITICO = "Borrador";
// ingresamos el asiento en Pesos Argentinos
asiento.ID_MONEDA_ASIENTO = monedaServices.GetByFilter("MONEDA.COD_MONEDA = 'PES'").Single().IdMoneda;
// ingresamos el tipo de asiento de Sueldos
asiento.ID_TIPO_ASIENTO = tipoAsientosServices.GetByFilter("TIPO_ASIENTO.COD_TIPO_ASIENTO = 'SUELDOS'").Single().IdTipoAsiento;
asiento.DESC_ASIENTO_ANALITICO = "Adelanto / anticipo de sueldos del mes de octubre";
asiento.OBSERVACIONES = "Este asiento lo ingresamos por API";
asiento.RENGLON_ANALITICO_DTO = new List<RENGLON_ANALITICO_DTO>();

/*
Nuestro asiento es el siguiente:
                                  Debe   Haber                                
Anticipo de Sueldos             1000000
Sueldos y Jornales a pagar              1000000
*/

RENGLON_ANALITICO_DTO renglonCuentaSueldos = new RENGLON_ANALITICO_DTO();
renglonCuentaSueldos.ID_CUENTA = cuentasContablesServices.GetByFilter("COD_CUENTA = '1140204'").Single().IdCuenta;
renglonCuentaSueldos.IMPORTE_DEBE = 1000000;
renglonCuentaSueldos.DESC_LEYENDA = "Anticipo de Sueldos de Juan y Pedro";
renglonCuentaSueldos.FECHA_ORIGEN = new DateTime(2024, 10, 10);
asiento.RENGLON_ANALITICO_DTO.Add(renglonCuentaSueldos);

RENGLON_ANALITICO_DTO renglonSueldosyJornalesAPagar = new RENGLON_ANALITICO_DTO();
renglonSueldosyJornalesAPagar.ID_CUENTA = cuentasContablesServices.GetByFilter("COD_CUENTA = '2120107'").Single().IdCuenta;
renglonSueldosyJornalesAPagar.IMPORTE_HABER = 1000000;
renglonSueldosyJornalesAPagar.DESC_LEYENDA = "Sueldos y Jornales a pagar";
renglonSueldosyJornalesAPagar.FECHA_ORIGEN = new DateTime(2024, 10, 10);
asiento.RENGLON_ANALITICO_DTO.Add(renglonSueldosyJornalesAPagar);


int savedId = 0;
// Enviamos a insertar el asiento cargado.
try
{
    savedId = asientosServices.Create(asiento);
    Console.WriteLine($"Id Asiento {savedId} creado con exito!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al crear el asiento {asiento.DESC_ASIENTO_ANALITICO}. ({ex.Message})");
}

// Modificamos un asiento contable

Console.WriteLine("Modificando el asiento contable creado...");

//int idGva14ToUpdate = clienteServices.GetByFilter($"COD_GVA14 = '{cliente.CodGva14}'").Single().IdGva14;
AsientoAnaliticoData asientoToUpdate = asientosServices.GetById(savedId);
Console.WriteLine($"Asiento a modificar: {asientoToUpdate.ID_ASIENTO_ANALITICO_CN} - {asientoToUpdate.NRO_ASIENTO_ANALITICO}");
asientoToUpdate.ESTADO_ASIENTO_ANALITICO = "Ingresado";

// Enviamos a insertar el asiento cargado.
try
{
    asientosServices.Update(asientoToUpdate);
    Console.WriteLine($"Id Asiento {savedId} modificado con exito!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al Modificar el asiento {asientoToUpdate.DESC_ASIENTO_ANALITICO}. ({ex.Message})");
} 

// Eliminamos el asiento

try
{
    //Eliminamos el cliente por su id
    asientosServices.Delete(savedId);
    Console.WriteLine($"Id Asiento {savedId} eliminado con éxito!");
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
    Console.WriteLine($"Error al eliminar el asiento ({ex.Message})");
};
