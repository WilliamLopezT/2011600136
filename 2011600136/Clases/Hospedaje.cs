using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Hospedaje : ServicioTuristico
    {

        public Hospedaje(TipoHospedaje tip, CalificacionHospedaje cal, CategoriaHospedaje cat, List<ServicioHospedaje> servs) {
            this.tipoHospedaje = tip;
            this.calificacionHospedaje = cal;
            this.categoriaHospedaje = cat;
            this._ServiciosHospedaje = servs;
        }

        public int codigo { get; set; }
        public TipoHospedaje tipoHospedaje { get; set; }
        public CalificacionHospedaje calificacionHospedaje { get; set; }
        public CategoriaHospedaje categoriaHospedaje { get; set; }

        // Pueden ofrecerse 1 o más servicios dentro del hospedaje.
        private List<ServicioHospedaje> _ServiciosHospedaje;
        public List<ServicioHospedaje> ServiciosHospedaje {
            get { return _ServiciosHospedaje; }
            set { _ServiciosHospedaje = ServiciosHospedaje; }
        }

        public double precioFinal { get; set; }

        public double PrecioFinal {
            set {
                double factorPrecioServicios = 1;
                foreach (ServicioHospedaje ser in this.ServiciosHospedaje)
                {
                    factorPrecioServicios *= ser.factorPrecio;
                }
                precioFinal = this.tipoHospedaje.factorPrecio * this.calificacionHospedaje.factorPrecio * this.categoriaHospedaje.factorPrecio * factorPrecioServicios;
            }
        }

        // Función sobreescrita en base a la clase padre 'ServicioTuristico'.
        public override double obtenerPrecio() {
            return this.precioFinal;
        }

    }
}
