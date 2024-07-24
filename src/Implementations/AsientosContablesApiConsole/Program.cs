using TangoDeltaApi.CommonServices.contabilidad.asientos;
using TangoDeltaApi.CommonServices.contabilidad.asientos.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

// Configuracion de conexión a Tango Delta.
ITangoConfig config = new TangoConfig()
{
    TangoUrl = "http://euforia24.axoft.com:17000",
    ApiAuthorization = "f1fe08df-3cb4-4a90-9cf4-2f55aba9f81e",
    CompanyId = "1"
};


IAsientosServices asientosServices = new AsientosServices(config);


// Obtener todos los asientos contables (como si fuese la VISTA del ABM)
List<AsientosQueryRecord> data = asientosServices.Get(1000, 0);

foreach (var item in data)
{
    Console.WriteLine($"Id: {item.IdAsientoAnaliticoCn} - Fecha Asiento: {item.FechaAsiento} - Nro Ejercicio: {item.NroEjercicio} - Nro Asiento: {item.NroAsientoAnalitico} - Desc: {item.DescAsientoAnalitico}");
}

