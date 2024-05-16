using Newtonsoft.Json;
using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.transporte.model;

public  class TransporteQueryRecord: BaseQueryRecord
{
    public override int GetId()
    {
        return IdGva24;
    }

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
