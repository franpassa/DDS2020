using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    class ConRetraso : EstadoCopia
    {
        override public void esPrestada()
        {

        }
        override public void seDevuelve()
        {
            Copia.cambiarEstado(new Libre(Copia));
            Copia.FechaDevolucion = DateTime.Now;
        }
        override public void repararse()
        {
        }
    }
}
