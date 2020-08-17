using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;

namespace Ejercicio_133
{
    public class Cajero
    {
        float dinero; // Dinero disponible
        string ticket;
        DateTime tiempoEntradaTicket;

        public Cajero(float _dinero, string _ticket)
        {
            this.dinero = _dinero;
            this.ticket = _ticket;
        }


        public float Dinero { get => dinero; set => dinero = value; }
        public string Ticket { get => ticket; set => ticket = value; }
        public DateTime TiempoEntradaTicket { get => tiempoEntradaTicket; set => tiempoEntradaTicket = value; }

        public float calcularImporte()
        {
            float importe = ticket.Length * 3; // Como no dice como se calcula, hicimos la longuitud del ticket * 3
            Console.WriteLine("Importe: ", importe);
            return importe;
        }

        public bool resultadoValidacion(float _dinero)
        {
            if((_dinero >= calcularImporte())          // El dinero que entra es mayor al importe
                &&     
               (calcularImporte() - _dinero >= dinero)) // Hay vuelto
            {
                Console.WriteLine("Vuelto: ", calcularImporte() - _dinero);
                return true;
            }
            else 
            if((_dinero >= calcularImporte())          // El dinero que entra es mayor al importe
                &&
               (calcularImporte() - _dinero < dinero)) // No hay vuelto
            {
                Console.WriteLine("Vuelto: 0");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
