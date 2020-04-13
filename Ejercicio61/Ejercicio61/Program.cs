using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario("Usuario");
            Historial historial = new Historial();
            string seguir = "y";
            while(seguir == "y") {
                Console.WriteLine("Elegir opcion: ");
                Evento evento = usuario.elegirOpcion();

                historial.agregarEvento(evento);

                Console.WriteLine("Desea elegir otra opcion? Y/N");
                seguir = Console.ReadLine();
            }
            historial.imprimirEventos();
            Console.WriteLine("\n Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
