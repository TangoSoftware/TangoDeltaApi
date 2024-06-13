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

+---------------+---+--------------+------+--------------------------+
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
| ID_GV         | S | Id           | int  | Validamos que            |
| A43_TALON_PED | i | entificación |      | corresponda a un         |
|               |   | del          |      | talonario de pedidos. ID |
|               |   | talonario de |      | de la tabla GVA43 donde  |
|               |   | pedidos      |      | GVA43.COMPROB = "PED"    |
+---------------+---+--------------+------+--------------------------+
| NRO_PEDIDO    | N | Número del   | st   | Si lo ingresás           |
|               | o | pedido       | ring | verificamos que sea      |
|               |   |              |      | correlativo al último    |
|               |   |              |      | (si no que tenés         |
|               |   |              |      | habilitada la edición    |
|               |   |              |      | del número de            |
|               |   |              |      | talonario).              |
|               |   |              |      |                          |
|               |   |              |      | Si no lo ingresás, lo    |
|               |   |              |      | asignaremos              |
|               |   |              |      | automáticamente.         |
+---------------+---+--------------+------+--------------------------+
| ESTADO        | N | Estado del   | int  | Si no lo ingresás, lo    |
|               | o | pedido       |      | asigna automáticamente   |
|               |   |              |      | en función a lo          |
|               |   |              |      | establecido en           |
|               |   |              |      | [Parámetros de           |
|               |   |              |      | Ventas]{.underline}      |
|               |   |              |      | (Aprueba pedidos)        |
|               |   |              |      |                          |
|               |   |              |      | **Valores posibles:**    |
|               |   |              |      |                          |
|               |   |              |      | -   **1** (Ingresado)    |
|               |   |              |      |                          |
|               |   |              |      | -   **2** (Aprobado)     |
|               |   |              |      |                          |
|               |   |              |      | **Ejemplos:**            |
|               |   |              |      |                          |
|               |   |              |      | -   Si no lo ingresás, y |
|               |   |              |      |     "No aprueba          |
|               |   |              |      |     pedidos", ESTADO = 2 |
|               |   |              |      |                          |
|               |   |              |      | -   Si no lo ingresás, y |
|               |   |              |      |     "Aprueba pedidos",   |
|               |   |              |      |     ESTADO = 1           |
|               |   |              |      |                          |
|               |   |              |      | -   Si ingresás 2 y      |
|               |   |              |      |     "Aprueba pedidos"    |
|               |   |              |      |     ESTADO = 2           |
|               |   |              |      |                          |
|               |   |              |      | -   Si ingresás 1 y "No  |
|               |   |              |      |     aprueba pedidos",    |
|               |   |              |      |     rechazamos el        |
|               |   |              |      |     registro.            |
+---------------+---+--------------+------+--------------------------+
| FECHA_PEDIDO  | N | Fecha del    | date | Si no lo indicás         |
|               | o | pedido       | time | asumimos la fecha del    |
|               |   |              |      | día                      |
+---------------+---+--------------+------+--------------------------+
| ID_GVA14      | N | Id           | int  | Es requerido cuando la   |
|               | o | entificación |      | propiedad                |
|               |   | del cliente  |      | ES_CLIENTE_HABITUAL es   |
|               |   | habitual     |      | true                     |
|               |   |              |      |                          |
|               |   |              |      | Si esa propiedad es      |
|               |   |              |      | false no lo debés        |
|               |   |              |      | informar.                |
+---------------+---+--------------+------+--------------------------+
| ES_CLI        | S | Indica si el | bool | **Valores posibles:**    |
| ENTE_HABITUAL | i | pedido       |      |                          |
|               |   | corresponde  |      | -   true: cliente        |
|               |   | a un cliente |      |     habitual             |
|               |   | habitual o   |      |                          |
|               |   | uno          |      | -   false: cliente       |
|               |   | ocasional    |      |     ocasional            |
|               |   |              |      |                          |
|               |   |              |      | En caso de que quieras   |
|               |   |              |      | registrar un pedido      |
|               |   |              |      | correspondiente a un     |
|               |   |              |      | cliente ocasional debés  |
|               |   |              |      | completar las siguientes |
|               |   |              |      | secciones del JSON:      |
|               |   |              |      |                          |
|               |   |              |      | -                        |
|               |   |              |      |    CLIENTE_OCASIONAL_DTO |
|               |   |              |      |                          |
|               |   |              |      | -                        |
|               |   |              |      |    CLIENTE_OCASIONAL_PER |
|               |   |              |      | CEPCIONES_DEFINIBLES_DTO |
+---------------+---+--------------+------+--------------------------+
| ID_GVA01      | S | Id           | int  |                          |
|               | i | entificación |      |                          |
|               |   | de la        |      |                          |
|               |   | condición de |      |                          |
|               |   | venta        |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_GVA23      | S | Id           | int  |                          |
|               | i | entificación |      |                          |
|               |   | del vendedor |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_STA22      | S | Id           | int  |                          |
|               | i | entificación |      |                          |
|               |   | del depósito |      |                          |
|               |   | de stock     |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_GVA24      | S | Id           | int  |                          |
|               | i | entificación |      |                          |
|               |   | del          |      |                          |
|               |   | t            |      |                          |
|               |   | ransportista |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_MONEDA     | S | Id           | int  | El ID debe corresponder  |
|               | i | entificación |      | a una moneda donde       |
|               |   | de la moneda |      |                          |
|               |   | del          |      | MONEDA.TIPO_MONEDA =     |
|               |   | comprobante  |      | "Corriente" o            |
|               |   |              |      | "Extranjera contable"    |
|               |   |              |      | (lo que habitualmente    |
|               |   |              |      | representa pesos o       |
|               |   |              |      | dólares).                |
+---------------+---+--------------+------+--------------------------+
| COTIZACION    | N | Cotización   | dec  | Si no lo ingresás, lo    |
|               | o | de la moneda | imal | completaremos con la     |
|               |   | extranjera   |      | cotización establecida   |
|               |   | contable     |      | en [Parámetros de        |
|               |   |              |      | Ventas]{.underline} (no  |
|               |   |              |      | es un campo visible por  |
|               |   |              |      | el usuario. Se alimenta  |
|               |   |              |      | desde el proceso de      |
|               |   |              |      | [C                       |
|               |   |              |      | otizaciones]{.underline} |
|               |   |              |      | del módulo Procesos      |
|               |   |              |      | Generales y de las       |
|               |   |              |      | cotizaciones ingresadas  |
|               |   |              |      | por los usuarios en los  |
|               |   |              |      | comprobantes de Ventas)  |
+---------------+---+--------------+------+--------------------------+
| ID_GVA10      | S | Id           | int  |                          |
|               | i | entificación |      |                          |
|               |   | de la lista  |      |                          |
|               |   | de precios   |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_DIRE       | N | Id           | int  | Si no lo ingresás,       |
| CCION_ENTREGA | o | entificación |      | asumimos que el pedido   |
|               |   | de la        |      | se debe enviar a la      |
|               |   | dirección de |      | dirección habitual de    |
|               |   | entrega del  |      | entrega del cliente.     |
|               |   | cliente      |      |                          |
|               |   |              |      | Si lo ingresás validamos |
|               |   |              |      | que exista, que          |
|               |   |              |      | corresponda al cliente   |
|               |   |              |      | informado y que esté     |
|               |   |              |      | habilitada.              |
|               |   |              |      |                          |
|               |   |              |      | No debés completar esta  |
|               |   |              |      | propiedad si             |
|               |   |              |      | ES_CLIENTE_HABITUAL =    |
|               |   |              |      | false                    |
+---------------+---+--------------+------+--------------------------+
| FECHA_ENTREGA | N | Fecha de     | date | Solo los podés informar  |
|               | o | entrega      | time | si usa planes de entrega |
|               |   |              |      | ([Parámetros de          |
|               |   |              |      | Venta]{.underline}       |
|               |   |              |      | \\Comprobantes\\Pedidos) |
|               |   |              |      |                          |
|               |   |              |      | Si no lo ingresás,       |
|               |   |              |      | asumimos la              |
|               |   |              |      | FECHA_PEDIDO + la        |
|               |   |              |      | cantidad habitual de     |
|               |   |              |      | días de entrega definida |
|               |   |              |      | en Parámetros de Venta.  |
+---------------+---+--------------+------+--------------------------+
| ID_ASIE       | N | Id           | int  | Si lo ingresás           |
| NTO_MODELO_GV | o | entificación |      | verificamos que          |
|               |   | del modelo   |      | corresponda a un modelo  |
|               |   | de asiento   |      | de asiento habilitado    |
|               |   | que se debe  |      | para facturas.           |
|               |   | aplicar a    |      |                          |
|               |   | las facturas |      |                          |
|               |   | relacionadas |      |                          |
|               |   | con el       |      |                          |
|               |   | pedido       |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_GVA81      | N | Id           | int  | Tené en cuenta que esta  |
|               | o | entificación |      | propiedad es obligatoria |
|               |   | de la        |      | si exigís la             |
|               |   | c            |      | clasificación de         |
|               |   | lasificación |      | comprobantes "Siempre"   |
|               |   | de           |      | ([Parámetros de          |
|               |   | comprobantes |      | Venta]{.u                |
|               |   |              |      | nderline}\\Clasificación |
|               |   |              |      | de                       |
|               |   |              |      | comprobantes\\Clasifica  |
|               |   |              |      | comprobantes)            |
|               |   |              |      |                          |
|               |   |              |      | Si no la informás, la    |
|               |   |              |      | completamos con la       |
|               |   |              |      | clasificación habitual   |
|               |   |              |      | para pedidos definida en |
|               |   |              |      | Parámetros de Ventas.    |
|               |   |              |      | (solo para el caso en    |
|               |   |              |      | que sea obligatorio su   |
|               |   |              |      | ingreso de acuerdo con   |
|               |   |              |      | lo explicado más arriba, |
|               |   |              |      | de lo contrario quedará  |
|               |   |              |      | sin clasificar)          |
|               |   |              |      |                          |
|               |   |              |      | Controlamos que se       |
|               |   |              |      | encuentre vigente, que   |
|               |   |              |      | esté habilitada para el  |
|               |   |              |      | módulo de "Ventas" y     |
|               |   |              |      | para "Pedidos".          |
+---------------+---+--------------+------+--------------------------+
| ID_GVA43_TALO | N | Id           | int  | Si lo ingresás           |
| NARIO_FACTURA | o | entificación |      | verificamos que          |
|               |   | del          |      | corresponda a un         |
|               |   | talonario    |      | talonario de factura     |
|               |   | con el que   |      | (GVA43.COMPROB = "FAC")  |
|               |   | se debería   |      |                          |
|               |   | facturar     |      |                          |
+---------------+---+--------------+------+--------------------------+
| NRO           | N | Número de    | st   |                          |
| _ORDEN_COMPRA | o | orden de     | ring |                          |
|               |   | compra del   |      |                          |
|               |   | cliente      |      |                          |
+---------------+---+--------------+------+--------------------------+
| FECHA         | N | Fecha de la  | date | Esta propiedad es        |
| _ORDEN_COMPRA | o | orden de     | time | obligatoria si completás |
|               |   | compra del   |      | NRO_ORDEN_COMPRA         |
|               |   | cliente      |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_SUC        | N | Id           | int  | Completá esta propiedad  |
| URSAL_DESTINO | o | entificación |      | si el pedido debe        |
|               |   | de la        |      | continuar circuito en    |
|               |   | sucursal a   |      | otra sucursal, ya sea    |
|               |   | la que debe  |      | para facturarse como     |
|               |   | enviarse en  |      | para remitirse.          |
|               |   | pedido.      |      |                          |
|               |   |              |      | Si la completás,         |
|               |   |              |      | verificamos que exista y |
|               |   |              |      | que sea distinta a la    |
|               |   |              |      | asignada en el proceso   |
|               |   |              |      | Empresa.                 |
+---------------+---+--------------+------+--------------------------+
| COM           | N | Indica si el | bool | **Valores posibles:**    |
| PROMETE_STOCK | o | pedido       |      |                          |
|               |   | compromete   |      | -   true: compromete     |
|               |   | stock        |      |     stock                |
|               |   |              |      |                          |
|               |   |              |      | -   false: no compromete |
|               |   |              |      |     stock                |
|               |   |              |      |                          |
|               |   |              |      | Si no lo informás,       |
|               |   |              |      | asumimos el valor "true" |
+---------------+---+--------------+------+--------------------------+
| ID_ACTIVIDAD  | N | Código de    | int  | Solo debés completar     |
| _EMPRESA_AFIP | o | actividad de |      | esta información         |
|               |   | la empresa   |      | (opcionalmente) si la    |
|               |   | que debe     |      | empresa está obligada a  |
|               |   | aplicar al   |      | cumplir con la RG 3749   |
|               |   | facturar     |      | (régimen de información  |
|               |   | según lo     |      | adicional de factura     |
|               |   | especificado |      | electrónica). Este dato  |
|               |   | por la RG    |      | se traslada luego a la   |
|               |   | 3749         |      | factura.                 |
|               |   |              |      |                          |
|               |   |              |      | **Valores posibles:**    |
|               |   |              |      | (debés informar el ID    |
|               |   |              |      | correspondiente al       |
|               |   |              |      | código)                  |
|               |   |              |      |                          |
|               |   |              |      | -   **10** - Educación   |
|               |   |              |      |     pública de gestión   |
|               |   |              |      |     privada              |
|               |   |              |      |                          |
|               |   |              |      | -   **11**- Locación de  |
|               |   |              |      |     inmuebles rurales    |
|               |   |              |      |                          |
|               |   |              |      | -   **12** - Locación de |
|               |   |              |      |     inmuebles turísticos |
+---------------+---+--------------+------+--------------------------+
| ACTIVIDAD_COM | N | Código de    | st   | Solo debés completar     |
| PROBANTE_AFIP | o | actividad de | ring | esta información         |
|               |   | la           |      | (opcionalmente) si la    |
|               |   | transacción  |      | empresa está obligada a  |
|               |   | que debe     |      | cumplir con la RG 3749   |
|               |   | aplicar al   |      | (régimen de información  |
|               |   | facturar     |      | adicional de factura     |
|               |   | según lo     |      | electrónica). Este dato  |
|               |   | especificado |      | se traslada luego a la   |
|               |   | por la RG    |      | factura.                 |
|               |   | 3749         |      |                          |
|               |   |              |      | Valores posibles:        |
|               |   |              |      |                          |
|               |   |              |      | -   "C" comprendida      |
|               |   |              |      |                          |
|               |   |              |      | -   "N" no comprendida   |
+---------------+---+--------------+------+--------------------------+
| ID_TIPO       | N | Tipo de      | st   | Solo debés completar     |
| _DOCUMENTO_GV | o | documento de | ring | esta información         |
|               |   | la persona   |      | (opcionalmente) si la    |
|               |   | responsable  |      | empresa está obligada a  |
|               |   | del pago     |      | cumplir con la RG 3749   |
|               |   | según lo     |      | (régimen de información  |
|               |   | especificado |      | adicional de factura     |
|               |   | por la RG    |      | electrónica). Este dato  |
|               |   | 3749         |      | se traslada luego a la   |
|               |   |              |      | factura.                 |
+---------------+---+--------------+------+--------------------------+
| NUMERO_DOCU   | N | Número de    | st   | Solo debés completar     |
| MENTO_PAGADOR | o | documento de | ring | esta información         |
|               |   | la persona   |      | (opcionalmente) si la    |
|               |   | responsable  |      | empresa está obligada a  |
|               |   | del pago     |      | cumplir con la RG 3749   |
|               |   | según lo     |      | (régimen de información  |
|               |   | especificado |      | adicional de factura     |
|               |   | por la RG    |      | electrónica). Este dato  |
|               |   | 3749         |      | se traslada luego a la   |
|               |   |              |      | factura.                 |
|               |   |              |      |                          |
|               |   |              |      | En las facturas          |
|               |   |              |      | correspondientes a       |
|               |   |              |      | colegios                 |
|               |   |              |      | (AC                      |
|               |   |              |      | TIVIDAD_COMPROBANTE_AFIP |
|               |   |              |      | = 10) habitualmente es   |
|               |   |              |      | uno de los progenitores  |
+---------------+---+--------------+------+--------------------------+
| LEYENDA_1     | N | Leyenda 1    | st   |                          |
|               | o | del pedido   | ring |                          |
+---------------+---+--------------+------+--------------------------+
| LEYENDA_2     | N | Leyenda 2    | st   |                          |
|               | o | del pedido   | ring |                          |
+---------------+---+--------------+------+--------------------------+
| LEYENDA_3     | N | Leyenda 3    | st   |                          |
|               | o | del pedido   | ring |                          |
+---------------+---+--------------+------+--------------------------+
| LEYENDA_4     | N | Leyenda 4    | st   |                          |
|               | o | del pedido   | ring |                          |
+---------------+---+--------------+------+--------------------------+
| LEYENDA_5     | N | Leyenda 5    | st   |                          |
|               | o | del pedido   | ring |                          |
+---------------+---+--------------+------+--------------------------+
| PO            | N | Porcentaje   | dec  | **Valores posibles:**    |
| RCENTAJE_DESC | o | de descuento | imal | entre 0 y 100.           |
| UENTO_GENERAL |   | del pedido   |      |                          |
|               |   |              |      | Solo lo podés informar   |
|               |   |              |      | si                       |
|               |   |              |      | I                        |
|               |   |              |      | MPORTE_DESCUENTO_GENERAL |
|               |   |              |      | es null                  |
|               |   |              |      |                          |
|               |   |              |      | Tené en cuenta que este  |
|               |   |              |      | valor se suma al         |
|               |   |              |      | descuento del cliente si |
|               |   |              |      | informás que             |
|               |   |              |      | APLICA_DESCUENTO_CLIENTE |
|               |   |              |      | = true                   |
+---------------+---+--------------+------+--------------------------+
| IMPORTE_DESC  | N | Importe de   | dec  | **Valores posibles:**    |
| UENTO_GENERAL | o | descuento    | imal | mayor o igual a 0        |
|               |   | del pedido   |      |                          |
|               |   |              |      | Solo lo podés informar   |
|               |   |              |      | si                       |
|               |   |              |      | PORC                     |
|               |   |              |      | ENTAJE_DESCUENTO_GENERAL |
|               |   |              |      | es null                  |
|               |   |              |      |                          |
|               |   |              |      | Tené en cuenta que este  |
|               |   |              |      | valor se suma al         |
|               |   |              |      | descuento del cliente si |
|               |   |              |      | informás que             |
|               |   |              |      | APLICA_DESCUENTO_CLIENTE |
|               |   |              |      | = true                   |
+---------------+---+--------------+------+--------------------------+
| PORCENTAJE_RE | N | Porcentaje   | dec  | **Valores posibles:**    |
| CARGO_GENERAL | o | de recargo   | imal | entre 0 y 100.           |
|               |   | del pedido   |      |                          |
|               |   |              |      | Solo lo podés informar   |
|               |   |              |      | si                       |
|               |   |              |      | IMPORTE_RECARGO_GENERAL  |
|               |   |              |      | es null                  |
+---------------+---+--------------+------+--------------------------+
| IMPORTE_RE    | N | Importe de   | dec  | **Valores posibles:**    |
| CARGO_GENERAL | o | recargo del  | imal | mayor o igual a 0        |
|               |   | pedido       |      |                          |
|               |   |              |      | Solo lo podés informar   |
|               |   |              |      | si                       |
|               |   |              |      | PO                       |
|               |   |              |      | RCENTAJE_RECARGO_GENERAL |
|               |   |              |      | es null                  |
+---------------+---+--------------+------+--------------------------+
| APLICA_DESC   | N | Indica si se | bool | **Valores posibles:**    |
| UENTO_CLIENTE | o | debe aplicar |      |                          |
|               |   | el descuento |      | -   true: aplica el      |
|               |   | habitual del |      |     descuento asignado   |
|               |   | cliente      |      |     en el proceso de     |
|               |   |              |      |     Clientes.            |
|               |   |              |      |                          |
|               |   |              |      | -   false: no aplica el  |
|               |   |              |      |     descuento asignado   |
|               |   |              |      |     en el proceso de     |
|               |   |              |      |     Clientes.            |
+---------------+---+--------------+------+--------------------------+
| CALCUL        | N | Indica si se | bool | **Valores posibles:**    |
| A_PROMOCIONES | o | deben        |      |                          |
|               |   | aplicar      |      | -   true: aplica         |
|               |   | promociones  |      |     automáticamente las  |
|               |   | en el pedido |      |     promociones          |
|               |   | o se debe    |      |     definidas en el      |
|               |   | genera sin   |      |     sistema.             |
|               |   | tenerlas en  |      |                          |
|               |   | cuenta       |      | -   false: no se aplican |
|               |   |              |      |     las promociones      |
|               |   |              |      |     comerciales para el  |
|               |   |              |      |     pedido (como si no   |
|               |   |              |      |     existieran o no      |
|               |   |              |      |     estuvieran vigentes) |
|               |   |              |      |                          |
|               |   |              |      | Tené en cuenta que en    |
|               |   |              |      | caso de existir          |
|               |   |              |      | promociones del tipo     |
|               |   |              |      | "A+B" debés informar por |
|               |   |              |      | tu cuenta los artículos  |
|               |   |              |      | que se entregan como     |
|               |   |              |      | "regalo" en este pedido  |
|               |   |              |      | para que se aplique la   |
|               |   |              |      | promoción.               |
+---------------+---+--------------+------+--------------------------+
| VALIDA_L      | N | Indica si se | bool | **Valores posibles:**    |
| IMITE_CREDITO | o | debe validar |      |                          |
|               |   | el límite de |      | -   true: control        |
|               |   | crédito del  |      |     estricto de límite   |
|               |   | cliente al   |      |     de crédito           |
|               |   | grabar el    |      |                          |
|               |   | pedido.      |      | -   false: no controla   |
|               |   |              |      |     límite de crédito    |
|               |   |              |      |                          |
|               |   |              |      | En caso de que actives   |
|               |   |              |      | esta opción y el pedido  |
|               |   |              |      | superase el límite de    |
|               |   |              |      | crédito no podrás grabar |
|               |   |              |      | el comprobante.          |
|               |   |              |      |                          |
|               |   |              |      | Tené en cuenta que, si   |
|               |   |              |      | el cliente pertenece a   |
|               |   |              |      | un grupo empresario,     |
|               |   |              |      | validaremos el límite de |
|               |   |              |      | crédito de acuerdo con   |
|               |   |              |      | lo especificado en la    |
|               |   |              |      | configuración del grupo  |
|               |   |              |      | empresario.              |
+---------------+---+--------------+------+--------------------------+
| ID_SBA01      | N | Id           | int  | Tené en cuenta que       |
|               | o | entificación |      | trasladaremos la         |
|               |   | de la cuenta |      | intención de pago a la   |
|               |   | de Tesorería |      | factura en forma         |
|               |   | que          |      | automática y por el      |
|               |   | representa   |      | importe total del        |
|               |   | la intención |      | pedido.                  |
|               |   | de pago del  |      |                          |
|               |   | cliente (Se  |      |                          |
|               |   | traslada     |      |                          |
|               |   | luego a      |      |                          |
|               |   | factura)     |      |                          |
+---------------+---+--------------+------+--------------------------+
| OBSERVACIONES | N | O            | st   |                          |
|               | o | bservaciones | ring |                          |
|               |   | del pedido   |      |                          |
+---------------+---+--------------+------+--------------------------+

