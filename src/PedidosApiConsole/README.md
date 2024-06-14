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


##### PLAN_DE_ENTREGA_DTO (No requerido)

Solo podés informar esta sección si tenés tildada la opción "Usa planes
de entrega" en Parámetros de Venta\\Comprobantes\\Pedidos.

Tené en cuenta que esta sección es de tipo array por lo que deberás
repetirla para registrar las distintas fechas de entrega pactadas con tu
cliente para cada RENGLON_DTO.

----------------+---+--------------+------+---------------------------
| Campo         | R | Descripción  | Tipo | Consideraciones, valores |
|               | e |              | de   | posibles y ejemplos      |
|               | q |              | dato |                          |
|               | u |              |      |                          |
|               | e |              |      |                          |
|               | r |              |      |                          |
|               | i |              |      |                          |
|               | d |              |      |                          |
|               | o |              |      |                          |
+===============+===+==============+======+==========================+
| CANTIDAD      | N | Cantidad que | dec  | La suma de todas las     |
|               | o | debes        | imal | cantidades del array de  |
|               |   | entregar en  |      | PLAN_DE_ENTREGA debe     |
|               |   | la fecha     |      | coincidir con lo         |
|               |   | FECH         |      | informado en la          |
|               |   | A_DE_ENTREGA |      | propiedad                |
|               |   | para el      |      | CANTIDAD_PEDIDA de la    |
|               |   | renglón del  |      | sección RENGLON_DTO      |
|               |   | pedido       |      |                          |
|               |   |              |      | Tené en cuenta que si    |
|               |   |              |      | completaste la propiedad |
|               |   |              |      | CANTIDAD_PEDIDA con un   |
|               |   |              |      | valor negativo las       |
|               |   |              |      | cantidades de esta       |
|               |   |              |      | sección también deben    |
|               |   |              |      | tener valores menores a  |
|               |   |              |      | cero.                    |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| FEC           | N | Fecha de     | date | Es requerido si se       |
| HA_DE_ENTREGA | o | entrega      | time | ingresa una cantidad.    |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|

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


