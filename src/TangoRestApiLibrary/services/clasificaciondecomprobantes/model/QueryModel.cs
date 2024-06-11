using Newtonsoft.Json;
using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.ClasificacionDeComprobantes.model;

public class ClasificacionDeComprobantesQueryRecord : BaseQueryRecord
{
    [JsonProperty("ID_GVA81")]
    public int IdGva81 { get; set; }

    [JsonProperty("COD_GVA81")]
    public long CodGva81 { get; set; }

    [JsonProperty("DESCRIP")]
    public string? Descrip { get; set; }

    [JsonProperty("DESDE_FE")]
    public DateTime? DesdeFe { get; set; }

    [JsonProperty("HASTA_FE")]
    public DateTime? HastaFe { get; set; }

    [JsonProperty("HABIL_COMP")]
    public bool HabilComp { get; set; }

    [JsonProperty("SOL")]
    public bool Sol { get; set; }

    [JsonProperty("ORD")]
    public bool Ord { get; set; }

    [JsonProperty("RMC")]
    public bool Rmc { get; set; }

    [JsonProperty("DEV")]
    public bool Dev { get; set; }

    [JsonProperty("FCC")]
    public bool Fcc { get; set; }

    [JsonProperty("CRC")]
    public bool Crc { get; set; }

    [JsonProperty("DBC")]
    public bool Dbc { get; set; }

    [JsonProperty("OPC")]
    public bool Opc { get; set; }

    [JsonProperty("IMP")]
    public bool Imp { get; set; }

    [JsonProperty("EMB")]
    public bool Emb { get; set; }

    [JsonProperty("DES")]
    public bool Des { get; set; }

    [JsonProperty("HABIL_VENT")]
    public bool HabilVent { get; set; }

    [JsonProperty("COT")]
    public bool Cot { get; set; }

    [JsonProperty("PED")]
    public bool Ped { get; set; }

    [JsonProperty("REM")]
    public bool Rem { get; set; }

    [JsonProperty("FAC")]
    public bool Fac { get; set; }

    [JsonProperty("REC")]
    public bool Rec { get; set; }

    [JsonProperty("CRE")]
    public bool Cre { get; set; }

    [JsonProperty("DEB")]
    public bool Deb { get; set; }

    [JsonProperty("HABIL_FONDOS")]
    public bool HabilFondos { get; set; }

    [JsonProperty("F_COBROS")]
    public bool FCobros { get; set; }

    [JsonProperty("F_PAGOS")]
    public bool FPagos { get; set; }

    [JsonProperty("F_DEPOSITO")]
    public bool FDeposito { get; set; }

    [JsonProperty("F_BCOCAR")]
    public bool FBcocar { get; set; }

    [JsonProperty("F_RCHP")]
    public bool FRchp { get; set; }

    [JsonProperty("F_RCHT")]
    public bool FRcht { get; set; }

    [JsonProperty("F_MOVI")]
    public bool FMovi { get; set; }

    [JsonProperty("F_CHD")]
    public bool FChd { get; set; }

    [JsonProperty("F_CAR")]
    public bool FCar { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("FILLER")]
    public string? Filler { get; set; }

    [JsonProperty("COD_DESCRIP")]
    public string? CodDescrip { get; set; }
}
