using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class MedioPago
    {

        public MedioPago(String nom, Boolean ofreceDscto) {
            this.nombre = nom;
            this.ofreceDescuento = ofreceDscto;
        }

        public int codigo { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        // Dependiendo si es crédito o al contado, puede ofrecer un descuento.
        public Boolean ofreceDescuento { get; set; }

    }
}
