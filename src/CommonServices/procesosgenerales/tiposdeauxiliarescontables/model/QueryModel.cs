using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.tiposdeauxiliarescontables.model;

public class TiposDeAuxiliaresContablesQueryRecord : BaseQueryRecord
{
    [JsonProperty("AUXILIAR")]
    public string? Auxiliar { get; set; }

    [JsonProperty("ID_TIPO_AUXILIAR")]
    public long IdTipoAuxiliar { get; set; }

    [JsonProperty("COD_TIPO_AUXILIAR")]
    public string? CodTipoAuxiliar { get; set; }

    [JsonProperty("DESC_TIPO_AUXILIAR")]
    public string? DescTipoAuxiliar { get; set; }

    [JsonProperty("TIPO_AUXILIAR1")]
    public string? TipoAuxiliar1 { get; set; }

    [JsonProperty("ID_TIPO_AUXILIAR_AUTOMATICO")]
    public long? IdTipoAuxiliarAutomatico { get; set; }

    [JsonProperty("USA_SUBAUXILIARES_CONTABLES")]
    public string? UsaSubauxiliaresContables { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("COD_DESCRIP")]
    public string? CodDescrip { get; set; }
}
