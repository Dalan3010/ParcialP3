using System;
using System.Collections.Generic;
using System.Linq;
using ENTITY;
using DLL;

namespace BLL
{
    public class MovimientoService
    {
        private readonly MovimientoDAL _movRepo = new MovimientoDAL();
        private readonly ProductoDAL _prodRepo = new ProductoDAL();

        public List<Movimiento> Listar()
        {
            var lista = _movRepo.GetAll();
            HydrateMovimientos(lista);
            return lista;
        }

        public void Registrar(Movimiento m)
        {
            if (m.Cantidad <= 0) throw new Exception("La cantidad debe ser mayor a cero.");

            var productos = _prodRepo.GetAll();
            var prod = productos.FirstOrDefault(p => p.IdProducto == m.IdProducto);
            if (prod == null) throw new Exception("Producto no encontrado.");

            if (m.Tipo.Equals("Salida", StringComparison.OrdinalIgnoreCase))
            {
                if (prod.Stock < m.Cantidad)
                    throw new Exception($"Stock insuficiente. Disponible: {prod.Stock}");
                prod.Stock -= m.Cantidad;
            }
            else if (m.Tipo.Equals("Entrada", StringComparison.OrdinalIgnoreCase))
            {
                prod.Stock += m.Cantidad;
            }
            else
            {
                throw new Exception("El tipo de movimiento debe ser 'Entrada' o 'Salida'.");
            }

            _prodRepo.SaveAll(productos);

            var movs = _movRepo.GetAll();
            m.IdMovimiento = movs.Count > 0 ? movs.Max(x => x.IdMovimiento) + 1 : 1;
            m.Fecha = DateTime.Now;
            _movRepo.Save(m);
        }

        private void HydrateMovimientos(List<Movimiento> movimientos)
        {
            var productos = _prodRepo.GetAll();
            foreach (var m in movimientos)
            {
                m.Producto = productos.FirstOrDefault(p => p.IdProducto == m.IdProducto);
            }
        }
    }
}
