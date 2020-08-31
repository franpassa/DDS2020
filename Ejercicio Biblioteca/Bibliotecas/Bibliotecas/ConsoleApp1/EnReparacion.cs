using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    class EnReparacion : EstadoCopia
    {
        public EnReparacion(Copia copia)
        {
            Copia = copia;
        }

        override public void esPrestada()
        {

        }
        override public void seDevuelve()
        {

        }
        override public void repararse()
        {
        }
    }
}
