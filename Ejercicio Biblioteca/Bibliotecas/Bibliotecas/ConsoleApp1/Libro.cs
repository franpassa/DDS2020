using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliotecas
{
    public class Libro
    {
        public Libro(int id_libro, Autor autor, string categoria, string editorial, string nombre)
        {
            Id_libro = id_libro;
            Autor = autor;
            Categoria = categoria;
            Editorial = editorial;
            Nombre = nombre;
            IDAutor = autor.Id;
        }

        [Key]
        public int Id_libro { get; set; }

        [ForeignKey("Autor")]
        public int IDAutor { get; set; }
        public Autor Autor { get; set; }
        public string Categoria { get; set; }
        public string Editorial { get; set; }
        public string Nombre { get; set; }
    }
}
