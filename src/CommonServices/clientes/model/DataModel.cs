using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.cliente.model;

public partial class ClienteData : BaseData
{
    [JsonProperty("DIRECCION_ENTREGA")]
    public List<DireccionEntrega>? DireccionEntrega { get; set; }

    [JsonProperty("CONTACTOS")]
    public List<Contacto>? Contactos { get; set; }

    [JsonProperty("ID_GVA14_DEFECTO")]
    public int? IdGva14Defecto { get; set; }

    //[JsonProperty("GVA14ITC")]
    //public object[] Gva14Itc { get; set; } //ver

    [JsonProperty("ID_GVA14")]
    public int IdGva14 { get; set; }

    [JsonProperty("COD_GVA14")]
    public required string CodGva14 { get; set; }

    [JsonProperty("ID_TIPO_DOCUMENTO_GV")]
    public int IdTipoDocumentoGv { get; set; }

    [JsonProperty("CUIT")]
    public string? Cuit { get; set; }

    [JsonProperty("RAZON_SOCI")]
    public string? RazonSoci { get; set; }

    [JsonProperty("DOMICILIO")]
    public string? Domicilio { get; set; }

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

    [JsonProperty("NOM_COM")]
    public string? NomCom { get; set; }

    [JsonProperty("DIR_COM")]
    public string? DirCom { get; set; }

    [JsonProperty("FECHA_ALTA")]
    public DateTime? FechaAlta { get; set; }

    [JsonProperty("CUMPLEANIO")]
    public DateTime? Cumpleanio { get; set; }

    [JsonProperty("FECHA_INHA")]
    public DateTime? FechaInha { get; set; }

    [JsonProperty("SEXO")]
    public string? Sexo { get; set; }

    [JsonProperty("ID_SUCURSAL")]
    public int? IdSucursal { get; set; }

    [JsonProperty("NRO_INSCR_RG1817")]
    public string? NroInscrRg1817 { get; set; }

    [JsonProperty("FECHA_VTO")]
    public DateTime? FechaVto { get; set; }

    [JsonProperty("N_IMPUESTO")]
    public string? NImpuesto { get; set; }

    [JsonProperty("ID_TIPO_DOCUMENTO_EXTERIOR")]
    public int? IdTipoDocumentoExterior { get; set; }

    [JsonProperty("NUMERO_DOCUMENTO_EXTERIOR")]
    public string? NumeroDocumentoExterior { get; set; }

    [JsonProperty("CLAUSULA")]
    public bool Clausula { get; set; }

    [JsonProperty("TIPO")]
    public string? Tipo { get; set; }

    [JsonProperty("N_ING_BRUT")]
    public string? NIngBrut { get; set; }

    [JsonProperty("CM_VIGENCIA_COEFICIENTE")]
    public string? CmVigenciaCoeficiente { get; set; }

    [JsonProperty("ADJUNTO")]
    public string? Adjunto { get; set; }

    [JsonProperty("CALLE")]
    public string? Calle { get; set; }

    [JsonProperty("DTO_LEGAL")]
    public string? DtoLegal { get; set; }

    [JsonProperty("ENV_PROV")]
    public string? EnvProv { get; set; }

    [JsonProperty("FECHA_ANT")]
    public DateTime? FechaAnt { get; set; }

    [JsonProperty("NRO_LEGAL")]
    public long NroLegal { get; set; }

    [JsonProperty("PISO_LEGAL")]
    public long PisoLegal { get; set; }

    [JsonProperty("SALDO_ANT")]
    public decimal SaldoAnt { get; set; }

    [JsonProperty("SALDO_CC")]
    public decimal SaldoCc { get; set; }

    [JsonProperty("SALDO_DOC")]
    public decimal SaldoDoc { get; set; }

    [JsonProperty("SALDO_D_UN")]
    public decimal SaldoDUn { get; set; }

    [JsonProperty("TIPO_DOC")]
    public string? TipoDoc { get; set; }

    [JsonProperty("ZONA_ENVIO")]
    public string? ZonaEnvio { get; set; }

    [JsonProperty("FECHA_MODI")]
    public DateTime? FechaModi { get; set; }

    [JsonProperty("N_PAGOELEC")]
    public string? NPagoelec { get; set; }

    [JsonProperty("SAL_AN_UN")]
    public decimal SalAnUn { get; set; }

    [JsonProperty("SALDO_CC_U")]
    public decimal SaldoCcU { get; set; }

    [JsonProperty("SUCUR_ORI")]
    public int SucurOri { get; set; }

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

    [JsonProperty("COD_GVA05_ENV")]
    public string? CodGva05Env { get; set; }

    [JsonProperty("COD_GVA18_ENV")]
    public string? CodGva18Env { get; set; }

