<a name="inicio"></a>
Tango Software - API Facturador
=======

- [Instalación](#instalacion)
  - [Versiones soportadas](#versiones)
  - [Generalidades](#generalidades)
- [Recepción de comprobantes API](#comprobantes)
  - [Datos del JSON](#djson)
  - [Tablas de Referencia](#tablasref)
  - [Ejemplos de JSON de un comprobante](#ejemplosjson)
	- [01 - Factura - Efectivo](#ej1)
	- [02 - Factura - Cuenta corriente](#ej2)
	- [03 - Factura - Cheque](#ej3)
	- [04 - Factura - Tarjeta](#ej4)
	- [05 - Factura - Comprobante Electronico](#ej5)
	- [06 - Nota de débito-crédito - Con comprobante de referencia](#ej6)
	- [07 - Nota de débito-crédito - Sin comprobante de referencia](#ej7)	
	- [08 - Factura - Con cliente ocasional](#ej8)
	- [09 - Factura - Con descuentos y recargos](#ej9)	
	- [10 - Factura - Items con descuento](#ej10)
	- [11 - Factura - Items con impuestos internos](#ej11)	
	- [12 - Factura - Items con kit fijo o variable](#ej12)
	- [13 - Factura - Items con percepciones](#ej13)
	- [14 - Factura - Items con series y partidas](#ej14)
	- [15 - Factura - Moneda extranjera](#ej15)
	- [16 - Factura - Sin Tesorería](#ej16)
	- [17 - Factura - Exportacion](#ej17)
	- [18 - Factura - Exportacion con permisos de embarco](#ej18)
	- [19 - Factura - Exportacion con remito tabaco](#ej19)
	- [20 - Factura - Artículo con más de una descripción adicional](#ej20)
		
<a name="instalacion"></a>

## Instalación

<a name="versiones"></a>

### Versiones soportadas
La versión mínima de ventas requerida para poder utilizar la API del Facturador es la 20.01.073 (o superior) correspondiente al hotfix https://descargas.axoft.com/ftp/version_interna/HotfixPublicados/HotFix_20_01_000_0073.exe (o posterior). No es necesario realizar ninguna instalación adicional dado que ya viene incorporada en las versiones.

<a name="generalidades"></a>

### Generalidades

Esta versión soporta comprobantes en moneda local y extranjera.

Se aceptan tantos decimales como aquella cantidad configurada en la instalación de la versión.

La registración de los comprobantes se realiza teniendo en cuenta la misma configuración con la que el facturador trabaja cuando no se selecciona un perfil determinado.

#### Tamaño de solicitudes

En el archivo PreferenciasPOS.xml se encuentra el parámetro << ApiRequestTamanio >> que permite definir el tamaño máximo en bytes de capacidad que posee el servidor para procesar cada solicitud JSON. A modo de ejemplo, a continuación se tienen algunas equivalencias de tamaños entre bytes y KB, MB y GB.

| Tamaño en Bytes en XML | Tamaño capacidad servidor (apróx.) |
|--- |--- |
|1024|1 KB|
|1048576|1 MB|
|1073741824|1 GB|

En el caso de que se intente procesar una solicitud JSON con un tamaño superior al configurado entonces la respuesta al JSON sera una notificación de tipo error como se muestra a continuación para un ejemplo en el que el tamaño máximo esta configurado en 100 KB.

```json
{
    "Message": "Hubo errores en la registración, verifique el resultado.",
    "Comprobantes": [
        {
            "numeroComprobante": null,
            "estado": "Error",
            "exceptionMessage": "(78052) El archivo JSON que intenta subir excede el tamaño máximo (100 KB) permitido. Reduzcalo e intentelo nuevamente.",
            "mensaje": null
        }
    ],
    "Succeeded": false
}
```

#### Log

En el archivo PreferenciasPOS.xml también se encuentra el parámetro << ApiRequestLogHabilitado >> que permite configurar si en el log se van a grabar (true) o no (false) datos de conexión vinculados a la solicitud JSON que se intenta registrar. Cabe destacar que la impresión en el log se realizará siempre y cuando la solicitud respete el tamaño configurado en el parámetro << ApiRequestTamanio >>.

<a name="comprobantes"></a>

## Registración de comprobantes API

**Ejemplo de URL del servicio de API para comprobantes:**
http://tango:17000/FacturadorVenta/registrar

### Notificaciones

**Formato de JSON de notificación**

Ejemplo 1
```json
{
    "Message": "Los comprobantes se han registrado correctamente",
    "Comprobantes": [
        {
            "numeroComprobante": "FAC A0000100000017",
            "estado": "Ok",
            "exceptionMessage": "",
            "mensaje": ""
        }
    ],
    "Succeeded": true
}
```
Ejemplo 2
```json
{
    "Message": "Hubo errores en la registración, verifique el resultado.",
    "Comprobantes": [
        {
            "numeroComprobante": "FAC A0000100000017",
            "estado": "Error",
            "exceptionMessage": "",
            "mensaje": "(51016) Ya existe el número de comprobante A 00001-00000017. Verifique el talonario utilizado."
        }
    ],
    "Succeeded": false
}
```

**Aclaración**
- La propiedad "Message" muestra un mensaje generico informando si el comprobante fue registrado correctamente o no.
- La propiedad "Comprobantes" contiene a las siguientes propiedades:
	+ "numeroComprobante": Indica el tipo y nro. de comprobante leído del json.
	+ "estado": Indica "Ok" si el comprobante se registro correctamente o "Error" en caso contrario.
	+ "exceptionMessage": Muestra algún mensaje de excepción al registrar el comprobante.
	+ "mensaje": Vacío en caso de que el comprobante se registre correctamente y en el caso de que haya ocurrido un error se mostrará la descripción del mismo.
- La propiedad "Succeeded" indica _true_ si el comprobante fue registrado correctamente o _false_ en caso contrario.

<a name="djson"></a>

### Datos del JSON

A continuación, se detalla a modo orientativo, el contenido de cada uno de los datos del JSON.

**Tópico principal - Encabezado**

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|codigoTipoComprobante|Si|Código de tipo de comprobante|Alfanumérico de 3 carácteres|FAC, CDE, CIN, DIN, N/D, CDC, DDC, CDP, NDM, AJD, AJC|
|numeroComprobante|Si|Número de comprobante|Alfanumérico de hasta 14 carácteres|El número es único y no debe repetirse, con lo cual el nro. a registrar no debe estar registrado para otro comprobante.|
|codigoTalonario|Si|Código de talonario|Numérico de tipo entero|>0|
|codigoCliente|Si|Código de cliente|Alfanumérico de hasta 6 caracteres||
|codigoCondicionDeVenta|Si|Código de condición de venta|Numérico de tipo entero|>0|
|numeroDeProyecto|No|Número de proyecto|Numérico de tipo entero de 8 dígitos||
|codigoOperacionRG3685	|No	|Código de régimen de información relativo a las compras y ventas RG3685	|Alfanumérico de 1 carácter	|Ver tablas de referencia, [Operaciones RG3685](#RG3685)|
|codigoClasificacion|No|Código de clasificación de comprobante|Alfanumérico de hasta 6 carácteres||
|fechaComprobante|Si|Fecha del comprobante.|Date|yyyy-mm-dd. La fecha debe ser mayor a la fecha de cierre de tesorería.|
|fechaCierreTesoreria|No|Fecha del cierre de tesorería. Debe ser anterior a la fecha del comprobante.|Date|yyyy-mm-dd|
|codigoListaPrecio|Si|Código de la lista de precio.|Numérico de tipo entero|>0|
|cotizacionVentas|No|Importe cotización venta|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|Si es null, o no es un número, o es menor o igual a cero, se utiliza la cotización de parámetros de venta. Los decimales que se envíen se ajustan a la configuración de decimales para la cotización.|
|leyendaCotizacion|No|Leyenda de cotización de venta|Alfanumérico de hasta 30 carácteres||
|codigoContracuenta|Si|Código de contracuenta|Numérico de tipo entero||
|codigoDeposito|Si|Código de depósito|Alfanumérico de 2 carácteres||
|codigoVendedor|Si|Código de vendedor|Alfanumérico de hasta 10 carácteres||
|idMotivo	|No	|Mótivo de nota de crédito. Sera requerido en el caso que el perfil se encuentre configurado como tal.	|Numérico de tipo entero	|Ver tablas de referencia, [Motivos](#motivosnc) |
|codigoAsiento|No|Código de asiento|Alfanumérico de hasta 4 carácteres||
|codigoFlete|No|Código de transporte|Alfanumérico de hasta 10 carácteres||
|leyenda1|No|Leyendas del comprobante|Alfanumérico de hasta 60 carácteres||
|leyenda2|No|Leyendas del comprobante|Alfanumérico de hasta 60 carácteres||
|leyenda3|No|Leyendas del comprobante|Alfanumérico de hasta 60 carácteres||
|leyenda4|No|Leyendas del comprobante|Alfanumérico de hasta 60 carácteres||
|leyenda5|No|Leyendas del comprobante|Alfanumérico de hasta 60 carácteres||
|esMonedaExtranjera|No|Indica si la operación se realiza bajo moneda extranjera o no.|De tipo lógico|True / false|
|total|Si|Importe total del comprobante|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|totalSinImpuestos|Si|Importe total del comprobante sin impuestos|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|totalExento|No|Importe exento del comprobante|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|totalIva|Si|Importe total de IVA del comprobante|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|subtotal|Si|Importe subtotal del comprobante|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|subtotalSinImpuestos|Si|Importe subtotal del comprobante sin impuestos|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|descuentoPorcentaje|No|Porcentaje de descuento|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|descuentoMonto|No|Importe del descuento|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|descuentoMontoSinIva|No|Importe del descuento sin IVA|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|recargoPorcentaje|No|Porcentaje de recargo|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|recargoMonto|No|Importe de recargo|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|recargoMontoSinIva|No|Importe de recargo sin IVA|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|recargoFletePorcentaje|No|Porcentaje de recargo por flete|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|recargoFleteMonto|No|Monto del recargo por flete|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|recargoFleteMontoSinIva|No|Monto sin IVA del recargo por flete|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|interesesPorcentaje|No|Porcentaje de interes|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|interesesMontoSinIva|No|Monto sin IVA de intereses|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|observaciones|No|Representa las observaciones realizadas por vendedor en el comprobante|Alfanumérico de hasta 280 carácteres||
|rg3668TipoIdentificacionFirmante|No|Tipo doc del firmante|Numérico de tipo entero|>0|
|rg3668CaracterDelFirmante|No|Descripción caracter del firmante|Numérico de tipo entero|>0|
|rg3668CodigoIdentificacionFirmante|No|Código de identificación del firmante|Numérico de tipo entero|>0|
|rg3668MotivoDeExcepcion|No|Código de excepción|Numérico de tipo entero|>0|
|rg3668CodigoWeb|No|Código de F8001 Web|Numérico de tipo float|>0|
|citiOpera|No|Clasificación citi opera|Alfanumérico de 1 caracter||
|citiTipo|No|Clasificación citi tipo|Alfanumérico de 1 caracter||

**Tópico ítems**

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|Codigo|Si|Código del artículo|Alfanumérico de hasta 15 carácteres||
|descargaStock|No|Indica si el item descarga stock o no|De tipo lógico|True/false. Si no se ingresa ningún valor para esta propiedad entonces se toma el valor que ya se encuentre registrado en la base de datos para el artículo en cuestión.|
|descripcion|No|Descripción del artículo|Alfanumérico de hasta 30 carácteres||
|descripcionAdicional|No|Descripción adicional del artículo|Alfanumérico de hasta 20 carácteres||
|codigoTasaIva|No|Código de tasa IVA|Numérico de tipo entero|>0|
|cantidad|Si|Cantidad de venta|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.||
|codigoDeposito|No|Código de deposito|Alfanumérico de 2 carácteres||
|codigoUM|No|Código de unidad de medida|Alfanumérico de hasta 10 carácteres|Si no se ingresa ningún valor para esta propiedad entonces se toma el valor que ya se encuentre registrado en la base de datos para el artículo en cuestión.|
|Precio|No|Precio unitario del artículo|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0. Si no se ingresa ningún valor para esta propiedad entonces se toma el valor que ya se encuentre registrado en la base de datos para el artículo en cuestión.|
|importe|No|Importe total de venta del artículo|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|importeSinImpuestos|No|Importe total de venta del artículo sin impuestos|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|importeIva|No|Importe total de IVA|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|

<a name="tablasref"></a>

### Tablas de referencia

<a name="RG3685"></a>

**Operaciones RG3685**

| Código | Descripción |
|---|---|
| O| Operaciones gravadas|
|A |No alcanzado|
|C|Operaciones de canje/Devol. IVA turistas|
|E| Operaciones exentas|
|N| No gravado|
|X| Exportaciones al exterior|
|Z| Exportaciones a zona franca|
|T| Reintegro decreto 1043/2016|

<a name="motivosnc"></a>

**Motivos NC**
| Código | Descripción |
|---|---|
|1| Devolución de mercadería|
|2| Saldo a favor|
|3| Diferencia de cambio|
|4| Anulación de fact. electrónica|

<a name="responsabilidadiva"></a>

**Responsabilidad ante IVA**
| Código | Descripción |
|---|---|
|0| Responsable Inscripto|
|1| Consumidor Final|
|2| Monotributo|
|3| Inscripto No Responsable|
|4|IVA Exento Operacion De Exportacion|
|5|Exento|
|6|Sujeto No Categorizado|

<a name="codigosincoterms"></a>

**Códigos Incoterms**
| Código | Descripción |
|---|---|
|EXW| Ex Works / en fábrica|
|FCA| Free Carrier / libre transportista|
|FAS| Free Alongside Ship / libre al costado del buque|
|FOB| Free on Board / libre a bordo|
|CFR|Cost and Freight / Coste y flete|
|CIF|Cost, Insurance and Freight / Coste, seguro y flete|
|CPT|Carriage Paid To / Transporte pagado hasta|
|CIP|Carriage and Insurance Paid / Transporte y seguro pagados hasta|
|DAF|Delivered at Frontier - Entregado en frontera, lugar convenido|
|DES|Entregada sobre buque, puerto de destino convenido|
|DEQ|Entregado Ex Muelle (puerto de destino designado)|
|DDU|Delivered Duty Unpaid / Entregada derechos no pagados, lugar de destino convenido|
|DDP|Delivered Duty Paid / Entregado con derechos pagados|
|DAP|Delivered at Place / Entregado en punto de destino|
|DAT|Delivered at Terminal / Entregado en la terminal|

<a name="codigopaises"></a>

**Código Países AFIP**

| Código País AFIP| Descripción |
|---|---|
|101|Burkina Faso|
|102|Argelia|
|103|Botswana|
|104|Burundi|
|105|Camerun|
|107|República Centroafricana|
|108|Congo|
|109|República Democratica del Congo (Ex Zaire)|
|110|Costa de Marfil|
|111|Chad|
|112|Benin|
|113|Egipto|
|115|Gabon|
|116|Gambia|
|117|Ghana|
|118|Guinea|
|119|Guinea Ecuatorial|
|120|Kenya|
|121|Lesotho|
|122|Liberia|
|123|Libia|
|124|Madagascar|
|125|Malawi|
|126|Mali|
|127|Marruecos|
|128|Islas Mauricio|
|129|Mauritania|
|130|Niger|
|131|Nigeria|
|132|Zimbabwe|
|133|Rwanda|
|134|Senegal|
|135|Sierra Leona|
|136|Somalia|
|137|Swazilandia|
|139|Tanzania|
|140|Togo|
|141|Tunez|
|142|Uganda|
|144|Zambia|
|145|Africa (Territorios vinculados al Reino Unido)|
|146|Africa (Territorios vinculados a España)|
|147|Africa (Territorios vinculados a Francia)|
|149|Angola|
|150|Islas Cabo Verde|
|151|Mozambique|
|152|Seychelles|
|153|Djibouti|
|155|Comoras|
|156|Guinea Bissau|
|157|Santo Tomé y Principe|
|158|Namibia|
|159|Sudafrica|
|160|Eritrea|
|161|Etiopía|
|162|Sudan|
|163|Sudan del sur|
|197|Africa (Resto)|
|198|Africa (Indeterminado)|
|200|Argentina|
|201|Barbados|
|202|Bolivia|
|203|Brasil|
|204|Canada|
|205|Colombia|
|206|Costa Rica|
|207|Cuba|
|208|Chile|
|209|República Dominicana|
|210|Ecuador|
|211|El Salvador|
|212|Estados Unidos|
|213|Guatemala|
|214|Guyana|
|215|Haiti|
|216|Honduras|
|217|Jamaica|
|218|Mexico|
|219|Nicaragua|
|220|Panama|
|221|Paraguay|
|222|Peru|
|223|Puerto Rico|
|224|Trinidad y Tobago|
|225|Uruguay|
|226|Venezuela|
|227|America (Territorios vinculados al Reino Unido)|
|228|America (Territorios vinculados a Dinamarca)|
|229|America (Territorios vinculados a Francia)|
|230|Territorios Holandeses|
|231|America (Territorios vinculados a Estados Unidos)|
|232|Suriname|
|233|Dominica|
|234|Santa Lucia|
|235|San Vicente y las Granadinas|
|236|Belice|
|237|Antigua y Barbuda|
|238|San Cristóbal y Nevis|
|239|Bahamas|
|240|Granada|
|241|Antillas Holandesas (Territorios vinculados a Paises Bajos)|
|242|Aruba|
|250|Tierra del Fuego (A.A.E)|
|251|Zona Franca La Plata (Buenos Aires)|
|252|Zona Franca Justo Daract (San Luis)|
|253|Zona Franca Rio Gallegos (Santa Cruz)|
|254|Islas Malvinas|
|255|Zona Franca Tucuman (Tucuman)|
|256|Zona Franca Córdoba (Córdoba)|
|257|Zona Franca Mendoza (Mendoza)|
|258|Zona Franca General Pico (La Pampa)|
|259|Zona Franca Comodoro Rivadavia (Chubut)|
|260|Zona Franca Iquique (Chile)|
|261|Zona Franca Punta Arenas (Chile)|
|262|Zona Franca Salta (Salta)|
|263|Zona Franca Paso de los Libres (Corrientes)|
|264|Zona Franca Puerto Iguazú (Misiones)|
|265|Sector Antártico Argentino|
|270|Zona Franca Colón (Panama)|
|271|Zona Franca Winner - Santa Cruz de la Cierra (Bolivia)|
|280|Zona Franca Colonia (Uruguay)|
|281|Zona Franca Florida (Uruguay)|
|282|Zona Franca Libertad (Uruguay)|
|283|Zonamerica - Ex Montevideo (Uruguay)|
|284|Zona Franca Nueva Helvecia (Uruguay)|
|285|Zona Franca Nueva Palmira (Uruguay)|
|286|Zona Franca Rio Negro (Uruguay)|
|287|Zona Franca Rivera (Uruguay)|
|288|Zona Franca San José (Uruguay)|
|291|Zona Franca Manaos (Brasil)|
|295|Mar Argentino - Zona Económica Exclusiva (Argentina)|
|296|Rios Argentinos - Naveg. Inter. (Argentina)|
|297|Resto América|
|298|Indeterminado (América)|
|301|Afganistan|
|302|Arabia Saudita|
|303|Bahrein|
|304|Myanmar (Ex Birmania)|
|305|Butan|
|306|Cambodya (Ex Kampuche)|
|307|Sri Lanka|
|308|Corea Democrática|
|309|Corea Republicana|
|310|China|
|312|Filipinas|
|313|Taiwan|
|315|India|
|316|Indonesia|
|317|Irak|
|318|Iran|
|319|Israel|
|320|Japón|
|321|Jordania|
|322|Qatar|
|323|Kuwait|
|324|Laos|
|325|Libano|
|326|Malasia|
|327|Islas Maldivas|
|328|Oman|
|329|Mongolia|
|330|Nepal|
|331|Emiratos Árabes Unidos|
|332|Pakistan|
|333|Singapur|
|334|Siria|
|335|Thailandia|
|337|Vietnam|
|341|Hong Kong (Reg. Adm. Esp. de China)|
|344|Macao (Reg. Adm. Espec. Macao)|
|345|Bangladesh|
|346|Brunei|
|348|República de Yemen|
|349|Armenia|
|350|Azerbaijan|
|351|Georgia|
|352|Kazajstan|
|353|Kirguizistan|
|354|Tayikistan|
|355|Turkmenistan|
|356|Uzbekistan|
|357|Gaza y Jericó (Terr. Au. Palestinos)|
|397|Resto de Asia|
|398|Indet. (Asia)|
|401|Albania|
|404|Andorra|
|405|Austria|
|406|Belgica|
|407|Bulgaria|
|409|Dinamarca|
|410|España|
|411|Finlandia|
|412|Francia|
|413|Grecia|
|414|Hungria|
|415|Irlanda|
|416|Islandia|
|417|Italia|
|418|Liechtenstein|
|419|Luxemburgo|
|420|Malta|
|421|Monaco|
|422|Noruega|
|423|Paises Bajos|
|424|Polonia|
|425|Portugal|
|426|Reino Unido|
|427|Rumania|
|428|San Marino|
|429|Suecia|
|430|Suiza|
|431|Vaticano (Santa Sede)|
|433|Europa (Pos. Brit.)|
|435|Chipre|
|436|Turquia|
|438|Alemania Rep. Fed.|
|439|Bielorrusia|
|440|Estonia|
|441|Letonia|
|442|Lituania|
|443|Moldavia|
|444|Rusia|
|445|Ucrania|
|446|Bosnia Herzegovina|
|447|Croacia|
|448|Eslovaquia|
|449|Eslovenia|
|450|Macedonia|
|451|Rep. Checa|
|453|Montenegro|
|454|Serbia|
|497|Resto Europa|
|498|Indet. (Europa)|
|501|Australia|
|503|Nauru|
|504|Nueva Zelandia|
|505|Vanatu|
|506|Samoa Occidental|
|507|Oceania (Territorios vinculados a Australia)|
|508|Oceania (Territorios vinculados al Reino Unido)|
|509|Oceania (Territorios vinculados a Francia)|
|510|Oceania (Territorios vinculados a Nueva Zelanda)|
|511|Oceania (Territorios vinculados a Estados Unidos)|
|512|Islas Fiji|
|513|Papua Nueva Guinea|
|514|Islas Kiribati|
|515|Est. Feder. Micronesia|
|516|Palau|
|517|Tuvalu|
|518|Islas salomón|
|519|Tonga|
|520|Islas Marshall|
|521|Islas Marianas|
|597|Resto Oceania|
|598|Indet. (Oceania)|
|671|Islas Caimán (Territorio no Autonomo del Reino Unido)|
|997|Resto continente|
|998|Indet. (Continente)|
|244|Curazao|
|245|San Martin (parte holandesa)|
|268|Zona Franca Villa Constitución - Argentina|
|652|Anguila (territorio no autonomo del R. Unido)|
|653|Aruba (territorio de Paises Bajos)|
|654|Isla de Cook (territorio autonomo asociado a Nueva Zelanda)|
|655|Patau|
|656|Polinesia Francesa (territorio de ultramar de Francia)|
|659|Antillas Holandesas (territorio de Paises Bajos)|
|662|Ascencion|
|663|Bermudas (territorio no autonomo del R. Unido)|
|664|Campione Ditalia|
|665|Colonia de Gibraltar|
|666|Groenlandia|
|667|Guam (territorio no autonomo de los Estados Unidos)|
|668|Hong Kong (territorio de China)|
|669|Islas Azores|
|670|Islas del Canal (Guernesey, Jersey, Alderney, A.Stark, L.Sark, etc)|
|672|isla christmas|
|673|Isla de Cocos o Keeling|
|676|Isla de Man (Territorio del Reino Unido)|
|677|Isla de Norfolk (territorio del Reino Unido)|
|678|Islas Turcas y Caicos (territorio no autonomo del Reino Unido)|
|679|Islas Pacifico|
|680|Islas de San Pedro y Miguelon|
|681|Isla Qeshm|
|682|Islas Virgenes Britanicas (territorio no autonomo del Reino Unido)|
|683|Islas Virgenes de Estados Unidos de America|
|684|Labuam|
|685|Madeira (territorio de Portugal)|
|686|Monserrat (territorio no Autonomo del Reino Unido)|
|687|Niue|
|690|Pitcairn|
|693|Regimen Aplicable a las SA Financieras (ley 11073 de la rou)|
|694|Santa Elena|
|695|Samoa Americana|
|696|Archipielago de Svbalbard|
|697|Tristan da Cunha|
|698|Trieste (Italia)|
|699|tokelau|
|700|Zona Libre de Ostrava (Ciudad de la Antigua Checoslovaquia)|

<a name="ejemplosjson"></a>

### Ejemplos de JSON de un comprobante

<a name="ej1"></a>

**01 - Factura - Efectivo**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, mientras que a continuación se explican los campos de la sección "Pagos" correspondientes para la modalidad efectivo.

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|Tipo|Si|Modalidad de pago|Alfanúmerico||
|codigoDeCuenta|Si|Código de cuenta|Numérico de tipo entero||
|descuentoPorcentaje|No|Porcentaje de descuento|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|recargoPorcentaje|No|Porcentaje de recargo|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|monto|Si|Monto pagado|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000140",
		"codigoTalonario": "1",
		"codigoCliente": "010001",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2024-02-06",
		"fechaCierreTesoreria": "2024-02-01",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"idMotivo": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "Leyenda 1",
		"leyenda2": "Leyenda 2",
		"leyenda3": "Leyenda 3",
		"leyenda4": "Leyenda 4",
		"leyenda5": "Leyenda 5",
		"esMonedaExtranjera": false,
		"total": 242.00,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"descuentoPorcentaje": 0,
		"descuentoMonto": 0,
		"descuentoMontoSinIva": 0,
		"recargoPorcentaje": 0,
		"recargoMonto": 0,
		"recargoMontoSinIva": 0,
		"recargoFletePorcentaje": 0,
		"recargoFleteMonto": 0,
		"recargoFleteMontoSinIva": 0,
		"interesesPorcentaje": 0.00,
		"interesesMontoSinIva": 0.00,
		"observaciones": "",
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": "Titular",
		"rg3668CodigoIdentificacionFirmante": "DNI",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"citiOpera":"O",
		"citiTipo":"B",
		"items": [
			{
				"codigo": "0200200033",
				"descargaStock" : true,
				"descripcion": "POLEA 30cm DE LAS OTRAS",
				"codigoTasaIva": "1",
				"cantidad": 2,
				"codigoDeposito": "2",
				"codigoUM": "UNI",
				"precio": 121.00,
				"importe": 242.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 242.00
			}
		]
	}
]
```

<a name="ej2"></a>

**02 - Factura - Cuenta corriente**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, en este caso no hay una sección de "Pagos" pero si existe una sección de cuotasCuentaCorriente que se describe a continuación.

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Cuotas cuenta corriente**|||||
|Fecha de vencimiento|Si|Fecha de vencimiento de la cuota|Date|yyyy-mm-dd|
|Importe|Si|Importe de cuota|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.||

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000103",
		"codigoTalonario": "1",
		"codigoCliente": "020031",
		"codigoCondicionDeVenta": 2,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-06-10",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"idMotivo": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "Leyenda 1",
		"leyenda2": "Leyenda 2",
		"leyenda3": "Leyenda 3",
		"leyenda4": "Leyenda 4",
		"leyenda5": "Leyenda 5",
		"esMonedaExtranjera": false,
		"total" : 266.20,
		"totalSinImpuestos": 220.00,
		"totalExento": 0.00,
		"totalIva": 46.20,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"descuentoPorcentaje": 0,
		"descuentoMonto": 0,
		"descuentoMontoSinIva": 0,
		"recargoPorcentaje": 0,
		"recargoMonto": 0,
		"recargoMontoSinIva": 0,
		"recargoFletePorcentaje": 0,
		"recargoFleteMonto": 0,
		"recargoFleteMontoSinIva": 0,
		"interesesPorcentaje": 10.00,
		"interesesMontoSinIva": 20.00,
		"observaciones": "",
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "0200200033",
				"descripcion": "POLEA 30cm DE LAS OTRAS",
				"descargaStock" : true,
				"codigoTasaIva": "1",
				"cantidad": 2,
				"codigoDeposito": "2",
				"codigoUM": "UNI",
				"precio": 121.00,
				"importe": 242.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00
			}
		],
		"cuotasCuentaCorriente" :
		[
			{
				"fechaVencimiento": "2019-07-10",
				"importe" : 66.55
			},
			{
				"fechaVencimiento": "2019-08-10",
				"importe" : 199.65
			}
		]
	}
]
```

<a name="ej3"></a>

**03 - Factura - Cheque**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, mientras que a continuación se explican los campos de la sección "Pagos" correspondientes para la modalidad cheque.

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**pagos**|||||
|Tipo|Si|Modalidad de pago|Alfanúmerico||
|codigoDeCuenta|Si|Código de cuenta|Numérico de tipo entero||
|numeroDeCheque|Si|Número de cheque|Numérico de tipo entero|>0|
|Leyenda|No|Leyenda del cheque|Alfanumérico de hasta 40 carácteres||
|codigoPostal|No|Código postal|Alfanumérico de hasta 8 carácteres||
|Clearing|No|Número de clearing|Numérico de tipo entero|>0|
|fechaEmision|Si|Fecha de emisión del cheque|Date|yyyy-mm-dd|
|fechaRegistracion|Si|Fecha de registración.|Date|yyyy-mm-dd|
|fechaCheque|Si|Fecha del cheque.|Date|yyyy-mm-dd|
|Registrado|No|Indica si el cheque fue registrado o no.|De tipo lógico|True / false|
|esDiferido|No|Indica si el cheque es diferido o no|De tipo lógico|True / false|
|codigoBanco|No|Código del banco|Alfanumérico de hasta 10 carácteres||
|razonSocial|No|Razon social del emisor|Alfanumérico de hasta 60 carácteres||
|descuentoPorcentaje|No|Porcentaje de descuento|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|recargoPorcentaje|No|Porcentaje de recargo|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|Monto|Si|Monto pagado|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100001104",
		"codigoTalonario": "1",
		"codigoCliente": "020025",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-07-10",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"idMotivo": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"esMonedaExtranjera": false,
		"total" : 242,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"descuentoPorcentaje": 0,
		"descuentoMonto": 0,
		"descuentoMontoSinIva": 0,
		"recargoPorcentaje": 0,
		"recargoMonto": 0,
		"recargoMontoSinIva": 0,
		"recargoFletePorcentaje": 0,
		"recargoFleteMonto": 0,
		"recargoFleteMontoSinIva": 0,
		"interesesPorcentaje": 0.00,
		"interesesMontoSinIva": 0.00,
		"observaciones": "",
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "030006526",
				"descargaStock" : true,
				"codigoTasaIva": "1",
				"cantidad": 2,
				"codigoDeposito": "2",
				"codigoUM": "UNI",
				"precio": 121.00,
				"importe": 242.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00
			}
		],
		"pagos": [
			{
				"tipo" : "Cheque",
				"codigoDeCuenta": "3",
				"numeroDeCheque": 1111,
				"leyenda" : "COBRO VENTA CON CHEQUE XXXX",
				"codigoPostal" : "4444",
				"clearing": 2222,
				"fechaEmision" : "20190710",
				"fechaRegistracion" : "20190711",
				"fechaCheque" : "20190712",
				"registrado" : true,
				"esDiferido" : true,
				"codigoBanco" : "005",
				"razonSocial" : "AUDIO CITY S.R.L.",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 242.00
			}
		]
	}
]
```

<a name="ej4"></a>

**04 - Factura - Tarjeta**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, mientras que a continuación se explican los campos de la sección "Pagos" correspondientes para la modalidad tarjeta.

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|pagos|||||
|tipo|Si|Modalidad de pago|Alfanúmerico||
|codigoDeCuenta|Si|Código de cuenta|Numérico de tipo entero|>0|
|codigoDePlan|Si|Código del plan vinculado a la tarjeta|Numérico de tipo entero|>0|
|codigoDePromocion|No|Código de promoción|Numérico de tipo entero|>0|
|codigoDeTarjeta|Si|Código de la tarjeta|Alfanúmerico de hasta 3 carácteres||
|fecha|No|Fecha del cupón|Date|yyyy-mm-dd|
|descuentoPorcentaje|No|Porcentaje de descuento|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|recargoPorcentaje|No|Porcentaje de recargo|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|coeficientePorcentaje|No|Coeficiente de porcentaje|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|numeroDeCuotas|Si|Cantidad de cuotas|Numérico de tipo entero|>0|
|referencia|No|Referencia de la operación|Alfanumérico de hasta 30 carácteres||
|idTerminalPos|Si|Id de la terminal POS|Numérico de tipo entero|>0|
|numeroCupon|Si|Número de cupon|Numérico de tipo entero|>0|
|tipoCupon|Si|Tipo de cupon|Alfanumérico||
|numeroLote|Si|Número de lote|Numérico de tipo entero|>0|
|tipoDocumento|No|Tipo de documento titular de la tarjeta|Alfanumérico de hasta 3 carácteres||
|documento|No|Número de documento del titular de la tarjeta|Alfanumérico de hasta 9 carácteres||
|numeroDeAutorizacion|Si|Número de autorización de la operación|Numérico de tipo entero|>=0|
|fechaDeVencimiento|Si|Fecha de vencimiento de la tarjeta|Date|Yyyy-mm-dd. La fecha debe ser mayor o igual a la actual.|
|socio|No|Socio|Alfanumérico de hasta 20 carácteres|>0|
|telefono|No|Teléfono del socio|Alfanumérico de hasta 20 carácteres||
|codigoDeOperacion|No|Código de operación|Numérico de tipo entero||
|leyendaOperacion|No|Leyenda de la operación|Alfanumérico de hasta 60 carácteres||
|monto|Si|Monto de la operación|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000105",
		"codigoTalonario": "1",
		"codigoCliente": "020025",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-07-10",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"esMonedaExtranjera": false,
		"total" : 242,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"descuentoPorcentaje": 0,
		"descuentoMonto": 0,
		"descuentoMontoSinIva": 0,
		"recargoPorcentaje": 0,
		"recargoMonto": 0,
		"recargoMontoSinIva": 0,
		"recargoFletePorcentaje": 0,
		"recargoFleteMonto": 0,
		"recargoFleteMontoSinIva": 0,
		"interesesPorcentaje": 0.00,
		"interesesMontoSinIva": 0.00,
		"observaciones": "",
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "030006526",
				"descargaStock" : true,
				"codigoTasaIva": "1",
				"cantidad": 2,
				"codigoDeposito": "2",
				"codigoUM": "UNI",
				"precio": 121.00,
				"importe": 242.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00
			}
		],
		"pagos": [
			{
				"tipo" : "Tarjeta",
				"codigoDeCuenta": "7",
				"codigoDePlan": "1",
				"codigoDePromocion": "",
				"codigoDeTarjeta": "DI",
				"fecha": "2022-11-01",
				"descuentoPorcentaje": 0,
				"recargoPorcentaje": 0,
				"coeficientePorcentaje": 0,
				"numeroDeCuotas": 1,
				"referencia":"4444",
				"idTerminalPos": "2",
				"numeroCupon" : 47,
				"tipoCupon" : "A",
				"numeroLote" : 175,
				"tipoDocumento" : "DNI",
				"documento": "33333333",
				"numeroDeAutorizacion" : 2222,
				"fechaDeVencimiento" : "2024-12-20",
				"socio" : "1111",
				"telefono" : "5555",
				"codigoDeOperacion": 3,
				"leyendaOperacion": "Importe a cancelar",
				"monto": 242.00
			}
		]
	}
]
```

<a name="ej5"></a>

**05 - Factura - Comprobante Electronico**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia es que en el encabezado se agrega el campo cAE que se explica a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

El campo "fechaVtoCAE" se agregó a partir de la versión **T21 hotfix 4996** y en **T23** a partir del **hotfix 2975**.


| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Encabezado**|||||
|cAE|Si|Código de Autorización Electrónico otorgado por AFIP|Alfanumérico de 14 carácteres||
|fechaVtoCAE|No|Fecha de vencimiento del CAE|Date|Yyyy-mm-dd|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A1752800000106",
		"codigoTalonario": "20",
		"cAE" : "69214744756356",
		"fechaVtoCAE": "2024-03-06",
		"codigoCliente": "020031",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2024-01-28",
		"fechaCierreTesoreria": "2024-01-01",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"total": 121.00,
		"totalSinImpuestos": 100.00,
		"totalExento": 0.00,
		"totalIva": 21.00,
		"subtotal": 121.00,
		"subtotalSinImpuestos": 100.00,
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "0200200033",
				"codigoDeposito": "1",
				"codigoTasaIva": "1",
				"cantidad": 1,
				"precio": 121,
				"importe": 121,
				"importeSinImpuestos": 100,
				"importeIva": 21
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"monto": 121.00
			}
		]
	}
]
```

<a name="ej6"></a>

**06 - Nota de débito-crédito - Con comprobante de referencia**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia es que en el encabezado se agregan tres campos vinculados al comprobante de referencia que se explican a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Encabezado**|||||
|codigoTipoComprobanteDeReferencia|Si|Código de tipo de comprobante de referencia|Alfanumérico de 3 carácteres|FAC, CDE, CIN, DIN, N/D, CDC, DDC, CDP, NDM, AJD, AJC|
|numeroDeComprobanteDeReferencia|Si|Número de comprobante de referencia|Alfanumérico de 14 carácteres||
|comprobanteCanceladoCompletamente|Si|Indica si el comprobante de referencia es cancelado completamente o no|De tipo lógico|True / false|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "CDE",
		"numeroComprobante": "A0000100000107",
		"codigoTalonario": "1",
		"codigoCliente": "020025",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-07-11",
		"fechaCierreTesoreria": "2021-07-10",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "11",
		"codigoMotivo" : "03",
		"codigoTipoComprobanteDeReferencia": "FAC",
		"numeroDeComprobanteDeReferencia": "A0000100000001",
		"comprobanteCanceladoCompletamente" : true,
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"total" : 242,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 242.00
			}
		],
		"cuotasCuentaCorriente" :
		[
			{
				"fechaVencimiento": "2021-07-11",
				"importe" : 242.00
			}
		]
	}
]
```

<a name="ej7"></a>

**07 - Nota de débito-crédito - Sin comprobante de referencia**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia es que en el encabezado se encuentran los dos campos vinculados al comprobante de referencia que se explican a continuación y que para este caso el nro. de comprobante puede ser vacío y el campo comprobanteCanceladoCompletamente debe tener el valor "false" . Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Encabezado**|||||
|numeroDeComprobanteDeReferencia|No|Número de comprobante de referencia|Alfanumérico de 14 carácteres||
|comprobanteCanceladoCompletamente|No|Indica si el comprobante de referencia es cancelado completamente o no|De tipo lógico|True / false|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "CDE",
		"numeroComprobante": "A0000100000108",
		"codigoTalonario": "1",
		"codigoCliente": "020025",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-08-12",
		"fechaCierreTesoreria": "2021-07-12",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "11",
		"idMotivo" : "03",
		"numeroDeComprobanteDeReferencia": "",
		"comprobanteCanceladoCompletamente" : false,
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"total": 242.00,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "0200200033",
				"codigoDeposito": "2",
				"codigoTasaIva": "1",
				"cantidad": 2.00,
				"precio": 121.00,
				"bonificacion" : 0.00,
				"importe": 242.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 242.00
			}
		]
	}
]
```

<a name="ej8"></a>

**08 - Factura - Con cliente ocasional**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, pero existen las siguientes diferencias: en el encabezado se agrega un campo "mailDestinatario" y existe una nueva sección llamada "clienteOcasional", ambas diferencias se describen a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Encabezado**|||||
|mailDestinatario|No|Correo electrónico del destinatario|Alfanumérico de hasta 60 carácteres||
|**clienteOcasional**|||||
|razonSocial|Si|Razón social del cliente ocasional|Alfanumérico de hasta 60 carácteres||
|tipoDocumento|No|Tipo documento|Numérico de tipo entero|>0|
|documento|Si|Documento del cliente ocasional|Alfanumérico de hasta 20 carácteres||
|responsabilidad|No|Responsabilidad ante IVA del cliente ocasional|Numérico de tipo entero|Ver tablas de referencia, [Responsabilidad ante IVA](#responsabilidadiva)|
|discriminaIva|No|Indica si el cliente discrimina IVA o no|De tipo lógico|True / false|
|liquidaIva|No|Indica si el cliente liquida IVA o no|De tipo lógico|True / false|
|domicilio|No|Domicilio|Alfanumérico de hasta 30 carácteres||
|localidad|No|Localidad|Alfanumérico de hasta 20 carácteres||
|codigoProvincia|No|Código de la provincia|Alfanumérico de 2 carácteres||
|codigoPostal|No|Código postal|Alfanumérico de hasta 8 carácteres||
|telefono|No|Teléfono del cliente|Alfanumérico de hasta 100 carácteres||
|fechaDeNacimiento|No|Fecha de nacimiento del cliente|Date|yyyy-mm-dd|
|sexo|No|Sexo|Alfanumérico de 1 carácter|M/F|
|mail|No|Correo electrónico del cliente|Alfanumérico de hasta 60 carácteres||
|mailDestinatario|No|Correo electrónico del destinatario|Alfanumérico de hasta 60 carácteres||
|domicilioEntrega|No|Domicilio de entrega|Alfanumérico de hasta 200 carácteres||
|localidadEntrega|No|Localidad del domicilio de entrega|Alfanumérico de hasta 100 carácteres||
|codigoProvinciaEntrega|No|Código de provincia del domicilio de entrega|Alfanumérico de 2 carácteres||
|codigoPostalEntrega|No|Código postal del domicilio de entrega|Alfanumérico de hasta 10 carácteres||
|paisEntrega|No|País del domicilio de entrega|Alfanumérico de hasta 100 carácteres||
|telefonoEntrega|No|Teléfono del domicilio de entrega|Alfanumérico de hasta 100 carácteres||

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000109",
		"codigoTalonario": "1",
		"codigoCliente": "000000",
		"mailDestinatario" : "xyz@789.com",
		"clienteOcasional" :
		{
			"razonSocial" : "SISTEMAS ELECTRONICOS DE REGISTRACION S A",
			"tipoDocumento" : 80,
			"documento" : "30-59198525-2",
			"responsabilidad" : 0,
			"discriminaIva" : true,
			"liquidaIva" : true,
			"domicilio" : "LOYOLA 554 Piso:2",
			"localidad" : "Villa Crespo",
			"codigoProvincia" : "01",
			"codigoPostal" : "1416",
			"telefono": "",
			"fechaDeNacimiento" : "1996-01-01",
			"sexo" : "F",
			"mail" : "abc@123.com",
			"mailDestinatario" : "def@456.com",
			"domicilioEntrega" : "Gorriti 69",
			"localidadEntrega" : "Palermo",
			"codigoProvinciaEntrega" : "01",
			"codigoPostalEntrega" : "1416",
			"paisEntrega" : "Argentina",
			"telefonoEntrega" : "48018668"
		},
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-07-19",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"total": 121.00,
		"totalSinImpuestos": 100.00,
		"totalExento": 0.00,
		"totalIva": 21.00,
		"subtotal": 121.00,
		"subtotalSinImpuestos": 100.00,
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "0200200033",
				"codigoDeposito": "1",
				"codigoTasaIva": "1",
				"cantidad": 1,
				"precio": 121,
				"importe": 121,
				"importeSinImpuestos": 100,
				"importeIva": 21
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 121.00
			}
		],
	}
]
```

<a name="ej9"></a>

**09 - Factura - Con descuentos y recargos**

Los datos de encabezado e ítems son los explicados en los Tópicos Principal e Ítems, mientras que la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100001110",
		"codigoTalonario": "1",
		"codigoCliente": "020025",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-08-12",
		"fechaCierreTesoreria": "2021-07-12",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"total": 121.00,
		"totalSinImpuestos": 100.00,
		"totalExento": 0.00,
		"totalIva": 21.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"descuentoPorcentaje" : 75.00,
		"descuentoMonto": 181.50,
		"descuentoMontoSinIva": 150.00,
		"recargoPorcentaje" : 15.00,
		"recargoMonto" : 36.30,
		"recargoMontoSinIva" : 30.00,
		"recargoFletePorcentaje" : 10.00,
		"recargoFleteMonto" : 24.20,
		"recargoFleteMontoSinIva" : 20.00,
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "0200200033",
				"codigoDeposito": "2",
				"codigoTasaIva": "1",
				"cantidad": 2,
				"precio": 121.00,
				"importe": 242.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 121.00
			}
		]
	}
]
```

<a name="ej10"></a>

**10 - Factura - Items con descuento**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia es que en la sección Ítems se agrega un campo de bonificación que se explica a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Ítems**|||||
|bonificacion|No|Porcentaje de bonificación|Numérico de tipo entero|>=0|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000111",
		"codigoTalonario": "1",
		"codigoCliente": "010001",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-06-10",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"idMotivo": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "Leyenda 1",
		"leyenda3": "Leyenda 2",
		"leyenda2": "Leyenda 3",
		"leyenda4": "Leyenda 4",
		"leyenda5": "Leyenda 5",
		"esMonedaExtranjera": false,
		"total": 242.00,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"descuentoPorcentaje": 0,
		"descuentoMonto": 0,
		"descuentoMontoSinIva": 0,
		"recargoPorcentaje": 0,
		"recargoMonto": 0,
		"recargoMontoSinIva": 0,
		"recargoFletePorcentaje": 0,
		"recargoFleteMonto": 0,
		"recargoFleteMontoSinIva": 0,
		"interesesPorcentaje": 0.00,
		"interesesMontoSinIva": 0.00,
		"observaciones": "",
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "0200200033",
				"descripcion": "POLEA 30cm DE LAS OTRAS",
				"codigoTasaIva": "1",
				"cantidad": 2,
				"codigoDeposito": "2",
				"codigoUM": "UNI",
				"precio": 121.00,
				"importe": 242.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00,
				"bonificacion": 10
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 242.00
			}
		]
	}
]
```

<a name="ej11"></a>

**11 - Factura - Items con impuestos internos**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia es que se agregan dos secciones correspondientes a los impuestos internos: impuestoInterno e impuestoInternoAdicional que se describen a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Sección impuestoInterno**|||||
|Codigo|Si|Código del impuesto|Numérico de tipo entero|>0|
|Porcentaje|No|Porcentaje de alícuota|Numérico de 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|Importe|Si|Importe del impuesto|Numérico de 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|**Sección impuestoInternoAdicional**|||||
|Codigo|Si|Código del impuesto|Numérico de tipo entero|>0|
|Porcentaje|No|Porcentaje de alícuota|Numérico de 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|importe|Si|Importe del impuesto|Numérico de 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000112",
		"codigoTalonario": "1",
		"codigoCliente": "020031",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-07-10",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"idMotivo": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "Leyenda 1",
		"leyenda2": "Leyenda 2",
		"leyenda3": "Leyenda 3",
		"leyenda4": "Leyenda 4",
		"leyenda5": "Leyenda 5",
		"esMonedaExtranjera": false,
		"total" : 272.00,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 272.00,
		"subtotalSinImpuestos": 200.00,
		"descuentoPorcentaje": 0,
		"descuentoMonto": 0,
		"descuentoMontoSinIva": 0,
		"recargoPorcentaje": 0,
		"recargoMonto": 0,
		"recargoMontoSinIva": 0,
		"recargoFletePorcentaje": 0,
		"recargoFleteMonto": 0,
		"recargoFleteMontoSinIva": 0,
		"interesesPorcentaje": 0.00,
		"interesesMontoSinIva": 0.00,
		"observaciones": "",
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "0200103855",
				"descargaStock" : true,
				"codigoTasaIva": "1",
				"cantidad": 2,
				"codigoDeposito": "2",
				"codigoUM": "UNI",
				"precio": 136.00,
				"importe": 272.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00,
				"impuestoInterno":
				{
					"codigo": 22,
					"porcentaje": 10,
					"importe": 20
				},
				"impuestoInternoAdicional":
				{
					"codigo": 82,
					"porcentaje": 0,
					"importe": 10
				}
			}
		],
		"pagos": 
		[
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 272.00
			}
		],
	}
]
```

<a name="ej12"></a>

**12 - Factura - Items con kit fijo o variable**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia es que en la sección Ítems se agregan tres secciones correspondientes a los "componentes" del kit y a las "partidas" y "series" de los artículos que corresponda. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

Aclaración: en este ejemplo la sección "componentes" si es obligatoria pero las secciones "partidas" y "series" solo deben estar presentes si alguno de los componentes del kit esta configurado para trabajar con partidas y series. En este caso, por ejemplo el artículo componente de código "030006527" no se encuentra en la sección de partidas y series.

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Sección componentes**|||||
|Codigo|Si|Código del artículo|Alfanumérico de hasta 15 carácteres||
|codigoTasaIva|No|Código de tasa IVA|Numérico de tipo entero|>0|
|cantidad|Si|Cantidad de venta|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.||
|precio|No|Precio unitario del artículo|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0. Si no se ingresa ningún valor para esta propiedad entonces se toma el valor que ya se encuentre registrado en la base de datos para el artículo en cuestión.|
|importe|No|Importe total de venta del artículo|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|importeSinImpuestos|No|Importe total de venta del artículo sin impuestos|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|importeIva|No|Importe total de IVA|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|**Sub-sección partidas**|||||
|Numero|Si|Número de partida|Alfanumérico de hasta 25 carácteres|>0|
|codigoArticulo|Si|Código del artículo|Alfanumérico de hasta 15 carácteres||
|cantidad|Si|Cantidad de venta|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.||
|**Sub-sección series**|||||
|numero|Si|Numero de serie del artículo|Alfanumérico de hasta 30 carácteres||

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000113",
		"codigoTalonario": "1",
		"codigoCliente": "020025",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-07-19",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"total": 242,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242,
		"subtotalSinImpuestos": 200.00,
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "040010001",
				"codigoDeposito": "2",
				"codigoTasaIva": "1",
				"cantidad": 1,
				"precio": 242,
				"importe": 242,
				"importeSinImpuestos": 200,
				"importeIva": 42,
				"componentes":
				[
					{
						"codigo": "0100100265",
						"codigoTasaIva": "1",
						"cantidad": 1,
						"precio": 121,
						"importe": 121,
						"importeSinImpuestos": 100,
						"importeIva": 21
					},
					{
						"codigo": "030006527",
						"codigoTasaIva": "1",
						"cantidad": 1,
						"precio": 121,
						"importe": 121,
						"importeSinImpuestos": 100,
						"importeIva": 21
					}
				],
				"partidas": [
					{
						"numero": "105",
						"codigoArticulo" : "0100100265",
						"cantidad": 1,
						"series": [
							{ "numero" : "DK120NE209" }
						]
					}
				]
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"monto": 242.00
			}
		],
	}
]
```

<a name="ej13"></a>

**13 - Factura - Items con percepciones**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia con respecto a los mismos es que se agrega una sección "Percepciones" que se explica a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Sub-sección percepciones**|||||
|codigoAlicuota|Si|Código del impuesto|Numérico de tipo entero|>0|
|codigoPercepcion|No|Código de la percepción|Alfanumérico de hasta 2 carácteres||
|porcentaje|No|Porcentaje de alícuota|Numérico de 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|base|No|Base imponible|Numérico de 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|
|importe|Si|Importe del impuesto|Numérico de 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000114",
		"codigoTalonario": "1",
		"codigoCliente": "020025",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-07-10",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"idMotivo": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "ley1",
		"leyenda2": "ley2",
		"leyenda3": "ley3",
		"leyenda4": "ley4",
		"leyenda5": "ley5",
		"esMonedaExtranjera": false,
		"total" : 126.79,
		"totalSinImpuestos": 100.00,
		"totalExento": 0.00,
		"totalIva": 21.00,
		"subtotal": 121.00,
		"subtotalSinImpuestos": 100.00,
		"descuentoPorcentaje": 0,
		"descuentoMonto": 0,
		"descuentoMontoSinIva": 0,
		"recargoPorcentaje": 0,
		"recargoMonto": 0,
		"recargoMontoSinIva": 0,
		"recargoFletePorcentaje": 0,
		"recargoFleteMonto": 0,
		"recargoFleteMontoSinIva": 0,
		"interesesPorcentaje": 0.00,
		"interesesMontoSinIva": 0.00,
		"observaciones": "",
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "030006526",
				"descargaStock" : true,
				"codigoTasaIva": "1",
				"cantidad": 2,
				"codigoDeposito": "2",
				"codigoUM": "UNI",
				"precio": 121.00,
				"importe": 121.00,
				"importeSinImpuestos": 100.00,
				"importeIva": 21.00,
				"percepciones":
				[
					{
						"codigoAlicuota": 51,
						"codigoPercepcion": "",
						"porcentaje": 1.5,
						"base": 100.00,
						"importe": 1.50
					},
					{
						"codigoAlicuota": 1,
						"codigoPercepcion": "AR",
						"porcentaje": 3.50,
						"base": 122.50,
						"importe": 4.29
					}
				]
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 126.79
			}
		]
	}
]
```

<a name="ej14"></a>

**14 - Factura - Items con series y partidas**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia es que en la sección Ítems se agregan dos secciones correspondientes a las "partidas" y "series" de los artículos que corresponda. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|**Sección items**|||||
|**Sub-sección partidas**|||||
|numero|Si|Número de partida|Alfanumérico de hasta 25 carácteres|>0|
|cantidad|Si|Cantidad de venta|Numérico con 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.||
|**Sub-sección series**|||||
|numero|Si|Número de serie del artículo|Alfanumérico de hasta 30 carácteres||

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000380",
		"codigoTalonario": "1",
		"codigoCliente": "020031",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-07-19",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"total": 242.00,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "0100200703",
				"codigoDeposito": "1",
				"codigoTasaIva": "1",
				"cantidad": 2,
				"precio": 121,
				"importe": 242,
				"importeSinImpuestos": 200,
				"importeIva": 42,
				"partidas": [
					{
						"numero": "109",
						"cantidad": 1
					},
					{
						"numero": "115",
						"cantidad": 1,
						"series": [
							{ "numero" : "JV17CD0204" },
							{ "numero" : "JV17CD0205" }
						]
					}
				]
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"monto": 242.00
			}
		]
	}
]
```

<a name="ej15"></a>

**15 - Factura - Moneda extranjera**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia con respecto a los mismos es que en el encabezado se agregan dos campos vinculados a la moneda extranjera que se describen a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

En este caso el campo "esMonedaExtranjera" debe tener el valor "true".

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|cotizacion|No|Cotización de la moneda extranjera|Numérico de 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|En caso de que no se ingrese un valor o sea igual a cero entonces se utilizará el valor de parámetros de venta.|
|totalMonedaExtranjera|Si|Total en moneda extranjera|Numérico de 22 dígitos con hasta 7 decimales. Usando el punto como separador de decimales.|>=0|

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100001116",
		"codigoTalonario": "1",
		"codigoCliente": "020025",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-08-12",
		"fechaCierreTesoreria": "2021-07-12",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"esMonedaExtranjera" : true,
		"cotizacion" : 62.56,
		"total": 242,
		"totalMonedaExtranjera": 3.87,
		"totalSinImpuestos": 3.20,
		"totalExento": 0,
		"totalIva": 0.67,
		"subtotal": 242,
		"subtotalSinImpuestos": 200,
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "0200200033",
				"codigoDeposito": "2",
				"codigoTasaIva": "1",
				"cantidad": 2,
				"precio": 121,
				"bonificacion" : 0.00,
				"importe": 3.86,
				"importeSinImpuestos": 3.19,
				"importeIva": 0.67
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"monto": 3.87
			}
		]
	}
]
```

<a name="ej16"></a>

**16 - Factura - Sin Tesorería**

Los datos de encabezado e ítems ya se encuentran explicados en los Tópicos Principal e Ítems. Lo que se destaca de este caso es que no existe una sección de pagos.
Cabe aclarar que este caso es aplicable siempre y cuando se cuente con una licencia del sistema que no tenga el módulo de tesorería activado.

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000014",
		"codigoTalonario": "1",
		"codigoCliente": "020025",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2021-07-10",
		"fechaCierreTesoreria": "2021-06-07",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "",
		"leyenda2": "",
		"leyenda3": "",
		"leyenda4": "",
		"leyenda5": "",
		"esMonedaExtranjera": false,
		"total" : 242,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"descuentoPorcentaje": 0,
		"descuentoMonto": 0,
		"descuentoMontoSinIva": 0,
		"recargoPorcentaje": 0,
		"recargoMonto": 0,
		"recargoMontoSinIva": 0,
		"recargoFletePorcentaje": 0,
		"recargoFleteMonto": 0,
		"recargoFleteMontoSinIva": 0,
		"interesesPorcentaje": 0.00,
		"interesesMontoSinIva": 0.00,
		"observaciones": "",
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": null,
		"rg3668CodigoIdentificacionFirmante": "",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"items": [
			{
				"codigo": "030006526",
				"descargaStock" : true,
				"codigoTasaIva": "1",
				"cantidad": 2,
				"codigoDeposito": "2",
				"codigoUM": "UNI",
				"precio": 121.00,
				"importe": 242.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00
			}
		]
	}
]
```

