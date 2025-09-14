using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGestion
{
    // Usuario.cs
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }

        // Constructor
        public Usuario(int id, string nombre, string apellido, string correo)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            CorreoElectronico = correo;
        }

        // Método para obtener el nombre completo
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
