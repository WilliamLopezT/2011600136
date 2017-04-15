using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CalificacionHospedaje
    {

        public CalificacionHospedaje(String nom, double facPrecio) {
            this.nombre = nom;
            this.factorPrecio = facPrecio;
        }

        public int codigo { get; set; }
        public String nombre { get; set; }
        // Calificación del 1 a 5 estrellas.
        public short calificacion { get; set; }
        // Aquí se describen los requerimientos a cumplir para cada calificación.
        public String descripcion { get; set; }
        // Factor que influirá en el precio final del hospedaje.
        public double factorPrecio { get; set; }

    }
}