##### RENGLON_DTO

Tené en cuenta que esta sección es de tipo array por lo que deberás
repetirla para registrar los distintos renglones del pedido.

+---------------+---+--------------+------+--------------------------+
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
| ID_STA11      | S | Id           | int  |                          |
|               | i | entificación |      |                          |
|               |   | del artículo |      |                          |
|               |   | pedido       |      |                          |
+---------------+---+--------------+------+--------------------------+
| DESCRIP       | N | Descripción  | st   | Solo lo debés informar   |
| CION_ARTICULO | o | del artículo | ring | si necesitás alterar la  |
|               |   |              |      | descripción habitual del |
|               |   |              |      | artículo.                |
|               |   |              |      |                          |
|               |   |              |      | Tené en cuenta que lo    |
|               |   |              |      | podrás ingresar          |
|               |   |              |      | únicamente si está       |
|               |   |              |      | activo el parámetro      |
|               |   |              |      | "Permite agregar líneas  |
|               |   |              |      | y editar las del         |
|               |   |              |      | artículo" ([Parámetros   |
|               |   |              |      | de                       |
|               |   |              |      | Venta]{.underline}\      |
|               |   |              |      | \Comprobantes\\General\\ |
|               |   |              |      | Descripciones            |
|               |   |              |      | adicionales en créditos, |
|               |   |              |      | débitos y pedidos)       |
+---------------+---+--------------+------+--------------------------+
| DESC          | N | Descripción  | st   | Solo lo debés informar   |
| RIPCION_ADICI | o | adicional    | ring | si necesitás alterar la  |
| ONAL_ARTICULO |   | del artículo |      | descripción adicional    |
|               |   |              |      | habitual del artículo.   |
|               |   |              |      |                          |
|               |   |              |      | Tené en cuenta que lo    |
|               |   |              |      | podrás ingresar          |
|               |   |              |      | únicamente si está       |
|               |   |              |      | activo el parámetro      |
|               |   |              |      | "Permite agregar líneas  |
|               |   |              |      | y editar las del         |
|               |   |              |      | artículo"                |
|               |   |              |      | ([\|]{.underline}\       |
|               |   |              |      | \Comprobantes\\General\\ |
|               |   |              |      | Descripciones            |
|               |   |              |      | adicionales en créditos, |
|               |   |              |      | débitos y pedidos)       |
+---------------+---+--------------+------+--------------------------+
| ID_STA22      | N | Id           | int  | Si no lo informás,       |
|               | o | entificación |      | asignaremos el valor     |
|               |   | del depósito |      | definido en la sección   |
|               |   | del renglón  |      | ENCABEZADO               |
+---------------+---+--------------+------+--------------------------+
| MODULO_       | N | Unidad de    | st   | **Valores posibles:**    |
| UNIDAD_MEDIDA | o | medida en la | ring |                          |
|               |   | que está     |      | -   "GV": presentación   |
|               |   | expresa la   |      |     de ventas            |
|               |   | CAN          |      |                          |
|               |   | TIDAD_PEDIDA |      | -   "ST": unidad de      |
|               |   |              |      |     medida de stock      |
|               |   |              |      |                          |
|               |   |              |      | En caso de no informar   |
|               |   |              |      | un valor asumiremos      |
|               |   |              |      | "GV".                    |
+---------------+---+--------------+------+--------------------------+
| CA            | S | Cantidad     | dec  | **Valores posibles:**    |
| NTIDAD_PEDIDA | I | solicitada   | imal | distinto de 0.           |
|               |   | por el       |      |                          |
|               |   | cliente      |      | Puede ser un valor       |
|               |   |              |      | negativo siempre y       |
|               |   |              |      | cuando la propiedad      |
|               |   |              |      | PRECIO tenga un valor    |
|               |   |              |      | positivo o null. Podés   |
|               |   |              |      | utilizar un valor        |
|               |   |              |      | negativo para reflejar   |
|               |   |              |      | una devolución del       |
|               |   |              |      | producto.                |
+---------------+---+--------------+------+--------------------------+
| CANTID        | N | Cantidad     | dec  | **Valores posibles:**    |
| AD_A_FACTURAR | o | habilitada   | imal | menor o igual que        |
|               |   | para         |      | CANTIDAD_PEDIDA          |
|               |   | facturar     |      |                          |
|               |   |              |      | Si no lo informás, o lo  |
|               |   |              |      | dejás en null,           |
|               |   |              |      | asignaremos la misma     |
|               |   |              |      | cantidad que             |
|               |   |              |      | CANTIDAD_PEDIDA          |
+---------------+---+--------------+------+--------------------------+
| CANTID        | N | Cantidad     | dec  | **Valores posibles:**    |
| AD_A_DESCARGA | o | habilitada   | imal | menor o igual que        |
|               |   | para remitir |      | CANTIDAD_PEDIDA          |
|               |   |              |      |                          |
|               |   |              |      | Si no lo informás, o lo  |
|               |   |              |      | dejás en null,           |
|               |   |              |      | asignaremos la misma     |
|               |   |              |      | cantidad que             |
|               |   |              |      | CANTIDAD_PEDIDA          |
+---------------+---+--------------+------+--------------------------+
| CAN           | N | Cantidad     | dec  | **Valores posibles:**    |
| TIDAD_PENDIEN | o | pendiente de | imal | igual que                |
| TE_A_FACTURAR |   | facturar     |      | CANTIDAD_PEDIDA o 0      |
|               |   |              |      | (cero)                   |
|               |   |              |      |                          |
|               |   |              |      | Si no lo informás, o lo  |
|               |   |              |      | dejás en null,           |
|               |   |              |      | asignaremos la misma     |
|               |   |              |      | cantidad que             |
|               |   |              |      | CANTIDAD_A_FACTURAR      |
+---------------+---+--------------+------+--------------------------+
| PRECIO        | N | Precio de    | dec  | **Valores posibles:**    |
|               | o | venta        | imal | importes negativos, cero |
|               |   |              |      | o positivos.             |
|               |   |              |      |                          |
|               |   |              |      | Tené en cuenta que el    |
|               |   |              |      | valor puede ser negativo |
|               |   |              |      | siempre y cuando la      |
|               |   |              |      | propiedad                |
|               |   |              |      | CANTIDAD_PEDIDA tenga un |
|               |   |              |      | valor positivo. Un valor |
|               |   |              |      | negativo se puede usar,  |
|               |   |              |      | por ejemplo, para        |
|               |   |              |      | representar un descuento |
|               |   |              |      | en la factura por ese    |
|               |   |              |      | artículo.                |
|               |   |              |      |                          |
|               |   |              |      | Si ingresás un valor     |
|               |   |              |      | negativo no debés dejar  |
|               |   |              |      | espacios entre el signo  |
|               |   |              |      | y el importe; por        |
|               |   |              |      | ejemplo -5000.           |
|               |   |              |      |                          |
|               |   |              |      | Tené en cuenta que el    |
|               |   |              |      | valor ingresado debe     |
|               |   |              |      | estar expresado en la    |
|               |   |              |      | moneda de la lista de    |
|               |   |              |      | precios (ID_GVA10)       |
|               |   |              |      | informada en la sección  |
|               |   |              |      | ENCABEZADO.              |
|               |   |              |      |                          |
|               |   |              |      | Si no lo ingresás,       |
|               |   |              |      | asignaremos el precio de |
|               |   |              |      | la lista informada en la |
|               |   |              |      | sección ENCABEZADO. En   |
|               |   |              |      | caso de que no exista    |
|               |   |              |      | precio para el artículo  |
|               |   |              |      | rechazaremos el pedido.  |
+---------------+---+--------------+------+--------------------------+
| PORCENTAJE    | N | Porcentaje   | dec  | **Valores posibles:**    |
| _BONIFICACION | o | de           | imal | entre 0 y 100            |
|               |   | bonificación |      |                          |
|               |   | del renglón  |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_GVA81      | N | Id           | int  | Si no lo ingresás,       |
|               | o | entificación |      | asignaremos la           |
|               |   | de la        |      | clasificación indicada   |
|               |   | c            |      | en la sección            |
|               |   | lasificación |      | ENCABEZADO.              |
|               |   | de           |      |                          |
|               |   | comprobantes |      | Controlamos que se       |
|               |   | a nivel      |      | encuentre vigente, que   |
|               |   | renglón      |      | esté habilitada para el  |
|               |   |              |      | módulo de "Ventas" y     |
|               |   |              |      | para "Pedidos".          |
+---------------+---+--------------+------+--------------------------+
| OBSERVACIONES | N | O            | st   | Recomendamos utilizar    |
|               | o | bservaciones | ring | esta nueva propiedad en  |
|               |   | asignadas al |      | lugar de completar la    |
|               |   | renglón      |      | sección                  |
|               |   |              |      | D                        |
|               |   |              |      | ESCRIPCION_ADICIONAL_DTO |
|               |   |              |      | pero si utilizabas las   |
|               |   |              |      | descripciones            |
|               |   |              |      | adicionales para agregar |
|               |   |              |      | información adicional    |
|               |   |              |      | del artículo pedido      |
|               |   |              |      | podés continuar          |
|               |   |              |      | haciéndolo o incluso     |
|               |   |              |      | combinar ambas opciones. |
+---------------+---+--------------+------+--------------------------+

