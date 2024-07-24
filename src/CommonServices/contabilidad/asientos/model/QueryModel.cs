using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.contabilidad.asientos.model;

public class AsientosQueryRecord : BaseQueryRecord
{

    [JsonProperty("ID_ASIENTO_ANALITICO_CN")]
    public long IdAsientoAnaliticoCn { get; set; }

    [JsonProperty("NRO_INTERNO_ANALITICO")]
    public long NroInternoAnalitico { get; set; }

    [JsonProperty("NRO_ASIENTO_ANALITICO")]
    public long NroAsientoAnalitico { get; set; }

    [JsonProperty("DESC_ASIENTO_ANALITICO")]
    public string? DescAsientoAnalitico { get; set; }

    [JsonProperty("FECHA_ASIENTO")]
    public DateTimeOffset FechaAsiento { get; set; }

    [JsonProperty("ORIGEN_ASIENTO")]
    public string? OrigenAsiento { get; set; }

    [JsonProperty("ORIGEN_EXTERNO")]
    public string? OrigenExterno { get; set; }

    [JsonProperty("CLASE_ASIENTO")]
    public string? ClaseAsiento { get; set; }

    [JsonProperty("ESTADO_ASIENTO_ANALITICO")]
    public string? EstadoAsientoAnalitico { get; set; }

    [JsonProperty("ASIENTO_EXTRACONTABLE")]
    public string? AsientoExtracontable { get; set; }

    [JsonProperty("DESC_PERIODO")]
    public string? DescPeriodo { get; set; }

    [JsonProperty("DESFE_PERIODO")]
    public DateTimeOffset DesfePeriodo { get; set; }

    [JsonProperty("HASFE_PERIODO")]
    public DateTimeOffset HasfePeriodo { get; set; }

    [JsonProperty("NRO_EJERCICIO")]
    public long NroEjercicio { get; set; }

    [JsonProperty("ESTADO_EJERCICIO")]
    public string? EstadoEjercicio { get; set; }

    [JsonProperty("EJERCICIO_ACTUAL")]
    public string? EjercicioActual { get; set; }

    [JsonProperty("EJERCICIO_ANTERIOR")]
    public string? EjercicioAnterior { get; set; }

    [JsonProperty("COD_ASIENTO_MODELO")]
    public string? CodAsientoModelo { get; set; }

    [JsonProperty("DESC_ASIENTO_MODELO")]
    public string? DescAsientoModelo { get; set; }

    [JsonProperty("COD_TIPO_ASIENTO")]
    public string? CodTipoAsiento { get; set; }

    [JsonProperty("DESC_TIPO_ASIENTO")]
    public string? DescTipoAsiento { get; set; }

    [JsonProperty("NRO_ASIENTO_REVERTIDO_CN")]
    public string? NroAsientoRevertidoCn { get; set; }

    [JsonProperty("NRO_ASIENTO_REVERSION_CN")]
    public string? NroAsientoReversionCn { get; set; }

    [JsonProperty("ESTADO_RESUMEN")]
    public string? EstadoResumen { get; set; }

    [JsonProperty("NRO_ASIENTO_RESUMEN")]
    public long? NroAsientoResumen { get; set; }

    [JsonProperty("DESC_ASIENTO_RESUMEN")]
    public string? DescAsientoResumen { get; set; }

    [JsonProperty("FECHA_ASIENTO_ASIENTO_RESUMEN_CN")]
    public DateTimeOffset? FechaAsientoAsientoResumenCn { get; set; }

    [JsonProperty("COD_MONEDA")]
    public string? CodMoneda { get; set; }

    [JsonProperty("DESC_MONEDA")]
    public string? DescMoneda { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }
}
