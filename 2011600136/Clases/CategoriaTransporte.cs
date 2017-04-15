using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CategoriaTransporte
    {

        public CategoriaTransporte(String nom) {
            this.nombre = nom;
        }

        public int codigo { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }

    }
}
