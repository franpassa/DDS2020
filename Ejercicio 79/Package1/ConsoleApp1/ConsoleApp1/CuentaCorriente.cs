///////////////////////////////////////////////////////////
//  CuentaCorriente.cs
//  Implementation of the Class CuentaCorriente
//  Generated by Enterprise Architect
//  Created on:      11-Jul-2020 6:44:33 PM
//  Original author: Fenjer
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using InteresesBancarios;
namespace InteresesBancarios {
	public class CuentaCorriente : Visitable {

		private float dinero;

		public CuentaCorriente(float _dinero)
		{
			dinero = _dinero;
		}

		public void accept(Visitor Visitor){

		}

	}//end CuentaCorriente

}//end namespace InteresesBancarios