using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using InteresesBancarios;
namespace InteresesBancarios {
	public class TarjetaDeCr�dito : Visitable {

		private float dinero;
		public float Dinero { get => dinero; set => dinero = value; }

		public TarjetaDeCr�dito(float _dinero){
			Dinero = _dinero;
		}


		public void accept(Inter�s Visitor){
			Visitor.visit(this);
		}

	}//end TarjetaDeCr�dito

}//end namespace InteresesBancarios