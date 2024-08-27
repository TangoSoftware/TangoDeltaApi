using TangoDeltaApi.CommonServices.procesosgenerales.cuentascontables.model;
using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.cuentascontables;

public class CuentasContablesServices(ITangoConfig config)
    : BaseServices<CuentasContablesQueryRecord, CuentasContablesData>(config), ICuentasContablesServices
{
    protected override string ProcessId => "1575";
}
