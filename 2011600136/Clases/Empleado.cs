using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empleado
    {

        public Empleado(Persona pers, double sue) {
            this.persona = pers;
            this.sueldo = sue;
        }

        public int codigo { get; set; }
        // Referencia a la clase persona. Evita redundancia de atributos.
        public Persona persona { get; set; }
        public double sueldo { get; set; }

    }
}
