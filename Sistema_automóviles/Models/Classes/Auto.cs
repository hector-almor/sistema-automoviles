using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_automóviles.Models.Classes
{
    public class Auto
    {
        public int? ID_auto { get; set; }
        public string? Marca {  get; set; }
        public string? Modelo { get; set; }
        public int? Año {  get; set; }
        public int? Existencia { get; set; }
        public float? Costo { get; set; }
        public float Precio { get; set; }
    }
}
