PROGRAMACIÓN DE
COMPUTADORES III
SEGUNDO PRCIAL
JOHN JAIRO PATIÑO VANEGAS

2026-1

Nombre
Completo:

_______________________________________________________________

OBJETIVO GENERAL

Construir una aplicación en C# Windows Forms, organizada en 4 capas (Entidad, Lógica, Datos y Presentación),
que permita gestionar un inventario de productos, sus categorías, proveedores y movimientos de inventario.

ARQUITECTURA EN CAPAS (obligatoria)

Cada proyecto debe ser de tipo Class Library (.NET Framework), excepto la Presentación que es Windows
Forms App (.NET Framework). Las referencias entre capas deben configurarse exactamente como se indica.

Presentación
(Windows Forms)

•  Formularios e
interfaces

•  Captura de eventos
•  Referencia a Lógica

Lógica
(Class Library)
•  Reglas de negocio
•  Validaciones
•  Ref. a Datos y

Entidad

Datos
(Class Library)
•  Lectura/escritura .txt
•  Sin lógica de negocio
•  Ref. a Entidad

Entidad
(Class Library)
•  Clases modelo
•  Solo propiedades
•  Sin dependencias

Referencias requeridas:
  Presentación  →  Lógica
  Lógica        →  Datos  +  Entidad
  Datos         →  Entidad

ARCHIVOS DE DATOS PROPORCIONADOS

Se entregan cuatro archivos .txt con separador ; (punto y coma). La capa de Datos debe leerlos y devolver listas
de objetos correctamente tipados.

Archivo

Estructura (separado por ;)

Descripción

Categorias.txt

IdCategoria ; NombreCategoria ; Descripcion

Catálogo de categorías de
productos

Proveedores.txt

IdProveedor ; Nombre ; Contacto ; Telefono ;
Email

Registro de proveedores

Productos.txt

IdProducto ; Nombre ; Descripcion ; Precio ;
Stock ; IdCategoria ; IdProveedor

Inventario de productos

Movimientos.txt

IdMovimiento ; IdProducto ; Tipo ; Cantidad ;
Fecha ; Descripcion

Historial de movimientos de
inventario

RESUMEN DE PUNTOS

Actividad

Puntaje

N°

1

2

3

Crear estructura de 4 capas

Leer y cargar archivos de datos

Diseñar formulario principal de gestión

4  Gestión de Categorías y Proveedores

5

Registrar, Editar y Eliminar Productos

6  Gestión de Movimientos de Inventario

7

8

9

Persistencia de Datos

Sistema de Alertas de Stock

Cuestionario Teórico-Práctico

TOTAL

0.8

0.8

0.8

0.4

0.8

0.4

0.5

0.5

1.0

5.0

DESCRIPCIÓN DE ACTIVIDADES

1  Crear la Estructura de 4 Capas en el Proyecto

Puntaje
0.8 pts

Crear la solución en Visual Studio con los 4 proyectos correctamente configurados:

•  Capa de Entidad: Class Library (.NET Framework) — contiene las clases modelo (Categoria, Proveedor,

Producto, Movimiento).

•  Capa de Lógica: Class Library (.NET Framework) — contiene los servicios de negocio.
•  Capa de Datos: Class Library (.NET Framework) — contiene el acceso a archivos .txt.
•  Capa de Presentación: Windows Forms App (.NET Framework) — contiene los formularios.
•  Configurar las referencias entre proyectos tal como se indica en el diagrama de arquitectura.
•  Organizar carpetas internas: Entidades, Servicios, AccesoDatos, etc., según corresponda en cada capa.

Criterios de Evaluación

(0.4 pts)  Si crea correctamente los 4 proyectos con sus tipos correspondientes.
(0.4 pts)  Si establece correctamente las referencias entre proyectos.

2

Leer y Cargar los Archivos de Datos en la Capa de
Datos

Puntaje
0.8 pts

En la capa de Datos, implementar métodos de lectura para cada archivo .txt:

•  Crear un método para leer Categorias.txt y devolver una lista List<Categoria>.
•  Crear un método para leer Proveedores.txt y devolver una lista List<Proveedor>.
•  Crear un método para leer Productos.txt y devolver una lista List<Producto>.
•  Crear un método para leer Movimientos.txt y devolver una lista List<Movimiento>.
•  El separador de campos es el punto y coma ( ; ); parsear correctamente cada campo al tipo de dato

adecuado (int, decimal, DateTime, etc.).

•  Gestionar excepciones en la lectura (archivo no encontrado, línea mal formada, etc.) e informar por mensaje.

Criterios de Evaluación

(0.4 pts)  Si implementa correctamente la lectura de los cuatro archivos.
(0.4 pts)  Si devuelve listas de objetos correctamente tipados (tipos primitivos parseados
correctamente).

3

Diseñar el Formulario Principal de Gestión de
Productos

Puntaje
0.8 pts

Crear el formulario principal de Windows Forms con la siguiente estructura:

•  Sistema de pestañas (TabControl) para separar: Productos, Categorías, Proveedores y Movimientos.
•  En la pestaña Productos incluir campos de texto para: Nombre, Descripción, Precio y Stock.
•  ComboBox para seleccionar Categoría (cargado desde la lista de categorías).
•  ComboBox para seleccionar Proveedor (cargado desde la lista de proveedores).
•  Botones de acción: Agregar, Editar, Eliminar.
•  DataGridView para mostrar la lista de productos registrados con todas sus columnas.
•  El formulario debe ser ordenado, con etiquetas (Label) descriptivas para cada campo.

Criterios de Evaluación

