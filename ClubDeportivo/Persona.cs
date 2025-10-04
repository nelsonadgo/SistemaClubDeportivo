using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class Persona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Tipo { get; set; }
        public int Documento { get; set; }
        public int Telefono { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}, {Tipo} - {Documento}, Teléfono: {Telefono}, Email: {Email}";
        }
    }
}
