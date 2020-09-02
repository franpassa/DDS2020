using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public abstract class EstadoCopia
    {
        public Copia Copia { get; set; }

        public abstract void seDevuelve();
        public abstract void esPrestada();
        public abstract void repararse();
    }
}
