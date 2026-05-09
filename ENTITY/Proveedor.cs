using System;
using System.Collections.Generic;

namespace ENTITY
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public override string ToString()
        {
            return $"{IdProveedor} | {Nombre} | {Contacto} | {Telefono} | {Email}";
        }
    }
}
