using Newtonsoft.Json;
using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.condicionVentas.model;

public class CondicionVentaQueryRecord : BaseQueryRecord
{
    public override int GetId()
    {
        return IdGva01;
    }

    [JsonProperty("ID_GVA01")]
    public int IdGva01 { get; set; }

    [JsonProperty("COND_VTA")]
    public int CondVta { get; set; }

    [JsonProperty("DESC_COND")]
    public string? DescCond { get; set; }

    [JsonProperty("ID_GVA10")]
    public int? IdGva10 { get; set; }

    [JsonProperty("FAC_CREDIT")]
    public bool FacCredit { get; set; }

    [JsonProperty("GENERA_FECHAS_ALTERNATIVAS")]
    public string? GeneraFechasAlternativas { get; set; }

    [JsonProperty("APLICA_MORA")]
    public string? AplicaMora { get; set; }

    [JsonProperty("ID_INTERES_POR_MORA")]
    public int? IdInteresPorMora { get; set; }

    [JsonProperty("FECHA_VIGENCIA_DESDE")]
    public DateTime? FechaVigenciaDesde { get; set; }

    [JsonProperty("FECHA_VIGENCIA_HASTA")]
    public DateTime? FechaVigenciaHasta { get; set; }

    [JsonProperty("ACEPTA_CONTADO")]
    public bool AceptaContado { get; set; }

    [JsonProperty("ACEPTA_CTA")]
    public bool AceptaCta { get; set; }

    [JsonProperty("PORC_MIN_CONTADO")]
    public decimal PorcMinContado { get; set; }

    [JsonProperty("OBLIGA_CONTADO")]
    public bool ObligaContado { get; set; }

    [JsonProperty("TIPO_ASIGNACION")]
    public string? TipoAsignacion { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("COD_DESCRIP")]
    public string? CodDescrip { get; set; }
}
