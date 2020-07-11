using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using InteresesBancarios;
namespace InteresesBancarios {
	public class CuentaCorriente : Visitable {

		private float dinero;
		public float Dinero { get => dinero; set => dinero = value; }

		public CuentaCorriente(float _dinero)
		{
			Dinero = _dinero;
		}


		public void accept(Interés Visitor){
			Visitor.visit(this);
		}

	}//end CuentaCorriente

}//end namespace InteresesBancarios