using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasColeccionesInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" EL ZOO se lleno de animales en huelga ");
            Puma pm1 = new Puma();
            Console.WriteLine(" El puma es un animal que " + pm1.Ruido());

            Leon l1 = new Leon();
            Console.WriteLine(" El leon es un animal que " + l1.Ruido());
            
            Aguila a1 = new Aguila();
            Console.WriteLine(" El aguila es un animal que " + a1.Ruido());

            Canario c1 = new Canario();
            Console.WriteLine(" El canario es un animal que " + c1.Ruido());
            
            Gato g1 = new Gato();
            Console.WriteLine(" El gato es un animal que " + g1.Ruido());
            
            Perro p1 = new Perro();
            Console.WriteLine(" El perro es una animal que " + p1.Ruido());

            List<Flyable> ListaVoladores = new List<Flyable>();
            ListaVoladores.Add(new Canario());
            ListaVoladores.Add(new Aguila());

            Console.WriteLine(" La cantidad de animales voladores son " + ListaVoladores.Count);
            
            Console.ReadKey();


        }
    }
}
