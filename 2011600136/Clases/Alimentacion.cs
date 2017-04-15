using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Alimentacion : ServicioTuristico
    {

        public Alimentacion(CategoriaAlimentacion cat, double pre) {
            this.categoriaAlimentacion = cat;
            this.precio = pre;
        }

        public int codigo { get; set; }
        public CategoriaAlimentacion categoriaAlimentacion { get; set; }
        public double precio { get; set; }
        public override double obtenerPrecio() {
            return this.precio;
        }

    }
}
