using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGestion
{
    // Libro.cs
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }

        // Constructor por defecto
        public Libro()
        {
        }

        // Constructor para facilitar la creación de nuevos libros
        public Libro(int id, string titulo, string autor, int anio)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anio;
        }
    }
}