    [JsonProperty("WEB_CLIENT_ID")]
    public int? WebClientId { get; set; }

    [JsonProperty("PUBLICA_WEB_CLIENTES")]
    public string? PublicaWebClientes { get; set; }

    [JsonProperty("MAIL_NEXO")]
    public string? MailNexo { get; set; }

    [JsonProperty("MAIL_DE")]
    public string? MailDe { get; set; }

    [JsonProperty("IDENTIF_AFIP")]
    public string? IdentifAfip { get; set; }

    [JsonProperty("COD_DESCRIP")]
    public string? CodDescrip { get; set; }

    [JsonProperty("FILLER")]
    public string? Filler { get; set; }

    [JsonProperty("LOCALIDAD")]
    public string? Localidad { get; set; }

    [JsonProperty("COD_GVA18")]
    public string? CodGva18 { get; set; }

    [JsonProperty("C_POSTAL")]
    public string? CPostal { get; set; }

    [JsonProperty("ID_GVA05")]
    public int? IdGva05 { get; set; }

    [JsonProperty("ID_GVA18")]
    public int? IdGva18 { get; set; }

    [JsonProperty("ID_GVA151")]
    public int? IdGva151 { get; set; }

    [JsonProperty("ID_GVA62")]
    public int? IdGva62 { get; set; }

    [JsonProperty("ID_GVA23")]
    public int? IdGva23 { get; set; }

    [JsonProperty("ID_GVA24")]
    public int? IdGva24 { get; set; }

    [JsonProperty("OBSERVACIO")]
    public string? Observacio { get; set; }

    [JsonProperty("ID_CATEGORIA_IVA")]
    public int? IdCategoriaIva { get; set; }

    [JsonProperty("ID_GVA41_NO_CAT")]
    public int? IdGva41NoCat { get; set; }

    [JsonProperty("SOBRE_IVA")]
    public string? SobreIva { get; set; }

    [JsonProperty("PORC_EXCL")]
    public decimal PorcExcl { get; set; }

    [JsonProperty("II_L")]
    public string? IiL { get; set; }

    [JsonProperty("II_D")]
    public string? IiD { get; set; }

    [JsonProperty("SOBRE_II")]
    public string? SobreIi { get; set; }

    [JsonProperty("ALI_NO_CAT")]
    public string? AliNoCat { get; set; }

    [JsonProperty("ID_GVA150")]
    public int? IdGva150 { get; set; }

    [JsonProperty("RG_3572_EMPRESA_VINCULADA_CLIENTE")]
    public bool Rg3572_EmpresaVinculadaCliente { get; set; }

    [JsonProperty("ID_RG_3572_TIPO_OPERACION_HABITUAL")]
    public int? IdRg3572_TipoOperacionHabitual { get; set; }

    [JsonProperty("RG_3572_TIPO_OPERACION_HABITUAL_VENTAS")]
    public string? Rg3572_TipoOperacionHabitualVentas { get; set; }

    [JsonProperty("ID_RG_3685_TIPO_OPERACION_VENTAS")]
    public int? IdRg3685_TipoOperacionVentas { get; set; }

    [JsonProperty("ID_GVA01")]
    public int? IdGva01 { get; set; }

    [JsonProperty("ID_GVA10")]
    public int? IdGva10 { get; set; }

    [JsonProperty("PORC_DESC")]
    public decimal PorcDesc { get; set; }

    [JsonProperty("CUPO_CREDI")]
    public decimal CupoCredi { get; set; }

    [JsonProperty("MON_CTE")]
    public bool MonCte { get; set; }

    [JsonProperty("EXPORTA")]
    public bool Exporta { get; set; }

    [JsonProperty("APLICA_MORA")]
    public string? AplicaMora { get; set; }

    [JsonProperty("ID_INTERES_POR_MORA")]
    public int? IdInteresPorMora { get; set; }

    [JsonProperty("INHABILITADO_NEXO_COBRANZAS")]
    public string? InhabilitadoNexoCobranzas { get; set; }

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

    [JsonProperty("ID_GVA44_FEX")]
    public int? IdGva44Fex { get; set; }

    [JsonProperty("COMENTARIO_TYP_FAC")]
    public string? ComentarioTypFac { get; set; }

    [JsonProperty("TYP_NCEX")]
    public string? TypNcex { get; set; }

    [JsonProperty("ID_GVA44_NCEX")]
    public int? IdGva44Ncex { get; set; }

    [JsonProperty("COMENTARIO_TYP_ND")]
    public string? ComentarioTypNd { get; set; }

    [JsonProperty("TYP_NDEX")]
    public string? TypNdex { get; set; }

    [JsonProperty("ID_GVA44_NDEX")]
    public int? IdGva44Ndex { get; set; }

