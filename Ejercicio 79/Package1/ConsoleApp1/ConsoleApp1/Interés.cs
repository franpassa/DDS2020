using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using InteresesBancarios;
namespace InteresesBancarios {
	public class Interés : Visitor {

		public Interés(){

		}

		public void visit(CajaDeAhorro cda)
		{
			cda.Dinero += cda.Dinero * (float)0.01;
		}

		public void visit(CuentaCorriente cc)
		{
			cc.Dinero += cc.Dinero * (float)0.01;
		}

		public void visit(TarjetaDeCrédito tdc)
		{
			tdc.Dinero += tdc.Dinero * (float)0.05;
		}


	}//end Interés

}//end namespace InteresesBancarios