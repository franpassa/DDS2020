using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    class Libre : EstadoCopia
    {
        public Libre(Copia copia)
        {
            Copia = copia;
        }

        override public void esPrestada()
        {
            Copia.cambiarEstado(new Prestada(Copia));
            Copia.FechaPrestamo = DateTime.Now;
        }
        override public void seDevuelve()
        {

        }
        override public void repararse()
        {
            Copia.cambiarEstado(new EnReparacion(Copia));
        }
    }
}
