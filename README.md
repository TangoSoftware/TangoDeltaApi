### Servicios

**Clientes**

Este servicio permite realizar las operaciones CRUD (Create, Read,
Update, Delete) relacionadas con el proceso de
[Clientes](https://ayudas.axoft.com/23ar/ayudas/gv/archivos_carp_gv/actualizacion_carp_gv/clientes_carp_gv/).

Cada cliente se representa como un objeto JSON con varios campos. Cada
campo tiene un significado específico, un conjunto de valores posibles y
puede ser de ingreso obligatorio.

Este servicio cuenta con los siguientes métodos:

-   Consulta: Get y GetById

-   Alta: Put

-   Modificación: Post

-   Baja: Delete

Para más información sobre este tema consulte la sección [Readme]{.mark}
del servicio para acceder al detalle de cada uno de los campos de JSON o
acceda a la sección [Program]{.mark} para consultar algunos ejemplos de
implementación.

**Pedidos**

Este servicio permite obtener información sobre los pedidos existentes
Get , GetbyID y GetByFilter o ingresar nuevos comprobantes Post.
Adicionalmente incluimos ejemplos sobre cómo obtener la información
necesaria para completar los ID de las tablas relacionadas; por ejemplo,
cómo obtener el ID del vendedor en base su código o nombre para
registrarlo en el pedido.

[Los métodos PUT, DELETE no funcionan]{.mark}

[Otros métodos disponibles CLOSE (cerrar) y CANCEL (anular)]{.mark}

[Get by filter usar AXV_PEDIDO (No GVA21) è grandes procesos normalmente
usan AXV_NombreProceso y no la tabla maestra conocida è afecta solo a
GetByFilter]{.mark}

Para más información sobre este tema consulte la sección [Readme]{.mark}
del servicio para acceder al detalle de cada uno de los campos de JSON o
acceda a la sección [Program]{.mark} para consultar algunos ejemplos de
implementación.

**[FacturaciónVentas]{.mark}**

## ¿Cómo contribuir?

Si desea contribuir a este proyecto, puede clonar este repositorio y
enviar un pull request con sus cambios. Asegúrese de seguir las
convenciones de código existentes y de escribir pruebas para cualquier
nuevo código.

Si encuentra un problema o tiene una sugerencia, puede abrir un nuevo
issue en este repositorio.