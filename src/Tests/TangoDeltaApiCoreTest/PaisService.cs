using TangoDeltaApi.Core.Config;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.Test.CoreTest;

internal class PaisService(ITangoConfig config, IAxHttpClient? axHttpClient = null)
    : BaseServices<PaisQuery, PaisData>(config, axHttpClient)
{
    protected override string ProcessId => "1097";
}
