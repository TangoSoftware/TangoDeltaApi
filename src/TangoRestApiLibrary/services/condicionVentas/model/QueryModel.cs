using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TangoRestApiClient.services.condicionVentas.model;

public class CondicionVentaQuery
{
    [JsonProperty("resultData")]
    public ResultData ResultData { get; set; }

    [JsonProperty("message")]
    public object Message { get; set; }

    [JsonProperty("exceptionInfo")]
    public object ExceptionInfo { get; set; }

    [JsonProperty("succeeded")]
    public bool Succeeded { get; set; }
}

public class ResultData
{
    [JsonProperty("list")]
    public CondicionVentaQueryRecord[] List { get; set; }

    [JsonProperty("pageIndex")]
    public int PageIndex { get; set; }

    [JsonProperty("pageSize")]
    public int PageSize { get; set; }

    [JsonProperty("totalCount")]
    public int TotalCount { get; set; }

    [JsonProperty("totalPages")]
    public int TotalPages { get; set; }

    [JsonProperty("hasPreviousPage")]
    public bool HasPreviousPage { get; set; }

    [JsonProperty("hasNextPage")]
    public bool HasNextPage { get; set; }
}

public class CondicionVentaQueryRecord
{
    [JsonProperty("ID_GVA01")]
    public int IdGva01 { get; set; }

    [JsonProperty("COND_VTA")]
    public int CondVta { get; set; }

    [JsonProperty("DESC_COND")]
    public string DescCond { get; set; }

    [JsonProperty("ID_GVA10")]
    public int? IdGva10 { get; set; }

    [JsonProperty("FAC_CREDIT")]
    public bool FacCredit { get; set; }

    [JsonProperty("GENERA_FECHAS_ALTERNATIVAS")]
    public string GeneraFechasAlternativas { get; set; }

    [JsonProperty("APLICA_MORA")]
    public string AplicaMora { get; set; }

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
    public string TipoAsignacion { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string Observaciones { get; set; }

    [JsonProperty("COD_DESCRIP")]
    public string CodDescrip { get; set; }
}

