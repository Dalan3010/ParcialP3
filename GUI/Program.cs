using System;
using System.Collections.Generic;
using ENTITY;
using BLL;

namespace GUI
{
    class Program
    {
        static CategoriaService catService = new CategoriaService();
        static ProveedorService provService = new ProveedorService();
        static ProductoService prodService = new ProductoService();
        static MovimientoService movService = new MovimientoService();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE GESTIÓN DE INVENTARIO ===");
                Console.WriteLine("1. Gestión de Categorías");
                Console.WriteLine("2. Gestión de Proveedores");
                Console.WriteLine("3. Gestión de Productos");
                Console.WriteLine("4. Movimientos de Inventario");
                Console.WriteLine("5. Reporte de Stock Bajo");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1": MenuCategorias(); break;
                    case "2": MenuProveedores(); break;
                    case "3": MenuProductos(); break;
                    case "4": MenuMovimientos(); break;
                    case "5": ReporteStockBajo(); break;
                    case "0": exit = true; break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
                if (!exit)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void MenuCategorias()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                Console.WriteLine("--- GESTIÓN DE CATEGORÍAS ---");
                Console.WriteLine("1. Listar");
                Console.WriteLine("2. Agregar");
                Console.WriteLine("3. Editar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("0. Volver");
                Console.Write("\nOpción: ");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            var lista = catService.Listar();
                            Console.WriteLine("\nID | Nombre | Descripción");
                            foreach (var c in lista) Console.WriteLine(c.ToString());
                            break;
                        case "2":
                            var cNew = new Categoria();
                            Console.Write("Nombre: "); cNew.NombreCategoria = Console.ReadLine();
                            Console.Write("Descripción: "); cNew.Descripcion = Console.ReadLine();
                            catService.Agregar(cNew);
                            Console.WriteLine("Categoría agregada con éxito.");
                            break;
                        case "3":
                            Console.Write("ID de la categoría a editar: ");
                            int idEd = int.Parse(Console.ReadLine());
                            var cEd = new Categoria { IdCategoria = idEd };
                            Console.Write("Nuevo Nombre: "); cEd.NombreCategoria = Console.ReadLine();
                            Console.Write("Nueva Descripción: "); cEd.Descripcion = Console.ReadLine();
                            catService.Editar(cEd);
                            Console.WriteLine("Categoría actualizada.");
                            break;
                        case "4":
                            Console.Write("ID a eliminar: ");
                            int idDel = int.Parse(Console.ReadLine());
                            catService.Eliminar(idDel);
                            Console.WriteLine("Categoría eliminada.");
                            break;
                        case "0": back = true; break;
                    }
                }
                catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
            }
        }

        static void MenuProveedores()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                Console.WriteLine("--- GESTIÓN DE PROVEEDORES ---");
                Console.WriteLine("1. Listar");
                Console.WriteLine("2. Agregar");
                Console.WriteLine("3. Editar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("0. Volver");
                Console.Write("\nOpción: ");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            var lista = provService.Listar();
                            Console.WriteLine("\nID | Nombre | Contacto | Teléfono | Email");
                            foreach (var p in lista) Console.WriteLine(p.ToString());
                            break;
                        case "2":
                            var pNew = new Proveedor();
                            Console.Write("Nombre: "); pNew.Nombre = Console.ReadLine();
                            Console.Write("Contacto: "); pNew.Contacto = Console.ReadLine();
                            Console.Write("Teléfono: "); pNew.Telefono = Console.ReadLine();
                            Console.Write("Email: "); pNew.Email = Console.ReadLine();
                            provService.Agregar(pNew);
                            Console.WriteLine("Proveedor agregado.");
                            break;
                        case "3":
                            Console.Write("ID a editar: ");
                            int idEd = int.Parse(Console.ReadLine());
                            var pEd = new Proveedor { IdProveedor = idEd };
                            Console.Write("Nombre: "); pEd.Nombre = Console.ReadLine();
                            Console.Write("Contacto: "); pEd.Contacto = Console.ReadLine();
                            Console.Write("Teléfono: "); pEd.Telefono = Console.ReadLine();
                            Console.Write("Email: "); pEd.Email = Console.ReadLine();
                            provService.Editar(pEd);
                            Console.WriteLine("Proveedor actualizado.");
                            break;
                        case "4":
                            Console.Write("ID a eliminar: ");
                            int idDel = int.Parse(Console.ReadLine());
                            provService.Eliminar(idDel);
                            Console.WriteLine("Proveedor eliminado.");
                            break;
                        case "0": back = true; break;
                    }
                }
                catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
            }
        }

        static void MenuProductos()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                Console.WriteLine("--- GESTIÓN DE PRODUCTOS ---");
                Console.WriteLine("1. Listar");
                Console.WriteLine("2. Agregar");
                Console.WriteLine("3. Editar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("0. Volver");
                Console.Write("\nOpción: ");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            var lista = prodService.Listar();
                            Console.WriteLine("\nID | Nombre | Precio | Stock | Categoría | Proveedor");
                            foreach (var p in lista) Console.WriteLine(p.ToString());
                            break;
                        case "2":
                            var pNew = new Producto();
                            Console.Write("Nombre: "); pNew.Nombre = Console.ReadLine();
                            Console.Write("Descripción: "); pNew.Descripcion = Console.ReadLine();
                            Console.Write("Precio: "); pNew.Precio = decimal.Parse(Console.ReadLine());
                            Console.Write("Stock: "); pNew.Stock = int.Parse(Console.ReadLine());
                            Console.Write("ID Categoría: "); pNew.IdCategoria = int.Parse(Console.ReadLine());
                            Console.Write("ID Proveedor: "); pNew.IdProveedor = int.Parse(Console.ReadLine());
                            Console.Write("Stock Mínimo (Default 5): "); 
                            string sm = Console.ReadLine();
                            if(!string.IsNullOrEmpty(sm)) pNew.StockMinimo = int.Parse(sm);
                            prodService.Agregar(pNew);
                            Console.WriteLine("Producto agregado.");
                            break;
                        case "3":
                            Console.Write("ID a editar: ");
                            int idEd = int.Parse(Console.ReadLine());
                            var pEd = new Producto { IdProducto = idEd };
                            Console.Write("Nombre: "); pEd.Nombre = Console.ReadLine();
                            Console.Write("Descripción: "); pEd.Descripcion = Console.ReadLine();
                            Console.Write("Precio: "); pEd.Precio = decimal.Parse(Console.ReadLine());
                            Console.Write("Stock: "); pEd.Stock = int.Parse(Console.ReadLine());
                            Console.Write("ID Categoría: "); pEd.IdCategoria = int.Parse(Console.ReadLine());
                            Console.Write("ID Proveedor: "); pEd.IdProveedor = int.Parse(Console.ReadLine());
                            prodService.Editar(pEd);
                            Console.WriteLine("Producto actualizado.");
                            break;
                        case "4":
                            Console.Write("ID a eliminar: ");
                            int idDel = int.Parse(Console.ReadLine());
                            prodService.Eliminar(idDel);
                            Console.WriteLine("Producto eliminado.");
                            break;
                        case "0": back = true; break;
                    }
                }
                catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
            }
        }

        static void MenuMovimientos()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                Console.WriteLine("--- MOVIMIENTOS DE INVENTARIO ---");
                Console.WriteLine("1. Registrar Movimiento");
                Console.WriteLine("2. Listar Historial");
                Console.WriteLine("0. Volver");
                Console.Write("\nOpción: ");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            var m = new Movimiento();
                            Console.Write("ID Producto: "); m.IdProducto = int.Parse(Console.ReadLine());
                            Console.Write("Tipo (Entrada/Salida): "); m.Tipo = Console.ReadLine();
                            Console.Write("Cantidad: "); m.Cantidad = int.Parse(Console.ReadLine());
                            Console.Write("Descripción: "); m.Descripcion = Console.ReadLine();
                            movService.Registrar(m);
                            Console.WriteLine("Movimiento registrado y stock actualizado.");
                            break;
                        case "2":
                            var listaMov = movService.Listar();
                            Console.WriteLine("\nID | Producto | Tipo | Cant | Fecha | Desc");
                            foreach (var mov in listaMov) Console.WriteLine(mov.ToString());
                            break;
                        case "0": back = true; break;
                    }
                }
                catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
            }
        }

        static void ReporteStockBajo()
        {
            Console.Clear();
            Console.WriteLine("--- REPORTE DE STOCK BAJO ---");
            var bajos = prodService.GetStockBajo();
            if (bajos.Count == 0)
            {
                Console.WriteLine("No hay productos con stock bajo.");
            }
            else
            {
                Console.WriteLine("\nNombre | Stock Actual | Stock Mínimo | Proveedor");
                foreach (var p in bajos) Console.WriteLine($"{p.Nombre} | {p.Stock} | {p.StockMinimo} | {p.Proveedor?.Nombre ?? "N/A"}");
            }
        }
    }
}
