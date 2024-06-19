using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.stock.deposito.model;

public class DepositoQueryRecord : BaseQueryRecord
{

    [JsonProperty("ID_STA22")]
    public int IdSta22 { get; set; }

    [JsonProperty("COD_STA22")]
    public int CodSta22 { get; set; }

    [JsonProperty("NOMBRE_SUC")]
    public string? NombreSuc { get; set; }

    [JsonProperty("INHABILITA")]
    public bool Inhabilita { get; set; }

    [JsonProperty("DIR_SUCURS")]
    public string? DirSucurs { get; set; }

    [JsonProperty("ID_SUCURSAL")]
    public int? IdSucursal { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("SINCRONIZA_NEXO_PEDIDOS")]
    public bool SincronizaNexoPedidos { get; set; }

    [JsonProperty("SUCURSAL_DESTINO")]
    public int? SucursalDestino { get; set; }

    [JsonProperty("COD_DESCRIP")]
    public string? CodDescrip { get; set; }
}
