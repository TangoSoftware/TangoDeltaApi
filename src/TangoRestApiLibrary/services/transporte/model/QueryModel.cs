using Newtonsoft.Json;

namespace TangoRestApiClient.services.transporte.model;

    public partial class TransporteQuery
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

    public partial class ResultData
    {
        [JsonProperty("list")]
        public TransporteQueryRecord[]? List { get; set; }

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

    public  class TransporteQueryRecord
    {
        [JsonProperty("ID_GVA24")]
        public int IdGva24 { get; set; }

        [JsonProperty("COD_GVA24")]
        public required string CodGva24 { get; set; }

        [JsonProperty("NOMBRE_TRA")]
        public string? NombreTra { get; set; }

        [JsonProperty("CATEG_TRAN")]
        public string? CategTran { get; set; }

        [JsonProperty("CUIT_TRANS")]
        public string? CuitTrans { get; set; }

        [JsonProperty("PORC_RECAR")]
        public decimal PorcRecar { get; set; }

        [JsonProperty("DOM_TRANS")]
        public string? DomTrans { get; set; }

        [JsonProperty("LOCALIDAD")]
        public string? Localidad { get; set; }

        [JsonProperty("COD_POSTAL")]
        public string? CodPostal { get; set; }

        [JsonProperty("ID_GVA18")]
        public int IdGva18 { get; set; }

        [JsonProperty("TELEFONO")]
        public string? Telefono { get; set; }

        [JsonProperty("E_MAIL")]
        public string? EMail { get; set; }

        [JsonProperty("WEB")]
        public string? Web { get; set; }

        [JsonProperty("COD_PROVIN")]
        public string? CodProvin { get; set; }

        [JsonProperty("COD_GVA18")]
        public string? CodGva18 { get; set; }

        [JsonProperty("OBSERVACIONES")]
        public string? Observaciones { get; set; }

        [JsonProperty("COD_DESCRIP")]
        public string? CodDescrip { get; set; }
    }
