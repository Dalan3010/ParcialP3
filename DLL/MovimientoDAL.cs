using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ENTITY;

namespace DLL
{
    public class MovimientoDAL
    {
        private readonly string _path = "Movimientos.txt";

        public List<Movimiento> GetAll()
        {
            try
            {
                if (!File.Exists(_path)) return new List<Movimiento>();
                return File.ReadAllLines(_path)
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
                string line = $"{m.IdMovimiento};{m.IdProducto};{m.Tipo};{m.Cantidad};{m.Fecha};{m.Descripcion}";
                File.AppendAllText(_path, line + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving movement: " + ex.Message);
            }
        }
    }
}
