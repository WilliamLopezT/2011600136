using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public Persona(String apePat, String apeMat, String nom, char sex) {
            this.apellidoPaterno = apePat;
            this.apellidoMaterno = apeMat;
            this.nombre = nom;
            this.sexo = sex;
        }

        public int codigo { get; set; }
        public String apellidoPaterno { get; set; }
        public String apellidoMaterno { get; set; }
        public String nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String dni { get; set; }
        public char sexo { get; set; }

        public String nombreCompleto() {
            return this.apellidoPaterno + " " + this.apellidoMaterno + ", " + this.nombre;
        }

    }
}
