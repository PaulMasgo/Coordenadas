using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCords
{
    public class Coordenada
    {
        public Double Latitud { get; set; }
        public Double Longitud { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool QuiereContinuar = true;

            Console.WriteLine("Hola, ingresa coordenadas (latitud, longitud) o x para salir:");
            Console.WriteLine("Ejemplo: 12.3444,14.2333");
            List<Coordenada> CoordenadasIngresadas = new List<Coordenada>();
            while (QuiereContinuar)
            {
                String input = Console.ReadLine();
                if (input.ToLower().Equals("x"))
                {
                    QuiereContinuar = false;
                    continue;
                }
                if (input.Split(',').Length != 2)
                {
                    Console.WriteLine("Coordena no valida Ingrese nuevamente");
                    continue;
                }

                

                // todo lo que es correcto
                Double latitud;
                Double longitud;
                Coordenada miCoordenada = new Coordenada()
                {
                    Latitud = Double.TryParse(input.Split(',')[0], out latitud) ? latitud:0,
                    Longitud = Double.TryParse(input.Split(',')[1], out longitud) ? longitud : 0,
                };

                CoordenadasIngresadas.Add(miCoordenada);


            }

            int index = 1;
            Console.WriteLine("Tu has ingresado: {0} coordenadas", CoordenadasIngresadas.Count);
            Console.WriteLine("Las coordenadas ingresadas fueron:");
            foreach(Coordenada item in CoordenadasIngresadas)
            {
                Console.WriteLine(index+ "=> Latitud: " + item.Latitud + " Longitud: " + item.Longitud);
                index++;
            }
            Console.ReadKey();
        }
    }
}
