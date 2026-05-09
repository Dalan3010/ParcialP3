using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ENTITY;

namespace DLL
{
    public class ProductoDAL
    {
        private readonly string _path = "Productos.txt";

        public List<Producto> GetAll()
        {
            try
            {
                if (!File.Exists(_path)) return new List<Producto>();
                return File.ReadAllLines(_path)
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
                var lines = productos.Select(p => $"{p.IdProducto};{p.Nombre};{p.Descripcion};{p.Precio};{p.Stock};{p.IdCategoria};{p.IdProveedor};{p.StockMinimo}");
                File.WriteAllLines(_path, lines);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving products: " + ex.Message);
            }
        }
    }
}
