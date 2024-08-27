using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.tipodeasientos.model;

public class TiposDeAsientosQueryRecord : BaseQueryRecord
{
    [JsonProperty("ID_TIPO_ASIENTO")]
    public int IdTipoAsiento { get; set; }

    [JsonProperty("DETAIL_TOOLBAR_GROUP")]
    public string? DetailToolbarGroup { get; set; }

    [JsonProperty("LEYENDA_ENCABEZADO_TIPO_ASIENTO")]
    public string? LeyendaEncabezadoTipoAsiento { get; set; }

    [JsonProperty("COD_TIPO_ASIENTO")]
    public string? CodTipoAsiento { get; set; }

    [JsonProperty("DESC_TIPO_ASIENTO")]
    public string? DescTipoAsiento { get; set; }

    [JsonProperty("HABILITADO")]
    public string? Habilitado { get; set; }

    [JsonProperty("GENERA_ASIENTO_RESUMEN")]
    public string? GeneraAsientoResumen { get; set; }

    [JsonProperty("ESTADO_INICIAL_ASIENTOS")]
    public string? EstadoInicialAsientos { get; set; }

    [JsonProperty("EDITA_ESTADO_ASIENTOS")]
    public string? EditaEstadoAsientos { get; set; }

    [JsonProperty("ID_AGRUPACION_ASIENTO")]
    public long IdAgrupacionAsiento { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("COD_DESCRIP")]
    public string? CodDescrip { get; set; }
}
