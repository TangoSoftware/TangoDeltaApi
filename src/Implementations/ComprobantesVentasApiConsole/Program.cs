using  TangoDeltaApi.CommonServices.ventas.comprobantesregistracion;
using TangoDeltaApi.CommonServices.ventas.comprobantesregistracion.model;

using TangoDeltaApi.Core.Config;

// Configuracion de conexión a Tango Delta.
ITangoConfig config = new TangoConfig()
{
    TangoUrl = "http://euforia24.axoft.com:17000",
    ApiAuthorization = "fa0d52d3-7f54-47a3-8327-4fc830fe82c4",
    CompanyId = "1"
};


// Instancia de PedidosServices
IComprobantesResgistracionServices comprobantesRegistracionServices = new ComprobantesRegistracionServices(config);


/* Creando un nuveo comprobante  que se va a guardar en Tango Delta */
ComprobantesRegistracionData data = new ComprobantesRegistracionData();
//data.ID_GVA01 = 1; // Condicion de venta



//comprprobantesRegistracionServices.Save(data);




