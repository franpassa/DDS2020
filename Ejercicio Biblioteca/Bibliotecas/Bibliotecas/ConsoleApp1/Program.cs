using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;
using System.Data.Entity;
using Bibliotecas;

namespace Bibliotecas
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                Autor autor = new Autor(1,"pepe","hoy","argentino");
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
            }
        }
    }
}
