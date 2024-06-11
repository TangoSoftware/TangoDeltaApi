using Newtonsoft.Json;
using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.ClasificacionDeComprobantes.model;

public class ClasificacionDeComprobantesData : BaseData
{
    [JsonProperty("ID_GVA81")]
    public int IdGva81 { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_GVA81", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? COD_GVA81 { get; set; }

    [Newtonsoft.Json.JsonProperty("DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(40)]
    public string? DESCRIP { get; set; }

    [Newtonsoft.Json.JsonProperty("DESDE_FE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? DESDE_FE { get; set; }

    [Newtonsoft.Json.JsonProperty("HASTA_FE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.DateTimeOffset? HASTA_FE { get; set; }

    [Newtonsoft.Json.JsonProperty("HABIL_COMP", Required = Newtonsoft.Json.Required.Always)]
    public bool HABIL_COMP { get; set; }

    [Newtonsoft.Json.JsonProperty("SOL", Required = Newtonsoft.Json.Required.Always)]
    public bool SOL { get; set; }

    [Newtonsoft.Json.JsonProperty("ORD", Required = Newtonsoft.Json.Required.Always)]
    public bool ORD { get; set; }

    [Newtonsoft.Json.JsonProperty("RMC", Required = Newtonsoft.Json.Required.Always)]
    public bool RMC { get; set; }

    [Newtonsoft.Json.JsonProperty("DEV", Required = Newtonsoft.Json.Required.Always)]
    public bool DEV { get; set; }

    [Newtonsoft.Json.JsonProperty("FCC", Required = Newtonsoft.Json.Required.Always)]
    public bool FCC { get; set; }

    [Newtonsoft.Json.JsonProperty("CRC", Required = Newtonsoft.Json.Required.Always)]
    public bool CRC { get; set; }

    [Newtonsoft.Json.JsonProperty("DBC", Required = Newtonsoft.Json.Required.Always)]
    public bool DBC { get; set; }

    [Newtonsoft.Json.JsonProperty("OPC", Required = Newtonsoft.Json.Required.Always)]
    public bool OPC { get; set; }

    [Newtonsoft.Json.JsonProperty("IMP", Required = Newtonsoft.Json.Required.Always)]
    public bool IMP { get; set; }

    [Newtonsoft.Json.JsonProperty("EMB", Required = Newtonsoft.Json.Required.Always)]
    public bool EMB { get; set; }

    [Newtonsoft.Json.JsonProperty("DES", Required = Newtonsoft.Json.Required.Always)]
    public bool DES { get; set; }

    [Newtonsoft.Json.JsonProperty("HABIL_VENT", Required = Newtonsoft.Json.Required.Always)]
    public bool HABIL_VENT { get; set; }

    [Newtonsoft.Json.JsonProperty("COT", Required = Newtonsoft.Json.Required.Always)]
    public bool COT { get; set; }

    [Newtonsoft.Json.JsonProperty("PED", Required = Newtonsoft.Json.Required.Always)]
    public bool PED { get; set; }

    [Newtonsoft.Json.JsonProperty("REM", Required = Newtonsoft.Json.Required.Always)]
    public bool REM { get; set; }

    [Newtonsoft.Json.JsonProperty("FAC", Required = Newtonsoft.Json.Required.Always)]
    public bool FAC { get; set; }

    [Newtonsoft.Json.JsonProperty("REC", Required = Newtonsoft.Json.Required.Always)]
    public bool REC { get; set; }

    [Newtonsoft.Json.JsonProperty("CRE", Required = Newtonsoft.Json.Required.Always)]
    public bool CRE { get; set; }

    [Newtonsoft.Json.JsonProperty("DEB", Required = Newtonsoft.Json.Required.Always)]
    public bool DEB { get; set; }

    [Newtonsoft.Json.JsonProperty("HABIL_FONDOS", Required = Newtonsoft.Json.Required.Always)]
    public bool HABIL_FONDOS { get; set; }

    [Newtonsoft.Json.JsonProperty("F_COBROS", Required = Newtonsoft.Json.Required.Always)]
    public bool F_COBROS { get; set; }

    [Newtonsoft.Json.JsonProperty("F_PAGOS", Required = Newtonsoft.Json.Required.Always)]
    public bool F_PAGOS { get; set; }

    [Newtonsoft.Json.JsonProperty("F_DEPOSITO", Required = Newtonsoft.Json.Required.Always)]
    public bool F_DEPOSITO { get; set; }

    [Newtonsoft.Json.JsonProperty("F_BCOCAR", Required = Newtonsoft.Json.Required.Always)]
    public bool F_BCOCAR { get; set; }

    [Newtonsoft.Json.JsonProperty("F_RCHP", Required = Newtonsoft.Json.Required.Always)]
    public bool F_RCHP { get; set; }

    [Newtonsoft.Json.JsonProperty("F_RCHT", Required = Newtonsoft.Json.Required.Always)]
    public bool F_RCHT { get; set; }

    [Newtonsoft.Json.JsonProperty("F_MOVI", Required = Newtonsoft.Json.Required.Always)]
    public bool F_MOVI { get; set; }

    [Newtonsoft.Json.JsonProperty("F_CHD", Required = Newtonsoft.Json.Required.Always)]
    public bool F_CHD { get; set; }

    [Newtonsoft.Json.JsonProperty("F_CAR", Required = Newtonsoft.Json.Required.Always)]
    public bool F_CAR { get; set; }

    [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? OBSERVACIONES { get; set; }

    [Newtonsoft.Json.JsonProperty("FILLER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? FILLER { get; set; }

    [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? COD_DESCRIP { get; set; }

}
