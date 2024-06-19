using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.ClasificacionDeComprobantes.model;

public class ClasificacionDeComprobantesData : BaseData
{
    [JsonProperty("ID_GVA81")]
    public int IdGva81 { get; set; }

    [JsonProperty("COD_GVA81", Required = Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(10)]
    public string? COD_GVA81 { get; set; }

    [JsonProperty("DESCRIP", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(40)]
    public string? DESCRIP { get; set; }

    [JsonProperty("DESDE_FE", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? DESDE_FE { get; set; }

    [JsonProperty("HASTA_FE", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? HASTA_FE { get; set; }

    [JsonProperty("HABIL_COMP", Required = Required.Always)]
    public bool HABIL_COMP { get; set; }

    [JsonProperty("SOL", Required = Required.Always)]
    public bool SOL { get; set; }

    [JsonProperty("ORD", Required = Required.Always)]
    public bool ORD { get; set; }

    [JsonProperty("RMC", Required = Required.Always)]
    public bool RMC { get; set; }

    [JsonProperty("DEV", Required = Required.Always)]
    public bool DEV { get; set; }

    [JsonProperty("FCC", Required = Required.Always)]
    public bool FCC { get; set; }

    [JsonProperty("CRC", Required = Required.Always)]
    public bool CRC { get; set; }

    [JsonProperty("DBC", Required = Required.Always)]
    public bool DBC { get; set; }

    [JsonProperty("OPC", Required = Required.Always)]
    public bool OPC { get; set; }

    [JsonProperty("IMP", Required = Required.Always)]
    public bool IMP { get; set; }

    [JsonProperty("EMB", Required = Required.Always)]
    public bool EMB { get; set; }

    [JsonProperty("DES", Required = Required.Always)]
    public bool DES { get; set; }

    [JsonProperty("HABIL_VENT", Required = Required.Always)]
    public bool HABIL_VENT { get; set; }

    [JsonProperty("COT", Required = Required.Always)]
    public bool COT { get; set; }

    [JsonProperty("PED", Required = Required.Always)]
    public bool PED { get; set; }

    [JsonProperty("REM", Required = Required.Always)]
    public bool REM { get; set; }

    [JsonProperty("FAC", Required = Required.Always)]
    public bool FAC { get; set; }

    [JsonProperty("REC", Required = Required.Always)]
    public bool REC { get; set; }

    [JsonProperty("CRE", Required = Required.Always)]
    public bool CRE { get; set; }

    [JsonProperty("DEB", Required = Required.Always)]
    public bool DEB { get; set; }

    [JsonProperty("HABIL_FONDOS", Required = Required.Always)]
    public bool HABIL_FONDOS { get; set; }

    [JsonProperty("F_COBROS", Required = Required.Always)]
    public bool F_COBROS { get; set; }

    [JsonProperty("F_PAGOS", Required = Required.Always)]
    public bool F_PAGOS { get; set; }

    [JsonProperty("F_DEPOSITO", Required = Required.Always)]
    public bool F_DEPOSITO { get; set; }

    [JsonProperty("F_BCOCAR", Required = Required.Always)]
    public bool F_BCOCAR { get; set; }

    [JsonProperty("F_RCHP", Required = Required.Always)]
    public bool F_RCHP { get; set; }

    [JsonProperty("F_RCHT", Required = Required.Always)]
    public bool F_RCHT { get; set; }

    [JsonProperty("F_MOVI", Required = Required.Always)]
    public bool F_MOVI { get; set; }

    [JsonProperty("F_CHD", Required = Required.Always)]
    public bool F_CHD { get; set; }

    [JsonProperty("F_CAR", Required = Required.Always)]
    public bool F_CAR { get; set; }

    [JsonProperty("OBSERVACIONES", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? OBSERVACIONES { get; set; }

    [JsonProperty("FILLER", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? FILLER { get; set; }

    [JsonProperty("COD_DESCRIP", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? COD_DESCRIP { get; set; }
}