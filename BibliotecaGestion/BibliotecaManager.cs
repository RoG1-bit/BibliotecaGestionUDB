using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGestion
{
    public static class BibliotecaManager
    {
        // Evento para notificar cambios en los datos
        public static event EventHandler DatosActualizados;

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

            // Añadir Libros - Colección ampliada con 16 libros populares
            AgregarLibro("El Gran Gatsby", "F. Scott Fitzgerald", 1925);
            AgregarLibro("Matar a un Ruiseñor", "Harper Lee", 1960);
            AgregarLibro("1984", "George Orwell", 1949);
            AgregarLibro("Orgullo y Prejuicio", "Jane Austen", 1813);
            AgregarLibro("Cien Años de Soledad", "Gabriel García Márquez", 1967);
            AgregarLibro("Don Quijote", "Miguel de Cervantes", 1605);
            AgregarLibro("El Señor de los Anillos", "J.R.R. Tolkien", 1954);
            AgregarLibro("Harry Potter y la Piedra Filosofal", "J.K. Rowling", 1997);
            AgregarLibro("El Código Da Vinci", "Dan Brown", 2003);
            AgregarLibro("Los Juegos del Hambre", "Suzanne Collins", 2008);
            AgregarLibro("Crimen y Castigo", "Fyodor Dostoevsky", 1866);
            AgregarLibro("El Hobbit", "J.R.R. Tolkien", 1937);
            AgregarLibro("Rebelión en la Granja", "George Orwell", 1945);
            AgregarLibro("El Alquimista", "Paulo Coelho", 1988);
            AgregarLibro("La Sombra del Viento", "Carlos Ruiz Zafón", 2001);
            AgregarLibro("Cincuenta Sombras de Grey", "E.L. James", 2011);

            // Añadir Usuarios - Colección ampliada con 12 usuarios
            AgregarUsuario("Juan", "Pérez", "juan.perez@email.com");
            AgregarUsuario("María", "Gómez", "maria.gomez@email.com");
            AgregarUsuario("Ana", "Torres", "ana.torres@email.com");
            AgregarUsuario("Carlos", "López", "carlos.lopez@email.com");
            AgregarUsuario("Sofia", "Martínez", "sofia.martinez@email.com");
            AgregarUsuario("Diego", "Rodríguez", "diego.rodriguez@email.com");
            AgregarUsuario("Isabella", "Fernández", "isabella.fernandez@email.com");
            AgregarUsuario("Alejandro", "González", "alejandro.gonzalez@email.com");
            AgregarUsuario("Valentina", "Herrera", "valentina.herrera@email.com");
            AgregarUsuario("Santiago", "Ruiz", "santiago.ruiz@email.com");
            AgregarUsuario("Camila", "Jiménez", "camila.jimenez@email.com");
            AgregarUsuario("Sebastián", "Morales", "sebastian.morales@email.com");

            // Crear datos históricos y actuales
            CrearHistorialPrestamos();
        }

        private static void CrearHistorialPrestamos()
        {
            DateTime fechaActual = DateTime.Now;
            DateTime inicioMesActual = new DateTime(fechaActual.Year, fechaActual.Month, 1);
            
            // ====== PRÉSTAMOS DE SEPTIEMBRE 2024 (HISTORIAL) ======
            DateTime inicioSeptiembre = new DateTime(2024, 9, 1);
            DateTime finSeptiembre = new DateTime(2024, 9, 30);
            
            // Préstamos de septiembre - estos mantienen el historial permanente
            CrearPrestamoConFecha(1, 1, inicioSeptiembre.AddDays(2), inicioSeptiembre.AddDays(15)); // El Gran Gatsby - Juan
            CrearPrestamoConFecha(7, 2, inicioSeptiembre.AddDays(3), inicioSeptiembre.AddDays(18)); // El Señor de los Anillos - María
            CrearPrestamoConFecha(8, 3, inicioSeptiembre.AddDays(5), inicioSeptiembre.AddDays(20)); // Harry Potter - Ana
            CrearPrestamoConFecha(1, 4, inicioSeptiembre.AddDays(7), inicioSeptiembre.AddDays(22)); // El Gran Gatsby - Carlos (segundo préstamo)
            CrearPrestamoConFecha(9, 5, inicioSeptiembre.AddDays(8), inicioSeptiembre.AddDays(25)); // El Código Da Vinci - Sofia
            CrearPrestamoConFecha(10, 6, inicioSeptiembre.AddDays(10), inicioSeptiembre.AddDays(27)); // Los Juegos del Hambre - Diego
            CrearPrestamoConFecha(7, 7, inicioSeptiembre.AddDays(12), null); // El Señor de los Anillos - Isabella (aún prestado)
            CrearPrestamoConFecha(2, 8, inicioSeptiembre.AddDays(14), inicioSeptiembre.AddDays(28)); // Matar a un Ruiseñor - Alejandro
            CrearPrestamoConFecha(8, 9, inicioSeptiembre.AddDays(16), null); // Harry Potter - Valentina (aún prestado)
            CrearPrestamoConFecha(11, 10, inicioSeptiembre.AddDays(18), inicioSeptiembre.AddDays(29)); // Crimen y Castigo - Santiago
            CrearPrestamoConFecha(1, 11, inicioSeptiembre.AddDays(20), null); // El Gran Gatsby - Camila (tercer préstamo, aún prestado)
            CrearPrestamoConFecha(12, 12, inicioSeptiembre.AddDays(22), inicioSeptiembre.AddDays(30)); // El Hobbit - Sebastián

            // ====== PRÉSTAMOS DE OCTUBRE 2024 (MES ANTERIOR) ======
            DateTime inicioOctubre = new DateTime(2024, 10, 1);
            DateTime finOctubre = new DateTime(2024, 10, 31);
            
            CrearPrestamoConFecha(3, 1, inicioOctubre.AddDays(1), inicioOctubre.AddDays(16)); // 1984 - Juan
            CrearPrestamoConFecha(14, 2, inicioOctubre.AddDays(3), inicioOctubre.AddDays(18)); // El Alquimista - María
            CrearPrestamoConFecha(15, 3, inicioOctubre.AddDays(5), inicioOctubre.AddDays(20)); // La Sombra del Viento - Ana
            CrearPrestamoConFecha(4, 4, inicioOctubre.AddDays(8), inicioOctubre.AddDays(23)); // Orgullo y Prejuicio - Carlos
            CrearPrestamoConFecha(13, 5, inicioOctubre.AddDays(10), null); // Rebelión en la Granja - Sofia (aún prestado)

            // ====== PRÉSTAMOS DEL MES ACTUAL ======
            // Algunos préstamos del mes actual para mostrar actividad
            CrearPrestamoConFecha(5, 6, inicioMesActual.AddDays(2), null); // Cien Años de Soledad - Diego
            CrearPrestamoConFecha(6, 7, inicioMesActual.AddDays(4), null); // Don Quijote - Isabella
            CrearPrestamoConFecha(16, 8, inicioMesActual.AddDays(6), null); // Cincuenta Sombras - Alejandro
            CrearPrestamoConFecha(9, 9, inicioMesActual.AddDays(8), inicioMesActual.AddDays(15)); // El Código Da Vinci - Valentina
            CrearPrestamoConFecha(10, 10, inicioMesActual.AddDays(10), null); // Los Juegos del Hambre - Santiago
            CrearPrestamoConFecha(11, 11, inicioMesActual.AddDays(12), null); // Crimen y Castigo - Camila
            CrearPrestamoConFecha(12, 12, inicioMesActual.AddDays(14), null); // El Hobbit - Sebastián
            CrearPrestamoConFecha(1, 1, inicioMesActual.AddDays(16), null); // El Gran Gatsby - Juan (cuarto préstamo)
        }

        private static void CrearPrestamoConFecha(int libroId, int usuarioId, DateTime fechaPrestamo, DateTime? fechaDevolucion)
        {
            var prestamo = new Prestamo(proximoIdPrestamo++, libroId, usuarioId)
            {
                FechaPrestamo = fechaPrestamo,
                FechaDevolucion = fechaDevolucion
            };
            Prestamos.Add(prestamo);
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
            NotificarCambios(); // Notificar cambio
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
            NotificarCambios();
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
                NotificarCambios(); // Notificar cambio
            }
        }

        public static bool DevolverLibro(int libroId, int usuarioId)
        {
            // Buscar el préstamo activo (sin fecha de devolución) para este libro y usuario
            Prestamo prestamo = Prestamos.FirstOrDefault(p => p.LibroId == libroId && p.UsuarioId == usuarioId && p.FechaDevolucion == null);
            
            if (prestamo != null)
            {
                prestamo.FechaDevolucion = DateTime.Now;
                NotificarCambios(); // Notificar cambio
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
                NotificarCambios(); // Notificar cambio
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

        #region Métodos para Estadísticas Avanzadas

        // Obtener libros más prestados en el mes actual
        public static Dictionary<string, int> ObtenerLibrosMasPrestadosEnMes(int topN)
        {
            var inicioMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);

            return Prestamos
                .Where(p => p.FechaPrestamo >= inicioMes && p.FechaPrestamo <= finMes)
                .GroupBy(p => p.LibroId)
                .OrderByDescending(g => g.Count())
                .Take(topN)
                .ToDictionary(g => {
                    var libro = Libros.FirstOrDefault(l => l.Id == g.Key);
                    return libro?.Titulo ?? "Libro desconocido";
                }, g => g.Count());
        }

        // Obtener libros más prestados en un mes específico (MANTIENE HISTORIAL PERMANENTE)
        public static Dictionary<string, int> ObtenerLibrosMasPrestadosEnMesEspecifico(int año, int mes, int topN)
        {
            try
            {
                var inicioMes = new DateTime(año, mes, 1);
                var finMes = inicioMes.AddMonths(1).AddDays(-1);

                if (Prestamos == null || !Prestamos.Any())
                {
                    return new Dictionary<string, int>();
                }

                var resultado = Prestamos
                    .Where(p => p != null && p.FechaPrestamo >= inicioMes && p.FechaPrestamo <= finMes)
                    .GroupBy(p => p.LibroId)
                    .OrderByDescending(g => g.Count())
                    .Take(topN)
                    .ToDictionary(g => {
                        var libro = Libros?.FirstOrDefault(l => l != null && l.Id == g.Key);
                        return libro?.Titulo ?? $"Libro ID {g.Key}";
                    }, g => g.Count());

                return resultado ?? new Dictionary<string, int>();
            }
            catch (Exception)
            {
                return new Dictionary<string, int>();
            }
        }

        // Obtener libros más prestados en septiembre 2024 (historial permanente)
        public static Dictionary<string, int> ObtenerLibrosMasPrestadosEnSeptiembre(int topN)
        {
            return ObtenerLibrosMasPrestadosEnMesEspecifico(2024, 9, topN);
        }

        // Obtener todos los préstamos realizados en un mes específico
        public static List<Prestamo> ObtenerPrestamosDelMes(int año, int mes)
        {
            var inicioMes = new DateTime(año, mes, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);

            return Prestamos
                .Where(p => p.FechaPrestamo >= inicioMes && p.FechaPrestamo <= finMes)
                .OrderBy(p => p.FechaPrestamo)
                .ToList();
        }

        // Obtener estadísticas históricas por meses
        public static Dictionary<string, Dictionary<string, int>> ObtenerEstadisticasPorMeses()
        {
            var estadisticas = new Dictionary<string, Dictionary<string, int>>();
            
            // Obtener todos los meses que tienen préstamos
            var mesesConPrestamos = Prestamos
                .Select(p => new { Año = p.FechaPrestamo.Year, Mes = p.FechaPrestamo.Month })
                .Distinct()
                .OrderByDescending(m => m.Año)
                .ThenByDescending(m => m.Mes);

            foreach (var periodo in mesesConPrestamos)
            {
                string nombreMes = $"{ObtenerNombreMes(periodo.Mes)} {periodo.Año}";
                estadisticas[nombreMes] = ObtenerLibrosMasPrestadosEnMesEspecifico(periodo.Año, periodo.Mes, 5);
            }

            return estadisticas;
        }

        private static string ObtenerNombreMes(int numeroMes)
        {
            string[] meses = { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                              "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return meses[numeroMes];
        }

        // Obtener usuarios con más libros prestados actualmente (sin devolver)
        public static Dictionary<string, int> ObtenerUsuariosConMasLibrosPrestados(int topN)
        {
            return Prestamos
                .Where(p => p.FechaDevolucion == null) // Solo préstamos activos
                .GroupBy(p => p.UsuarioId)
                .OrderByDescending(g => g.Count())
                .Take(topN)
                .ToDictionary(g => {
                    var usuario = Usuarios.FirstOrDefault(u => u.Id == g.Key);
                    return usuario?.NombreCompleto ?? "Usuario desconocido";
                }, g => g.Count());
        }

        // Método para obtener estadísticas del mes actual
        public static Dictionary<string, int> ObtenerEstadisticasDelMes()
        {
            var inicioMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);

            var prestamosDelMes = Prestamos.Where(p => p.FechaPrestamo >= inicioMes && p.FechaPrestamo <= finMes);
            var devolucionesDelMes = Prestamos.Where(p => p.FechaDevolucion.HasValue && 
                p.FechaDevolucion.Value >= inicioMes && p.FechaDevolucion.Value <= finMes);

            return new Dictionary<string, int>
            {
                {"Préstamos del Mes", prestamosDelMes.Count()},
                {"Devoluciones del Mes", devolucionesDelMes.Count()},
                {"Préstamos Activos", Prestamos.Count(p => p.FechaDevolucion == null)},
                {"Libros Más Prestados en Septiembre", ObtenerLibrosMasPrestadosEnSeptiembre(1).Values.FirstOrDefault()}
            };
        }

        // Obtener libros más prestados de todos los tiempos (historial completo)
        public static Dictionary<string, int> ObtenerLibrosMasPrestadosHistorial(int topN)
        {
            try
            {
                if (Prestamos == null || !Prestamos.Any())
                {
                    return new Dictionary<string, int>();
                }

                var resultado = Prestamos
                    .GroupBy(p => p.LibroId) // Agrupar por ID de libro
                    .OrderByDescending(g => g.Count()) // Ordenar por cantidad total de préstamos
                    .Take(topN) // Tomar los N primeros
                    .ToDictionary(g => {
                        var libro = Libros?.FirstOrDefault(l => l != null && l.Id == g.Key);
                        return libro?.Titulo ?? $"Libro ID {g.Key}";
                    }, g => g.Count()); // Contar TODOS los préstamos del libro

                return resultado ?? new Dictionary<string, int>();
            }
            catch (Exception)
            {
                return new Dictionary<string, int>();
            }
        }

        #endregion

        // Método de diagnóstico para verificar el estado de los datos
        public static string DiagnosticarEstado()
        {
            var diagnostico = new StringBuilder();
            diagnostico.AppendLine("=== DIAGNÓSTICO DEL SISTEMA ===");
            
            try
            {
                diagnostico.AppendLine($"📚 Libros registrados: {Libros?.Count ?? 0}");
                diagnostico.AppendLine($"👥 Usuarios registrados: {Usuarios?.Count ?? 0}");
                diagnostico.AppendLine($"📋 Préstamos totales: {Prestamos?.Count ?? 0}");
                
                if (Prestamos != null && Prestamos.Any())
                {
                    var prestamosActivos = Prestamos.Count(p => p.FechaDevolucion == null);
                    var prestamosSeptiembre = Prestamos.Count(p => p.FechaPrestamo.Year == 2024 && p.FechaPrestamo.Month == 9);
                    var prestamosMesActual = Prestamos.Count(p => p.FechaPrestamo.Year == DateTime.Now.Year && p.FechaPrestamo.Month == DateTime.Now.Month);
                    
                    diagnostico.AppendLine($"📈 Préstamos activos: {prestamosActivos}");
                    diagnostico.AppendLine($"🗓️ Préstamos de septiembre 2024: {prestamosSeptiembre}");
                    diagnostico.AppendLine($"📅 Préstamos del mes actual: {prestamosMesActual}");
                }
                
                diagnostico.AppendLine($"✅ Estado: Sistema operativo");
            }
            catch (Exception ex)
            {
                diagnostico.AppendLine($"❌ Error en diagnóstico: {ex.Message}");
            }
            
            return diagnostico.ToString();
        }

        // Método para notificar cambios
        public static void NotificarCambios()
        {
            DatosActualizados?.Invoke(null, EventArgs.Empty);
        }
    }
}
