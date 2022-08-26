using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasColeccionesInterfaz
{
    class Canario : Domesticados, Flyable
    {
        public string Ruido()
        {
            return " que realiza sonidos de frecuencias agudas altas";
        }

        public string Volar()
        {
            return " este canario por lo general lo tienen en una jaula ";
        }
    }
}
