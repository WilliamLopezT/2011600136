using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos
{
    class Programa
    {
        static void Main(string[] args) {
            // Creamos instancias de las distintas clases.
            Persona persona1 = new Persona("López","Tello","Willie",'M');
            Persona persona2 = new Persona("García", "Fuentes", "Oscar", 'M');
            Persona persona3 = new Persona("Estrada", "Arias", "Nicole", 'F');
            Persona persona4 = new Persona("Cruz", "Calle", "Wendy", 'F');

            Cliente cliente1 = new Cliente(persona1);
            Cliente cliente2 = new Cliente(persona3);
            Empleado empleado1 = new Empleado(persona2, 2800);
            Empleado empleado2 = new Empleado(persona4, 3500);

            TipoHospedaje tipoHospedaje1 = new TipoHospedaje("Hotel", 1.12);
            TipoHospedaje tipoHospedaje2 = new TipoHospedaje("Hostal", 1.08);
            TipoHospedaje tipoHospedaje3 = new TipoHospedaje("Backpacker", 1.06);

            CalificacionHospedaje calificacionHospedaje1 = new CalificacionHospedaje("1 Estrella", 1.05);
            CalificacionHospedaje calificacionHospedaje2 = new CalificacionHospedaje("2 Estrellas", 1.06);
            CalificacionHospedaje calificacionHospedaje3 = new CalificacionHospedaje("3 Estrellas", 1.07);
            CalificacionHospedaje calificacionHospedaje4 = new CalificacionHospedaje("4 Estrellas", 1.09);
            CalificacionHospedaje calificacionHospedaje5 = new CalificacionHospedaje("5 Estrellas", 1.12);

            CategoriaHospedaje categoriaHospedaje1 = new CategoriaHospedaje("Básico", 1.04);
            CategoriaHospedaje categoriaHospedaje2 = new CategoriaHospedaje("Normal", 1.07);
            CategoriaHospedaje categoriaHospedaje3 = new CategoriaHospedaje("VIP", 1.10);

            ServicioHospedaje servicioHospedaje1 = new ServicioHospedaje("Lavandería", 1.05);
            ServicioHospedaje servicioHospedaje2 = new ServicioHospedaje("Planchado", 1.08);
            ServicioHospedaje servicioHospedaje3 = new ServicioHospedaje("Room Service", 1.11);

            List<ServicioHospedaje> servs1 = new List<ServicioHospedaje>();
            servs1.Add(servicioHospedaje1);
            servs1.Add(servicioHospedaje3);

            List<ServicioHospedaje> servs2 = new List<ServicioHospedaje>();
            servs2.Add(servicioHospedaje1);
            servs2.Add(servicioHospedaje2);
            servs2.Add(servicioHospedaje3);

            Hospedaje hospedaje1 = new Hospedaje(tipoHospedaje2, calificacionHospedaje3, categoriaHospedaje2, servs1);
            Hospedaje hospedaje2 = new Hospedaje(tipoHospedaje1, calificacionHospedaje5, categoriaHospedaje3, servs2);

            TipoTransporte tipoTransporte1 = new TipoTransporte("Aéreo");
            TipoTransporte tipoTransporte2 = new TipoTransporte("Terrestre");
            TipoTransporte tipoTransporte3 = new TipoTransporte("Acuático");

            CategoriaTransporte categoriaTransporte1 = new CategoriaTransporte("Regular");
            CategoriaTransporte categoriaTransporte2 = new CategoriaTransporte("Expreso");

            Transporte transporte1 = new Transporte(tipoTransporte1,categoriaTransporte1, 350);
            Transporte transporte2 = new Transporte(tipoTransporte1, categoriaTransporte2, 380);
            Transporte transporte3 = new Transporte(tipoTransporte2, categoriaTransporte1, 120);
            Transporte transporte4 = new Transporte(tipoTransporte2, categoriaTransporte2, 150);
            Transporte transporte5 = new Transporte(tipoTransporte3, categoriaTransporte1, 180);
            Transporte transporte6 = new Transporte(tipoTransporte3, categoriaTransporte2, 210);

            CategoriaAlimentacion categoriaAlimentacion1 = new CategoriaAlimentacion("Vegetariana");
            CategoriaAlimentacion categoriaAlimentacion2 = new CategoriaAlimentacion("Regular");

            Alimentacion alimentacion1 = new Alimentacion(categoriaAlimentacion1, 45);
            Alimentacion alimentacion2 = new Alimentacion(categoriaAlimentacion2, 60);

            TipoComprobante tipoComprobante1 = new TipoComprobante("Boleta",'B');
            TipoComprobante tipoComprobante2 = new TipoComprobante("Factura", 'F');

            ComprobantePago comprobantePago1 = new ComprobantePago(tipoComprobante1, new DateTime(2017, 4, 10));
            ComprobantePago comprobantePago2 = new ComprobantePago(tipoComprobante2, new DateTime(2017, 4, 12));
            ComprobantePago comprobantePago3 = new ComprobantePago(tipoComprobante2, new DateTime(2017, 4, 13));

            MedioPago medioPago1 = new MedioPago("Contado", true);
            MedioPago medioPago2 = new MedioPago("Crédito", false);

            List<ServicioTuristico> servsTur1 = new List<ServicioTuristico>();
            servsTur1.Add(alimentacion1);
            servsTur1.Add(transporte3);
            servsTur1.Add(hospedaje2);

            List<ServicioTuristico> servsTur2 = new List<ServicioTuristico>();
            servsTur2.Add(alimentacion2);
            servsTur2.Add(transporte5);
            servsTur2.Add(hospedaje2);

            List<ServicioTuristico> servsTur3 = new List<ServicioTuristico>();
            servsTur3.Add(alimentacion2);
            servsTur3.Add(transporte1);
            servsTur3.Add(hospedaje2);

            Paquete paquete1 = new Paquete(servsTur1);
            Paquete paquete2 = new Paquete(servsTur2);
            Paquete paquete3 = new Paquete(servsTur3);

            VentaPaquete ventaPaquete1 = new VentaPaquete(cliente1, paquete1, comprobantePago2, medioPago1, empleado2, new DateTime(2017, 4, 12));
            VentaPaquete ventaPaquete2 = new VentaPaquete(cliente2, paquete3, comprobantePago1, medioPago1, empleado2, new DateTime(2017, 4, 10));
            VentaPaquete ventaPaquete3 = new VentaPaquete(cliente1, paquete2, comprobantePago3, medioPago2, empleado1, new DateTime(2017, 4, 13));

            List<VentaPaquete> listaVentas = new List<VentaPaquete>();
            listaVentas.Add(ventaPaquete1);
            listaVentas.Add(ventaPaquete2);
            listaVentas.Add(ventaPaquete3);

            foreach (VentaPaquete venPq in listaVentas) {
                Console.WriteLine(venPq.reporte());
            }

            Console.ReadLine(); // Simulamos una pausa en la ejecución.

        }
    }
}
