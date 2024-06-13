# TangoDeltaApi 

## Readme del repositorio

TangoDeltaApi es uno de los principales repositorios de Tango Software.

Si bien los procesos desarrollados con tecnología Delta cuentan con
[documentación](https://ayudas.axoft.com/23ar/documentos/operacion/apertura_oper/api_oper/)
sobre cada uno de sus métodos este repositorio amplía la información
para los servicios relacionados con transacciones (pedidos, facturas,
asientos). Incorpora además un ejemplo sobre cómo utilizar el servicio
de Clientes a fin de que sirva como referencia para la implementación de
otros similares como pueden ser proveedores, legajos, artículos, etc.

Cuenta además con una librería) de ejemplo para facilitar la integración
con Tango Delta.

[Hay que explicar que las API de transacciones tienen costo y que el
resto funcionan mientras esté en el rebaño]{.mark}

### TangoRestApi Library

TangoRestApi es una librería desarrollada en .NET Core que facilita la
llamada a los servicios de Axcloud implementando sus modelos. Esta
librería puede ser descargada y compilada si utiliza C# como leguaje de
programación, o puede ser usada como guía para desarrollarlo con otra
tecnología.

Axcloud es el servidor web de Tango Delta; es decir el responsable de
atender las peticiones de las APIs.

Esta librería es utilizada como una capa intermedia en la implementación
de las APIs funcionales (servicios) mencionadas a continuación.

**Consideraciones sobre la seguridad y acceso a la información**

Tenga en cuenta que Tango Software es un sistema OnPremise. Si requiere
utilizar las API desde internet debe abrir el puerto de seguridad con el
que se accede a la información de su sistema Tango (por defecto puerto
17000) o utilizar [Tango
Connect](https://ayudas.axoft.com/23ar/documentos/operacion/acceso_oper/connect_oper/).

Si no utiliza Tango Connect siga estas
[instrucciones](https://ayudas.axoft.com/23ar/documentos/operacion/acceso_oper/certseguridad_oper/)
para instalar un certificado de seguridad en su sistema Tango.