    [JsonProperty("COMENTARIO_TYP_NC")]
    public string? ComentarioTypNc { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("COD_GVA05")]
    public string? CodGva05 { get; set; }

    [JsonProperty("COD_GVA24")]
    public string? CodGva24 { get; set; }

    [JsonProperty("COD_GVA151")]
    public string? CodGva151 { get; set; }

    [JsonProperty("COD_GVA62")]
    public string? CodGva62 { get; set; }

    [JsonProperty("COD_GVA23")]
    public string? CodGva23 { get; set; }

    [JsonProperty("COD_RUBRO")]
    public string? CodRubro { get; set; }

    [JsonProperty("NRO_LISTA")]
    public long? NroLista { get; set; }

    [JsonProperty("IVA_D")]
    public string? IvaD { get; set; }

    [JsonProperty("IVA_L")]
    public string? IvaL { get; set; }

    [JsonProperty("COD_GVA150")]
    public string? CodGva150 { get; set; }

    [JsonProperty("GRUPO_EMPR")]
    public string? GrupoEmpr { get; set; }

    [JsonProperty("CLA_IMP_CL")]
    public string? ClaImpCl { get; set; }

    [JsonProperty("INHABILITADO_NEXO_PEDIDOS")]
    public string? InhabilitadoNexoPedidos { get; set; }

    [JsonProperty("RG_3685_TIPO_OPERACION_VENTAS")]
    public string? Rg3685_TipoOperacionVentas { get; set; }

    [JsonProperty("COD_PROVIN")]
    public string? CodProvin { get; set; }

    [JsonProperty("COD_TRANSP")]
    public string? CodTransp { get; set; }

    [JsonProperty("COD_VENDED")]
    public string? CodVended { get; set; }

    [JsonProperty("COD_ZONA")]
    public string? CodZona { get; set; }

    [JsonProperty("COND_VTA")]
    public long? CondVta { get; set; }

    [JsonProperty("ID_SUCURSAL_DESTINO_FACTURA_REMITO")]
    public int? IdSucursalDestinoFacturaRemito { get; set; }

    [JsonProperty("ID_SUCURSAL_DESTINO_FACTURA")]
    public int? IdSucursalDestinoFactura { get; set; }
}

public class Contacto
{
    [JsonProperty("ID_GVA27")]
    public int IdGva27 { get; set; }

    [JsonProperty("ID_GVA14")]
    public int IdGva14 { get; set; }

    [JsonProperty("ID_TIPO_DOCUMENTO")]
    public int? IdTipoDocumento { get; set; }

    [JsonProperty("FILLER")]
    public string? Filler { get; set; }

    [JsonProperty("CARGO")]
    public string? Cargo { get; set; }

    [JsonProperty("COD_CLIENT")]
    public string? CodClient { get; set; }

    [JsonProperty("DEFECTO")]
    public string? Defecto { get; set; }

    [JsonProperty("E_MAIL_CONTACTO")]
    public string? EMailContacto { get; set; }

    [JsonProperty("NOMBRE")]
    public string? Nombre { get; set; }

    [JsonProperty("OBSERVACIO")]
    public string? Observacio { get; set; }

    [JsonProperty("TELEFONO")]
    public string? Telefono { get; set; }

    [JsonProperty("ENVIA_PDF_COTIZACION")]
    public string? EnviaPdfCotizacion { get; set; }

    [JsonProperty("ENVIA_PDF_RECIBO")]
    public string? EnviaPdfRecibo { get; set; }

    [JsonProperty("INVITA_WEB_CLIENTES")]
    public string? InvitaWebClientes { get; set; }

    [JsonProperty("TELEFONO_MOVIL")]
    public string? TelefonoMovil { get; set; }

    [JsonProperty("PAGADOR_HABITUAL")]
    public string? PagadorHabitual { get; set; }

    [JsonProperty("TIPO_DOCUMENTO")]
    public string? TipoDocumento { get; set; }

    [JsonProperty("NUMERO_DOCUMENTO")]
    public string? NumeroDocumento { get; set; }

    [JsonProperty("USUARIO_TIENDA")]
    public string? UsuarioTienda { get; set; }
}

public partial class DireccionEntrega
{
    [JsonProperty("GVA144")]
    public List<Gva144>? Gva144 { get; set; }

    [JsonProperty("ID_DIRECCION_ENTREGA")]
    public int IdDireccionEntrega { get; set; }

    [JsonProperty("ID_GVA14")]
    public int IdGva14 { get; set; }

    [JsonProperty("ID_GVA18")]
    public int? IdGva18 { get; set; }

    [JsonProperty("ID_AL_FIJ_IB3")]
    public int? IdAlFijIb3 { get; set; }

    [JsonProperty("ID_ALI_ADI_IB")]
    public string? IdAliAdiIb { get; set; }

