using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGestion
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int LibroId { get; set; } // Referencia al ID del libro
        public int UsuarioId { get; set; } // Referencia al ID del usuario
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; } // '?' permite que sea nulo si no se ha devuelto

        // Constructor
        public Prestamo(int id, int libroId, int usuarioId)
        {
            Id = id;
            LibroId = libroId;
            UsuarioId = usuarioId;
            FechaPrestamo = DateTime.Now; // Se asigna la fecha y hora actual
            FechaDevolucion = null; // Inicialmente nulo
        }
    }

}
