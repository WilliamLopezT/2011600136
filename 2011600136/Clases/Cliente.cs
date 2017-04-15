using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {

        public Cliente(Persona pers) {
            this.persona = pers;
        }
        
        public int codigo { get; set; }
        // Referencia a la clase persona. Evita redundancia de atributos.
        public Persona persona { get; set; }

    }
}