| **Campo**         | **Requerido** | **Descripción**  | **Tipo de dato** | **Consideraciones, valores posibles y ejemplos**  |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_TIPO           | Si            | Tipo de documento                   | int              |                                                   |
| _DOCUMENTO_GV     | documento    |      |                          |
|                   | del cliente  |      |                          |
|                   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| NRO_DOCUMENTO | N | Número de    | st   |                          |
|               | o | documento    | ring |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| RAZON_SOCIAL  | N | Razón social | st   |                          |
|               | o | del cliente  | ring |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| DOMICILIO     | N | Domicilio    | st   |                          |
|               | o | del cliente  | ring |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| LOCALIDAD     | N | Localidad    | st   |                          |
|               | o | del cliente  | ring |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| CODIGO_POSTAL | N | Código       | st   |                          |
|               | o | postal del   | ring |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_GV         | S | Id           | int  |                          |
| A18_PROVINCIA | i | entificación |      |                          |
|               |   | de la        |      |                          |
|               |   | provincia    |      |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ACTIVIDAD     | N | Actividad    | st   |                          |
|               | o | comercial    | ring |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| IDENTIFICACI  | N | Id           | st   | Tené en cuenta solo      |
| ON_TRIBUTARIA | o | entificación | ring | deberías completar este  |
|               |   | tributaria   |      | campo si el pedido se va |
|               |   | para         |      | a facturar con un        |
|               |   | trasladar a  |      | comprobante de           |
|               |   | la factura   |      | exportación y no         |
|               |   | en caso de   |      | completaste la propiedad |
|               |   | tratarse de  |      | NRO_DOCUMENTO            |
|               |   | un           |      |                          |
|               |   | comprobante  |      |                          |
|               |   | electrónico  |      |                          |
|               |   | de           |      |                          |
|               |   | exportación  |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| REGIMEN_IN    | N | Régimen de   | st   | **Valores posibles:**    |
| GRESOS_BRUTOS | o | ingresos     | ring |                          |
|               |   | brutos del   |      | -   null: No liquida     |
|               |   | cliente      |      |     (graba en blanco)    |
|               |   | ocasional    |      |                          |
|               |   |              |      | -   "L": Local           |
|               |   |              |      |                          |
|               |   |              |      | -   "M": Multilateral    |
|               |   |              |      |                          |
|               |   |              |      | -   "S": Régimen         |
|               |   |              |      |     simplificado         |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| NRO_IN        | N | Número de    | st   |                          |
| GRESOS_BRUTOS | o | inscripción  | ring |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional en |      |                          |
|               |   | ingresos     |      |                          |
|               |   | brutos       |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| E_MAIL        | N | Correo       | st   |                          |
|               | o | electrónico  | ring |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| WEB_CLIENTE   | N | Página web   | st   |                          |
|               | o | del cliente  | ring |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| NUMERO_INSCR  | N | Número de    | st   |                          |
| IPCION_RG1817 | o | constancia   | ring |                          |
|               |   | de condición |      |                          |
|               |   | tributaria   |      |                          |
|               |   | (RG1817)     |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| FECHA_VENC    | N | Fecha de     | date | Tené en cuenta que no    |
| IMIENTO_INSCR | o | vencimiento  | time | validamos en forma       |
| IPCION_RG1817 |   | de la        |      | estricta que la fecha    |
|               |   | constancia   |      | informada sea mayor o    |
|               |   | de condición |      | igual a la actual debido |
|               |   | tributaria   |      | a que no es posible      |
|               |   | (RG1817)     |      | definir un control       |
|               |   |              |      | estricto de este valor   |
|               |   |              |      | desde Parámetros         |
|               |   |              |      | generales de Ventas.     |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_           | S | Id           | int  |                          |
| CATEGORIA_IVA | i | entificación |      |                          |
|               |   | de la        |      |                          |
|               |   | categoría de |      |                          |
|               |   | IVA del      |      |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_GVA4       | N | Id           | int  | **Valores posibles:** ID |
| 1_ALICUOTA_NO | o | entificación |      | correspondiente a la     |
| _CATEGORIZADA |   | de la        |      | tabla GVA41 cuyo código  |
|               |   | alícuota de  |      | esté comprendido entre   |
|               |   | IVA a        |      | el 11 y el 20.           |
|               |   | aplicar      |      |                          |
|               |   | cuando se    |      |                          |
|               |   | trate de un  |      |                          |
|               |   | cliente con  |      |                          |
|               |   | categoría    |      |                          |
|               |   | "Sujeto no   |      |                          |
|               |   | c            |      |                          |
|               |   | ategorizado" |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| CALCULA_P     | N | Indica si se | bool | **Valores posibles:**    |
| ERCEPCION_IVA | o | debe         |      |                          |
|               |   | calcular     |      | -   true: calcula        |
|               |   | percepciones |      |     percepción de IVA    |
|               |   | de IVA al    |      |                          |
|               |   | cliente      |      | -   false: no calcula    |
|               |   | ocasional    |      |     percepción de IVA    |
|               |   |              |      |                          |
|               |   |              |      | En caso de no informar   |
|               |   |              |      | un valor consideraremos  |
|               |   |              |      | "false" y por lo tanto   |
|               |   |              |      | no calcularemos          |
|               |   |              |      | percepciones de IVA.     |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| PORCENT       | N | Porcentaje   | dec  | **Valores posibles:**    |
| AJE_EXCLUSION | o | de exclusión | imal | entre 0 y 100            |
|               |   | a considerar |      |                          |
|               |   | sobre la     |      |                          |
|               |   | percepción   |      |                          |
|               |   | de IVA       |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| LIQUIDA_IMPUE | N | Indica si se | bool | **Valores posibles:**    |
| STOS_INTERNOS | o | debe         |      |                          |
|               |   | liquidar     |      | -   true: liquida        |
|               |   | impuestos    |      |     impuestos internos   |
|               |   | internos al  |      |                          |
|               |   | cliente      |      | -   false: no liquida    |
|               |   | ocasional    |      |     impuestos internos   |
|               |   |              |      |                          |
|               |   |              |      | En caso de no informar   |
|               |   |              |      | un valor consideraremos  |
|               |   |              |      | "false" y por lo tanto   |
|               |   |              |      | no calcularemos          |
|               |   |              |      | impuestos internos.      |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| DIS           | N | Indica si se | bool | **Valores posibles:**    |
| CRIMINA_IMPUE | o | debe         |      |                          |
| STOS_INTERNOS |   | discriminar  |      | -   true: discrimina     |
|               |   | en el        |      |     impuestos internos   |
|               |   | comprobante  |      |                          |
|               |   | los          |      | -   false: no discrimina |
|               |   | impuestos    |      |     impuestos internos   |
|               |   | internos     |      |                          |
|               |   | calculados   |      | En caso de no informar   |
|               |   |              |      | un valor consideraremos  |
|               |   |              |      | "false" y por lo tanto   |
|               |   |              |      | no discriminaremos       |
|               |   |              |      | impuestos internos.      |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| CALCULA_PER   | N | Indica si se | bool | **Valores posibles:**    |
| CEPCION_IMPUE | o | debe         |      |                          |
| STOS_INTERNOS |   | liquidar     |      | -   true: calcula        |
|               |   | percepción   |      |     percepción de        |
|               |   | de impuestos |      |     impuestos internos   |
|               |   | internos al  |      |                          |
|               |   | cliente      |      | -   false: no calcula    |
|               |   | ocasional    |      |     percepción de        |
|               |   |              |      |     impuestos internos   |
|               |   |              |      |                          |
|               |   |              |      | En caso de no informar   |
|               |   |              |      | un valor consideraremos  |
|               |   |              |      | "false" y por lo tanto   |
|               |   |              |      | no calcularemos          |
|               |   |              |      | percepciones de          |
|               |   |              |      | impuestos internos.      |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_GVA41_ALI  | N | Id           | int  | **Valores posibles:** ID |
| CUOTA_FIJA_PE | o | entificación |      | correspondiente a la     |
| RCEPCION_IIBB |   | de la        |      | tabla GVA41 cuyo código  |
|               |   | alícuota     |      | esté comprendido entre   |
|               |   | fija de      |      | el 51 y el 80.           |
|               |   | Ingresos     |      |                          |
|               |   | brutos       |      | Solo lo podés informar   |
|               |   |              |      | si                       |
|               |   |              |      | LIQUIDA_PE               |
|               |   |              |      | RCEPCION_INGRESOS_BRUTOS |
|               |   |              |      | = true.                  |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| LIQUIDA_      | N | Indica si se | bool | **Valores posibles:**    |
| PERCEPCION_IN | o | debe         |      |                          |
| GRESOS_BRUTOS |   | liquidar     |      | -   true: liquida        |
|               |   | ingresos     |      |     percepción de IIBB   |
|               |   | brutos al    |      |                          |
|               |   | cliente      |      | -   false: no liquida    |
|               |   | ocasional    |      |     percepción de IIBB   |
|               |   |              |      |                          |
|               |   |              |      | En caso de no informar   |
|               |   |              |      | un valor consideraremos  |
|               |   |              |      | "false" y por lo tanto   |
|               |   |              |      | no calcularemos          |
|               |   |              |      | percepciones de ingresos |
|               |   |              |      | brutos.                  |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| CONSI         | N | Indica si se | bool | **Valores posibles:**    |
| DERA_IVA_BASE | o | debe         |      |                          |
| _CALCULO_IIBB |   | considerar   |      | -   true: considera en   |
|               |   | el importe   |      |     IVA dentro de la     |
|               |   | de IVA       |      |     base de cálculo      |
|               |   | dentro de la |      |                          |
|               |   | base de      |      | -   false: no lo         |
|               |   | cálculo de   |      |     considera            |
|               |   | la alícuota  |      |                          |
|               |   | fija de      |      | En caso de no informar   |
|               |   | ingresos     |      | un valor consideraremos  |
|               |   | brutos       |      | "false" y por lo tanto   |
|               |   |              |      | no consideraremos el IVA |
|               |   |              |      | dentro de la base de     |
|               |   |              |      | cálculo.                 |
|               |   |              |      |                          |
|               |   |              |      | Solo lo podés informar   |
|               |   |              |      | si                       |
|               |   |              |      | LIQUIDA_PE               |
|               |   |              |      | RCEPCION_INGRESOS_BRUTOS |
|               |   |              |      | = true                   |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_G          | N | Id           | int  | **Valores posibles:** ID |
| VA41_ALICUOTA | o | entificación |      | correspondiente a la     |
| _ADICIONAL_PE |   | de la        |      | tabla GVA41 cuyo código  |
| RCEPCION_IIBB |   | alícuota     |      | esté comprendido entre   |
|               |   | adicional de |      | el 51 y el 80.           |
|               |   | Ingresos     |      |                          |
|               |   | brutos       |      | Solo lo podés informar   |
|               |   |              |      | si                       |
|               |   |              |      | LIQUIDA_PE               |
|               |   |              |      | RCEPCION_INGRESOS_BRUTOS |
|               |   |              |      | = true                   |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| CONSIDERA_    | N | Indica si se | bool | **Valores posibles:**    |
| IVA_BASE_CALC | o | debe         |      |                          |
| ULO_IIBB_ADIC |   | considerar   |      | -   true: considera en   |
|               |   | el importe   |      |     IVA dentro de la     |
|               |   | de IVA       |      |     base de cálculo      |
|               |   | dentro de la |      |                          |
|               |   | base de      |      | -   false: no lo         |
|               |   | cálculo de   |      |     considera            |
|               |   | la alícuota  |      |                          |
|               |   | adicional de |      | En caso de no informar   |
|               |   | ingresos     |      | un valor consideraremos  |
|               |   | brutos       |      | "false" y por lo tanto   |
|               |   |              |      | no consideraremos el IVA |
|               |   |              |      | dentro de la base de     |
|               |   |              |      | cálculo.                 |
|               |   |              |      |                          |
|               |   |              |      | Solo lo podés informar   |
|               |   |              |      | si                       |
|               |   |              |      | LIQUIDA_PE               |
|               |   |              |      | RCEPCION_INGRESOS_BRUTOS |
|               |   |              |      | = true                   |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| L             | N | Indica si se | bool | **Valores posibles:**    |
| IQUIDA_PERCEP | o | debe         |      |                          |
| CION_INGRESOS |   | liquidar     |      | -   true: liquida        |
| _BRUTOS_59_98 |   | ingresos     |      |     percepción de IIBB   |
|               |   | brutos de    |      |     59/98                |
|               |   | acuerdo con  |      |                          |
|               |   | la RG 58/59  |      | -   false: no liquida    |
|               |   | al cliente   |      |     percepción de IIBB   |
|               |   | ocasional.   |      |     59/98                |
|               |   | Esta RG está |      |                          |
|               |   | relacionada  |      | En caso de no informar   |
|               |   | con          |      | un valor consideraremos  |
|               |   | industrias   |      | "false" y por lo tanto   |
|               |   | elaboradoras |      | no liquidaremos la       |
|               |   | de cervezas  |      | percepción de IIBB       |
|               |   | y agentes de |      | 59/98.                   |
|               |   | come         |      |                          |
|               |   | rcialización |      |                          |
|               |   | mayorista de |      |                          |
|               |   | dichos       |      |                          |
|               |   | bienes       |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_GV         | N | Id           | int  | **Valores posibles:** ID |
| A41_ALICUOTA_ | o | entificación |      | correspondiente a la     |
| FIJA_PERCEPCI |   | de la        |      | tabla GVA41 cuyo código  |
| ON_IIBB_59_98 |   | alícuota de  |      | esté comprendido entre   |
|               |   | Ingresos     |      | el 51 y el 80.           |
|               |   | brutos (RG   |      |                          |
|               |   | 58/59)       |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| INCLUYE_IMPUE | N | Indica si se | bool | **Valores posibles:**    |
| STOS_INTERNOS | o | deben        |      |                          |
|               |   | considerar   |      | -   true: incluye        |
|               |   | los          |      |     impuestos internos   |
|               |   | impuestos    |      |                          |
|               |   | internos en  |      | -   false: no incluye    |
|               |   | el cálculo   |      |     impuestos internos   |
|               |   | de ingresos  |      |                          |
|               |   | brutos (RG   |      | En caso de no informar   |
|               |   | 58/59)       |      | un valor consideraremos  |
|               |   |              |      | "false" y por lo tanto   |
|               |   |              |      | no incluiremos los       |
|               |   |              |      | impuestos internos       |
|               |   |              |      | []{.mark}                |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_GVA151     | N | Id           | int  |                          |
|               | o | entificación |      |                          |
|               |   | del rubro    |      |                          |
|               |   | comercial    |      |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_GVA150     | N | Id           | int  |                          |
|               | o | entificación |      |                          |
|               |   | de la        |      |                          |
|               |   | c            |      |                          |
|               |   | lasificación |      |                          |
|               |   | impositiva   |      |                          |
|               |   | del cliente  |      |                          |
|               |   | para la      |      |                          |
|               |   | aplicación   |      |                          |
|               |   | de           |      |                          |
|               |   | percepciones |      |                          |
|               |   | definibles   |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| DIRE          | N | Dirección de | st   |                          |
| CCION_ENTREGA | o | entrega del  | ring |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| LOCA          | N | Localidad de | st   |                          |
| LIDAD_ENTREGA | o | la dirección | ring |                          |
|               |   | de entrega   |      |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| CODIGO_P      | N | Código       | st   |                          |
| OSTAL_ENTREGA | o | postal de la | ring |                          |
|               |   | dirección de |      |                          |
|               |   | entrega del  |      |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| ID_GVA18_PROV | S | Id           | int  | Podés obtener el ID a    |
| INCIA_ENTREGA | i | entificación |      | informar desde la tabla  |
|               |   | de la        |      | GVA18.                   |
|               |   | provincia de |      |                          |
|               |   | la dirección |      |                          |
|               |   | de entrega   |      |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| TELE          | N | Teléfono 1   | st   |                          |
| FONO1_ENTREGA | o | de la        | ring |                          |
|               |   | dirección de |      |                          |
|               |   | entrega del  |      |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|
| TELE          | N | Teléfono 2   | st   |                          |
| FONO2_ENTREGA | o | de la        | ring |                          |
|               |   | dirección de |      |                          |
|               |   | entrega del  |      |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
|-------------------|---------------|------------------|------------------|---------------------------------------------------|

