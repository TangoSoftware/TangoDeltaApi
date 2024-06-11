using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.Deposito.model;

public class DepositoData : BaseData
{

    [Newtonsoft.Json.JsonProperty("ID_STA22", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int ID_STA22 { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_STA22", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? COD_STA22 { get; set; }

    [Newtonsoft.Json.JsonProperty("NOMBRE_SUC", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(30)]
    public string? NOMBRE_SUC { get; set; }

    [Newtonsoft.Json.JsonProperty("INHABILITA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? INHABILITA { get; set; }

    [Newtonsoft.Json.JsonProperty("DIR_SUCURS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(30)]
    public string? DIR_SUCURS { get; set; }

    [Newtonsoft.Json.JsonProperty("ID_SUCURSAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? ID_SUCURSAL { get; set; }

    [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(8000)]
    public string? OBSERVACIONES { get; set; }

    [Newtonsoft.Json.JsonProperty("SINCRONIZA_NEXO_PEDIDOS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? SINCRONIZA_NEXO_PEDIDOS { get; set; }

    [Newtonsoft.Json.JsonProperty("SUCURSAL_DESTINO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? SUCURSAL_DESTINO { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_DESCRIP { get; set; }

}
