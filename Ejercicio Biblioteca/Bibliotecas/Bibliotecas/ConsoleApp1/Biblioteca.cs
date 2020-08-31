using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    class Biblioteca
    {
        private List<Copia> copias;
        private List<Lector> lectores;

        public Biblioteca(List<Copia> copias, List<Lector> lectores)
        {
            this.copias = copias;
            this.lectores = lectores;
        }

        public List<Lector> Lectores { get => lectores; set => lectores = value; }
        public List<Copia> Copias { get => copias; set => copias = value; }

        public bool prestar(Copia copia, Lector lector)
        {
            if (!lector.estaMultado() && lector.Copias.Count()<3)
            {
                copia.esPrestada();
                return true;
            }
            return false;
        }

        public void multarLector(Lector lector, int diasMulta)
        {
            lector.DiasDeMulta += diasMulta;
        }

        public void guardarCopia(Copia copia, Lector lector)
        {
            copia.seDevuelve();


            if(copia.FechaPrestamo.AddDays(30) < copia.FechaDevolucion)
            {
                int diasMulta = copia.FechaDevolucion.Subtract(copia.FechaPrestamo).Days;
                multarLector(lector, diasMulta*2);
            }
        }

        public void repararCopia(Copia copia)
        {
            copia.repararse();
        }
    }
}
