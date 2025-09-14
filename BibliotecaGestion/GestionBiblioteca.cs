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
    public partial class GestionBiblioteca : Form
    {
        public GestionBiblioteca()
        {
            InitializeComponent();
        }

        private void GestionBiblioteca_Load(object sender, EventArgs e)
        {
            RefrescarUsuarios();
            RefrescarPrestamos();
            CargarComboUsuarios();
        }

        #region Gestión de Usuarios

        private void RefrescarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = BibliotecaManager.Usuarios;
            
            // Configurar las columnas del DataGridView de usuarios
            if (dgvUsuarios.Columns.Count > 0)
            {
                dgvUsuarios.Columns["Id"].Width = 30;
                dgvUsuarios.Columns["Nombre"].Width = 80;
                dgvUsuarios.Columns["Apellido"].Width = 80;
                dgvUsuarios.Columns["CorreoElectronico"].Width = 150;
                dgvUsuarios.Columns["CorreoElectronico"].HeaderText = "Correo Electrónico";
            }
        }

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarioDetalles formDetalles = new FormUsuarioDetalles();
            if (formDetalles.ShowDialog() == DialogResult.OK)
            {
                RefrescarUsuarios();
                CargarComboUsuarios();
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
                Usuario usuarioSeleccionado = BibliotecaManager.ObtenerUsuarioPorId(idUsuario);
                
                if (usuarioSeleccionado != null)
                {
                    FormUsuarioDetalles formDetalles = new FormUsuarioDetalles(usuarioSeleccionado);
                    if (formDetalles.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarUsuarios();
                        CargarComboUsuarios();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el usuario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
                string nombreUsuario = (string)dgvUsuarios.SelectedRows[0].Cells["Nombre"].Value;
                string apellidoUsuario = (string)dgvUsuarios.SelectedRows[0].Cells["Apellido"].Value;
                
                var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar al usuario '{nombreUsuario} {apellidoUsuario}'?\n\nEsto también eliminará todos sus préstamos asociados.", 
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (confirmResult == DialogResult.Yes)
                {
                    BibliotecaManager.EliminarUsuario(idUsuario);
                    RefrescarUsuarios();
                    RefrescarPrestamos();
                    CargarComboUsuarios();
                    MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Gestión de Préstamos

        private void RefrescarPrestamos()
        {
            // Obtener préstamos con información detallada
            var prestamosDetallados = BibliotecaManager.Prestamos.Select(p => new
            {
                Id = p.Id,
                Libro = BibliotecaManager.ObtenerLibroPorId(p.LibroId)?.Titulo ?? "Libro no encontrado",
                Usuario = BibliotecaManager.ObtenerUsuarioPorId(p.UsuarioId)?.NombreCompleto ?? "Usuario no encontrado",
                FechaPrestamo = p.FechaPrestamo,
                FechaDevolucion = p.FechaDevolucion,
                Estado = p.FechaDevolucion == null ? "Prestado" : "Devuelto"
            }).ToList();

            dgvPrestamos.DataSource = prestamosDetallados;
            
            // Configurar las columnas del DataGridView de préstamos
            if (dgvPrestamos.Columns.Count > 0)
            {
                dgvPrestamos.Columns["Id"].Width = 30;
                dgvPrestamos.Columns["Libro"].Width = 120;
                dgvPrestamos.Columns["Usuario"].Width = 100;
                dgvPrestamos.Columns["FechaPrestamo"].Width = 80;
                dgvPrestamos.Columns["FechaPrestamo"].HeaderText = "Fecha Préstamo";
                dgvPrestamos.Columns["FechaDevolucion"].Width = 80;
                dgvPrestamos.Columns["FechaDevolucion"].HeaderText = "Fecha Devolución";
                dgvPrestamos.Columns["Estado"].Width = 60;
            }
        }

        private void CargarComboUsuarios()
        {
            cboUsuarios.DataSource = null;
            cboUsuarios.DataSource = BibliotecaManager.Usuarios;
            cboUsuarios.DisplayMember = "NombreCompleto";
            cboUsuarios.ValueMember = "Id";
            cboUsuarios.SelectedIndex = -1;
        }

        private void btnAñadirPrestamos_Click(object sender, EventArgs e)
        {
            // Aquí puedes implementar un formulario para añadir préstamos
            // Por ahora, mostraremos un mensaje simple
            MessageBox.Show("Funcionalidad de añadir préstamos pendiente de implementar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                int idPrestamo = (int)dgvPrestamos.SelectedRows[0].Cells["Id"].Value;
                string estado = (string)dgvPrestamos.SelectedRows[0].Cells["Estado"].Value;
                
                if (estado == "Prestado")
                {
                    var confirmResult = MessageBox.Show("¿Deseas marcar este préstamo como devuelto?", 
                        "Devolver libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (BibliotecaManager.DevolverLibroPorId(idPrestamo))
                        {
                            RefrescarPrestamos();
                            MessageBox.Show("Libro devuelto exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al devolver el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Este préstamo ya ha sido devuelto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un préstamo para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                int idPrestamo = (int)dgvPrestamos.SelectedRows[0].Cells["Id"].Value;
                string libro = (string)dgvPrestamos.SelectedRows[0].Cells["Libro"].Value;
                string usuario = (string)dgvPrestamos.SelectedRows[0].Cells["Usuario"].Value;
                
                var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar el préstamo del libro '{libro}' al usuario '{usuario}'?", 
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (confirmResult == DialogResult.Yes)
                {
                    BibliotecaManager.Prestamos.RemoveAll(p => p.Id == idPrestamo);
                    RefrescarPrestamos();
                    MessageBox.Show("Préstamo eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un préstamo para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
