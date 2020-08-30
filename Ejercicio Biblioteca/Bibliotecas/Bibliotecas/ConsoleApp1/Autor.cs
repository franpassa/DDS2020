using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bibliotecas
{
    public class Autor
    {
        public Autor(int id, string nombre, string fechaDeNacimiento, string nacionalidad)
        {
            Id = id;
            Nombre = nombre;
            FechaDeNacimiento = fechaDeNacimiento;
            Nacionalidad = nacionalidad;
        }

        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Nacionalidad { get; set; }
    }
}
