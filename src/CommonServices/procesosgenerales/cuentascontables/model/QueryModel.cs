
using Newtonsoft.Json;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.procesosgenerales.cuentascontables.model;

public class CuentasContablesQueryRecord : BaseQueryRecord
{
    [JsonProperty("ID_CUENTA")]
    public int IdCuenta { get; set; }

    [JsonProperty("COD_CUENTA")]
    public string? CodCuenta { get; set; }

    [JsonProperty("DESC_CUENTA")]
    public string? DescCuenta { get; set; }

    [JsonProperty("COD_DESC_CUENTA")]
    public string? CodDescCuenta { get; set; }

    [JsonProperty("COD_CUENTA_ALTERNATIVO")]
    public string? CodCuentaAlternativo { get; set; }

    [JsonProperty("CLASE_CUENTA")]
    public string? ClaseCuenta { get; set; }

    [JsonProperty("COD_CLASE_CUENTA")]
    public string? CodClaseCuenta { get; set; }

    [JsonProperty("DESC_CLASE_CUENTA")]
    public string? DescClaseCuenta { get; set; }

    [JsonProperty("SALDO_HABITUAL")]
    public string? SaldoHabitual { get; set; }

    [JsonProperty("TIPO_CUENTA")]
    public string? TipoCuenta { get; set; }

    [JsonProperty("USA_AUXILIARES_CONTABLES")]
    public string? UsaAuxiliaresContables { get; set; }

    [JsonProperty("HABILITADO")]
    public string? Habilitado { get; set; }

    [JsonProperty("DESFE_INHABILITADO")]
    public DateTime? DesfeInhabilitado { get; set; }

    [JsonProperty("HASFE_INHABILITADO")]
    public DateTime? HasfeInhabilitado { get; set; }

    [JsonProperty("REGISTRACION_AUTOMATICA")]
    public string? RegistracionAutomatica { get; set; }

    [JsonProperty("AFECTA_AJUSTE_INFLACION")]
    public string? AfectaAjusteInflacion { get; set; }

    [JsonProperty("USA_UNIDAD_ADICIONAL")]
    public string? UsaUnidadAdicional { get; set; }

    [JsonProperty("AFECTA_CONVERSION")]
    public string? AfectaConversion { get; set; }

    [JsonProperty("OBSERVACIONES")]
    public string? Observaciones { get; set; }

    [JsonProperty("AFECTA_COMPROBACION_AJUSTE")]
    public string? AfectaComprobacionAjuste { get; set; }

    [JsonProperty("COD_CUENTA_PROPORCION_AJUSTE")]
    public long? CodCuentaProporcionAjuste { get; set; }

    [JsonProperty("DESC_CUENTA_PROPORCION_AJUSTE")]
    public string? DescCuentaProporcionAjuste { get; set; }

    [JsonProperty("COD_CUENTA_RDO_INFLAC_NEGATIVO")]
    public long? CodCuentaRdoInflacNegativo { get; set; }

    [JsonProperty("DESC_CUENTA_RDO_INFLAC_NEGATIVO")]
    public string? DescCuentaRdoInflacNegativo { get; set; }

    [JsonProperty("COD_CUENTA_RDO_INFLAC_POSITIVO")]
    public long? CodCuentaRdoInflacPositivo { get; set; }

    [JsonProperty("DESC_CUENTA_RDO_INFLAC_POSITIVO")]
    public string? DescCuentaRdoInflacPositivo { get; set; }

    [JsonProperty("COD_MONEDA")]
    public string? CodMoneda { get; set; }

    [JsonProperty("DESC_MONEDA")]
    public string? DescMoneda { get; set; }

    [JsonProperty("TIPO_CONVERSION")]
    public string? TipoConversion { get; set; }

    [JsonProperty("COD_CUENTA_CONVERSION")]
    public string? CodCuentaConversion { get; set; }

    [JsonProperty("DESC_CUENTA_CONVERSION")]
    public string? DescCuentaConversion { get; set; }

