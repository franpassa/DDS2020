using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    class Evento
    {
        private int opcion;
        private DateTime fechaYhora;
        private string nombreEvento;
        private Usuario usuario;

        public Evento(int opcion, string nombre, Usuario usuario)
        {
            this.fechaYhora = DateTime.Now;
            this.Opcion = opcion;
            this.NombreEvento = nombre;
            this.Usuario = usuario;
        }

        public int Opcion { get => opcion; set => opcion = value; }
        public DateTime Fecha { get => fechaYhora; set => fechaYhora = value; }
      //  public int Hora { get => hora; set => hora = value; }
        public string NombreEvento { get => nombreEvento; set => nombreEvento = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
