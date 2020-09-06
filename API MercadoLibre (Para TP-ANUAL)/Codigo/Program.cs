using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace API_MercadoLibre
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ciudad caballito = new Ciudad("TUxBQkNBQjM4MDda");
            Console.WriteLine(caballito.nombre);

            Moneda moneda = new Moneda("ARS");
            Console.WriteLine(moneda.descripcion);

            Provincia capFed = new Provincia("AR-C");
            Console.WriteLine(capFed.nombre);
                        
            

            API_MercadoLibre ml = new API_MercadoLibre();
            foreach(Pais p in ml.paises)
            {
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine("ID: " + p.id);
                Console.WriteLine("Nombre pais: " + p.nombre);
                if (!p.provincias?.Any() == true)
                {
                    foreach (Provincia prov in p.provincias)
                    {
                        Console.WriteLine("________________________________________________");
                        Console.WriteLine("    ID: " + prov.id);
                        Console.WriteLine("    Nombre provincia: " + prov.nombre);

                        foreach(Ciudad ciudad in prov.ciudades)
                        {
                            Console.WriteLine("________________________");
                            Console.WriteLine("        ID: " + prov.id);
                            Console.WriteLine("        Nombre ciudad: " + prov.nombre);
                        }
                    }
                }
            }
            */

            Pais arg = new Pais("AR");
            Console.WriteLine(arg.nombre);
            Console.WriteLine(arg.provincias[0].nombre);
            Console.WriteLine(arg.moneda.descripcion);

            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("ID: " + arg.id);
            Console.WriteLine("Nombre pais: " + arg.nombre);
            foreach (Provincia prov in arg.provincias)
            {
                Console.WriteLine("________________________________________________");
                Console.WriteLine("    ID: " + prov.id);
                Console.WriteLine("    Nombre provincia: " + prov.nombre);

                foreach (Ciudad ciudad in prov.ciudades)
                {
                    Console.WriteLine("________________________");
                    Console.WriteLine("        ID: " + prov.id);
                    Console.WriteLine("        Nombre ciudad: " + prov.nombre);
                }
            }
            
            
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
