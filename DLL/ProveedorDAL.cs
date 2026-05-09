using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ENTITY;

namespace DLL
{
    public class ProveedorDAL
    {
        private readonly string _path = "Proveedores.txt";

        public List<Proveedor> GetAll()
        {
            try
            {
                if (!File.Exists(_path)) return new List<Proveedor>();
                return File.ReadAllLines(_path)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .Select(line =>
                    {
                        var parts = line.Split(';');
                        return new Proveedor
                        {
                            IdProveedor = int.Parse(parts[0]),
                            Nombre = parts[1],
                            Contacto = parts[2],
                            Telefono = parts[3],
                            Email = parts[4]
                        };
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading suppliers: " + ex.Message);
            }
        }

        public void SaveAll(List<Proveedor> proveedores)
        {
            try
            {
                var lines = proveedores.Select(p => $"{p.IdProveedor};{p.Nombre};{p.Contacto};{p.Telefono};{p.Email}");
                File.WriteAllLines(_path, lines);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving suppliers: " + ex.Message);
            }
        }
    }
}