##### CLIENTE_OCASIONAL_PERCEPCIONES_DEFINIBLES_DTO (No requerido)

Esta sección solo debe completarse (aunque es de forma opcional) si la
propiedad (de la sección ENCABEZADO) ES_CLIENTE_HABITUAL es false.

Tené en cuenta que esta sección es de tipo array por lo que deberás
repetirla para registrar las distintas precepciones definibles que se
deben aplicar al CLIENTE_OCASIONAL.

  -------------------------------------------------------------------------------------------------
  Campo                           Requerido   Descripción      Tipo de  Consideraciones, valores
                                                               dato     posibles y ejemplos
  ------------------------------- ----------- ---------------- -------- ---------------------------
  ID_PERCEPCION_VENTAS            Si          Identificación   int      Tené en cuenta que la
                                              de la percepción          información para completar
                                              definible que se          esta propiedad surge de la
                                              debe aplicar al           tabla GVA141 (Percepciones)
                                              cliente                   
                                              ocasional                 

  ID_PERCEPCION_VENTAS_ALICUOTA   Si          Identificación   Int      Tené en cuenta que la
                                              de la alícuota            información para completar
                                              asociada a la             esta propiedad surge de la
                                              percepción                tabla GVA141 (Alícuotas de
                                              definible que se          percepciones)
                                              debe aplicar al           
                                              cliente                   
                                              ocasional                 

  LEYENDA                         No          Leyenda libre    string   
  -------------------------------------------------------------------------------------------------

##### NOTA_PEDIDO_DTO (No requerido)

Tené en cuenta que esta sección es de tipo array por lo que deberás
repetirla para registrar los distintos mensajes que quieras dejar
asociados al pedido.

Si vas a completar esta sección es obligatorio que informes la propiedad
MENSAJE.

  ---------------------------------------------------------------------------------
  Campo            Requerido   Descripción     Tipo de  Consideraciones, valores
                                               dato     posibles y ejemplos
  ---------------- ----------- --------------- -------- ---------------------------
  MENSAJE          No          Comentario que  string   Además del mensaje
                               se quiera                registraremos la fecha del
                               incluir como             día y con el tipo de nota
                               nota adjunta en          "Manual".
                               el pedido                
                               dentro de la             
                               solapa de                
                               "Información             
                               adicional" del           
                               pedido.                  

  ---------------------------------------------------------------------------------

#### Novedades sobre cambios en el JSON

### Programs.cs (ejemplo)