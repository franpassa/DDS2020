using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;
using System.Data.Entity;
using Bibliotecas;
using System.Data.SqlClient;

namespace Bibliotecas
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                Autor autor = new Autor(1,"lucas","hoy","argentino");
                context.Autores.Add(autor);
                if (context.SaveChanges() > 0)
                {
                    Console.WriteLine("Nuevo Autor Creado");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error creando el Autor");
                }

                Libro caperucita = new Libro(1, autor, "infantil", "pepito", "blancanieves");
                context.Libros.Add(caperucita);
                if (context.SaveChanges() > 0)
                {
                    Console.WriteLine("Nuevo Libro Creado");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error creando el Libro");
                }


                Copia copiaCaperucita = new Copia(1, caperucita) ;
                context.Copias.Add(copiaCaperucita);
                if (context.SaveChanges() > 0)
                {
                    Console.WriteLine("Nuevo Copia Creada");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error creando la Copia");
                }

                Lector franco = new Lector(1);
                context.Lectores.Add(franco);
                if (context.SaveChanges() > 0)
                {
                    Console.WriteLine("Nuevo Lector Creado");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error creando el Lector");
                }
                /*
                foreach(Autor autorquery in autores)
                {
                    Console.WriteLine(autorquery.Nombre);
                }

                Console.ReadLine();
                */
            }
        }
    }
}
