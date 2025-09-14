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
        private int usuarioSeleccionado = -1;
        private List<dynamic> prestamosDetallados = new List<dynamic>();

        public GestionBiblioteca()
        {
            InitializeComponent();
        }

        private void GestionBiblioteca_Load(object sender, EventArgs e)
        {
            RefrescarUsuarios();
            RefrescarPrestamos();
            CargarComboUsuarios();
            CargarEstadisticasUsuarios();
        }

        #region Métodos de Usuario
        
        private void RefrescarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = BibliotecaManager.Usuarios;
            if (dgvUsuarios.Columns.Contains("Id"))
                dgvUsuarios.Columns["Id"].Width = 30;
        }

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarioDetalles formDetalles = new FormUsuarioDetalles();
            if (formDetalles.ShowDialog() == DialogResult.OK)
            {
                RefrescarUsuarios();
                CargarComboUsuarios();
                CargarEstadisticasUsuarios();
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
                        CargarEstadisticasUsuarios();
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
                string nombreUsuario = (string)dgvUsuarios.SelectedRows[0].Cells["NombreCompleto"].Value;
                
                var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar al usuario '{nombreUsuario}'?\nEsto también eliminará todos sus préstamos.", 
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (confirmResult == DialogResult.Yes)
                {
                    BibliotecaManager.EliminarUsuario(idUsuario);
                    RefrescarUsuarios();
                    RefrescarPrestamos();
                    CargarComboUsuarios();
                    CargarEstadisticasUsuarios();
                    MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Métodos de Préstamos

        private void RefrescarPrestamos()
        {
            // Obtener préstamos con información detallada
            prestamosDetallados = BibliotecaManager.Prestamos.Select(p => new
            {
                Id = p.Id,
                Libro = BibliotecaManager.ObtenerLibroPorId(p.LibroId)?.Titulo ?? "Libro no encontrado",
                Usuario = BibliotecaManager.ObtenerUsuarioPorId(p.UsuarioId)?.NombreCompleto ?? "Usuario no encontrado",
                FechaPrestamo = p.FechaPrestamo,
                FechaEntregaEsperada = p.FechaEntregaEsperada,
                FechaDevolucion = p.FechaDevolucion,
                Estado = p.FechaDevolucion == null ? "Prestado" : "Devuelto"
            }).ToList<dynamic>();

            // Filtrar por usuario seleccionado si es necesario
            if (usuarioSeleccionado != -1)
            {
                prestamosDetallados = prestamosDetallados.Where(p => 
                    BibliotecaManager.Prestamos.First(pr => pr.Id == p.Id).UsuarioId == usuarioSeleccionado).ToList();
            }

            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = prestamosDetallados;

            // Configurar columnas
            if (dgvPrestamos.Columns.Contains("Id"))
                dgvPrestamos.Columns["Id"].Width = 30;
            if (dgvPrestamos.Columns.Contains("FechaPrestamo"))
                dgvPrestamos.Columns["FechaPrestamo"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgvPrestamos.Columns.Contains("FechaEntregaEsperada"))
                dgvPrestamos.Columns["FechaEntregaEsperada"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgvPrestamos.Columns.Contains("FechaDevolucion"))
                dgvPrestamos.Columns["FechaDevolucion"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Resaltar préstamos vencidos
            foreach (DataGridViewRow row in dgvPrestamos.Rows)
            {
                if (row.Cells["Estado"].Value?.ToString() == "Prestado")
                {
                    DateTime fechaEntrega = (DateTime)row.Cells["FechaEntregaEsperada"].Value;
                    if (fechaEntrega < DateTime.Now)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238); // Rojo muy suave para vencidos
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(173, 75, 75); // Texto en rojo elegante
                    }
                }
            }

            // Actualizar información adicional
            ActualizarInformacionPrestamos();
        }

        private void ActualizarInformacionPrestamos()
        {
            if (usuarioSeleccionado != -1)
            {
                int totalPrestamos = prestamosDetallados.Count;
                int prestamosActivos = prestamosDetallados.Count(p => p.Estado == "Prestado");
                int prestamosVencidos = prestamosDetallados.Count(p => p.Estado == "Prestado" && p.FechaEntregaEsperada < DateTime.Now);
                
                string info = $"Total: {totalPrestamos} | Activos: {prestamosActivos} | Vencidos: {prestamosVencidos}";
                gbPrestamos.Text = $"📚 Gestionar Préstamos - {info}";
            }
            else
            {
                gbPrestamos.Text = "📚 Gestionar Préstamos";
            }
        }

        private void CargarComboUsuarios()
        {
            cboUsuarios.DataSource = null;
            
            // Crear una lista que incluya una opción "Todos los usuarios"
            var listaUsuarios = new List<dynamic>();
            listaUsuarios.Add(new { Id = -1, NombreCompleto = "-- Todos los usuarios --" });
            
            foreach (var usuario in BibliotecaManager.Usuarios)
            {
                listaUsuarios.Add(new { Id = usuario.Id, NombreCompleto = usuario.NombreCompleto });
            }
            
            cboUsuarios.DisplayMember = "NombreCompleto";
            cboUsuarios.ValueMember = "Id";
            cboUsuarios.DataSource = listaUsuarios;
            cboUsuarios.SelectedIndex = 0; // Seleccionar "Todos los usuarios" por defecto
        }

        private void CargarEstadisticasUsuarios()
        {
            var estadisticas = new List<dynamic>();

            foreach (var usuario in BibliotecaManager.Usuarios)
            {
                var prestamosUsuario = BibliotecaManager.ObtenerPrestamosPorUsuario(usuario.Id);
                var prestamosActivos = prestamosUsuario.Count(p => p.FechaDevolucion == null);
                var prestamosDevueltos = prestamosUsuario.Count(p => p.FechaDevolucion != null);
                var prestamosVencidos = prestamosUsuario.Count(p => p.FechaDevolucion == null && p.FechaEntregaEsperada < DateTime.Now);

                estadisticas.Add(new
                {
                    Usuario = usuario.NombreCompleto,
                    TotalPrestamos = prestamosUsuario.Count,
                    PrestamosActivos = prestamosActivos,
                    PrestamosDevueltos = prestamosDevueltos,
                    PrestamosVencidos = prestamosVencidos
                });
            }

            dgvEstadisticasUsuarios.DataSource = estadisticas;

            // Configurar columnas
            if (dgvEstadisticasUsuarios.Columns.Contains("Usuario"))
                dgvEstadisticasUsuarios.Columns["Usuario"].HeaderText = "Usuario";
            if (dgvEstadisticasUsuarios.Columns.Contains("TotalPrestamos"))
                dgvEstadisticasUsuarios.Columns["TotalPrestamos"].HeaderText = "Total";
            if (dgvEstadisticasUsuarios.Columns.Contains("PrestamosActivos"))
                dgvEstadisticasUsuarios.Columns["PrestamosActivos"].HeaderText = "Activos";
            if (dgvEstadisticasUsuarios.Columns.Contains("PrestamosDevueltos"))
                dgvEstadisticasUsuarios.Columns["PrestamosDevueltos"].HeaderText = "Devueltos";
            if (dgvEstadisticasUsuarios.Columns.Contains("PrestamosVencidos"))
                dgvEstadisticasUsuarios.Columns["PrestamosVencidos"].HeaderText = "Vencidos";

            // Resaltar filas con préstamos vencidos
            foreach (DataGridViewRow row in dgvEstadisticasUsuarios.Rows)
            {
                if (row.Cells["PrestamosVencidos"].Value != null)
                {
                    int vencidos = (int)row.Cells["PrestamosVencidos"].Value;
                    if (vencidos > 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238); // Rojo muy suave para vencidos
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(173, 75, 75); // Texto en rojo elegante
                    }
                }
            }
        }

        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsuarios.SelectedValue != null)
            {
                usuarioSeleccionado = (int)cboUsuarios.SelectedValue;
                RefrescarPrestamos();
            }
        }

        private void btnAñadirPrestamos_Click(object sender, EventArgs e)
        {
            // Verificar que haya usuarios y libros disponibles
            if (BibliotecaManager.Usuarios.Count == 0)
            {
                MessageBox.Show("No hay usuarios registrados. Debe añadir al menos un usuario antes de crear préstamos.", 
                    "Sin usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BibliotecaManager.ObtenerLibrosDisponibles().Count == 0)
            {
                MessageBox.Show("No hay libros disponibles para préstamo. Todos los libros están actualmente prestados.", 
                    "Sin libros disponibles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormPrestamoDetalles formDetalles = new FormPrestamoDetalles();
            if (formDetalles.ShowDialog() == DialogResult.OK)
            {
                RefrescarPrestamos();
                CargarEstadisticasUsuarios();
                MessageBox.Show("Préstamo añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                int idPrestamo = (int)dgvPrestamos.SelectedRows[0].Cells["Id"].Value;
                var prestamo = BibliotecaManager.ObtenerPrestamoPorId(idPrestamo);
                
                if (prestamo != null)
                {
                    FormPrestamoDetalles formDetalles = new FormPrestamoDetalles(prestamo);
                    if (formDetalles.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarPrestamos();
                        CargarEstadisticasUsuarios();
                        MessageBox.Show("Préstamo actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    // Notificar cambios manualmente para este caso específico
                    BibliotecaManager.NotificarCambios();
                    RefrescarPrestamos();
                    CargarEstadisticasUsuarios();
                    MessageBox.Show("Préstamo eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un préstamo para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void gbEstadisticas_Enter(object sender, EventArgs e)
        {

        }
    }
}
