using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaGestion
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                
                // Configurar manejo global de excepciones
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += Application_ThreadException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                
                Console.WriteLine("Iniciando aplicación BibliotecaGestion...");
                
                // Crear y ejecutar Form1
                using (var form = new Form1())
                {
                    Application.Run(form);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico al iniciar la aplicación:\n\n{ex.Message}\n\nDetalles:\n{ex.StackTrace}", 
                    "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error crítico en Main: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"Error no manejado en la aplicación:\n\n{e.Exception.Message}\n\nDetalles:\n{e.Exception.StackTrace}", 
                "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine($"ThreadException: {e.Exception.Message}");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            MessageBox.Show($"Error no manejado en el dominio:\n\n{ex?.Message}\n\nDetalles:\n{ex?.StackTrace}", 
                "Error de Dominio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine($"UnhandledException: {ex?.Message}");
        }
    }
}
