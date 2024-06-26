using TangoDeltaApi.CommonServices.procesosgenerales.ClasificacionDeComprobantes.model;
using TangoDeltaApi.Core.Service;
using TangoDeltaApiCore.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.ClasificacionDeComprobantes;

public interface IClasificacionDeComprobantesServices : IBaseServices<ClasificacionDeComprobantesQueryRecord, ClasificacionDeComprobantesData>
    , IHasGetByCode<string, ClasificacionDeComprobantesQueryRecord>
{
}
