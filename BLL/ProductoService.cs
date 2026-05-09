using System;
using System.Collections.Generic;
using System.Linq;
using ENTITY;
using DLL;

namespace BLL
{
    public class ProductoService
    {
        private readonly ProductoDAL _prodRepo = new ProductoDAL();
        private readonly CategoriaDAL _catRepo = new CategoriaDAL();
        private readonly ProveedorDAL _provRepo = new ProveedorDAL();

        public List<Producto> Listar()
        {
            var lista = _prodRepo.GetAll();
            HydrateProductos(lista);
            return lista;
        }

        public void Agregar(Producto p)
        {
            ValidarProducto(p);

            var lista = _prodRepo.GetAll();
            p.IdProducto = lista.Count > 0 ? lista.Max(x => x.IdProducto) + 1 : 1;
            lista.Add(p);
            _prodRepo.SaveAll(lista);
        }

        public void Editar(Producto p)
        {
            ValidarProducto(p);

            var lista = _prodRepo.GetAll();
            var index = lista.FindIndex(x => x.IdProducto == p.IdProducto);
            if (index == -1) throw new Exception("Producto no encontrado.");

            lista[index] = p;
            _prodRepo.SaveAll(lista);
        }

        public void Eliminar(int id)
        {
            var lista = _prodRepo.GetAll();
            var item = lista.FirstOrDefault(x => x.IdProducto == id);
            if (item == null) throw new Exception("Producto no encontrado.");

            lista.Remove(item);
            _prodRepo.SaveAll(lista);
        }

        public List<Producto> GetStockBajo()
        {
            var lista = _prodRepo.GetAll();
            HydrateProductos(lista);
            return lista.Where(p => p.Stock < p.StockMinimo).ToList();
        }

        private void ValidarProducto(Producto p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre)) throw new Exception("El nombre es obligatorio.");
            if (p.Precio <= 0) throw new Exception("El precio debe ser mayor a cero.");
            if (p.Stock < 0) throw new Exception("El stock no puede ser negativo.");
        }

        private void HydrateProductos(List<Producto> productos)
        {
            var categorias = _catRepo.GetAll();
            var proveedores = _provRepo.GetAll();

            foreach (var p in productos)
            {
                p.Categoria = categorias.FirstOrDefault(c => c.IdCategoria == p.IdCategoria);
                p.Proveedor = proveedores.FirstOrDefault(prov => prov.IdProveedor == p.IdProveedor);
            }
        }
    }
}
