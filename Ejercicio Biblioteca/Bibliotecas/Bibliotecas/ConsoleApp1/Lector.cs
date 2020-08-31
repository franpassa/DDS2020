using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    class Lector
    {
        public Lector(int iDLector)
        {
            IDLector = iDLector;
        }

        [Key]
        public int IDLector { get; set; }
        public ICollection<Copia> Copias { get; set; }
        public int DiasDeMulta { get; set; }

        public void devolverCopia(Copia copia, Biblioteca biblioteca)
        {
            biblioteca.guardarCopia(copia, this);
            Copias.Remove(copia);
        }
        public void pedirCopia(Copia copia, Biblioteca biblioteca)
        {
            if(biblioteca.prestar(copia, this))
            {
                Copias.Add(copia);
            }
        }
        public bool estaMultado()
        {
            return DiasDeMulta > 0;
        }

    }
}
