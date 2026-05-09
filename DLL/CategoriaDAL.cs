using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ENTITY;

namespace DLL
{
    public class CategoriaDAL
    {
        private string GetPath()
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            while (root != null && !File.Exists(Path.Combine(root, "ParcialP3.sln")))
            {
                root = Directory.GetParent(root)?.FullName;
            }
            
            string baseDir = root ?? AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(baseDir, "Data", "Categorias.txt");
        }

        public List<Categoria> GetAll()
        {
            try
            {
                string path = GetPath();
                if (!File.Exists(path)) return new List<Categoria>();
                return File.ReadAllLines(path)
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
                string path = GetPath();
                string dir = Path.GetDirectoryName(path);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                var lines = categorias.Select(c => $"{c.IdCategoria};{c.NombreCategoria};{c.Descripcion}");
                File.WriteAllLines(path, lines);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving categories: " + ex.Message);
            }
        }
    }
}
