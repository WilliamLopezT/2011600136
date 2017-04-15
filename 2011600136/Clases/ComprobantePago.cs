using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ComprobantePago
    {

        public ComprobantePago(TipoComprobante tip, DateTime fec) {
            this.tipoComprobante = tip;
            this.fecha = fec;
        }

        public int codigo { get; set; }
        public TipoComprobante tipoComprobante { get; set; }
        public DateTime fecha { get; set; }
        public double monto { get; set; }

    }
}
