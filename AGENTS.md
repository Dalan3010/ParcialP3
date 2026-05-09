# Agent Guidance: ParcialP3

This is a .NET Framework 4.8 Windows Forms application implementing an inventory management system with a strict 4-layer architecture.

## Architecture & Layering
The project follows a mandatory layered pattern. References must flow in one direction:
`GUI (Presentation)` → `BLL (Logic)` → `DLL (Data)` → `ENTITY (Model)`

- **ENTITY**: Model classes (e.g., `Producto`, `Categoria`). Must contain only properties and have no dependencies.
- **DLL (DAL)**: Data Access Layer. Handles all reading/writing to `.txt` files. Depends only on `ENTITY`.
- **BLL**: Business Logic Layer. Contains business rules, validations, and service methods. Depends on `DLL` and `ENTITY`.
- **GUI**: Windows Forms interface. Handles UI events and user interaction. Depends only on `BLL`.

## Data Persistence
Data is stored in plain text files using a semicolon (`;`) delimiter:
- `Categorias.txt`: `IdCategoria;NombreCategoria;Descripcion`
- `Proveedores.txt`: `IdProveedor;Nombre;Contacto;Telefono;Email`
- `Productos.txt`: `IdProducto;Nombre;Descripcion;Precio;Stock;IdCategoria;IdProveedor`
- `Movimientos.txt`: `IdMovimiento;IdProducto;Tipo;Cantidad;Fecha;Descripcion`

## Developer Commands
The project is a Visual Studio solution (`ParcialP3.sln`).
- **Build**: Use `msbuild ParcialP3.sln` or Visual Studio.
- **Run**: Execute the `GUI` project.
- **Target Framework**: .NET Framework 4.8.

## Core Conventions
- **Validations**: All business validations (e.g., positive numbers, required fields) must reside in the `BLL`, not in the `GUI`.
- **Persistence**: All file I/O must be encapsulated in the `DLL`.
- **UI**: Use `TabControl` for separating the management of Products, Categories, Suppliers, and Movements.
- **Stock Management**: Movements (Entry/Exit) must automatically trigger stock updates in the `DLL`.
