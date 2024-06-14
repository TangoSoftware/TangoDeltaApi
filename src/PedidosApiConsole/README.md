## Pedidos

Readme.md (intro + docu de API, cada campo en sí)

Este servicio permite obtener información sobre los pedidos existentes
Get o ingresar nuevos comprobantes Post. [Más arriba detallamos otros. Y
hay que agregar los de cierre ay anulación. También hay que destacar que
ahora permitimos crear pedidos de ocasionales]{.mark}

#### Versiones soportadas de Tango

Delta 4 en adelante

Rebaño + licencia para uso de API transacciones

Contar con Access Token

#### Ambientes

Producción / Testeo

#### Preguntas frecuentes

**Consideraciones generales:**

-   A partir de Delta 4 podés registrar pedidos de clientes ocasionales.

-   No podés ingresar pedidos en referencia a otros comprobantes
    (Cotizaciones).

-   Tené en cuenta que los importes totales del pedido son calculados
    automáticamente por la API en función a las propiedades de JSON; por
    tal motivo no forman parte de su estructura.

-   Los pedidos registrados mediante apertura (API o Excel) quedarán con
    origen "Externo" (GVA21.ORIGEN = \'E\')

**Consideraciones aplicables a cualquier propiedad del JSON:**

-   Toda propiedad de tipo *bool* es *nulleable* y su valor por defecto
    es *false*

-   Toda propiedad de tipo *datetime* considera únicamente la parte
    correspondiente a la fecha descartando la información de la *hora
    (*Salvo que se indique específicamente lo contrario).

-   Toda propiedad que comience con "*ID_XXXXXX"* hace referencia al
    identificador de esa propiedad en la tabla *"XXXXXX";* por ejemplo
    la propiedad *ID_MONEDA* hace referencia al identificador de la
    tabla *MONEDA*.

-   Los siguientes valores de las propiedades deben informarse en
    minúscula:

    -   null,

    -   false,

    -   true.

-   Si ingresás un valor negativo no debés dejar espacios entre el signo
    y el importe; por ejemplo -5000.

-   Tené en cuenta que si ingresás valores con decimales (ya sea en
    cantidades, importes o cotizaciones) debés respetar lo definido en
    el proceso [Configuración de decimales]{.underline} dentro del
    módulo Administrador. Si excedés esa cantidad de decimales lo
    redondearemos a lo configurador en Tango. Por ejemplo, si tenés
    configurado que trabajás con 4 decimales para las cotizaciones e
    ingresás \"COTIZACION\": 1020.7654789 el sistema lo redondeará al
    siguiente valor 1020.7655.

##### Encabezado

| Campo                        | Requerido | Descripción                                                                                                            | Tipo de dato |
|------------------------------|-----------|------------------------------------------------------------------------------------------------------------------------|--------------|
| ID_GVA43_TALON_PED           | Si        | Identificación del talonario de pedidos                                                                                | int          |
| NRO_PEDIDO                   | No        | Número del pedido                                                                                                      | string       |
| ESTADO                       | No        | Estado del pedido                                                                                                      | int          |
| FECHA_PEDIDO                 | No        | Fecha del pedido                                                                                                       | datetime     |
| ID_GVA14                     | No        | Identificación del cliente habitual                                                                                    | int          |
| ES_CLIENTE_HABITUAL          | Si        | Indica si el pedido corresponde a un cliente habitual o uno ocasional                                                  | bool         |
| ID_GVA01                     | Si        | Identificación de la condición de venta                                                                                | int          |
| ID_GVA23                     | Si        | Identificación del vendedor                                                                                            | int          |
| ID_STA22                     | Si        | Identificación del depósito de stock                                                                                   | int          |
| ID_GVA24                     | Si        | Identificación del transportista                                                                                       | int          |
| ID_MONEDA                    | Si        | Identificación de la moneda del comprobante                                                                            | int          |
| COTIZACION                   | No        | Cotización de la moneda extranjera contable                                                                            | decimal      |
| ID_GVA10                     | Si        | Identificación de la lista de precios                                                                                  | int          |
| ID_DIRECCION_ENTREGA         | No        | Identificación de la dirección de entrega del cliente                                                                  | int          |
| FECHA_ENTREGA                | No        | Fecha de entrega                                                                                                       | datetime     |
| ID_ASIENTO_MODELO_GV         | No        | Identificación del modelo de asiento que se debe aplicar a las facturas relacionadas con el pedido                     | int          |
| ID_GVA81                     | No        | Identificación de la clasificación de comprobantes                                                                     | int          |
| ID_GVA43_TALONARIO_FACTURA   | No        | Identificación del talonario con el que se debería facturar                                                            | int          |
| NRO_ORDEN_COMPRA             | No        | Número de orden de compra del cliente                                                                                  | string       |
| FECHA_ORDEN_COMPRA           | No        | Fecha de la orden de compra del cliente                                                                                | datetime     |
| ID_SUCURSAL_DESTINO          | No        | Identificación de la sucursal a la que debe enviarse en pedido.                                                        | int          |
| COMPROMETE_STOCK             | No        | Indica si el pedido compromete stock                                                                                   | bool         |
| ID_ACTIVIDAD_EMPRESA_AFIP    | No        | Código de actividad de la empresa que debe aplicar al facturar según lo especificado por la RG 3749                    | int          |
| ACTIVIDAD_COMPROBANTE_AFIP   | No        | Código de actividad de la transacción que debe aplicar al facturar según lo especificado por la RG 3749                | string       |
| ID_TIPO_DOCUMENTO_GV         | No        | Tipo de documento de la persona responsable del pago según lo especificado por la RG 3749                              | string       |
| NUMERO_DOCUMENTO_PAGADOR     | No        | Número de documento de la persona responsable del pago según lo especificado por la RG 3749                            | string       |
| LEYENDA_1                    | No        | Leyenda 1 del pedido                                                                                                   | string       |
| LEYENDA_2                    | No        | Leyenda 2 del pedido                                                                                                   | string       |
| LEYENDA_3                    | No        | Leyenda 3 del pedido                                                                                                   | string       |
| LEYENDA_4                    | No        | Leyenda 4 del pedido                                                                                                   | string       |
| LEYENDA_5                    | No        | Leyenda 5 del pedido                                                                                                   | string       |
| PORCENTAJE_DESCUENTO_GENERAL | No        | Porcentaje de descuento del pedido                                                                                     | decimal      |
| IMPORTE_DESCUENTO_GENERAL    | No        | Importe de descuento del pedido                                                                                        | decimal      |
| PORCENTAJE_RECARGO_GENERAL   | No        | Porcentaje de recargo del pedido                                                                                       | decimal      |
| IMPORTE_RECARGO_GENERAL      | No        | Importe de recargo del pedido                                                                                          | decimal      |
| APLICA_DESCUENTO_CLIENTE     | No        | Indica si se debe aplicar el descuento habitual del cliente                                                            | bool         |
| CALCULA_PROMOCIONES          | No        | Indica si se deben aplicar promociones en el pedido o se debe genera sin tenerlas en cuenta                            | bool         |
| VALIDA_LIMITE_CREDITO        | No        | Indica si se debe validar el límite de crédito del cliente al grabar el pedido.                                        | bool         |
| ID_SBA01                     | No        | Identificación de la cuenta de Tesorería que representa la intención de pago del cliente (Se traslada luego a factura) | int          |
| OBSERVACIONES                | No        | Observaciones del pedido                                                                                               | string       |

##### Renglones del pedido.

RENGLON_DTO: Tené en cuenta que esta sección es de tipo array, por lo que deberás repetirla para registrar los distintos renglones del pedido.

| Campo                          | Requerido | Descripción                                                        | Tipo de dato |
|--------------------------------|-----------|--------------------------------------------------------------------|--------------|
| ID_STA11                       | Si        | Identificación del artículo pedido                                 | int          |
| DESCRIPCION_ARTICULO           | No        | Descripción del artículo                                           | string       |
| DESCRIPCION_ADICIONAL_ARTICULO | No        | Descripción adicional del artículo                                 | string       |
| ID_STA22                       | No        | Identificación del depósito del renglón                            | int          |
| MODULO_UNIDAD_MEDIDA           | No        | Unidad de medida en la que está expresa la CANTIDAD_PEDIDA         | string       |
| CANTIDAD_PEDIDA                | SI        | Cantidad solicitada por el cliente                                 | decimal      |
| CANTIDAD_A_FACTURAR            | No        | Cantidad habilitada para facturar                                  | decimal      |
| CANTIDAD_A_DESCARGA            | No        | Cantidad habilitada para remitir                                   | decimal      |
| CANTIDAD_PENDIENTE_A_FACTURAR  | No        | Cantidad pendiente de facturar                                     | decimal      |
| PRECIO                         | No        | Precio de venta                                                    | decimal      |
| PORCENTAJE_BONIFICACION        | No        | Porcentaje de bonificación del renglón                             | decimal      |
| ID_GVA81                       | No        | Identificación de la clasificación de comprobantes a nivel renglón | int          |
| OBSERVACIONES                  | No        | Observaciones asignadas al renglón                                 | string       |


##### PLAN_DE_ENTREGA_DTO (No requerido)

Solo podés informar esta sección si tenés tildada la opción "Usa planes
de entrega" en Parámetros de Venta\\Comprobantes\\Pedidos.

Tené en cuenta que esta sección es de tipo array por lo que deberás
repetirla para registrar las distintas fechas de entrega pactadas con tu
cliente para cada RENGLON_DTO.

| Campo            | Requerido | Descripción                                                                          | Tipo de dato |
|------------------|-----------|--------------------------------------------------------------------------------------|--------------|
| CANTIDAD         | No        | Cantidad que debes  entregar en la fecha FECHA_DE_ENTREGA para el renglón del pedido | decimal      |
| FECHA_DE_ENTREGA | No        | Fecha de entrega                                                                     | datetime     |


##### DESCRIPCION_ADICIONAL_DTO (No requerido)

Recomendamos utilizar la nueva propiedad OBSERVACIONES de la sección
RENGLON_DTO (en lugar de esta sección) para que ingreses texto adicional
al renglón del pedido de una forma más sencilla y con mayor capacidad de
caracteres. De todas formas si tu implementación requiere el uso de esta
sección la podés completar sin inconvenientes. También podés combinar
ambas opciones.

Tené en cuenta que esta sección es de tipo array por lo que deberás
repetirla para registrar las distintas descripciones adicionales
asociadas a cada RENGLON_DTO.

  ----------------------------------------------------------------------------------------
  Campo                   Requerido   Descripción     Tipo de  Consideraciones, valores
                                                      dato     posibles y ejemplos
  ----------------------- ----------- --------------- -------- ---------------------------
  DESCRIPCION             No          Texto           string   
                                      suplementario            
                                      que se agrega            
                                      en un renglón            
                                      posterior a la           
                                      descripción del          
                                      artículo                 

  DESCRIPCION_ADICIONAL   No          Texto           string   
                                      suplementario            
                                      que se agrega            
                                      en un renglón            
                                      posterior a la           
                                      descripción              
                                      adicional del            
                                      artículo                 
  ----------------------------------------------------------------------------------------

[]{#_Toc167188187 .anchor}

##### CLIENTE_OCASIONAL_DTO (No requerido)

Esta sección solo debe completarse (aunque es de forma opcional) si la
propiedad (de la sección ENCABEZADO) ES_CLIENTE_HABITUAL es false.

| Campo                                        | Requerido | Descripción                                                                                                                                                                                                           | Tipo de dato |
|----------------------------------------------|-----------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------|
| ID_TIPO_DOCUMENTO_GV                         | Si        | Tipo de documento del cliente ocasional                                                                                                                                                                               | int          |
| NRO_DOCUMENTO                                | No        | Número de documento del cliente ocasional                                                                                                                                                                             | string       |
| RAZON_SOCIAL                                 | No        | Razón social del cliente ocasional                                                                                                                                                                                    | string       |
| DOMICILIO                                    | No        | Domicilio del cliente ocasional                                                                                                                                                                                       | string       |
| LOCALIDAD                                    | No        | Localidad del cliente ocasional                                                                                                                                                                                       | string       |
| CODIGO_POSTAL                                | No        | Código postal del cliente ocasional                                                                                                                                                                                   | string       |
| ID_GVA18_PROVINCIA                           | Si        | Identificación de la provincia del cliente ocasional                                                                                                                                                                  | int          |
| ACTIVIDAD                                    | No        | Actividad comercial del cliente ocasional                                                                                                                                                                             | string       |
| IDENTIFICACION_TRIBUTARIA                    | No        | Identificación tributaria para trasladar a la factura en caso de tratarse de un comprobante electrónico de exportación                                                                                                | string       |
| REGIMEN_INGRESOS_BRUTOS                      | No        | Régimen de ingresos brutos del cliente ocasional                                                                                                                                                                      | string       |
| NRO_INGRESOS_BRUTOS                          | No        | Número de inscripción del cliente ocasional en ingresos brutos                                                                                                                                                        | string       |
| E_MAIL                                       | No        | Correo electrónico del cliente ocasional                                                                                                                                                                              | string       |
| WEB_CLIENTE                                  | No        | Página web del cliente ocasional                                                                                                                                                                                      | string       |
| NUMERO_INSCRIPCION_RG1817                    | No        | Número de constancia de condición tributaria (RG1817)                                                                                                                                                                 | string       |
| FECHA_VENCIMIENTO_INSCRIPCION_RG1817         | No        | Fecha de vencimiento de la constancia de condición tributaria (RG1817)                                                                                                                                                | datetime     |
| ID_CATEGORIA_IVA                             | Si        | Identificación de la categoría de IVA del cliente ocasional                                                                                                                                                           | int          |
| ID_GVA41_ALICUOTA_NO_CATEGORIZADA            | No        | Identificación de la alícuota de IVA a aplicar cuando se trate de un cliente con categoría “Sujeto no categorizado”                                                                                                   | int          |
| CALCULA_PERCEPCION_IVA                       | No        | Indica si se debe calcular percepciones de IVA al cliente ocasional                                                                                                                                                   | bool         |
| PORCENTAJE_EXCLUSION                         | No        | Porcentaje de exclusión a considerar sobre la percepción de IVA                                                                                                                                                       | decimal      |
| LIQUIDA_IMPUESTOS_INTERNOS                   | No        | Indica si se debe liquidar impuestos internos al cliente ocasional                                                                                                                                                    | bool         |
| DISCRIMINA_IMPUESTOS_INTERNOS                | No        | Indica si se debe discriminar en el comprobante los impuestos internos calculados                                                                                                                                     | bool         |
| CALCULA_PERCEPCION_IMPUESTOS_INTERNOS        | No        | Indica si se debe liquidar percepción de impuestos internos al cliente ocasional                                                                                                                                      | bool         |
| ID_GVA41_ALICUOTA_FIJA_PERCEPCION_IIBB       | No        | Identificación de la alícuota fija de Ingresos brutos                                                                                                                                                                 | int          |
| LIQUIDA_PERCEPCION_INGRESOS_BRUTOS           | No        | Indica si se debe liquidar ingresos brutos al cliente ocasional                                                                                                                                                       | bool         |
| CONSIDERA_IVA_BASE_CALCULO_IIBB              | No        | Indica si se debe considerar el importe de IVA dentro de la base de cálculo de la alícuota fija de ingresos brutos                                                                                                    | bool         |
| ID_GVA41_ALICUOTA_ADICIONAL_PERCEPCION_IIBB  | No        | Identificación de la alícuota adicional de Ingresos brutos                                                                                                                                                            | int          |
| CONSIDERA_IVA_BASE_CALCULO_IIBB_ADIC         | No        | Indica si se debe considerar el importe de IVA dentro de la base de cálculo de la alícuota adicional de ingresos brutos                                                                                               | bool         |
| LIQUIDA_PERCEPCION_INGRESOS_BRUTOS_59_98     | No        | Indica si se debe liquidar ingresos brutos de acuerdo con la RG 58/59 al cliente ocasional. Esta RG está relacionada con industrias elaboradoras de cervezas y agentes de comercialización mayorista de dichos bienes | bool         |
| ID_GVA41_ALICUOTA_FIJA_PERCEPCION_IIBB_59_98 | No        | Identificación de la alícuota de Ingresos brutos (RG 58/59)                                                                                                                                                           | int          |
| INCLUYE_IMPUESTOS_INTERNOS                   | No        | Indica si se deben considerar los impuestos internos en el cálculo de ingresos brutos (RG 58/59)                                                                                                                      | bool         |
| ID_GVA151                                    | No        | Identificación del rubro comercial del cliente ocasional                                                                                                                                                              | int          |
| ID_GVA150                                    | No        | Identificación de la clasificación impositiva del cliente para la aplicación de percepciones definibles                                                                                                               | int          |
| DIRECCION_ENTREGA                            | No        | Dirección de entrega del cliente ocasional                                                                                                                                                                            | string       |
| LOCALIDAD_ENTREGA                            | No        | Localidad de la dirección de entrega del cliente ocasional                                                                                                                                                            | string       |
| CODIGO_POSTAL_ENTREGA                        | No        | Código postal de la dirección de entrega del cliente ocasional                                                                                                                                                        | string       |
| ID_GVA18_PROVINCIA_ENTREGA                   | Si        | Identificación de la provincia de la dirección de entrega del cliente ocasional                                                                                                                                       | int          |
| TELEFONO1_ENTREGA                            | No        | Teléfono 1 de la dirección de entrega del cliente ocasional                                                                                                                                                           | string       |
| TELEFONO2_ENTREGA                            | No        | Teléfono 2 de la dirección de entrega del cliente ocasional                                                                                                                                                           | string       |

##### CLIENTE_OCASIONAL_PERCEPCIONES_DEFINIBLES_DTO (No requerido)

Esta sección solo debe completarse (aunque es de forma opcional) si la
propiedad (de la sección ENCABEZADO) ES_CLIENTE_HABITUAL es false.

Tené en cuenta que esta sección es de tipo array por lo que deberás
repetirla para registrar las distintas precepciones definibles que se
deben aplicar al CLIENTE_OCASIONAL.

| Campo                         | Requerido | Descripción                                                                                               | Tipo de dato | Consideraciones, valores posibles y ejemplos                                                                         |
|-------------------------------|-----------|-----------------------------------------------------------------------------------------------------------|--------------|----------------------------------------------------------------------------------------------------------------------|
| ID_PERCEPCION_VENTAS          | Si        | Identificación de la percepción definible que se debe aplicar al cliente ocasional                        | int          | Tené en cuenta que la información para completar esta propiedad surge de la tabla GVA141 (Percepciones)              |
| ID_PERCEPCION_VENTAS_ALICUOTA | Si        | Identificación de la alícuota asociada a la percepción definible que se debe aplicar al cliente ocasional | Int          | Tené en cuenta que la información para completar esta propiedad surge de la tabla GVA141 (Alícuotas de percepciones) |
| LEYENDA                       | No        | Leyenda libre                                                                                             | string       | NULL                                                                                                                 |


##### NOTA_PEDIDO_DTO (No requerido)

Tené en cuenta que esta sección es de tipo array por lo que deberás
repetirla para registrar los distintos mensajes que quieras dejar
asociados al pedido.

Si vas a completar esta sección es obligatorio que informes la propiedad
MENSAJE.

| Campo   | Requerido | Descripción                                                                                                                | Tipo de dato | Consideraciones, valores posibles y ejemplos                                      |
|---------|-----------|----------------------------------------------------------------------------------------------------------------------------|--------------|-----------------------------------------------------------------------------------|
| MENSAJE | No        | Comentario que se quiera incluir como nota adjunta en el pedido dentro de la solapa de “Información adicional” del pedido. | string       | Además del mensaje registraremos la fecha del día y con el tipo de nota “Manual”. |


#### Novedades sobre cambios en el JSON

### Programs.cs (ejemplo)