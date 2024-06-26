using TangoDeltaApi.CommonServices.procesosgenerales.ClasificacionDeComprobantes.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.ClasificacionDeComprobantes;

public class ClasificacionDeComprobantesServices(ITangoConfig config)
    : BaseServices<ClasificacionDeComprobantesQueryRecord, ClasificacionDeComprobantesData>(config), IClasificacionDeComprobantesServices
{
    protected override string ProcessId => "326";

    public ClasificacionDeComprobantesQueryRecord GetByCode(string code)
    {
        return GetByFilter($"GVA81.COD_CLASIF = '{code}'").Single();
    }

    public int GetIdByCode(string code)
    {
        return GetByCode(code).IdGva81;
    }
}
