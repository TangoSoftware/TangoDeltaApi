using Newtonsoft.Json;
using TangoRestApiLibrary.services.basemodel;


namespace TangoRestApiClient.services.cliente.model;

public class ClienteQuery : BaseQuery<ResultData, ClienteQueryRecord>
{
}

public class ResultData : BaseResultData<ClienteQueryRecord>
{
}


public partial class ClienteQueryRecord : BaseQueryRecord
{
    public override int GetId()
    {
        return IdGva14;
    }

    [JsonProperty("COD_GVA14")]
    public required string CodGva14 { get; set; }

    [JsonProperty("RAZON_SOCI")]
    public string? RazonSoci { get; set; }

    [JsonProperty("NOM_COM")]
    public string? NomCom { get; set; }

    [JsonProperty("CUIT")]
    public required string Cuit { get; set; }

    [JsonProperty("TELEFONO_1")]
    public string? Telefono1 { get; set; }

    [JsonProperty("TELEFONO_2")]
    public string? Telefono2 { get; set; }

    [JsonProperty("TELEFONO_MOVIL")]
    public string? TelefonoMovil { get; set; }

    [JsonProperty("E_MAIL")]
    public string? EMail { get; set; }

    [JsonProperty("WEB")]
    public string? Web { get; set; }

    [JsonProperty("HABILITADO")]
    public bool Habilitado { get; set; }

    [JsonProperty("DOMICILIO")]
    public string? Domicilio { get; set; }

    [JsonProperty("DIR_COM")]
    public string? DirCom { get; set; }

    [JsonProperty("FECHA_ALTA")]
    public DateTime? FechaAlta { get; set; }

    [JsonProperty("CUMPLEANIO")]
    public DateTime? Cumpleanio { get; set; }

    [JsonProperty("EDAD")]
    public int? Edad { get; set; }

    [JsonProperty("FECHA_INHA")]
    public DateTime? FechaInha { get; set; }

    [JsonProperty("SEXO")]
    public string? Sexo { get; set; }

    [JsonProperty("NRO_INSCR_RG1817")]
    public string? NroInscrRg1817 { get; set; }

    [JsonProperty("FECHA_VTO")]
    public DateTime? FechaVto { get; set; }

    [JsonProperty("N_IMPUESTO")]
    public string? NImpuesto { get; set; }

    [JsonProperty("NUMERO_DOCUMENTO_EXTERIOR")]
    public string? NumeroDocumentoExterior { get; set; }

    [JsonProperty("CLAUSULA")]
    public bool Clausula { get; set; }

    [JsonProperty("N_ING_BRUT")]
    public string? NIngBrut { get; set; }

    [JsonProperty("CM_VIGENCIA_COEFICIENTE")]
    public string? CmVigenciaCoeficiente { get; set; }

    [JsonProperty("N_PAGOELEC")]
    public int? NPagoelec { get; set; }

    [JsonProperty("CBU")]
    public string? Cbu { get; set; }

    [JsonProperty("COBRA_LUNES")]
    public string? CobraLunes { get; set; }

    [JsonProperty("COBRA_MARTES")]
    public string? CobraMartes { get; set; }

    [JsonProperty("COBRA_MIERCOLES")]
    public string? CobraMiercoles { get; set; }

    [JsonProperty("COBRA_JUEVES")]
    public string? CobraJueves { get; set; }

    [JsonProperty("COBRA_VIERNES")]
    public string? CobraViernes { get; set; }

    [JsonProperty("COBRA_SABADO")]
    public string? CobraSabado { get; set; }

    [JsonProperty("COBRA_DOMINGO")]
    public string? CobraDomingo { get; set; }

    [JsonProperty("HORARIO_COBRANZA")]
    public string? HorarioCobranza { get; set; }

    [JsonProperty("PUBLICA_WEB_CLIENTES")]
    public string? PublicaWebClientes { get; set; }

    [JsonProperty("MAIL_NEXO")]
    public string? MailNexo { get; set; }

    [JsonProperty("MAIL_DE")]
    public string? MailDe { get; set; }

    [JsonProperty("IDENTIF_AFIP")]
    public string? IdentifAfip { get; set; }

    [JsonProperty("CLASIFICACION")]
    public string? Clasificacion { get; set; }

