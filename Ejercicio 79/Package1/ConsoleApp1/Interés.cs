using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using InteresesBancarios;
namespace InteresesBancarios {
	public class Inter�s : Visitor {

		public Inter�s(){

		}

		public void visit(CajaDeAhorro cda)
		{
			cda.Dinero += cda.Dinero * (float)0.01;
		}

		public void visit(CuentaCorriente cc)
		{
			cc.Dinero += cc.Dinero * (float)0.01;
		}

		public void visit(TarjetaDeCr�dito tdc)
		{
			tdc.Dinero += tdc.Dinero * (float)0.05;
		}


	}//end Inter�s

}//end namespace InteresesBancarios