using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using InteresesBancarios;
namespace InteresesBancarios {
	public class CajaDeAhorro : Visitable {

		private float dinero;
		public float Dinero { get => dinero; set => dinero = value; }

		public CajaDeAhorro(float _dinero)
		{
			Dinero = _dinero;
		}


		public void accept(Interés Visitor){
			Visitor.visit(this);
		}

	}//end CajaDeAhorro

}//end namespace InteresesBancarios