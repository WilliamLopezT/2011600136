using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class VentaPaquete
    {

        public VentaPaquete(Cliente clie, Paquete paq, ComprobantePago comp, MedioPago med, Empleado emp, DateTime fec) {
            this.cliente = clie;
            this.paquete = paq;
            this.comprobantePago = comp;
            this.medioPago = med;
            this.empleado = emp;
            this.fecha = fec;
        }

        public int codigo { get; set; }
        public Cliente cliente { get; set; }
        // Se vende 1 paquete a la vez.
        public Paquete paquete { get; set; }
        public ComprobantePago comprobantePago { get; set; }
        public MedioPago medioPago { get; set; }
        // Empleado que realiza la venta.
        public Empleado empleado { get; set; }
        public DateTime fecha { get; set; }
        public double montoTotal
        {
            get
            {
                return this.paquete.calcularPrecioTotal(); ;
            }
            set
            {
                // Asignamos el mismo monto al comprobante de la venta actual.
                this.montoTotal = this.paquete.calcularPrecioTotal();
                this.comprobantePago.monto = this.paquete.calcularPrecioTotal();
            }
        }

        public String reporte() {
            String reporte = "";
            reporte += "Cliente: " + this.cliente.persona.nombreCompleto() + "\n";
            reporte += "Empleado responsable: " + this.empleado.persona.nombreCompleto() + "\n";
            reporte += "Fecha: " + this.fecha + "\n";
            reporte += "Monto Total del Paquete: S/. " + this.montoTotal + "\n";
            return reporte;
        }

    }
}
