using TangoDeltaApi.CommonServices.ventas.vendedor.model;
using TangoDeltaApi.Core.Service;
using TangoDeltaApiCore.Service;

namespace TangoDeltaApi.CommonServices.ventas.vendedor;

public interface IVendedorServices: IBaseServices<VendedorQueryRecord, VendedorData>
    , IHasGetByCode<string, VendedorQueryRecord>
{
}
