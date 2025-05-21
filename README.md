### Servicios disponibles
<br>

**1) Clientes**

Este servicio permite realizar las operaciones CRUD (Create, Read,
Update, Delete) relacionadas con el proceso de
[Clientes](https://ayudas.axoft.com/23ar/ayudas/gv/archivos_carp_gv/actualizacion_carp_gv/clientes_carp_gv/).

Cada cliente se representa como un objeto JSON con varios campos. Cada
campo tiene un significado específico, un conjunto de valores posibles y
puede ser de ingreso obligatorio.

Este servicio cuenta con los siguientes métodos:

-   **Get y GetById:** Consulta

-   **Post:** Alta

-   **Put:** Modificación

-   **Delete:** Eliminación
<br>
Para más información sobre este tema consulte la sección [Readme]{.mark}
del servicio para acceder al detalle de cada uno de los campos de JSON o
acceda a la sección [Program]{.mark} para consultar algunos ejemplos de
implementación.

<br>
<br>
<br>

**2) Pedidos**

Este servicio permite obtener información sobre los pedidos existentes
**Get , GetbyID y GetByFilter** o ingresar nuevos comprobantes **Post**.

Adicionalmente incluimos ejemplos sobre cómo obtener la información
necesaria para completar los **ID** de las tablas relacionadas; un caso de aplicación podría se
cómo obtener el ID del vendedor en base su código o nombre para registrarlo en el pedido.


**Tené en cuenta que los métodos PUT, DELETE no funcionan por el momento. Otros métodos que incluimos en el servicio son CLOSE (cerrar) y CANCEL (anular)**
<br>
<br>
<br>
**Consideraciones**<br>
Cuando utilices el método **Get by filter** tené en cuenta que en algunos procesos el sistema trabaja con una *vista* en lugar de hacerlo con tabla principal. 
Por ejemplo, esto se da en los grandes procesos como:
-   **Clientes**
-   **Artículos**
-   **Proveedores**
-   y ahora **Pedidos**

Estos procesos trabajan con una vista que se denominan **AXV_NombreProceso**; en el caso de pedidos trabaja con AXV_PEDIDO (en lugar de GVA21).
Para obtener la *lista de tablas del sistema* consultá dicha sección en el *Manual de operación* en nuestro [portal de ayudas](https://ayudas.axoft.com/).

Para más información sobre esta API tema consultá la sección [Readme](https://github.com/TangoSoftware/TangoDeltaApi/blob/main/src/Implementations/PedidosApiConsole/README.md)
del servicio para acceder al detalle de cada uno de los campos de JSON o
accedé a la sección [Program](https://github.com/TangoSoftware/TangoDeltaApi/blob/main/src/Implementations/PedidosApiConsole/Program.cs) para consultar algunos ejemplos de
implementación.
<br>
<br>

**3) Facturación de Ventas**

Próximamente encontarás en esta sección toda la documentación necesaria para registrar facturas de ventas. 
En versiones anteriores esta documentación se encontraba en la ayuda del sistema.
<br>
<br>
..
