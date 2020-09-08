﻿///////////////////////////////////////////////////////////
//  Ciudad.cs
//  Implementation of the Class Ciudad
//  Generated by Enterprise Architect
//  Created on:      04-Sep-2020 11:29:28 PM
//  Original author: Ignacio Andre Keiniger
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Linq;
using API_MercadoLibre;

namespace API_MercadoLibre {
	public class Ciudad {

		public String id;
		public String nombre;

		public Ciudad(String _id){
			WebRequest request_ciudad = HttpWebRequest.Create("https://api.mercadolibre.com/classified_locations/cities/" + _id);
			bool leidoCorrectamente = true;
			try
			{
				request_ciudad.GetResponse();
			}
			catch (System.Net.WebException e)
			{
				Console.WriteLine("{0} Exception caught.", e);
				Console.WriteLine("Id de ciudad " + _id + " erroneo.");
				leidoCorrectamente = false;
			}
			if (leidoCorrectamente)
			{
				WebResponse response_ciudad = request_ciudad.GetResponse();
				StreamReader reader_ciudad = new StreamReader(response_ciudad.GetResponseStream());

				// Guardo el JSON leido en un objeto
				string objetoJSON_ciudad = reader_ciudad.ReadToEnd();
				ML_City ML_CityObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ML_City>(objetoJSON_ciudad);

				id = ML_CityObject.id;
				nombre = ML_CityObject.name;

				this.imprimir();
			}
		}

		public void imprimir()
        {
			Console.WriteLine();
			Console.WriteLine("			ID: " + id);
			Console.WriteLine("			Nombre ciudad: " + nombre);
		}
	}
}