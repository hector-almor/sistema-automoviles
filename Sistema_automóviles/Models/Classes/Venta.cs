using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_automóviles.Models.Classes
{
    internal class Venta
    {
        public int? ID_venta {  get; set; }
        public int? ID_auto { get; set; }
        public int? ID_cliente {  get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public byte? Numero_autos {  get; set; }
        public float? Precio { get; set; }
        public float? Total {  get; set; }
    }
}
