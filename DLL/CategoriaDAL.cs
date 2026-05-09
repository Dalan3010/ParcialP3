using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ENTITY;

namespace DLL
{
    public class CategoriaDAL
    {
        private readonly string _path = "Categorias.txt";

        public List<Categoria> GetAll()
        {
            try
            {
                if (!File.Exists(_path)) return new List<Categoria>();
                return File.ReadAllLines(_path)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .Select(line =>
                    {
                        var parts = line.Split(';');
                        return new Categoria
                        {
                            IdCategoria = int.Parse(parts[0]),
                            NombreCategoria = parts[1],
                            Descripcion = parts[2]
                        };
                    }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading categories: " + ex.Message);
            }
        }

        public void SaveAll(List<Categoria> categorias)
        {
            try
            {
                var lines = categorias.Select(c => $"{c.IdCategoria};{c.NombreCategoria};{c.Descripcion}");
                File.WriteAllLines(_path, lines);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving categories: " + ex.Message);
            }
        }
    }
}
