using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BibliotecaGestion
{
    public partial class FormUsuarioDetalles : Form
    {
        private bool esEdicion = false;
        private int usuarioId = 0;

        public FormUsuarioDetalles()
        {
            InitializeComponent();
            this.Text = "A�adir Usuario";
        }

        public FormUsuarioDetalles(Usuario usuario) : this()
        {
            esEdicion = true;
            usuarioId = usuario.Id;
            this.Text = "Editar Usuario";
            CargarDatosUsuario(usuario);
        }

        private void CargarDatosUsuario(Usuario usuario)
        {
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtCorreo.Text = usuario.CorreoElectronico;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string correo = txtCorreo.Text.Trim();

                if (esEdicion)
                {
                    BibliotecaManager.EditarUsuario(usuarioId, nombre, apellido, correo);
                    MessageBox.Show("Usuario editado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BibliotecaManager.AgregarUsuario(nombre, apellido, correo);
                    MessageBox.Show("Usuario a�adido exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El correo electr�nico es obligatorio.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            if (!EsCorreoValido(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("Solo se permiten correos electr�nicos v�lidos.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            return true;
        }

        private bool EsCorreoValido(string correo)
        {
            // Patr�n regex para validar correo electr�nico
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(correo, patron);
        }
    }
}