using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Copia
    {
        public Copia(int identificador, Libro libro)
        {
            Identificador = identificador;
            Libro = libro;
            IDLibro = libro.Id_libro;
        }

        [Key]
        public int Identificador { get; set; }

        [ForeignKey("Libro")]
        public int IDLibro { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaPrestamo { get; set; }
        private EstadoCopia EstadoCopia { get; set; }

        public void esPrestada()
        {
            EstadoCopia.esPrestada();
        }
        public void seDevuelve()
        {
            EstadoCopia.seDevuelve();
        }
        public void cambiarEstado(EstadoCopia estado)
        {
            EstadoCopia = estado;
        }

        public void repararse()
        {
            EstadoCopia.repararse();
        }
    }
}
