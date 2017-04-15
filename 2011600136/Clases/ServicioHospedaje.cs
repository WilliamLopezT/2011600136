using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ServicioHospedaje
    {

        public ServicioHospedaje(String nom, double facPrecio) {
            this.nombre = nom;
            this.factorPrecio = facPrecio;
        }

        public int codigo { get; set; }
        // Lavandería, Planchado, Room Service, etc.
        public String nombre { get; set; }
        // Factor que influirá en el precio final del hospedaje.
        public double factorPrecio { get; set; }

    }
}
