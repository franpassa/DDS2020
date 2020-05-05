using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Transporte;
namespace Transporte
{
	public class Por_Distancia : TipoEnvio {

		public Por_Distancia(){

		}

		public override float costo(){

			return 1;
		}

	}

}