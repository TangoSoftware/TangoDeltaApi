using Newtonsoft.Json;

namespace TangoRestApiClient.services.condicionVentas.model;

public class CondicionVentaData
{
    [JsonProperty("value")]
    public CondicionVentaDataset? Value { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("exceptionInfo")]
    public object? ExceptionInfo { get; set; }

    [JsonProperty("succeeded")]
    public bool Succeeded { get; set; }
}

public class CondicionVentaDataset
{
    [JsonProperty("ID_GVA01")]
    public int IdGva01 { get; set; }

    [JsonProperty("COND_VTA")]
    public int CondVta { get; set; }

    [JsonProperty("DESC_COND")]
    public string? DescCond { get; set; }

    [JsonProperty("ID_GVA10")]
    public int IdGva10 { get; set; }

    [JsonProperty("FAC_CREDIT")]
    public bool FacCredit { get; set; }

    [JsonProperty("GENERA_FECHAS_ALTERNATIVAS")]
    public string? GeneraFechasAlternativas { get; set; }

    [JsonProperty("APLICA_MORA")]
    public string? AplicaMora { get; set; }

    [JsonProperty("ID_INTERES_POR_MORA")]
    public int IdInteresPorMora { get; set; }

    [JsonProperty("FECHA_VIGENCIA_DESDE")]
    public DateTime FechaVigenciaDesde { get; set; }

    [JsonProperty("FECHA_VIGENCIA_HASTA")]
    public DateTime FechaVigenciaHasta { get; set; }

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

    [JsonProperty("RENGLON_CONDICION_VENTA")]
    public List<RenglonCondicionVenta>? RenglonCondicionVenta { get; set; }
}

public class RenglonCondicionVenta
{
    [JsonProperty("FECHA_FIJA_DIAMES")]
    public string? FechaFijaDiames { get; set; }

    [JsonProperty("FECHA_FIJA_FECHA")]
    public DateTime FechaFijaFecha { get; set; }

    [JsonProperty("ID_RENGLON_CONDICION_VENTA")]
    public int IdRenglonCondicionVenta { get; set; }

    [JsonProperty("ID_GVA01")]
    public int IdGva01 { get; set; }

    [JsonProperty("N_RENGLON")]
    public int NRenglon { get; set; }

    [JsonProperty("PORC_MONTO")]
    public decimal PorcMonto { get; set; }

    [JsonProperty("CANT_CUOTA")]
    public decimal CantCuota { get; set; }

    [JsonProperty("TIPO_VENCIMIENTO")]
    public string? TipoVencimiento { get; set; }

    [JsonProperty("A_VENCER")]
    public long AVencer { get; set; }

    [JsonProperty("DIA_MES")]
    public int DiaMes { get; set; }

    [JsonProperty("CANT_DIAS")]
    public int CantDias { get; set; }

    [JsonProperty("PORC_INT")]
    public long PorcInt { get; set; }

    [JsonProperty("FORMA")]
    public string? Forma { get; set; }

    [JsonProperty("ALTERNATIVA_1")]
    public string? Alternativa1 { get; set; }

    [JsonProperty("RECARGO_DESCUENTO_1")]
    public string? RecargoDescuento1 { get; set; }

    [JsonProperty("ALTERNATIVA_2")]
    public string? Alternativa2 { get; set; }

    [JsonProperty("RECARGO_DESCUENTO_2")]
    public string? RecargoDescuento2 { get; set; }
}
