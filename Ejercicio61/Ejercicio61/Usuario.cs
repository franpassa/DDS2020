using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    class Usuario
    {
        private string nombreUsuario;

        public Usuario(string nombre)
        {
            NombreUsuario = nombre;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }

        public Evento elegirOpcion()
        {
            int op = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elegir nombre del evento: ");
            string nom = Console.ReadLine();
            Evento evento = new Evento(op, nom, this);

            return evento;
        }
    }
}
