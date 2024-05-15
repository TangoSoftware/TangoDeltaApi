using Newtonsoft.Json;

namespace TangoRestApiClient.services.vendedor.model;

public class VendedorQuery
{
    [JsonProperty("resultData")]
    public ResultData? ResultData { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("exceptionInfo")]
    public string? ExceptionInfo { get; set; }

    [JsonProperty("succeeded")]
    public bool Succeeded { get; set; }
}

public class ResultData
{
    [JsonProperty("list")]
    public VendedorQueryRecord[]? List { get; set; }

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

public class VendedorQueryRecord
{
    [JsonProperty("ID_GVA23")]
    public int IdGva23 { get; set; }

    [JsonProperty("COD_SHOP")]
    public long CodShop { get; set; }

    [JsonProperty("COD_GVA23")]
    public required long CodGva23 { get; set; }

    [JsonProperty("NOMBRE_VEN")]
    public string? NombreVen { get; set; }

    [JsonProperty("INHABILITA")]
    public bool Inhabilita { get; set; }

    [JsonProperty("PORC_COMIS")]
    public decimal PorcComis { get; set; }

    [JsonProperty("ID_TIPO_DOCUMENTO_GV")]
    public int? IdTipoDocumentoGv { get; set; }

    [JsonProperty("NRO_DOC")]
    public string? NroDoc { get; set; }

    [JsonProperty("DOM_VENDED")]
    public string? DomVended { get; set; }

    [JsonProperty("LOCALIDAD")]
    public string? Localidad { get; set; }

    [JsonProperty("COD_POSTAL")]
    public string? CodPostal { get; set; }

    [JsonProperty("ID_GVA18")]
    public int? IdGva18 { get; set; }

    [JsonProperty("COD_PROVIN")]
    public string? CodProvin { get; set; }

    [JsonProperty("TELEFONO")]
    public string? Telefono { get; set; }

    [JsonProperty("E_MAIL")]
    public string? EMail { get; set; }

    [JsonProperty("TIPO_DOC")]
    public int? TipoDoc { get; set; }

    [JsonProperty("COD_GVA18")]
    public string? CodGva18 { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("COD_DESCRIP")]
    public string CodDescrip { get; set; }
}
