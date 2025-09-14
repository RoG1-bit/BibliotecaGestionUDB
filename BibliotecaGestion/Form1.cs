using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BibliotecaGestion
{
    
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timerActualizacion;
       
        public Form1()
        {
            try
            {
                InitializeComponent();
                InicializarTimer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario principal.", "Error de Inicio", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarTimer()
        {
            try
            {
                timerActualizacion = new System.Windows.Forms.Timer();
                timerActualizacion.Interval = 60000;
                timerActualizacion.Tick += TimerActualizacion_Tick;
            }
            catch (Exception ex)
            {
                // Timer no es crítico, continuar sin él
            }
        }

        private void TimerActualizacion_Tick(object sender, EventArgs e)
        {
            // Actualizar solo los gráficos para mantener rendimiento
            ActualizarGraficos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BibliotecaManager.CargarDatosIniciales();
                RefrescarTabla();
                
                if (chartBooks != null)
                {
                    ConfigurarGraficos();
                    ActualizarGraficos();
                    
                    if (timerActualizacion != null)
                    {
                        timerActualizacion.Start();
                    }
                }
                
                BibliotecaManager.DatosActualizados += BibliotecaManager_DatosActualizados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la aplicación. La aplicación funcionará con funcionalidad limitada.", 
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BibliotecaManager_DatosActualizados(object sender, EventArgs e)
        {
            // Actualizar gráficos cuando hay cambios en los datos
            if (InvokeRequired)
            {
                Invoke(new Action(() => ActualizarGraficos()));
            }
            else
            {
                ActualizarGraficos();
            }
        }

        private void ConfigurarGraficos()
        {
            try
            {
                if (chartBooks != null)
                {
                    chartBooks.Series.Clear();
                    chartBooks.Titles.Clear();
                    chartBooks.Legends.Clear();

                    if (chartBooks.ChartAreas.Count == 0)
                    {
                        chartBooks.ChartAreas.Add(new ChartArea("ChartArea1"));
                    }

                    var area = chartBooks.ChartAreas[0];
                    area.AxisX.Title = "Libros";
                    area.AxisY.Title = "Total de Préstamos";
                    area.AxisX.Interval = 1;
                    // Configurar escala Y de 0 a 20
                    area.AxisY.Minimum = 0;
                    area.AxisY.Maximum = 20;
                    area.AxisY.Interval = 2; // Intervalos cada 2 unidades
                }

                if (chartUsers != null)
                {
                    chartUsers.Series.Clear();
                    chartUsers.Titles.Clear();
                    chartUsers.Legends.Clear();

                    if (chartUsers.ChartAreas.Count == 0)
                    {
                        chartUsers.ChartAreas.Add(new ChartArea("ChartArea1"));
                    }

                    var area = chartUsers.ChartAreas[0];
                    area.AxisX.Title = "Usuarios";
                    area.AxisY.Title = "Préstamos Activos";
                    area.AxisX.Interval = 1;
                    // Configurar escala Y de 0 a 20
                    area.AxisY.Minimum = 0;
                    area.AxisY.Maximum = 20;
                    area.AxisY.Interval = 2; // Intervalos cada 2 unidades
                }
            }
            catch (Exception ex)
            {
                // Error en configuración de gráficos, continuar sin ellos
            }
        }
        
        private void RefrescarTabla()
        {
            RefrescarLibros();
        }

        private void RefrescarLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = BibliotecaManager.Libros;
            if (dgvLibros.Columns.Contains("Id"))
                dgvLibros.Columns["Id"].Width = 30;
        }

        private void ActualizarGraficos()
        {
            try
            {
                // Solo actualizar si los controles existen
                if (chartBooks != null)
                {
                    ActualizarGraficoLibros();
                }
                
                if (chartUsers != null)
                {
                    ActualizarGraficoUsuarios();
                }
            }
            catch (Exception ex)
            {
                // No mostrar MessageBox aquí para evitar spam de errores
            }
        }

        private void ActualizarGraficoLibros()
        {
            try
            {
                if (chartBooks == null)
                {
                    return;
                }

                chartBooks.Series.Clear();
                chartBooks.Titles.Clear();
                chartBooks.Legends.Clear();

                if (chartBooks.ChartAreas.Count == 0)
                {
                    chartBooks.ChartAreas.Add(new ChartArea("ChartArea1"));
                }

                var chartArea = chartBooks.ChartAreas[0];
                chartArea.AxisX.Title = "Libros";
                chartArea.AxisY.Title = "Total de Préstamos";
                chartArea.AxisX.Interval = 1;
                // Mantener escala Y de 0 a 20
                chartArea.AxisY.Minimum = 0;
                chartArea.AxisY.Maximum = 20;
                chartArea.AxisY.Interval = 2;

                chartBooks.Titles.Add("Libros Más Prestados (Historial Completo)");

                Dictionary<string, int> librosData = null;
                try
                {
                    // Usar el nuevo método que cuenta TODOS los préstamos de cada libro
                    librosData = BibliotecaManager.ObtenerLibrosMasPrestadosHistorial(5);
                }
                catch (Exception ex)
                {
                    librosData = new Dictionary<string, int>();
                }

                Series serie = new Series("Libros")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.FromArgb(72, 126, 176) // Azul elegante
                };
                chartBooks.Series.Add(serie);

                if (librosData != null && librosData.Any())
                {
                    int contador = 0;
                    foreach (var item in librosData.Take(5))
                    {
                        if (!string.IsNullOrEmpty(item.Key))
                        {
                            // Asegurar que los valores no excedan 20
                            int valor = Math.Min(item.Value, 20);
                            serie.Points.AddXY(contador, valor);
                            serie.Points[contador].AxisLabel = item.Key;
                            serie.Points[contador].Label = $"{item.Value} préstamos";
                            contador++;
                        }
                    }
                }
                else
                {
                    serie.Points.AddXY(0, 0);
                    serie.Points[0].AxisLabel = "Sin datos";
                    serie.Points[0].Label = "0";
                }
            }
            catch (Exception ex)
            {
                try
                {
                    if (chartBooks != null)
                    {
                        chartBooks.Series.Clear();
                        chartBooks.Titles.Clear();
                        chartBooks.Titles.Add("Error al cargar datos");
                    }
                }
                catch
                {
                    // Ignorar errores de limpieza
                }
            }
        }

        private void ActualizarGraficoUsuarios()
        {
            try
            {
                if (chartUsers == null)
                {
                    return;
                }

                chartUsers.Series.Clear();
                chartUsers.Titles.Clear();

                if (chartUsers.ChartAreas.Count == 0)
                {
                    chartUsers.ChartAreas.Add(new ChartArea("ChartArea1"));
                }

                chartUsers.Titles.Add("Usuarios con Más Préstamos Activos");

                // Configurar escala Y de 0 a 20
                var chartArea = chartUsers.ChartAreas[0];
                chartArea.AxisX.Interval = 1;
                chartArea.AxisY.Minimum = 0;
                chartArea.AxisY.Maximum = 20;
                chartArea.AxisY.Interval = 2;

                Dictionary<string, int> usuariosData = null;
                try
                {
                    usuariosData = BibliotecaManager.ObtenerUsuariosConMasLibrosPrestados(5);
                }
                catch (Exception ex)
                {
                    usuariosData = new Dictionary<string, int>();
                }

                Series serie = new Series("Usuarios")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.FromArgb(173, 75, 75) // Rojo elegante
                };
                chartUsers.Series.Add(serie);

                if (usuariosData != null && usuariosData.Any())
                {
                    int contador = 0;
                    foreach (var item in usuariosData.Take(5))
                    {
                        if (!string.IsNullOrEmpty(item.Key))
                        {
                            // Asegurar que los valores no excedan 20
                            int valor = Math.Min(item.Value, 20);
                            serie.Points.AddXY(contador, valor);
                            serie.Points[contador].AxisLabel = item.Key;
                            serie.Points[contador].Label = valor.ToString();
                            contador++;
                        }
                    }
                }
                else
                {
                    serie.Points.AddXY(0, 0);
                    serie.Points[0].AxisLabel = "Sin datos";
                    serie.Points[0].Label = "0";
                }
            }
            catch (Exception ex)
            {
                try
                {
                    if (chartUsers != null)
                    {
                        chartUsers.Series.Clear();
                        chartUsers.Titles.Clear();
                        chartUsers.Titles.Add("Error al cargar datos de usuarios");
                    }
                }
                catch
                {
                    // Ignorar errores de limpieza
                }
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FormLibroDetalles formDetalles = new FormLibroDetalles();
            if (formDetalles.ShowDialog() == DialogResult.OK)
            {
                RefrescarTabla();
                ActualizarGraficos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                int idLibro = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
                Libro libroSeleccionado = BibliotecaManager.ObtenerLibroPorId(idLibro);
                
                if (libroSeleccionado != null)
                {
                    FormLibroDetalles formDetalles = new FormLibroDetalles(libroSeleccionado);
                    if (formDetalles.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarTabla();
                        ActualizarGraficos();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el libro seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un libro para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                int idLibro = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
                string tituloLibro = (string)dgvLibros.SelectedRows[0].Cells["Titulo"].Value;
                var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar el libro '{tituloLibro}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    BibliotecaManager.EliminarLibro(idLibro);
                    RefrescarTabla();
                    ActualizarGraficos();
                    MessageBox.Show("Libro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un libro para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGestionAvanzada_Click(object sender, EventArgs e)
        {
            try
            {
                GestionBiblioteca docForm = new GestionBiblioteca();
                docForm.ShowDialog();
                
                ActualizarGraficos();
                MostrarEstadisticasHistoricas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la gestión avanzada.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarEstadisticasHistoricas()
        {
            var estadisticasSeptiembre = BibliotecaManager.ObtenerLibrosMasPrestadosEnSeptiembre(5);
            
            if (estadisticasSeptiembre.Any())
            {
                string mensaje = "📚 HISTORIAL PERMANENTE - SEPTIEMBRE 2024 📚\n\n";
                mensaje += "Libros más prestados en septiembre:\n";
                
                int posicion = 1;
                foreach (var libro in estadisticasSeptiembre)
                {
                    mensaje += $"{posicion}. {libro.Key}: {libro.Value} préstamo(s)\n";
                    posicion++;
                }
                
                mensaje += "\n💡 Este historial se mantiene permanente y no se borra cuando los libros son devueltos.";
                
                MessageBox.Show(mensaje, "Historial de Préstamos - Septiembre 2024", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Desuscribirse del evento
            BibliotecaManager.DatosActualizados -= BibliotecaManager_DatosActualizados;
            
            // Limpiar el timer al cerrar el formulario
            if (timerActualizacion != null)
            {
                timerActualizacion.Stop();
                timerActualizacion.Dispose();
            }
            base.OnFormClosed(e);
        }

        // Método público para forzar actualización desde otros formularios
        public void ForzarActualizacionGraficos()
        {
            ActualizarGraficos();
        }
    }
}
