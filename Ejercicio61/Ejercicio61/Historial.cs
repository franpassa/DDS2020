using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    class Historial
    {
        private List<Evento> eventos = new List<Evento>();
        private List<Usuario> usuarios = new List<Usuario>();

        public void agregarEvento(Evento evento)
        {
            if (usuarios.Count < 3)
            {
                eventos.Add(evento);
                usuarios.Add(evento.Usuario);
            } else
            {
                Console.WriteLine("Ya hay tres usuarios");
            }

        }

        public void imprimirEventos()
        {
            Console.WriteLine("\n Historial: \n");
            foreach (Evento evento in eventos)
            {
                Console.WriteLine("Opcion: {0}, Fecha y Hora: {1}, Nombre del evento: {2}, Usuario: {3}", evento.Opcion, evento.Fecha, evento.NombreEvento, evento.Usuario.NombreUsuario);
            }
        }
    }
}
