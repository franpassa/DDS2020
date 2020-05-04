
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Transporte;
namespace Transporte
{

    public class Por_Peso : TipoEnvio
    {

        public Por_Peso()
        {

        }

        public override float costo()
        {
            return 0;
        }

    }
}