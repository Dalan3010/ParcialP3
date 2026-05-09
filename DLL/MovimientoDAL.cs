using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ENTITY;

namespace DLL
{
    public class MovimientoDAL
    {
        private string GetPath()
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            while (root != null && !File.Exists(Path.Combine(root, "ParcialP3.sln")))
            {
                root = Directory.GetParent(root)?.FullName;
            }
            
            string baseDir = root ?? AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(baseDir, "Data", "Movimientos.txt");
        }

        public List<Movimiento> GetAll()
        {
            try
            {
                string path = GetPath();
                if (!File.Exists(path)) return new List<Movimiento>();
                return File.ReadAllLines(path)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .Select(line =>
                    {
                        var parts = line.Split(';');
                        return new Movimiento
                        {
                            IdMovimiento = int.Parse(parts[0]),
                            IdProducto = int.Parse(parts[1]),
                            Tipo = parts[2],
                            Cantidad = int.Parse(parts[3]),
                            Fecha = DateTime.Parse(parts[4]),
                            Descripcion = parts[5]
                        };
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading movements: " + ex.Message);
            }
        }

        public void Save(Movimiento m)
        {
            try
            {
                string path = GetPath();
                string dir = Path.GetDirectoryName(path);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                string line = $"{m.IdMovimiento};{m.IdProducto};{m.Tipo};{m.Cantidad};{m.Fecha};{m.Descripcion}";
                File.AppendAllText(path, line + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving movement: " + ex.Message);
            }
        }
    }
}
