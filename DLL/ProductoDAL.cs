using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ENTITY;

namespace DLL
{
    public class ProductoDAL
    {
        private string GetPath()
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            while (root != null && !File.Exists(Path.Combine(root, "ParcialP3.sln")))
            {
                root = Directory.GetParent(root)?.FullName;
            }
            
            string baseDir = root ?? AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(baseDir, "Data", "Productos.txt");
        }

        public List<Producto> GetAll()
        {
            try
            {
                string path = GetPath();
                if (!File.Exists(path)) return new List<Producto>();
                return File.ReadAllLines(path)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .Select(line =>
                    {
                        var parts = line.Split(';');
                        return new Producto
                        {
                            IdProducto = int.Parse(parts[0]),
                            Nombre = parts[1],
                            Descripcion = parts[2],
                            Precio = decimal.Parse(parts[3]),
                            Stock = int.Parse(parts[4]),
                            IdCategoria = int.Parse(parts[5]),
                            IdProveedor = int.Parse(parts[6]),
                            StockMinimo = parts.Length > 7 ? int.Parse(parts[7]) : 5
                        };
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading products: " + ex.Message);
            }
        }

        public void SaveAll(List<Producto> productos)
        {
            try
            {
                string path = GetPath();
                string dir = Path.GetDirectoryName(path);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                var lines = productos.Select(p => $"{p.IdProducto};{p.Nombre};{p.Descripcion};{p.Precio};{p.Stock};{p.IdCategoria};{p.IdProveedor};{p.StockMinimo}");
                File.WriteAllLines(path, lines);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving products: " + ex.Message);
            }
        }
    }
}
