using TangoDeltaApi.Core.Service;

namespace TangoDeltaApi.CommonServices.contabilidad.asientos.model;


[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public  class MONEDA
    {
        [Newtonsoft.Json.JsonProperty("ID_MONEDA", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ID_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("COD_MONEDA", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string? COD_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("DESC_MONEDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string? DESC_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("TIPO_MONEDA", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string? TIPO_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("SIMBOLO_MONEDA", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? SIMBOLO_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("CANT_DECIMAL_MONEDA", Required = Newtonsoft.Json.Required.Always)]
        public int CANT_DECIMAL_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_SBA43", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_SBA43 { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_MONEDA_AFIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_MONEDA_AFIP { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_EJERCICIO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_EJERCICIO { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_CUENTA_TENENCIA_POSITIVO_MDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_CUENTA_TENENCIA_POSITIVO_MDA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_CUENTA_TENENCIA_NEGATIVO_MDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_CUENTA_TENENCIA_NEGATIVO_MDA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_CUENTA_TRASLACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_CUENTA_TRASLACION { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_ASIENTO_TENENCIA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_ASIENTO_TENENCIA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_ASIENTO_CONVERSION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_ASIENTO_CONVERSION { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? EDITA_TIPO_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_COTIZACION", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string? EDITA_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("CANT_DECIMAL_COTIZACION", Required = Newtonsoft.Json.Required.Always)]
        public int CANT_DECIMAL_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("COD_AFIP_EX", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? COD_AFIP_EX { get; set; }

        [Newtonsoft.Json.JsonProperty("COD_AFIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string? COD_AFIP { get; set; }

        [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string? OBSERVACIONES { get; set; }

        [Newtonsoft.Json.JsonProperty("COD_DESCRIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? COD_DESCRIP { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class RENGLON_ANALITICO_DTO
    {
        [Newtonsoft.Json.JsonProperty("ID_RENGLON_IMPORTES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ID_RENGLON_IMPORTES { get; set; }

        [Newtonsoft.Json.JsonProperty("NRO_RENGLON_ANALITICO", Required = Newtonsoft.Json.Required.Always)]
        public int NRO_RENGLON_ANALITICO { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_CUENTA", Required = Newtonsoft.Json.Required.Always)]
        public int ID_CUENTA { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_DEBE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? IMPORTE_DEBE { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_DEBE_AUX", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? IMPORTE_DEBE_AUX { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_HABER", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? IMPORTE_HABER { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_HABER_AUX", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? IMPORTE_HABER_AUX { get; set; }

        [Newtonsoft.Json.JsonProperty("FECHA_ORIGEN", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.DateTimeOffset FECHA_ORIGEN { get; set; }

        [Newtonsoft.Json.JsonProperty("DESC_LEYENDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? DESC_LEYENDA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_RENGLON_ADICIONAL_ANALITICO_CN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_RENGLON_ADICIONAL_ANALITICO_CN { get; set; }

        [Newtonsoft.Json.JsonProperty("CUENTA_UA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CUENTA_UA { get; set; }

        [Newtonsoft.Json.JsonProperty("UNIDAD_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UNIDAD_ADICIONAL { get; set; }

        [Newtonsoft.Json.JsonProperty("TIPO_UNIDAD_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TIPO_UNIDAD_ADICIONAL { get; set; }

        [Newtonsoft.Json.JsonProperty("UNIDAD_MEDIDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UNIDAD_MEDIDA { get; set; }

        [Newtonsoft.Json.JsonProperty("MONEDA_INGRESO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MONEDA_INGRESO { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_MONEDA_INGRESO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_MONEDA_INGRESO { get; set; }

        [Newtonsoft.Json.JsonProperty("MONEDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_MONEDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? IMPORTE { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_AUX", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? IMPORTE_AUX { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool EDITA_TIPO_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_COTIZACION", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool EDITA_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("COTIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("TOTAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? TOTAL { get; set; }

        [Newtonsoft.Json.JsonProperty("TOTAL_AUX", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? TOTAL_AUX { get; set; }

        [Newtonsoft.Json.JsonProperty("USA_MONEDA_CORRIENTE", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool USA_MONEDA_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("MONEDA_CORRIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MONEDA_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_CORRIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? IMPORTE_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_CORRIENTE_AUX", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? IMPORTE_CORRIENTE_AUX { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_TIPO_COTIZACION_CORRIENTE", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool EDITA_TIPO_COTIZACION_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_COTIZACION_CORRIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_COTIZACION_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_COTIZACION_CORRIENTE", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool EDITA_COTIZACION_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("COTIZACION_CORRIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? COTIZACION_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("TOTAL_CORRIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? TOTAL_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("TOTAL_CORRIENTE_AUX", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? TOTAL_CORRIENTE_AUX { get; set; }

        [Newtonsoft.Json.JsonProperty("CANTIDAD", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? CANTIDAD { get; set; }

        [Newtonsoft.Json.JsonProperty("CANTIDAD_AUX", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? CANTIDAD_AUX { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_TIPO_VALORIZACION", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool EDITA_TIPO_VALORIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_VALORIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_TIPO_VALORIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_VALORIZACION", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool EDITA_VALORIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("VALORIZACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal? VALORIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_UNIDAD_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_UNIDAD_ADICIONAL { get; set; }

        [Newtonsoft.Json.JsonProperty("CANT_DECIMALES_UNIDAD_MEDIDA", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CANT_DECIMALES_UNIDAD_MEDIDA { get; set; }

        [Newtonsoft.Json.JsonProperty("CANT_DECIMALES_COTIZACION", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CANT_DECIMALES_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("CANT_DECIMALES_MONEDA", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CANT_DECIMALES_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("CANT_DECIMALES_COTIZACION_CORRIENTE", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CANT_DECIMALES_COTIZACION_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("CANT_DECIMALES_MONEDA_CORRIENTE", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CANT_DECIMALES_MONEDA_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("ROW_VERSION_UNIDAD_ADICIONAL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ROW_VERSION_UNIDAD_ADICIONAL { get; set; }

        [Newtonsoft.Json.JsonProperty("CUENTA_AUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CUENTA_AUXILIAR { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_AUXILIARES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IMPORTE_AUXILIARES { get; set; }

        [Newtonsoft.Json.JsonProperty("TIPO_AUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ICollection<TIPO_AUXILIAR_DTO>? TIPO_AUXILIAR { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TIPO_AUXILIAR_DTO
    {
        [Newtonsoft.Json.JsonProperty("ID_REGLA_APROPIACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_REGLA_APROPIACION { get; set; }

        [Newtonsoft.Json.JsonProperty("APROPIA_100", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? APROPIA_100 { get; set; }

        [Newtonsoft.Json.JsonProperty("ESTADO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ESTADO { get; set; }

        [Newtonsoft.Json.JsonProperty("AUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ICollection<AUXILIAR_DTO>? AUXILIAR { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public  class AUXILIAR_DTO
    {
        [Newtonsoft.Json.JsonProperty("ID_AUXILIAR", Required = Newtonsoft.Json.Required.Always)]
        public int ID_AUXILIAR { get; set; }

        [Newtonsoft.Json.JsonProperty("PORC_APROPIACION", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, 100D)]
        public decimal PORC_APROPIACION { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_RENGLON", Required = Newtonsoft.Json.Required.Always)]
        public decimal IMPORTE_RENGLON { get; set; }

        [Newtonsoft.Json.JsonProperty("LEYENDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? LEYENDA { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_APROPIACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EDITA_APROPIACION { get; set; }

        [Newtonsoft.Json.JsonProperty("SUBAUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ICollection<SUBAUXILIAR_DTO>? SUBAUXILIAR { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public  class SUBAUXILIAR_DTO
    {
        [Newtonsoft.Json.JsonProperty("ID_SUBAUXILIAR", Required = Newtonsoft.Json.Required.Always)]
        public int ID_SUBAUXILIAR { get; set; }

        [Newtonsoft.Json.JsonProperty("PORC_APROPIACION", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, 100D)]
        public decimal PORC_APROPIACION { get; set; }

        [Newtonsoft.Json.JsonProperty("IMPORTE_RENGLON", Required = Newtonsoft.Json.Required.Always)]
        public decimal IMPORTE_RENGLON { get; set; }

        [Newtonsoft.Json.JsonProperty("LEYENDA", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? LEYENDA { get; set; }

        [Newtonsoft.Json.JsonProperty("EDITA_APROPIACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EDITA_APROPIACION { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public  class ASIENTO_COTIZACION_ANALITICO_CN
    {
        [Newtonsoft.Json.JsonProperty("ID_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.Always)]
        public int ID_TIPO_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_MONEDA", Required = Newtonsoft.Json.Required.Always)]
        public int ID_MONEDA { get; set; }

        [Newtonsoft.Json.JsonProperty("COTIZACION_ALTERNATIVA", Required = Newtonsoft.Json.Required.Always)]
        public decimal COTIZACION_ALTERNATIVA { get; set; }

        [Newtonsoft.Json.JsonProperty("SE_PUEDE_EDITAR_TIPO_COTIZACION", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool SE_PUEDE_EDITAR_TIPO_COTIZACION { get; set; }

        [Newtonsoft.Json.JsonProperty("SE_PUEDE_EDITAR_COTIZACION", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool SE_PUEDE_EDITAR_COTIZACION { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class AsientosData : BaseData
    {
        [Newtonsoft.Json.JsonProperty("REVIERTE_ASIENTO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool REVIERTE_ASIENTO { get; set; }

        [Newtonsoft.Json.JsonProperty("FECHA_ASIENTO", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.DateTimeOffset FECHA_ASIENTO { get; set; }

        [Newtonsoft.Json.JsonProperty("NRO_ASIENTO_ANALITICO", Required = Newtonsoft.Json.Required.Always)]
        public decimal NRO_ASIENTO_ANALITICO { get; set; }

        [Newtonsoft.Json.JsonProperty("NRO_INTERNO_ANALITICO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NRO_INTERNO_ANALITICO { get; set; }

        [Newtonsoft.Json.JsonProperty("CLASE_ASIENTO", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string? CLASE_ASIENTO { get; set; }

        [Newtonsoft.Json.JsonProperty("EJERCICIO_PERIODO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EJERCICIO_PERIODO { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_PERIODO", Required = Newtonsoft.Json.Required.Always)]
        public int ID_PERIODO { get; set; }

        [Newtonsoft.Json.JsonProperty("CONTROL_ASIENTO_REVERSION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CONTROL_ASIENTO_REVERSION { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_TIPO_ASIENTO", Required = Newtonsoft.Json.Required.Always)]
        public int ID_TIPO_ASIENTO { get; set; }

        [Newtonsoft.Json.JsonProperty("ESTADO_ASIENTO_ANALITICO", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string? ESTADO_ASIENTO_ANALITICO { get; set; }

        [Newtonsoft.Json.JsonProperty("ORIGEN_ASIENTO_1", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string? ORIGEN_ASIENTO_1 { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_MONEDA_ASIENTO", Required = Newtonsoft.Json.Required.Always)]
        public int ID_MONEDA_ASIENTO { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_MONEDA_PREFERENCIAS", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ID_MONEDA_PREFERENCIAS { get; set; }

        [Newtonsoft.Json.JsonProperty("ESTADO_RESUMEN", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string? ESTADO_RESUMEN { get; set; }

        [Newtonsoft.Json.JsonProperty("DESC_ASIENTO_ANALITICO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? DESC_ASIENTO_ANALITICO { get; set; }

        [Newtonsoft.Json.JsonProperty("USUARIO_INGRESO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? USUARIO_INGRESO { get; set; }

        [Newtonsoft.Json.JsonProperty("FECHA_INGRESO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FECHA_INGRESO { get; set; }

        [Newtonsoft.Json.JsonProperty("TERMINAL_INGRESO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TERMINAL_INGRESO { get; set; }

        [Newtonsoft.Json.JsonProperty("USUARIO_ULTIMA_MODIFICACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? USUARIO_ULTIMA_MODIFICACION { get; set; }

        [Newtonsoft.Json.JsonProperty("FECHA_ULTIMA_MODIFICACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FECHA_ULTIMA_MODIFICACION { get; set; }

        [Newtonsoft.Json.JsonProperty("TERMINAL_ULTIMA_MODIFICACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TERMINAL_ULTIMA_MODIFICACION { get; set; }

        [Newtonsoft.Json.JsonProperty("NRO_LOTE_IMPORTACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NRO_LOTE_IMPORTACION { get; set; }

        [Newtonsoft.Json.JsonProperty("NRO_ORIGEN_EXPORTACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NRO_ORIGEN_EXPORTACION { get; set; }

        [Newtonsoft.Json.JsonProperty("DESC_ORIGEN_EXPORTACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DESC_ORIGEN_EXPORTACION { get; set; }

        [Newtonsoft.Json.JsonProperty("NRO_LOTE_EXPORTACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NRO_LOTE_EXPORTACION { get; set; }

        [Newtonsoft.Json.JsonProperty("USUARIO_EXPORTACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? USUARIO_EXPORTACION { get; set; }

        [Newtonsoft.Json.JsonProperty("FECHA_EXPORTACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FECHA_EXPORTACION { get; set; }

        [Newtonsoft.Json.JsonProperty("TERMINAL_EXPORTACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TERMINAL_EXPORTACION { get; set; }

        [Newtonsoft.Json.JsonProperty("ORIGEN_ASIENTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ORIGEN_ASIENTO { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_REVERSION_ANALITICO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_REVERSION_ANALITICO { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_ASIENTO_RESUMEN_CN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_ASIENTO_RESUMEN_CN { get; set; }

        [Newtonsoft.Json.JsonProperty("ASIENTO_REVERSION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ASIENTO_REVERSION { get; set; }

        [Newtonsoft.Json.JsonProperty("ASIENTO_EXTRACONTABLE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ASIENTO_EXTRACONTABLE { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_ASIENTO_MODELO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_ASIENTO_MODELO { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_LOTE_CN_RECIBIDO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_LOTE_CN_RECIBIDO { get; set; }

        [Newtonsoft.Json.JsonProperty("ORIGEN_EXTERNO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ORIGEN_EXTERNO { get; set; }

        [Newtonsoft.Json.JsonProperty("SE_PUEDE_EDITAR_NUMERO_ASIENTO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool SE_PUEDE_EDITAR_NUMERO_ASIENTO { get; set; }

        [Newtonsoft.Json.JsonProperty("SE_PUEDE_EDITAR_ESTADO_ASIENTO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool SE_PUEDE_EDITAR_ESTADO_ASIENTO { get; set; }

        [Newtonsoft.Json.JsonProperty("MONEDA_CORRIENTE", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MONEDA? MONEDA_CORRIENTE { get; set; }

        [Newtonsoft.Json.JsonProperty("ASIENTO_ESTA_REGISTRADO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ASIENTO_ESTA_REGISTRADO { get; set; }

        [Newtonsoft.Json.JsonProperty("ASIENTO_REVERTIDO_O_REVERSION_MODIFICADO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ASIENTO_REVERTIDO_O_REVERSION_MODIFICADO { get; set; }

        [Newtonsoft.Json.JsonProperty("MODIFICO_UK_RENGLONES", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool MODIFICO_UK_RENGLONES { get; set; }

        [Newtonsoft.Json.JsonProperty("CANTIDAD_DECIMALES_RENGLONES", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CANTIDAD_DECIMALES_RENGLONES { get; set; }

        [Newtonsoft.Json.JsonProperty("TOTAL_DEBE", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal TOTAL_DEBE { get; set; }

        [Newtonsoft.Json.JsonProperty("TOTAL_HABER", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal TOTAL_HABER { get; set; }

        [Newtonsoft.Json.JsonProperty("DIFERENCIA", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal DIFERENCIA { get; set; }

        [Newtonsoft.Json.JsonProperty("CANTIDAD_DECIMALES_COTIZACIONES", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CANTIDAD_DECIMALES_COTIZACIONES { get; set; }

        [Newtonsoft.Json.JsonProperty("OBSERVACIONES", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string? OBSERVACIONES { get; set; }

        [Newtonsoft.Json.JsonProperty("ACTIVAR_AUXILIARES", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ACTIVAR_AUXILIARES { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_RENGLON_AUXILIAR_EDICION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_RENGLON_AUXILIAR_EDICION { get; set; }

        [Newtonsoft.Json.JsonProperty("CAMBIO_TIPO_AUXILIAR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool CAMBIO_TIPO_AUXILIAR { get; set; }

        [Newtonsoft.Json.JsonProperty("ID_REGLA_APROPIACION", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ID_REGLA_APROPIACION { get; set; }

        [Newtonsoft.Json.JsonProperty("APROPIA_100", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? APROPIA_100 { get; set; }

        [Newtonsoft.Json.JsonProperty("ESTADO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ESTADO { get; set; }

        [Newtonsoft.Json.JsonProperty("USA_SUBAUXILIARES", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool USA_SUBAUXILIARES { get; set; }

        [Newtonsoft.Json.JsonProperty("RENGLON_ANALITICO_CN_DTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  ICollection<RENGLON_ANALITICO_DTO>? RENGLON_ANALITICO_CN_DTO { get; set; }

        [Newtonsoft.Json.JsonProperty("ASIENTO_COTIZACION_ANALITICO_CN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ICollection<ASIENTO_COTIZACION_ANALITICO_CN>? ASIENTO_COTIZACION_ANALITICO_CN { get; set; }

        [Newtonsoft.Json.JsonProperty("AUXILIAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ICollection<AUXILIAR_DTO>? AUXILIAR { get; set; }

        [Newtonsoft.Json.JsonProperty("TIPO_AUXILIAR_DTO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ICollection<TIPO_AUXILIAR_DTO>? TIPO_AUXILIAR_DTO { get; set; }
    }
    