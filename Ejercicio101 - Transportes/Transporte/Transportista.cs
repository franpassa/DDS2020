using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Transporte;
namespace Transporte {

	public class Transportista {

		private TipoEnvio Envio;
		private Transporte.TipoEnvio TipoEnvio;

		public Transportista(){

		}

		public float calcularEnvio(){

           return this.TipoEnvio.costo();

		}

		public void setEnvio(TipoEnvio _Envio){

            this.Envio = _Envio;

		}

	}

}