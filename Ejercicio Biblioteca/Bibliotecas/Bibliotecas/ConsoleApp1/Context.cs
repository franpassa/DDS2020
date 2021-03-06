﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace Bibliotecas
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class Context : DbContext
    {
        public DbSet<Autor> Autores { get; set; }

        public DbSet<Libro> Libros { get; set; }

        public DbSet<Copia> Copias { get; set; }

        public DbSet<Lector> Lectores { get; set; }

        public Context() : base("ContextDB")
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
        }
    }
}
