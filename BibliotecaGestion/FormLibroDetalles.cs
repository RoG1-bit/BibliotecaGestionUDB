using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaGestion
{
    public partial class FormLibroDetalles : Form
    {
        private bool esEdicion = false;
        private int libroId = 0;

        public FormLibroDetalles()
        {
            InitializeComponent();
            this.Text = "Añadir Libro";
        }

        public FormLibroDetalles(Libro libro) : this()
        {
            esEdicion = true;
            libroId = libro.Id;
            this.Text = "Editar Libro";
            CargarDatosLibro(libro);
        }

        private void CargarDatosLibro(Libro libro)
        {
            txtTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;
            numAnio.Value = libro.AnioPublicacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string titulo = txtTitulo.Text.Trim();
                string autor = txtAutor.Text.Trim();
                int anio = (int)numAnio.Value;

                if (esEdicion)
                {
                    BibliotecaManager.EditarLibro(libroId, titulo, autor, anio);
                    MessageBox.Show("Libro editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BibliotecaManager.AgregarLibro(titulo, autor, anio);
                    MessageBox.Show("Libro añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El autor es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
                return false;
            }

            if (numAnio.Value < 1000 || numAnio.Value > DateTime.Now.Year + 10)
            {
                MessageBox.Show($"El año debe estar entre 1000 y {DateTime.Now.Year + 10}.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAnio.Focus();
                return false;
            }

            return true;
        }

        private void FormLibroDetalles_Load(object sender, EventArgs e)
        {
            // Establecer el año actual como valor por defecto si es un libro nuevo
            if (!esEdicion)
            {
                numAnio.Value = DateTime.Now.Year;
            }
        }
    }
}