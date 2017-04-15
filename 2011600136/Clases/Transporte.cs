using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Transporte : ServicioTuristico
    {

        public Transporte(TipoTransporte tip, CategoriaTransporte cat, double pre) {
            this.tipoTransporte = tip;
            this.categoriaTransporte = cat;
            this.precio = pre;
        }

        public int codigo { get; set; }
        public TipoTransporte tipoTransporte { get; set; }
        public CategoriaTransporte categoriaTransporte { get; set; }
        public double precio { get; set; }
        public override double obtenerPrecio() {
            return this.precio;
        }

    }
}
