using System;

namespace Ejercicio_133
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario juan = new Usuario(100, "Ticket 1");
            Cajero autoMaq = new Cajero(150, "");

            juan.ingresarTicket(autoMaq);
            
            juan.ingresarDinero(autoMaq);
        }
    }
}
