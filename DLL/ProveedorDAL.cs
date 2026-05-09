using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ENTITY;

namespace DLL
{
    public class ProveedorDAL
    {
        private string GetPath()
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            while (root != null && !File.Exists(Path.Combine(root, "ParcialP3.sln")))
            {
                root = Directory.GetParent(root)?.FullName;
            }
            
            string baseDir = root ?? AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(baseDir, "Data", "Proveedores.txt");
        }

        public List<Proveedor> GetAll()
        {
            try
            {
                string path = GetPath();
                if (!File.Exists(path)) return new List<Proveedor>();
                return File.ReadAllLines(path)
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
                string path = GetPath();
                string dir = Path.GetDirectoryName(path);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                var lines = proveedores.Select(p => $"{p.IdProveedor};{p.Nombre};{p.Contacto};{p.Telefono};{p.Email}");
                File.WriteAllLines(path, lines);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving suppliers: " + ex.Message);
            }
        }
    }
}
