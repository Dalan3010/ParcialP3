using System;
using System.Collections.Generic;
using System.Linq;
using ENTITY;
using DLL;

namespace BLL
{
    public class CategoriaService
    {
        private readonly CategoriaDAL _catRepo = new CategoriaDAL();

        public List<Categoria> Listar() => _catRepo.GetAll();

        public void Agregar(Categoria c)
        {
            if (string.IsNullOrWhiteSpace(c.NombreCategoria))
                throw new Exception("Nombre de categoría es obligatorio.");

            var lista = _catRepo.GetAll();
            c.IdCategoria = lista.Count > 0 ? lista.Max(x => x.IdCategoria) + 1 : 1;
            lista.Add(c);
            _catRepo.SaveAll(lista);
        }

        public void Editar(Categoria c)
        {
            if (string.IsNullOrWhiteSpace(c.NombreCategoria))
                throw new Exception("Nombre de categoría es obligatorio.");

            var lista = _catRepo.GetAll();
            var index = lista.FindIndex(x => x.IdCategoria == c.IdCategoria);
            if (index == -1) throw new Exception("Categoría no encontrada.");

            lista[index] = c;
            _catRepo.SaveAll(lista);
        }

        public void Eliminar(int id)
        {
            var lista = _catRepo.GetAll();
            var item = lista.FirstOrDefault(x => x.IdCategoria == id);
            if (item == null) throw new Exception("Categoría no encontrada.");

            lista.Remove(item);
            _catRepo.SaveAll(lista);
        }
    }
}
