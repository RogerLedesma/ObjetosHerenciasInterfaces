using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasColeccionesInterfaz
{
    class Aguila : Salvajes, Flyable
    {
        public string Ruido()
        {
            return " emite sonidos agudos en las alturas";
        }

        public string Volar()
        {
            return " Este aguila es un animal volador";
        }
    }
}
