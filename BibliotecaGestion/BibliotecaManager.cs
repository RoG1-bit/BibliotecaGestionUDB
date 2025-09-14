using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGestion
{
    public static class BibliotecaManager
    {
        // Usamos listas para almacenar los datos en memoria
        public static List<Libro> Libros { get; private set; } = new List<Libro>();
        public static List<Usuario> Usuarios { get; private set; } = new List<Usuario>();
        public static List<Prestamo> Prestamos { get; private set; } = new List<Prestamo>();

        private static int proximoIdLibro = 1;
        private static int proximoIdUsuario = 1;
        private static int proximoIdPrestamo = 1;

        // Método para cargar datos de ejemplo al iniciar
        public static void CargarDatosIniciales()
        {
            // Limpiar listas para evitar duplicados si se llama varias veces
            Libros.Clear();
            Usuarios.Clear();
            Prestamos.Clear();

            // Reiniciar contadores de ID
            proximoIdLibro = 1;
            proximoIdUsuario = 1;
            proximoIdPrestamo = 1;

            // Añadir Libros
            AgregarLibro("El Gran Gatsby", "F. Scott Fitzgerald", 1925);
            AgregarLibro("Matar a un Ruiseñor", "Harper Lee", 1960);
            AgregarLibro("1984", "George Orwell", 1949);
            AgregarLibro("Orgullo y Prejuicio", "Jane Austen", 1813);

            // Añadir Usuarios
            AgregarUsuario("Juan", "Pérez", "juan.perez@email.com");
            AgregarUsuario("María", "Gómez", "maria.gomez@email.com");
            AgregarUsuario("Ana", "Torres", "ana.torres@email.com");

            // Añadir Prestamos de ejemplo
            RealizarPrestamo(1, 1); // Juan Pérez toma prestado El Gran Gatsby
            RealizarPrestamo(3, 1); // Juan Pérez toma prestado 1984
            RealizarPrestamo(1, 2); // María Gómez toma prestado El Gran Gatsby
        }


        #region Métodos CRUD para Libros

        public static void AgregarLibro(string titulo, string autor, int anio)
        {
            Libros.Add(new Libro(proximoIdLibro++, titulo, autor, anio));
        }

        public static void EditarLibro(int id, string nuevoTitulo, string nuevoAutor, int nuevoAnio)
        {
            Libro libro = Libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                libro.Titulo = nuevoTitulo;
                libro.Autor = nuevoAutor;
                libro.AnioPublicacion = nuevoAnio;
            }
        }

        public static void EliminarLibro(int id)
        {
            // También eliminamos los préstamos asociados para mantener la consistencia
            Prestamos.RemoveAll(p => p.LibroId == id);
            Libros.RemoveAll(l => l.Id == id);
        }

        #endregion

        #region Métodos CRUD para Usuarios

        public static void AgregarUsuario(string nombre, string apellido, string correo)
        {
            Usuarios.Add(new Usuario(proximoIdUsuario++, nombre, apellido, correo));
        }

        public static void EditarUsuario(int id, string nuevoNombre, string nuevoApellido, string nuevoCorreo)
        {
            Usuario usuario = Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                usuario.Nombre = nuevoNombre;
                usuario.Apellido = nuevoApellido;
                usuario.CorreoElectronico = nuevoCorreo;
            }
        }

        public static void EliminarUsuario(int id)
        {
            // También eliminamos los préstamos asociados para mantener la consistencia
            Prestamos.RemoveAll(p => p.UsuarioId == id);
            Usuarios.RemoveAll(u => u.Id == id);
        }

        #endregion

        #region Métodos para Préstamos

        public static void RealizarPrestamo(int libroId, int usuarioId)
        {
            // Validar que el libro no esté ya prestado (sin devolver)
            bool yaPrestado = Prestamos.Any(p => p.LibroId == libroId && p.FechaDevolucion == null);
            if (!yaPrestado)
            {
                Prestamos.Add(new Prestamo(proximoIdPrestamo++, libroId, usuarioId));
            }
        }

        public static bool DevolverLibro(int libroId, int usuarioId)
        {
            // Buscar el préstamo activo (sin fecha de devolución) para este libro y usuario
            Prestamo prestamo = Prestamos.FirstOrDefault(p => p.LibroId == libroId && p.UsuarioId == usuarioId && p.FechaDevolucion == null);
            
            if (prestamo != null)
            {
                prestamo.FechaDevolucion = DateTime.Now;
                return true; // Devolución exitosa
            }
            
            return false; // No se encontró el préstamo activo
        }

        public static bool DevolverLibroPorId(int prestamoId)
        {
            // Buscar el préstamo por ID
            Prestamo prestamo = Prestamos.FirstOrDefault(p => p.Id == prestamoId && p.FechaDevolucion == null);
            
            if (prestamo != null)
            {
                prestamo.FechaDevolucion = DateTime.Now;
                return true; // Devolución exitosa
            }
            
            return false; // No se encontró el préstamo o ya fue devuelto
        }

        // Método para obtener préstamos activos (no devueltos)
        public static List<Prestamo> ObtenerPrestamosActivos()
        {
            return Prestamos.Where(p => p.FechaDevolucion == null).ToList();
        }

        // Método para obtener préstamos por usuario
        public static List<Prestamo> ObtenerPrestamosPorUsuario(int usuarioId)
        {
            return Prestamos.Where(p => p.UsuarioId == usuarioId).ToList();
        }

        // Método para obtener préstamos por libro
        public static List<Prestamo> ObtenerPrestamosPorLibro(int libroId)
        {
            return Prestamos.Where(p => p.LibroId == libroId).ToList();
        }

        #endregion

        #region Métodos para Estadísticas

        // Usamos un Diccionario para devolver los resultados de los gráficos
        // La clave (string) será el nombre del libro/usuario, y el valor (int) será el conteo.
        public static Dictionary<string, int> ObtenerLibrosMasPrestados(int topN)
        {
            return Prestamos
                .GroupBy(p => p.LibroId) // Agrupar por ID de libro
                .OrderByDescending(g => g.Count()) // Ordenar por la cantidad de préstamos
                .Take(topN) // Tomar los N primeros
                .ToDictionary(g => Libros.First(l => l.Id == g.Key).Titulo, g => g.Count()); // Crear el diccionario
        }

        public static Dictionary<string, int> ObtenerUsuariosMasActivos(int topN)
        {
            return Prestamos
                .GroupBy(p => p.UsuarioId)
                .OrderByDescending(g => g.Count())
                .Take(topN)
                .ToDictionary(g => Usuarios.First(u => u.Id == g.Key).Nombre, g => g.Count());
        }

        #endregion

        #region Métodos de Búsqueda y Consulta

        // Buscar libros por título o autor
        public static List<Libro> BuscarLibros(string termino)
        {
            if (string.IsNullOrEmpty(termino))
                return Libros.ToList();

            return Libros.Where(l => 
                l.Titulo.ToLower().Contains(termino.ToLower()) || 
                l.Autor.ToLower().Contains(termino.ToLower())).ToList();
        }

        // Buscar usuarios por nombre o correo
        public static List<Usuario> BuscarUsuarios(string termino)
        {
            if (string.IsNullOrEmpty(termino))
                return Usuarios.ToList();

            return Usuarios.Where(u => 
                u.Nombre.ToLower().Contains(termino.ToLower()) || 
                u.CorreoElectronico.ToLower().Contains(termino.ToLower())).ToList();
        }

        // Obtener libro por ID
        public static Libro ObtenerLibroPorId(int id)
        {
            return Libros.FirstOrDefault(l => l.Id == id);
        }

        // Obtener usuario por ID
        public static Usuario ObtenerUsuarioPorId(int id)
        {
            return Usuarios.FirstOrDefault(u => u.Id == id);
        }

        // Obtener préstamo por ID
        public static Prestamo ObtenerPrestamoPorId(int id)
        {
            return Prestamos.FirstOrDefault(p => p.Id == id);
        }

        // Verificar si un libro está disponible para préstamo
        public static bool LibroDisponible(int libroId)
        {
            return !Prestamos.Any(p => p.LibroId == libroId && p.FechaDevolucion == null);
        }

        // Obtener libros disponibles
        public static List<Libro> ObtenerLibrosDisponibles()
        {
            var librosPrestadomIds = Prestamos
                .Where(p => p.FechaDevolucion == null)
                .Select(p => p.LibroId)
                .ToHashSet();

            return Libros.Where(l => !librosPrestadomIds.Contains(l.Id)).ToList();
        }

        // Obtener estadísticas generales
        public static Dictionary<string, int> ObtenerEstadisticasGenerales()
        {
            return new Dictionary<string, int>
            {
                {"Total Libros", Libros.Count},
                {"Total Usuarios", Usuarios.Count},
                {"Total Préstamos", Prestamos.Count},
                {"Préstamos Activos", Prestamos.Count(p => p.FechaDevolucion == null)},
                {"Libros Disponibles", ObtenerLibrosDisponibles().Count}
            };
        }

        #endregion
    }
}
