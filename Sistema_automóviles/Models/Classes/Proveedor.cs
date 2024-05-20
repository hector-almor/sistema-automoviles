using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_automóviles.Models.Classes
{
    internal class Proveedor
    {
        public int? ID_proveedor { get; set; }
        public int? ID_auto { get; set; }
        public string? Nombre { get; set; }
        public long? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Direccion {  get; set; }

        
    }
}
