using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_automóviles.Models.Classes
{
    internal class Cliente
    {
        public int? ID_cliente {  get; set; }
        public string? Nombre {  get; set; }
        public string? APaterno { get; set; }
        public string? AMaterno { get; set; }
        public string? Correo {  get; set; }
        public long? Telefono {  get; set; }
        public string? RFC {  get; set; }
        public int? CP { get; set; } 
    }
}