    [JsonProperty("ID_ALI_FIJ_IB")]
    public int? IdAliFijIb { get; set; }

    [JsonProperty("COD_DIRECCION_ENTREGA")]
    public string? CodDireccionEntrega { get; set; }

    [JsonProperty("COD_CLIENTE")]
    public string? CodCliente { get; set; }

    [JsonProperty("DIRECCION")]
    public string? Direccion { get; set; }

    [JsonProperty("COD_PROVINCIA")]
    public string? CodProvincia { get; set; }

    [JsonProperty("LOCALIDAD")]
    public string? Localidad { get; set; }

    [JsonProperty("HABITUAL")]
    public string? Habitual { get; set; }

    [JsonProperty("CODIGO_POSTAL")]
    public string? CodigoPostal { get; set; }

    [JsonProperty("TELEFONO1")]
    public string? Telefono1 { get; set; }

    [JsonProperty("TELEFONO2")]
    public string? Telefono2 { get; set; }

    [JsonProperty("TOMA_IMPUESTO_HABITUAL")]
    public string? TomaImpuestoHabitual { get; set; }

    [JsonProperty("FILLER")]
    public string? Filler { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("AL_FIJ_IB3")]
    public string? AlFijIb3 { get; set; }

    [JsonProperty("ALI_ADI_IB")]
    public string? AliAdiIb { get; set; }

    [JsonProperty("ALI_FIJ_IB")]
    public string? AliFijIb { get; set; }

    [JsonProperty("IB_L")]
    public bool IbL { get; set; }

    [JsonProperty("IB_L3")]
    public bool IbL3 { get; set; }

    [JsonProperty("II_IB3")]
    public bool IiIb3 { get; set; }

    [JsonProperty("LIB")]
    public string? Lib { get; set; }

    [JsonProperty("PORC_L")]
    public long PorcL { get; set; }

    [JsonProperty("HABILITADO")]
    public string? Habilitado { get; set; }

    [JsonProperty("HORARIO_ENTREGA")]
    public string? HorarioEntrega { get; set; }

    [JsonProperty("ENTREGA_LUNES")]
    public string? EntregaLunes { get; set; }

    [JsonProperty("ENTREGA_MARTES")]
    public string? EntregaMartes { get; set; }

    [JsonProperty("ENTREGA_MIERCOLES")]
    public string? EntregaMiercoles { get; set; }

    [JsonProperty("ENTREGA_JUEVES")]
    public string? EntregaJueves { get; set; }

    [JsonProperty("ENTREGA_VIERNES")]
    public string? EntregaViernes { get; set; }

    [JsonProperty("ENTREGA_SABADO")]
    public string? EntregaSabado { get; set; }

    [JsonProperty("ENTREGA_DOMINGO")]
    public string? EntregaDomingo { get; set; }

    [JsonProperty("CONSIDERA_IVA_BASE_CALCULO_IIBB")]
    public string? ConsideraIvaBaseCalculoIibb { get; set; }

    [JsonProperty("CONSIDERA_IVA_BASE_CALCULO_IIBB_ADIC")]
    public string? ConsideraIvaBaseCalculoIibbAdic { get; set; }

    [JsonProperty("WEB_ADDRESS_ID")]
    public string? WebAddressId { get; set; }

    [JsonProperty("COD_DESCRIP")]
    public string? CodDescrip { get; set; }
}

public partial class Gva144
{
    [JsonProperty("ID_GVA144")]
    public int IdGva144 { get; set; }

    [JsonProperty("COD_IMPUES")]
    public string? CodImpues { get; set; }

    [JsonProperty("COD_ALICUO")]
    public long CodAlicuo { get; set; }

    [JsonProperty("COD_CLIENT")]
    public string? CodClient { get; set; }

    [JsonProperty("LEYENDA")]
    public string? Leyenda { get; set; }

    [JsonProperty("FILLER")]
    public string? Filler { get; set; }

    [JsonProperty("DESDE_EXEN")]
    public DateTime? DesdeExen { get; set; }

    [JsonProperty("HASTA_EXEN")]
    public DateTime? HastaExen { get; set; }

    [JsonProperty("PORC_EXEN")]
    public decimal PorcExen { get; set; }

    [JsonProperty("CERT_EXEN")]
    public string? CertExen { get; set; }

    [JsonProperty("ID_DIRECCION_ENTREGA")]
    public int IdDireccionEntrega { get; set; }

    [JsonProperty("COD_PERCEPCION_VENTAS")]
    public string? CodPercepcionVentas { get; set; }

    [JsonProperty("ID_PERCEPCION_VENTAS")]
    public long IdPercepcionVentas { get; set; }

    [JsonProperty("ID_PERCEPCION_VENTAS_ALICUOTA")]
    public long IdPercepcionVentasAlicuota { get; set; }
}

