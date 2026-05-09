using System;

namespace ENTITY
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        
        public int StockMinimo { get; set; } = 5;

        public override string ToString()
        {
            return $"{IdProducto} | {Nombre} | {Precio} | {Stock} | {Categoria?.NombreCategoria ?? "N/A"} | {Proveedor?.Nombre ?? "N/A"}";
        }
    }
}

