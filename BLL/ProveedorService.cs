using System;
using System.Collections.Generic;
using System.Linq;
using ENTITY;
using DLL;

namespace BLL
{
    public class ProveedorService
    {
        private readonly ProveedorDAL _provRepo = new ProveedorDAL();

        public List<Proveedor> Listar() => _provRepo.GetAll();

        public void Agregar(Proveedor p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("Nombre del proveedor es obligatorio.");

            var lista = _provRepo.GetAll();
            p.IdProveedor = lista.Count > 0 ? lista.Max(x => x.IdProveedor) + 1 : 1;
            lista.Add(p);
            _provRepo.SaveAll(lista);
        }

        public void Editar(Proveedor p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("Nombre del proveedor es obligatorio.");

            var lista = _provRepo.GetAll();
            var index = lista.FindIndex(x => x.IdProveedor == p.IdProveedor);
            if (index == -1) throw new Exception("Proveedor no encontrado.");

            lista[index] = p;
            _provRepo.SaveAll(lista);
        }

        public void Eliminar(int id)
        {
            var lista = _provRepo.GetAll();
            var item = lista.FirstOrDefault(x => x.IdProveedor == id);
            if (item == null) throw new Exception("Proveedor no encontrado.");

            lista.Remove(item);
            _provRepo.SaveAll(lista);
        }
    }
}
