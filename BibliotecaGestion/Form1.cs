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
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BibliotecaManager.CargarDatosIniciales();
            RefrescarTabla();
        }
        private void RefrescarTabla()
        {
          RefrescarLibros();
        }

        private void RefrescarLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = BibliotecaManager.Libros;
            dgvLibros.Columns["Id"].Width = 30;
        }

        private void ActualizarGraficos()
        {
            var librosData = BibliotecaManager.ObtenerLibrosMasPrestados(3);
            chartBooks.Series.Clear();
            Series seriesLibros = new Series("Libros")
            {
                ChartType = SeriesChartType.Bar
            };
            chartBooks.Series.Add(seriesLibros);
            chartBooks.ChartAreas[0].AxisX.Interval = 1;
            foreach (var libro in librosData)
            {
                seriesLibros.Points.AddXY(libro.Key, libro.Value);
            }

            var usuariosData = BibliotecaManager.ObtenerUsuariosMasActivos(3);
            chartUsers.Series.Clear();
            Series seriesUsuarios = new Series("Usuarios")
            {
                ChartType = SeriesChartType.Bar
            };
            chartUsers.Series.Add(seriesUsuarios);
            chartUsers.ChartAreas[0].AxisX.Interval = 1;
            foreach (var usuario in usuariosData)
            {
                seriesUsuarios.Points.AddXY(usuario.Key, usuario.Value);
            }

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            BibliotecaManager.AgregarLibro("Nuevo Libro", "Autor Desconocido", 2025);
            RefrescarTabla();
            MessageBox.Show("Libro añadido exitosamente.");
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                int idLibro = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
                MessageBox.Show("Funcionalidad de edición pendiente de implementar para el libro con ID: " + idLibro);
            }
            else
            {
                MessageBox.Show("Selecciona un libro para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                int idLibro = (int)dgvLibros.SelectedRows[0].Cells["Id"].Value;
                string tituloLibro = (string)dgvLibros.SelectedRows[0].Cells["Titulo"].Value;
                var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar el libro '{tituloLibro}'?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BibliotecaManager.EliminarLibro(idLibro);
                    RefrescarTabla();
                    MessageBox.Show("Libro eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Selecciona un libro para eliminar.");
                }
            }
        }

        private void btnDocumentacion_Click(object sender, EventArgs e)
        {
            // Comentamos esta línea hasta que se cree la forma GestionBiblioteca
            // GestionBiblioteca docForm = new GestionBiblioteca();
            // docForm.ShowDialog();
            MessageBox.Show("Funcionalidad de documentación pendiente de implementar.");
        }
    }
}