##### PLAN_DE_ENTREGA_DTO (No requerido)

Solo podés informar esta sección si tenés tildada la opción "Usa planes
de entrega" en Parámetros de Venta\\Comprobantes\\Pedidos.

Tené en cuenta que esta sección es de tipo array por lo que deberás
repetirla para registrar las distintas fechas de entrega pactadas con tu
cliente para cada RENGLON_DTO.

+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
| FEC           | N | Fecha de     | date | Es requerido si se       |
| HA_DE_ENTREGA | o | entrega      | time | ingresa una cantidad.    |
+---------------+---+--------------+------+--------------------------+

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

+---------------+---+--------------+------+--------------------------+
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
| ID_TIPO       | S | Tipo de      | int  |                          |
| _DOCUMENTO_GV | i | documento    |      |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| NRO_DOCUMENTO | N | Número de    | st   |                          |
|               | o | documento    | ring |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| RAZON_SOCIAL  | N | Razón social | st   |                          |
|               | o | del cliente  | ring |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| DOMICILIO     | N | Domicilio    | st   |                          |
|               | o | del cliente  | ring |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| LOCALIDAD     | N | Localidad    | st   |                          |
|               | o | del cliente  | ring |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| CODIGO_POSTAL | N | Código       | st   |                          |
|               | o | postal del   | ring |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_GV         | S | Id           | int  |                          |
| A18_PROVINCIA | i | entificación |      |                          |
|               |   | de la        |      |                          |
|               |   | provincia    |      |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| ACTIVIDAD     | N | Actividad    | st   |                          |
|               | o | comercial    | ring |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
| NRO_IN        | N | Número de    | st   |                          |
| GRESOS_BRUTOS | o | inscripción  | ring |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional en |      |                          |
|               |   | ingresos     |      |                          |
|               |   | brutos       |      |                          |
+---------------+---+--------------+------+--------------------------+
| E_MAIL        | N | Correo       | st   |                          |
|               | o | electrónico  | ring |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| WEB_CLIENTE   | N | Página web   | st   |                          |
|               | o | del cliente  | ring |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| NUMERO_INSCR  | N | Número de    | st   |                          |
| IPCION_RG1817 | o | constancia   | ring |                          |
|               |   | de condición |      |                          |
|               |   | tributaria   |      |                          |
|               |   | (RG1817)     |      |                          |
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
| ID_           | S | Id           | int  |                          |
| CATEGORIA_IVA | i | entificación |      |                          |
|               |   | de la        |      |                          |
|               |   | categoría de |      |                          |
|               |   | IVA del      |      |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
| PORCENT       | N | Porcentaje   | dec  | **Valores posibles:**    |
| AJE_EXCLUSION | o | de exclusión | imal | entre 0 y 100            |
|               |   | a considerar |      |                          |
|               |   | sobre la     |      |                          |
|               |   | percepción   |      |                          |
|               |   | de IVA       |      |                          |
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
| ID_GV         | N | Id           | int  | **Valores posibles:** ID |
| A41_ALICUOTA_ | o | entificación |      | correspondiente a la     |
| FIJA_PERCEPCI |   | de la        |      | tabla GVA41 cuyo código  |
| ON_IIBB_59_98 |   | alícuota de  |      | esté comprendido entre   |
|               |   | Ingresos     |      | el 51 y el 80.           |
|               |   | brutos (RG   |      |                          |
|               |   | 58/59)       |      |                          |
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
| ID_GVA151     | N | Id           | int  |                          |
|               | o | entificación |      |                          |
|               |   | del rubro    |      |                          |
|               |   | comercial    |      |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
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
+---------------+---+--------------+------+--------------------------+
| DIRE          | N | Dirección de | st   |                          |
| CCION_ENTREGA | o | entrega del  | ring |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| LOCA          | N | Localidad de | st   |                          |
| LIDAD_ENTREGA | o | la dirección | ring |                          |
|               |   | de entrega   |      |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| CODIGO_P      | N | Código       | st   |                          |
| OSTAL_ENTREGA | o | postal de la | ring |                          |
|               |   | dirección de |      |                          |
|               |   | entrega del  |      |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| ID_GVA18_PROV | S | Id           | int  | Podés obtener el ID a    |
| INCIA_ENTREGA | i | entificación |      | informar desde la tabla  |
|               |   | de la        |      | GVA18.                   |
|               |   | provincia de |      |                          |
|               |   | la dirección |      |                          |
|               |   | de entrega   |      |                          |
|               |   | del cliente  |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| TELE          | N | Teléfono 1   | st   |                          |
| FONO1_ENTREGA | o | de la        | ring |                          |
|               |   | dirección de |      |                          |
|               |   | entrega del  |      |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+
| TELE          | N | Teléfono 2   | st   |                          |
| FONO2_ENTREGA | o | de la        | ring |                          |
|               |   | dirección de |      |                          |
|               |   | entrega del  |      |                          |
|               |   | cliente      |      |                          |
|               |   | ocasional    |      |                          |
+---------------+---+--------------+------+--------------------------+

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