    [JsonProperty("TIPO")]
    public string? Tipo { get; set; }

    [JsonProperty("SUCURSAL_NRO")]
    public int? SucursalNro { get; set; }

    [JsonProperty("SUCURSAL_DESC")]
    public string? SucursalDesc { get; set; }

    [JsonProperty("COD_TIPO_DOCUMENTO_GV")]
    public int? CodTipoDocumentoGv { get; set; }

    [JsonProperty("DESC_TIPO_DOCUMENTO_GV")]
    public string? DescTipoDocumentoGv { get; set; }

    [JsonProperty("COD_TIPO_DOCUMENTO_EXTERIOR")]
    public string? CodTipoDocumentoExterior { get; set; }

    [JsonProperty("DESC_TIPO_DOCUMENTO_EXTERIOR")]
    public string? DescTipoDocumentoExterior { get; set; }

    [JsonProperty("FAMILIA")]
    public string? Familia { get; set; }

    [JsonProperty("GRUPO")]
    public string? Grupo { get; set; }

    [JsonProperty("COMENTARIOS")]
    public string? Comentarios { get; set; }

    [JsonProperty("ID_GVA14")]
    public int IdGva14 { get; set; }

    [JsonProperty("LOCALIDAD")]
    public string? Localidad { get; set; }

    [JsonProperty("C_POSTAL")]
    public string? CPostal { get; set; }

    [JsonProperty("OBSERVACIO")]
    public string? Observacio { get; set; }

    [JsonProperty("SOBRE_IVA")]
    public string? SobreIva { get; set; }

    [JsonProperty("PORC_EXCL")]
    public long PorcExcl { get; set; }

    [JsonProperty("II_L")]
    public string? IiL { get; set; }

    [JsonProperty("II_D")]
    public string? IiD { get; set; }

    [JsonProperty("SOBRE_II")]
    public string? SobreIi { get; set; }

    [JsonProperty("RG_3572_EMPRESA_VINCULADA_CLIENTE")]
    public bool Rg3572_EmpresaVinculadaCliente { get; set; }

    [JsonProperty("PORC_DESC")]
    public long PorcDesc { get; set; }

    [JsonProperty("CUPO_CREDI")]
    public long CupoCredi { get; set; }

    [JsonProperty("MON_CTE")]
    public bool MonCte { get; set; }

    [JsonProperty("EXPORTA")]
    public bool Exporta { get; set; }

    [JsonProperty("NRO_SUCURSAL_DESTINO_FACTURA_REMITO")]
    public string? NroSucursalDestinoFacturaRemito { get; set; }

    [JsonProperty("DESC_SUCURSAL_DESTINO_FACTURA_REMITO")]
    public string? DescSucursalDestinoFacturaRemito { get; set; }

    [JsonProperty("NRO_SUCURSAL_DESTINO_FACTURA")]
    public string? NroSucursalDestinoFactura { get; set; }

    [JsonProperty("DESC_SUCURSAL_DESTINO_FACTURA")]
    public string? DescSucursalDestinoFactura { get; set; }

    [JsonProperty("APLICA_MORA")]
    public string? AplicaMora { get; set; }

    [JsonProperty("INHABILITADO_NEXO_COBRANZAS")]
    public string? InhabilitadoNexoCobranzas { get; set; }

    [JsonProperty("GVA01_COND_VTA")]
    public long Gva01CondVta { get; set; }

    [JsonProperty("GVA01_DESC_COND")]
    public string? Gva01DescCond { get; set; }

    [JsonProperty("GVA05_CODIGO")]
    public string? Gva05Codigo { get; set; }

    [JsonProperty("GVA05_DESCRIPCION")]
    public string? Gva05Descripcion { get; set; }

    [JsonProperty("GVA10_NRO_DE_LIS")]
    public long? Gva10NroDeLis { get; set; }

    [JsonProperty("GVA10_NOMBRE_LIS")]
    public string? Gva10NombreLis { get; set; }

    [JsonProperty("GVA150_CODIGO")]
    public string? Gva150Codigo { get; set; }

    [JsonProperty("GVA150_DESCRIPCION")]
    public string? Gva150Descripcion { get; set; }