    [JsonProperty("COD_CUENTA_TRASLACION")]
    public string? CodCuentaTraslacion { get; set; }

    [JsonProperty("DESC_CUENTA_TRASLACION")]
    public string? DescCuentaTraslacion { get; set; }

    [JsonProperty("COD_CUENTA_TENENCIA")]
    public long? CodCuentaTenencia { get; set; }

    [JsonProperty("DES_CUENTA_TENENCIA")]
    public string? DesCuentaTenencia { get; set; }

    [JsonProperty("COD_CUENTA_RDO_TENENCIA_NEGATIVO")]
    public long? CodCuentaRdoTenenciaNegativo { get; set; }

    [JsonProperty("DESC_CUENTA_RDO_TENENCIA_NEGATIVO")]
    public string? DescCuentaRdoTenenciaNegativo { get; set; }

    [JsonProperty("COD_CUENTA_RDO_TENENCIA_POSITIVO")]
    public long? CodCuentaRdoTenenciaPositivo { get; set; }

    [JsonProperty("DESC_CUENTA_RDO_TENENCIA_POSITIVO")]
    public string? DescCuentaRdoTenenciaPositivo { get; set; }

    [JsonProperty("COD_INDICE")]
    public string? CodIndice { get; set; }

    [JsonProperty("DESC_INDICE")]
    public string? DescIndice { get; set; }

    [JsonProperty("COD_INDICE_COMPROBACION_AJUSTE")]
    public string? CodIndiceComprobacionAjuste { get; set; }

    [JsonProperty("DESC_INDICE_COMPROBACION_AJUSTE")]
    public string? DescIndiceComprobacionAjuste { get; set; }

    [JsonProperty("COD_TIPO_COTIZACION")]
    public string? CodTipoCotizacion { get; set; }

    [JsonProperty("DESC_TIPO_COTIZACION")]
    public string? DescTipoCotizacion { get; set; }

    [JsonProperty("COD_TIPO_ASIENTO_CONVERSION")]
    public string? CodTipoAsientoConversion { get; set; }

    [JsonProperty("DESC_TIPO_ASIENTO_CONVERSION")]
    public string? DescTipoAsientoConversion { get; set; }

    [JsonProperty("COD_TIPO_ASIENTO")]
    public string? CodTipoAsiento { get; set; }

    [JsonProperty("DESC_TIPO_ASIENTO")]
    public string? DescTipoAsiento { get; set; }

    [JsonProperty("COD_CUENTA_RDO_EJE_POSITIVO")]
    public long? CodCuentaRdoEjePositivo { get; set; }

    [JsonProperty("DESC_CUENTA_RDO_EJE_POSITIVO")]
    public string? DescCuentaRdoEjePositivo { get; set; }

    [JsonProperty("COD_CUENTA_RDO_EJE_NEGATIVO")]
    public long? CodCuentaRdoEjeNegativo { get; set; }

    [JsonProperty("DESC_CUENTA_RDO_EJE_NEGATIVO")]
    public string? DescCuentaRdoEjeNegativo { get; set; }

    [JsonProperty("COD_CUENTA_RESULTADO_ACUMULADO")]
    public long? CodCuentaResultadoAcumulado { get; set; }

    [JsonProperty("DESC_CUENTA_RESULTADO_ACUMULADO")]
    public string? DescCuentaResultadoAcumulado { get; set; }

    [JsonProperty("TIPO_UNIDAD_ADICIONAL")]
    public string? TipoUnidadAdicional { get; set; }

    [JsonProperty("AFECTA_RESULTADO_TENENCIA")]
    public string? AfectaResultadoTenencia { get; set; }

    [JsonProperty("COD_UNIDAD_ADICIONAL")]
    public string? CodUnidadAdicional { get; set; }

    [JsonProperty("DESC_UNIDAD_ADICIONAL")]
    public string? DescUnidadAdicional { get; set; }
}

