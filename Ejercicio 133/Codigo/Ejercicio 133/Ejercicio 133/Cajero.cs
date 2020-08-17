using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;

namespace Ejercicio_133
{
    public class Cajero
    {
        float dinero; // Dinero disponible
        float precioPorHora;
        bool hayCambio = true;

        public Cajero(float dinero, bool hayCambio, float precioPorHora)
        {
            this.dinero = dinero;
            this.HayCambio = hayCambio;
            this.precioPorHora = precioPorHora;
        }


        public float Dinero { get => dinero; set => dinero = value; }
        public float PrecioPorHora { get => precioPorHora; set => precioPorHora = value; }
        public bool HayCambio { get => hayCambio; set => hayCambio = value; }

        public float calcularImporte( DateTime horaTicket)
        {
            DateTime horaActual = DateTime.Now;
            int horas = horaActual.Hour - horaTicket.Hour;
            int minutos = horaActual.Minute - horaTicket.Minute;
            float tiempoEstacionado = horas + minutos * (1/60);
            return tiempoEstacionado * PrecioPorHora;
        }

        public void cobrar(float importe, float dineroIngresado)
        {
                Dinero += dineroIngresado;

            if (dineroIngresado > importe)
            {
                if (HayCambio)
                {
                    Dinero -= (dineroIngresado - importe);
                }
            }

            verificarEstadoTicket();
        }

        public void verificarEstadoTicket()
        {
            //interaccion con hw del cajero (sensor del ticket por ej)
            //verifica si el ticket esta en el cajero, lo retiene de ser necesario y emite pitido
        }
    }
}
