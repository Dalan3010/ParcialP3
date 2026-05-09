using System;

namespace ENTITY
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
        
        public string Tipo { get; set; } // "Entrada" or "Salida"
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return $"{IdMovimiento} | {Producto?.Nombre ?? "N/A"} | {Tipo} | {Cantidad} | {Fecha} | {Descripcion}";
        }
    }

}
