using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TipoComprobante
    {

        public TipoComprobante(String nom, char abrev) {
            this.nombre = nom;
            this.abreviatura = abrev;
        }

        public int codigo { get; set; }
        public String nombre { get; set; }
        // Factura -> F / Boleta -> B
        public char abreviatura { get; set; }

    }
}
