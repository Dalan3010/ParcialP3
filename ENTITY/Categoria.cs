using System;
using System.Collections.Generic;

namespace ENTITY
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public override string ToString()
        {
            return $"{IdCategoria} | {NombreCategoria} | {Descripcion}";
        }
    }
}
