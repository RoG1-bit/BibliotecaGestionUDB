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
    public partial class FormPrestamoDetalles : Form
    {
        private bool esEdicion = false;
        private int prestamoId = 0;

        public FormPrestamoDetalles()
        {
            InitializeComponent();
            this.Text = "Nuevo Pr�stamo";
            CargarUsuarios();
            CargarLibrosDisponibles();
        }

        public FormPrestamoDetalles(Prestamo prestamo) : this()
        {
            esEdicion = true;
            prestamoId = prestamo.Id;
            this.Text = "Editar Pr�stamo";
            CargarDatosPrestamo(prestamo);
        }

        private void CargarUsuarios()
        {
            cboUsuario.DataSource = null;
            cboUsuario.DisplayMember = "NombreCompleto";
            cboUsuario.ValueMember = "Id";
            cboUsuario.DataSource = BibliotecaManager.Usuarios;
            cboUsuario.SelectedIndex = -1;
        }

        private void CargarLibrosDisponibles()
        {
            if (esEdicion)
            {
                // En edici�n, mostrar todos los libros (incluido el actualmente prestado)
                cboLibro.DataSource = null;
                cboLibro.DisplayMember = "Titulo";
                cboLibro.ValueMember = "Id";
                cboLibro.DataSource = BibliotecaManager.Libros;
            }
            else
            {
                // En nuevo pr�stamo, solo mostrar libros disponibles
                var librosDisponibles = BibliotecaManager.ObtenerLibrosDisponibles();
                cboLibro.DataSource = null;
                cboLibro.DisplayMember = "Titulo";
                cboLibro.ValueMember = "Id";
                cboLibro.DataSource = librosDisponibles;
                cboLibro.SelectedIndex = -1;
            }
        }

        private void CargarDatosPrestamo(Prestamo prestamo)
        {
            cboUsuario.SelectedValue = prestamo.UsuarioId;
            cboLibro.SelectedValue = prestamo.LibroId;
            dtpFechaPrestamo.Value = prestamo.FechaPrestamo;
            
            dtpFechaPrestamo.Enabled = false;
            
            if (prestamo.FechaDevolucion.HasValue)
            {
                chkDevuelto.Checked = true;
                dtpFechaDevolucion.Value = prestamo.FechaDevolucion.Value;
                panelDevolucion.Enabled = true;
            }
            else
            {
                chkDevuelto.Checked = false;
                panelDevolucion.Enabled = false;
            }
        }

        private void chkDevuelto_CheckedChanged(object sender, EventArgs e)
        {
            panelDevolucion.Enabled = chkDevuelto.Checked;
            if (chkDevuelto.Checked && !esEdicion)
            {
                dtpFechaDevolucion.Value = DateTime.Now;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    if (esEdicion)
                    {
                        // Editar pr�stamo existente
                        EditarPrestamo();
                    }
                    else
                    {
                        // Crear nuevo pr�stamo
                        CrearNuevoPrestamo();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar el pr�stamo: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CrearNuevoPrestamo()
        {
            int usuarioId = (int)cboUsuario.SelectedValue;
            int libroId = (int)cboLibro.SelectedValue;

            // Verificar que el libro est� disponible
            if (!BibliotecaManager.LibroDisponible(libroId))
            {
                var libro = BibliotecaManager.ObtenerLibroPorId(libroId);
                MessageBox.Show($"El libro '{libro?.Titulo}' no est� disponible para pr�stamo.\n\nSolo tenemos una copia y actualmente est� prestado a otro usuario.", 
                    "Libro no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verificar que el usuario no tenga ya este libro prestado
            var prestamoExistente = BibliotecaManager.Prestamos
                .FirstOrDefault(p => p.UsuarioId == usuarioId && p.LibroId == libroId && p.FechaDevolucion == null);
            
            if (prestamoExistente != null)
            {
                var libro = BibliotecaManager.ObtenerLibroPorId(libroId);
                MessageBox.Show($"Este usuario ya tiene el libro '{libro?.Titulo}' en pr�stamo.\n\nDebe devolverlo antes de poder prest�rselo nuevamente.", 
                    "Pr�stamo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BibliotecaManager.RealizarPrestamo(libroId, usuarioId);

            if (chkDevuelto.Checked)
            {
                var prestamo = BibliotecaManager.Prestamos.Last();
                prestamo.FechaDevolucion = dtpFechaDevolucion.Value;
            }

            var libroInfo = BibliotecaManager.ObtenerLibroPorId(libroId);
            MessageBox.Show($"Pr�stamo registrado exitosamente.\n\nLibro: {libroInfo?.Titulo}\nFecha de devoluci�n esperada: {DateTime.Now.AddDays(15):dd/MM/yyyy}", 
                "Pr�stamo completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditarPrestamo()
        {
            var prestamo = BibliotecaManager.ObtenerPrestamoPorId(prestamoId);
            if (prestamo != null)
            {
                prestamo.UsuarioId = (int)cboUsuario.SelectedValue;
                prestamo.LibroId = (int)cboLibro.SelectedValue;

                if (chkDevuelto.Checked)
                {
                    prestamo.FechaDevolucion = dtpFechaDevolucion.Value;
                }
                else
                {
                    prestamo.FechaDevolucion = null;
                }

                MessageBox.Show("Los datos del pr�stamo han sido actualizados.", "Operaci�n completada", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                throw new Exception("No se pudo localizar el pr�stamo para actualizar.");
            }
        }

        private bool ValidarCampos()
        {
            if (cboUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un usuario para el pr�stamo.", "Usuario requerido", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboUsuario.Focus();
                return false;
            }

            if (cboLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un libro para el pr�stamo.", "Libro requerido", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboLibro.Focus();
                return false;
            }

            if (chkDevuelto.Checked)
            {
                if (dtpFechaDevolucion.Value.Date < dtpFechaPrestamo.Value.Date)
                {
                    MessageBox.Show("La fecha de devoluci�n no puede ser anterior a la fecha de pr�stamo.", 
                        "Fechas inv�lidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaDevolucion.Focus();
                    return false;
                }

                if (dtpFechaDevolucion.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de devoluci�n no puede ser posterior a la fecha actual.", 
                        "Fecha futura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaDevolucion.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cboLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLibro.SelectedValue != null && !esEdicion)
            {
                int libroId = (int)cboLibro.SelectedValue;
                var libro = BibliotecaManager.ObtenerLibroPorId(libroId);
                if (libro != null)
                {
                    // Verificar disponibilidad
                    bool disponible = BibliotecaManager.LibroDisponible(libroId);
                    string estado = disponible ? "Disponible" : "En pr�stamo";
                    
                    lblInfoLibro.Text = $"{libro.Autor} � {libro.AnioPublicacion} � Estado: {estado}";
                    lblInfoLibro.ForeColor = disponible ? 
                        System.Drawing.Color.FromArgb(72, 126, 176) : // Azul elegante si est� disponible
                        System.Drawing.Color.FromArgb(173, 75, 75);   // Rojo elegante si est� prestado
                }
            }
            else if (esEdicion && cboLibro.SelectedValue != null)
            {
                int libroId = (int)cboLibro.SelectedValue;
                var libro = BibliotecaManager.ObtenerLibroPorId(libroId);
                if (libro != null)
                {
                    lblInfoLibro.Text = $"{libro.Autor} � {libro.AnioPublicacion}";
                    lblInfoLibro.ForeColor = System.Drawing.Color.FromArgb(134, 142, 150);
                }
            }
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsuario.SelectedValue != null)
            {
                int usuarioId = (int)cboUsuario.SelectedValue;
                var usuario = BibliotecaManager.ObtenerUsuarioPorId(usuarioId);
                if (usuario != null)
                {
                    var prestamosActivos = BibliotecaManager.ObtenerPrestamosPorUsuario(usuarioId)
                        .Count(p => p.FechaDevolucion == null);
                    
                    lblInfoUsuario.Text = $"{usuario.CorreoElectronico} � {prestamosActivos} pr�stamo(s) activo(s)";
                    
                    // Cambiar color seg�n la cantidad de pr�stamos con colores elegantes
                    if (prestamosActivos == 0)
                        lblInfoUsuario.ForeColor = System.Drawing.Color.FromArgb(72, 126, 176); // Azul elegante
                    else if (prestamosActivos <= 2)
                        lblInfoUsuario.ForeColor = System.Drawing.Color.FromArgb(134, 142, 150); // Gris elegante
                    else
                        lblInfoUsuario.ForeColor = System.Drawing.Color.FromArgb(173, 75, 75); // Rojo elegante
                }
            }
        }
    }
}