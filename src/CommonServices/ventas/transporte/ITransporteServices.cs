using TangoDeltaApi.CommonServices.ventas.transporte.model;
using TangoDeltaApi.Core.Service;
using TangoDeltaApiCore.Service;

namespace TangoDeltaApi.CommonServices.ventas.transporte;

public interface ITransporteServices: IBaseServices<TransporteQueryRecord, TransporteData>
    , IHasGetByCode<string, TransporteQueryRecord>
{
}