(0.4 pts)  Si incluye todos los campos requeridos (TextBox, ComboBox, botones, DataGridView).
(0.4 pts)  Si el formulario es ordenado y funcional con sistema de pestañas (TabControl).

4

Implementar la Gestión de Categorías y Proveedores

Puntaje
0.4 pts

En las pestañas correspondientes del formulario, implementar el CRUD de categorías y proveedores:

•  Categorías: formulario con campos IdCategoria, NombreCategoria y Descripcion; botones Agregar, Editar y

Eliminar; DataGridView con la lista.

•  Proveedores: formulario con campos IdProveedor, Nombre, Contacto, Telefono y Email; botones Agregar,

Editar y Eliminar; DataGridView con la lista.

•  Validar que los campos obligatorios estén completos antes de guardar; mostrar mensaje descriptivo al

usuario si algún campo está vacío.

•  La lógica de validación y las operaciones deben pasar por la capa de Lógica, no ejecutarse directamente

desde la Presentación.

Criterios de Evaluación

(0.2 pts)  Si implementa correctamente la gestión de categorías (agregar, editar, eliminar).
(0.2 pts)  Si implementa correctamente la gestión de proveedores (agregar, editar, eliminar).

5  Registrar, Editar y Eliminar Productos

Puntaje
0.8 pts

Implementar el CRUD completo de productos desde la pestaña Productos:

•  Agregar producto nuevo: capturar los valores de los campos, invocar el servicio de lógica y refrescar el

DataGridView.

•  Editar producto: al seleccionar una fila del DataGridView, cargar sus datos en los campos del formulario; al

confirmar, actualizar el registro.

•  Eliminar producto: al seleccionar una fila del DataGridView, solicitar confirmación al usuario y eliminar el

registro.

•  Validar que los campos obligatorios (Nombre, Precio, Stock, Categoría, Proveedor) estén completos antes de

guardar.

•  Validar que Precio y Stock sean valores numéricos positivos; mostrar mensaje descriptivo si la validación

falla.

Criterios de Evaluación

(0.3 pts)  Si agrega correctamente productos (campos capturados, servicio invocado, grilla actualizada).
(0.2 pts)  Si edita productos correctamente (carga datos en campos, actualiza registro).
(0.2 pts)  Si elimina productos correctamente (confirma acción, elimina de la lista).
(0.1 pts)  Si implementa validaciones de campos obligatorios y tipos numéricos positivos.

6  Gestión de Movimientos de Inventario

Puntaje
0.4 pts

Implementar en la pestaña Movimientos la gestión de entradas y salidas de inventario:

•  Seleccionar un producto de la lista para registrar el movimiento.
•  Registrar el tipo de movimiento: Entrada (aumenta stock) o Salida (disminuye stock), indicando la cantidad y

una descripción.

•  Actualizar automáticamente el stock del producto en la capa de Datos después de registrar el movimiento.
•  Validar que una Salida no deje el stock en valores negativos; informar al usuario si la cantidad solicitada

excede el stock disponible.

•  Mostrar el historial de movimientos por producto en un DataGridView filtrable.

Criterios de Evaluación

(0.2 pts)  Si implementa correctamente el registro de movimientos (Entrada / Salida con campos
requeridos).
(0.2 pts)  Si actualiza correctamente el stock del producto tras cada movimiento.

7  Persistencia de Datos en Archivos de

Puntaje
0.5 pts

Implementar la escritura de datos en los archivos .txt para que los cambios sean persistentes entre sesiones:

•  Al agregar, editar o eliminar un producto, guardar la lista actualizada en Productos.txt con el mismo formato

(separador ;).

•  Al agregar, editar o eliminar una categoría, actualizar Categorias.txt.
•  Al agregar, editar o eliminar un proveedor, actualizar Proveedores.txt.
•  Al registrar un movimiento, agregar el registro en Movimientos.txt.
•  Los métodos de escritura deben estar en la capa de Datos; la capa de Lógica los invoca, no la Presentación

directamente.

•  Gestionar excepciones de escritura e informar por mensaje al usuario.

Criterios de Evaluación

(0.3 pts)  Si guarda correctamente los datos de productos en Productos.txt tras cada operación.
(0.2 pts)  Si guarda correctamente los datos de categorías, proveedores y movimientos en sus archivos
respectivos.

8  Sistema de Alertas de Stock

Puntaje
0.5 pts

Implementar un sistema de alertas visuales para el control del nivel mínimo de inventario:

•  Definir un nivel mínimo de stock configurable para cada producto (puede ser un campo adicional en la

entidad Producto).

•  En el DataGridView de productos, resaltar visualmente (color de fila o icono) los productos cuyo stock esté

por debajo del mínimo definido.

•  Implementar un botón o pestaña de Alertas que muestre únicamente los productos con stock bajo.
•  Generar un reporte de productos con stock bajo que liste: nombre del producto, stock actual, stock mínimo y

proveedor asociado.

•  Implementar filtros en la vista de productos: Todos, Stock normal, Stock bajo, Sin stock.

Criterios de Evaluación

(0.3 pts)  Si implementa correctamente las alertas visuales en el DataGridView (resaltado de filas con
stock bajo).
(0.2 pts)  Si genera el reporte de productos con stock bajo con los campos requeridos.

REQUISITOS GENERALES

•  El programa debe compilar para ser revisado; no se aceptan correcciones durante la revisión.
•  Los puntos son inclusivos y acumulativos: para desarrollar el punto N se debe haber completado

correctamente el punto N-1.

•  Los servicios de la capa Lógica deben gestionar correctamente los errores, informando al usuario con

mensajes descriptivos.