<a name="ej17"></a>

**17 - Factura - Exportacion**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la diferencia con respecto a los mismos es que en el encabezado se agregan campos vinculados a la exportación que se describen a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

El campo cAE debe ser utilizado en el caso de que el comprobante sea electrónico.

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|cAE|No|Código de Autorización Electrónico otorgado por AFIP|Alfanumérico de 14 carácteres||
|CuitDestino|Si|Cuit destino de la exportación|Alfanumérico de 1 carácter|J/F|
|TipoExpo|Si|Tipo de exportación|Numérico de tipo entero|1, 2 o 4|
|PaisAfip|Si|Código AFIP del País destino del comprobante|Numérico de tipo entero|Ver tablas de referencia, [Código Países AFIP](#codigopaises)|
|CodigoIncoterms|Si|Código incoterms|Alfanumérico de 3 carácteres|Ver tablas de referencia, [Códigos Incoterms](#codigosincoterms)|
|DescripcionIncoterms|No|Descripción del código incoterms|Alfanumérico de hasta 20 carácteres||

**Json ejemplo**

```json
[
    {
        "codigoTipoComprobante": "FAC",
        "numeroComprobante": "E0555500000010",
        "codigoTalonario": "25",
        "cAE" : "69214744756356",
        "codigoCliente": "EXTER",
        "codigoCondicionDeVenta": 1,
        "numeroDeProyecto": "",
        "codigoOperacionRG3685": "",
        "codigoClasificacion": "",
        "fechaComprobante": "2022-10-18",
        "fechaCierreTesoreria": "2019-06-07",
        "codigoListaPrecio": "1",
        "cotizacionVentas": null,
        "leyendaCotizacion": "",
        "codigoContracuenta": "20",
        "codigoDeposito": "2",
        "codigoVendedor": "3",
        "codigoAsiento": "",
        "codigoFlete": "01",
        "leyenda1": "",
        "leyenda2": "",
        "leyenda3": "",
        "leyenda4": "",
        "leyenda5": "",
        "total": 100.00,
        "totalSinImpuestos": 0,
        "totalExento": 100.00,
        "totalIva": 0,
        "subtotal": 100.00,
        "subtotalSinImpuestos": 0,
        "rg3668TipoIdentificacionFirmante": null,
        "rg3668CaracterDelFirmante": null,
        "rg3668CodigoIdentificacionFirmante": "",
        "rg3668MotivoDeExcepcion": null,
        "rg3668CodigoWeb": "666",
        "items": [
            {
                "codigo": "ART_EXPORTAC.",
                "codigoDeposito": "1",
                "codigoTasaIva": "1",
                "cantidad": 1,
                "precio": 100,
                "importe": 100
            }
        ],
        "pagos": [
            {
                "tipo" : "Efectivo",
                "codigoDeCuenta": "1",
                "monto": 100.00
            }
        ],
        "CuitDestino": "J",
        "TipoExpo": "1",
        "PaisAfip": "200",
        "CodigoIncoterms": "FCA",
        "DescripcionIncoterms": ""        
    }
]
```

<a name="ej18"></a>

**18 - Factura - Exportacion con permisos de embarco**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia con respecto a los mismos es que en el encabezado se agregan campos vinculados a la exportación y una sección "PermisosEmbarque" que se describen a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

El campo cAE debe ser utilizado en el caso de que el comprobante sea electrónico.

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|cAE|No|Código de Autorización Electrónico otorgado por AFIP|Alfanumérico de 14 carácteres||
|CuitDestino|Si|Cuit destino de la exportación|Alfanumérico de 1 carácter|J/F|
|TipoExpo|Si|Tipo de exportación|Numérico de tipo entero|1, 2 o 4|
|PaisAfip|Si|Código AFIP del País destino del comprobante|Numérico de tipo entero|Ver tablas de referencia, [Código Países AFIP](#codigopaises)|
|CodigoIncoterms|Si|Código incoterms|Alfanumérico de 3 carácteres|Ver tablas de referencia, [Códigos Incoterms](#codigosincoterms)|
|DescripcionIncoterms|No|Descripción del código incoterms|Alfanumérico de hasta 20 carácteres||
|**Sección PermisosEmbarque**|||||
|CodigoDespacho|Si|Código de despacho|Alfanumérico de 16 carácteres||
|paisafip|Si|Código AFIP del País destino de las mercaderías|Numérico de tipo entero|Ver tablas de referencia, [Código Países AFIP](#codigopaises)|


**Json ejemplo**

```json
[
    {
        "codigoTipoComprobante": "FAC",
        "numeroComprobante": "E0555500000011",
        "codigoTalonario": "25",
        "cAE" : "69214744756356",
        "codigoCliente": "EXTER",
        "codigoCondicionDeVenta": 1,
        "numeroDeProyecto": "",
        "codigoOperacionRG3685": "",
        "codigoClasificacion": "",
        "fechaComprobante": "2022-10-18",
        "fechaCierreTesoreria": "2019-06-07",
        "codigoListaPrecio": "1",
        "cotizacionVentas": null,
        "leyendaCotizacion": "",
        "codigoContracuenta": "20",
        "codigoDeposito": "2",
        "codigoVendedor": "3",
        "codigoAsiento": "",
        "codigoFlete": "01",
        "leyenda1": "",
        "leyenda2": "",
        "leyenda3": "",
        "leyenda4": "",
        "leyenda5": "",
        "total": 100.00,
        "totalSinImpuestos": 0,
        "totalExento": 100.00,
        "totalIva": 0,
        "subtotal": 100.00,
        "subtotalSinImpuestos": 0,
        "rg3668TipoIdentificacionFirmante": null,
        "rg3668CaracterDelFirmante": null,
        "rg3668CodigoIdentificacionFirmante": "",
        "rg3668MotivoDeExcepcion": null,
        "rg3668CodigoWeb": "666",
        "items": [
            {
                "codigo": "ART_EXPORTAC.",
                "codigoDeposito": "1",
                "codigoTasaIva": "1",
                "cantidad": 1,
                "precio": 100,
                "importe": 100
            }
        ],
        "pagos": [
            {
                "tipo" : "Efectivo",
                "codigoDeCuenta": "1",
                "monto": 100.00
            }
        ],
        "CuitDestino": "J",
        "TipoExpo": "1",
        "PaisAfip": "200",
        "CodigoIncoterms": "FCA",
        "DescripcionIncoterms": "",
        "PermisosEmbarque": [
            {
                "CodigoDespacho": "00000AAXX000010A",
                "paisafip": "200"
            }
        ]
    }
]
```

<a name="ej19"></a>

**19 - Factura - Exportacion con remito tabaco**

Los datos de encabezado e ítems se encuentran explicados en los Tópico Principal e Ítems, la única diferencia con respecto a los mismos es que en el encabezado se agregan campos vinculados a la exportación y dos secciones "PermisosEmbarque" y "RemitosTabaco" que se describen a continuación. Por otro lado, la sección de pagos contiene datos de la modalidad de pago con efectivo ([01 - Factura - Efectivo](#ej1)).

El campo cAE debe ser utilizado en el caso de que el comprobante sea electrónico.

| Campo | Requerido | Descripción | Tipo de dato | Valores posibles/Ejemplos |
|--- |--- |--- |--- |--- |
|cAE|No|Código de Autorización Electrónico otorgado por AFIP|Alfanumérico de 14 carácteres||
|CuitDestino|Si|Cuit destino de la exportación|Alfanumérico de 1 carácter|J/F|
|TipoExpo|Si|Tipo de exportación|Numérico de tipo entero|1, 2 o 4|
|PaisAfip|Si|Código AFIP del País destino del comprobante|Numérico de tipo entero|Ver tablas de referencia, [Código Países AFIP](#codigopaises)|
|CodigoIncoterms|Si|Código incoterms|Alfanumérico de 3 carácteres|Ver tablas de referencia, [Códigos Incoterms](#codigosincoterms)|
|DescripcionIncoterms|No|Descripción del código incoterms|Alfanumérico de hasta 20 carácteres||
|**Sección PermisosEmbarque**|||||
|CodigoDespacho|Si|Código de despacho|Alfanumérico de 16 carácteres||
|paisafip|Si|Código AFIP del País destino de las mercaderías|Numérico de tipo entero|Ver tablas de referencia, [Código Países AFIP](#codigopaises)|
|**Sección RemitosTabaco**|||||
|NumeroComprobante|Si|Número de remito|Alfanumérico de 14 carácteres||
|TipoRemito|No|Tipo de remito|Alfanumérico de 1 carácter||
|CuitRemito|Si|Cuit del remito|Alfanumérico de 11 carácteres||

**Json ejemplo**

```json
[
    {
        "codigoTipoComprobante": "FAC",
        "numeroComprobante": "E0555500000012",
        "codigoTalonario": "25",
        "cAE" : "69214744756356",
        "codigoCliente": "EXTER",
        "codigoCondicionDeVenta": 1,
        "numeroDeProyecto": "",
        "codigoOperacionRG3685": "",
        "codigoClasificacion": "",
        "fechaComprobante": "2022-10-18",
        "fechaCierreTesoreria": "2022-06-07",
        "codigoListaPrecio": "1",
        "cotizacionVentas": null,
        "leyendaCotizacion": "",
        "codigoContracuenta": "20",
        "codigoDeposito": "2",
        "codigoVendedor": "3",
        "codigoAsiento": "",
        "codigoFlete": "01",
        "leyenda1": "",
        "leyenda2": "",
        "leyenda3": "",
        "leyenda4": "",
        "leyenda5": "",
        "total": 100.00,
        "totalSinImpuestos": 0,
        "totalExento": 100.00,
        "totalIva": 0,
        "subtotal": 100.00,
        "subtotalSinImpuestos": 0,
        "rg3668TipoIdentificacionFirmante": null,
        "rg3668CaracterDelFirmante": null,
        "rg3668CodigoIdentificacionFirmante": "",
        "rg3668MotivoDeExcepcion": null,
        "rg3668CodigoWeb": "666",
        "items": [
            {
                "codigo": "ART_EXPORTAC.",
                "codigoDeposito": "1",
                "codigoTasaIva": "1",
                "cantidad": 1,
                "precio": 100,
                "importe": 100
            }
        ],
        "pagos": [
            {
                "tipo" : "Efectivo",
                "codigoDeCuenta": "1",
                "monto": 100.00
            }
        ],
        "CuitDestino": "J",
        "TipoExpo": "1",
        "PaisAfip": "200",
        "CodigoIncoterms": "FCA",
        "DescripcionIncoterms": "",
        "PermisosEmbarque": [
            {
                "CodigoDespacho": "00000AAXX000009A",
                "paisafip": "200"
            }
        ],
        "RemitosTabaco": [
            {                
                "NumeroComprobante": "REM0000100000023",
                "TipoRemito": "X",
                "CuitRemito": "30100219014"
            }
        ]
    }
]
```

<a name="ej20"></a>

**20 - Factura - Artículo con más de una descripción adicional**

En el caso que se desee agregar a un artículo más de una descripción adicional entonces en la propiedad "descripcionAdicional" se deberá utilizar el salto de línea "\r\n".

Cabe destacar que como se indicó en el tópico "Ítems" cada línea de descripción adicional puede contener hasta 20 carácteres.

**Json ejemplo**

```json
[
	{
		"codigoTipoComprobante": "FAC",
		"numeroComprobante": "A0000100000140",
		"codigoTalonario": "1",
		"codigoCliente": "010001",
		"codigoCondicionDeVenta": 1,
		"numeroDeProyecto": "",
		"codigoOperacionRG3685": "",
		"codigoClasificacion": "",
		"fechaComprobante": "2024-02-06",
		"fechaCierreTesoreria": "2024-02-01",
		"codigoListaPrecio": "2",
		"cotizacionVentas": null,
		"leyendaCotizacion": "",
		"codigoContracuenta": "20",
		"codigoDeposito": "2",
		"codigoVendedor": "3",
		"idMotivo": "3",
		"codigoAsiento": "",
		"codigoFlete": "01",
		"leyenda1": "Leyenda 1",
		"leyenda2": "Leyenda 2",
		"leyenda3": "Leyenda 3",
		"leyenda4": "Leyenda 4",
		"leyenda5": "Leyenda 5",
		"esMonedaExtranjera": false,
		"total": 242.00,
		"totalSinImpuestos": 200.00,
		"totalExento": 0.00,
		"totalIva": 42.00,
		"subtotal": 242.00,
		"subtotalSinImpuestos": 200.00,
		"descuentoPorcentaje": 0,
		"descuentoMonto": 0,
		"descuentoMontoSinIva": 0,
		"recargoPorcentaje": 0,
		"recargoMonto": 0,
		"recargoMontoSinIva": 0,
		"recargoFletePorcentaje": 0,
		"recargoFleteMonto": 0,
		"recargoFleteMontoSinIva": 0,
		"interesesPorcentaje": 0.00,
		"interesesMontoSinIva": 0.00,
		"observaciones": "",
		"rg3668TipoIdentificacionFirmante": null,
		"rg3668CaracterDelFirmante": "",
		"rg3668CodigoIdentificacionFirmante": "DNI",
		"rg3668MotivoDeExcepcion": null,
		"rg3668CodigoWeb": "666",
		"citiOpera":"O",
		"citiTipo":"B",
		"items": [
			{
				"codigo": "0200200033",
				"descripcion": "POLEA 30cm DE LAS OTRAS",
				"descripcionAdicional": "descripción en \r\n varías lineas \r\n a través de la API",
				"codigoTasaIva": "1",
				"cantidad": 2,
				"codigoDeposito": "2",
				"codigoUM": "UNI",
				"precio": 121.00,
				"importe": 242.00,
				"importeSinImpuestos": 200.00,
				"importeIva": 42.00
			}
		],
		"pagos": [
			{
				"tipo" : "Efectivo",
				"codigoDeCuenta": "1",
				"descuentoPorcentaje" : 0.00,
				"recargoPorcentaje" : 0.00,
				"monto": 242.00
			}
		]
	}
]
```