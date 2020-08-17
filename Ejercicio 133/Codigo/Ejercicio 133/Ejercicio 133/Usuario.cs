using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_133
{
    public class Usuario
    {
        float dinero;
        string ticket;

        public Usuario(float _dinero, string _ticket)
        {
            this.dinero = _dinero;
            this.ticket = _ticket;
        }

        public float Dinero { get => dinero; set => dinero = value; }
        public string Ticket { get => ticket; set => ticket = value; }

        public void ingresarDinero(Cajero _cajero)
        {
            _cajero.resultadoValidacion(dinero);
        }

        public void ingresarTicket(Cajero _cajero)
        {
            _cajero.Ticket = Ticket;
        }

        public void retirarTicket(Cajero _cajero)
        {
            Ticket = _cajero.Ticket;
        }
    }
}