    [JsonProperty("GVA151_CODIGO")]
    public string? Gva151Codigo { get; set; }

    [JsonProperty("GVA151_DESCRIPCION")]
    public string? Gva151Descripcion { get; set; }

    [JsonProperty("GVA18_CODIGO")]
    public string? Gva18Codigo { get; set; }

    [JsonProperty("GVA18_DESCRIPCION")]
    public string? Gva18Descripcion { get; set; }

    [JsonProperty("GVA133_NOM_PAIS")]
    public string? Gva133NomPais { get; set; }

    [JsonProperty("GVA23_CODIGO")]
    public string? Gva23Codigo { get; set; }

    [JsonProperty("GVA23_DESCRIPCION")]
    public string? Gva23Descripcion { get; set; }

    [JsonProperty("GVA24_CODIGO")]
    public string? Gva24Codigo { get; set; }

    [JsonProperty("GVA24_DESCRIPCION")]
    public string? Gva24Descripcion { get; set; }

    [JsonProperty("GVA41_NO_CAT_CODIGO")]
    public string? Gva41NoCatCodigo { get; set; }

    [JsonProperty("GVA41_NO_CAT_DESCRIPCION")]
    public string? Gva41NoCatDescripcion { get; set; }

    [JsonProperty("COD_CATEGORIA_IVA")]
    public string? CodCategoriaIva { get; set; }

    [JsonProperty("DESC_CATEGORIA_IVA")]
    public string? DescCategoriaIva { get; set; }

    [JsonProperty("COD_INTERES_POR_MORA")]
    public string? CodInteresPorMora { get; set; }

    [JsonProperty("DESC_INTERES_POR_MORA")]
    public string? DescInteresPorMora { get; set; }

    [JsonProperty("GVA62_CODIGO")]
    public string? Gva62Codigo { get; set; }

    [JsonProperty("GVA62_DESCRIPCION")]
    public string? Gva62Descripcion { get; set; }

    [JsonProperty("COD_RG_3572_TIPO_OPERACION_HABITUAL")]
    public string? CodRg3572_TipoOperacionHabitual { get; set; }

    [JsonProperty("DESC_RG_3572_TIPO_OPERACION_HABITUAL")]
    public string? DescRg3572_TipoOperacionHabitual { get; set; }

    [JsonProperty("COD_OPERACION_AFIP_VENTAS")]
    public string? CodOperacionAfipVentas { get; set; }

    [JsonProperty("DESC_OPERACION_AFIP_VENTAS")]
    public string? DescOperacionAfipVentas { get; set; }

    [JsonProperty("GVA44_FEX_CODIGO")]
    public string? Gva44FexCodigo { get; set; }

    [JsonProperty("GVA44_FEX_TALONARIO")]
    public string? Gva44FexTalonario { get; set; }

    [JsonProperty("GVA44_NCEX_CODIGO")]
    public string? Gva44NcexCodigo { get; set; }

    [JsonProperty("GVA44_NCEX_TALONARIO")]
    public string? Gva44NcexTalonario { get; set; }

    [JsonProperty("GVA44_NDEX_CODIGO")]
    public string? Gva44NdexCodigo { get; set; }

    [JsonProperty("GVA44_NDEX_TALONARIO")]
    public string? Gva44NdexTalonario { get; set; }

    [JsonProperty("DESTINO_DE")]
    public string? DestinoDe { get; set; }

    [JsonProperty("IDIOMA_CTE")]
    public string? IdiomaCte { get; set; }

    [JsonProperty("DET_ARTIC")]
    public string? DetArtic { get; set; }

    [JsonProperty("INC_COMENT")]
    public string? IncComent { get; set; }

    [JsonProperty("TYP_FEX")]
    public string? TypFex { get; set; }

    [JsonProperty("COMENTARIO_TYP_FAC")]
    public string? ComentarioTypFac { get; set; }

    [JsonProperty("TYP_NCEX")]
    public string? TypNcex { get; set; }

    [JsonProperty("COMENTARIO_TYP_ND")]
    public string? ComentarioTypNd { get; set; }

    [JsonProperty("TYP_NDEX")]
    public string? TypNdex { get; set; }

    [JsonProperty("COMENTARIO_TYP_NC")]
    public string? ComentarioTypNc { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }
}
