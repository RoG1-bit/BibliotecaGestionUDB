namespace BibliotecaGestion
{
    partial class GestionBiblioteca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panelBotonesUsuarios = new System.Windows.Forms.Panel();
            this.btnAñadirUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.gbPrestamos = new System.Windows.Forms.GroupBox();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.lblFiltroUsuario = new System.Windows.Forms.Label();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.panelBotonesPrestamos = new System.Windows.Forms.Panel();
            this.btnAñadirPrestamos = new System.Windows.Forms.Button();
            this.btnEditarPrestamo = new System.Windows.Forms.Button();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.gbEstadisticas = new System.Windows.Forms.GroupBox();
            this.dgvEstadisticasUsuarios = new System.Windows.Forms.DataGridView();
            this.lblSeleccionarUsuario = new System.Windows.Forms.Label();
            this.gbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelBotonesUsuarios.SuspendLayout();
            this.gbPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.panelBotonesPrestamos.SuspendLayout();
            this.gbEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.BackColor = System.Drawing.Color.White;
            this.gbUsuarios.Controls.Add(this.dgvUsuarios);
            this.gbUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.gbUsuarios.Location = new System.Drawing.Point(20, 20);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(450, 200);
            this.gbUsuarios.TabIndex = 0;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "👥 Administrar Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(15, 30);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(420, 150);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // panelBotonesUsuarios
            // 
            this.panelBotonesUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelBotonesUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotonesUsuarios.Controls.Add(this.btnAñadirUsuario);
            this.panelBotonesUsuarios.Controls.Add(this.btnEditarUsuario);
            this.panelBotonesUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.panelBotonesUsuarios.Location = new System.Drawing.Point(20, 230);
            this.panelBotonesUsuarios.Name = "panelBotonesUsuarios";
            this.panelBotonesUsuarios.Size = new System.Drawing.Size(450, 50);
            this.panelBotonesUsuarios.TabIndex = 1;
            // 
            // btnAñadirUsuario
            // 
            this.btnAñadirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnAñadirUsuario.FlatAppearance.BorderSize = 0;
            this.btnAñadirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAñadirUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAñadirUsuario.Location = new System.Drawing.Point(15, 10);
            this.btnAñadirUsuario.Name = "btnAñadirUsuario";
            this.btnAñadirUsuario.Size = new System.Drawing.Size(120, 30);
            this.btnAñadirUsuario.TabIndex = 1;
            this.btnAñadirUsuario.Text = "➕ Añadir Usuario";
            this.btnAñadirUsuario.UseVisualStyleBackColor = false;
            this.btnAñadirUsuario.Click += new System.EventHandler(this.btnAñadirUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnEditarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEditarUsuario.Location = new System.Drawing.Point(150, 10);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(120, 30);
            this.btnEditarUsuario.TabIndex = 2;
            this.btnEditarUsuario.Text = "✏️ Editar Usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(285, 10);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(130, 30);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "🗑️ Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // gbPrestamos
            // 
            this.gbPrestamos.BackColor = System.Drawing.Color.White;
            this.gbPrestamos.Controls.Add(this.dgvPrestamos);
            this.gbPrestamos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbPrestamos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.gbPrestamos.Location = new System.Drawing.Point(20, 300);
            this.gbPrestamos.Name = "gbPrestamos";
            this.gbPrestamos.Size = new System.Drawing.Size(450, 200);
            this.gbPrestamos.TabIndex = 4;
            this.gbPrestamos.TabStop = false;
            this.gbPrestamos.Text = "📚 Gestionar Préstamos";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvPrestamos.Location = new System.Drawing.Point(15, 30);
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(420, 150);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // panelFiltro
            // 
            this.panelFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.panelFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltro.Controls.Add(this.lblFiltroUsuario);
            this.panelFiltro.Controls.Add(this.cboUsuarios);
            this.panelFiltro.Location = new System.Drawing.Point(490, 20);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(350, 60);
            this.panelFiltro.TabIndex = 5;
            // 
            // lblFiltroUsuario
            // 
            this.lblFiltroUsuario.AutoSize = true;
            this.lblFiltroUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltroUsuario.ForeColor = System.Drawing.Color.White;
            this.lblFiltroUsuario.Location = new System.Drawing.Point(10, 8);
            this.lblFiltroUsuario.Name = "lblFiltroUsuario";
            this.lblFiltroUsuario.Size = new System.Drawing.Size(124, 15);
            this.lblFiltroUsuario.TabIndex = 9;
            this.lblFiltroUsuario.Text = "🔍 Filtrar por Usuario:";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(13, 26);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(320, 23);
            this.cboUsuarios.TabIndex = 5;
            this.cboUsuarios.SelectedIndexChanged += new System.EventHandler(this.cboUsuarios_SelectedIndexChanged);
            // 
            // panelBotonesPrestamos
            // 
            this.panelBotonesPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelBotonesPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotonesPrestamos.Controls.Add(this.btnAñadirPrestamos);
            this.panelBotonesPrestamos.Controls.Add(this.btnEditarPrestamo);
            this.panelBotonesPrestamos.Controls.Add(this.btnEliminarPrestamo);
            this.panelBotonesPrestamos.Location = new System.Drawing.Point(20, 510);
            this.panelBotonesPrestamos.Name = "panelBotonesPrestamos";
            this.panelBotonesPrestamos.Size = new System.Drawing.Size(450, 50);
            this.panelBotonesPrestamos.TabIndex = 6;
            // 
            // btnAñadirPrestamos
            // 
            this.btnAñadirPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnAñadirPrestamos.FlatAppearance.BorderSize = 0;
            this.btnAñadirPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirPrestamos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAñadirPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnAñadirPrestamos.Location = new System.Drawing.Point(15, 10);
            this.btnAñadirPrestamos.Name = "btnAñadirPrestamos";
            this.btnAñadirPrestamos.Size = new System.Drawing.Size(120, 30);
            this.btnAñadirPrestamos.TabIndex = 6;
            this.btnAñadirPrestamos.Text = "➕ Nuevo Préstamo";
            this.btnAñadirPrestamos.UseVisualStyleBackColor = false;
            this.btnAñadirPrestamos.Click += new System.EventHandler(this.btnAñadirPrestamos_Click);
            // 
            // btnEditarPrestamo
            // 
            this.btnEditarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnEditarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnEditarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnEditarPrestamo.Location = new System.Drawing.Point(150, 10);
            this.btnEditarPrestamo.Name = "btnEditarPrestamo";
            this.btnEditarPrestamo.Size = new System.Drawing.Size(120, 30);
            this.btnEditarPrestamo.TabIndex = 7;
            this.btnEditarPrestamo.Text = "✏️ Editar Préstamo";
            this.btnEditarPrestamo.UseVisualStyleBackColor = false;
            this.btnEditarPrestamo.Click += new System.EventHandler(this.btnEditarPrestamo_Click);
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnEliminarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnEliminarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(285, 10);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(140, 30);
            this.btnEliminarPrestamo.TabIndex = 8;
            this.btnEliminarPrestamo.Text = "🗑️ Eliminar Préstamo";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = false;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // gbEstadisticas
            // 
            this.gbEstadisticas.BackColor = System.Drawing.Color.White;
            this.gbEstadisticas.Controls.Add(this.dgvEstadisticasUsuarios);
            this.gbEstadisticas.Controls.Add(this.lblSeleccionarUsuario);
            this.gbEstadisticas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.gbEstadisticas.Location = new System.Drawing.Point(490, 90);
            this.gbEstadisticas.Name = "gbEstadisticas";
            this.gbEstadisticas.Size = new System.Drawing.Size(350, 470);
            this.gbEstadisticas.TabIndex = 9;
            this.gbEstadisticas.TabStop = false;
            this.gbEstadisticas.Text = "📊 Estadísticas de Préstamos por Usuario";
            // 
            // dgvEstadisticasUsuarios
            // 
            this.dgvEstadisticasUsuarios.AllowUserToAddRows = false;
            this.dgvEstadisticasUsuarios.AllowUserToDeleteRows = false;
            this.dgvEstadisticasUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstadisticasUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEstadisticasUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticasUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvEstadisticasUsuarios.Location = new System.Drawing.Point(15, 60);
            this.dgvEstadisticasUsuarios.Name = "dgvEstadisticasUsuarios";
            this.dgvEstadisticasUsuarios.ReadOnly = true;
            this.dgvEstadisticasUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadisticasUsuarios.Size = new System.Drawing.Size(320, 390);
            this.dgvEstadisticasUsuarios.TabIndex = 6;
            // 
            // lblSeleccionarUsuario
            // 
            this.lblSeleccionarUsuario.AutoSize = true;
            this.lblSeleccionarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSeleccionarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblSeleccionarUsuario.Location = new System.Drawing.Point(15, 30);
            this.lblSeleccionarUsuario.Name = "lblSeleccionarUsuario";
            this.lblSeleccionarUsuario.Size = new System.Drawing.Size(236, 15);
            this.lblSeleccionarUsuario.TabIndex = 7;
            this.lblSeleccionarUsuario.Text = "Utiliza el filtro arriba para filtrar por usuario";
            // 
            // GestionBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Controls.Add(this.gbEstadisticas);
            this.Controls.Add(this.panelBotonesPrestamos);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.gbPrestamos);
            this.Controls.Add(this.panelBotonesUsuarios);
            this.Controls.Add(this.gbUsuarios);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GestionBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "⚙️ Gestión Avanzada - Usuarios y Préstamos";
            this.Load += new System.EventHandler(this.GestionBiblioteca_Load);
            this.gbUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelBotonesUsuarios.ResumeLayout(false);
            this.gbPrestamos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panelBotonesPrestamos.ResumeLayout(false);
            this.gbEstadisticas.ResumeLayout(false);
            this.gbEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panelBotonesUsuarios;
        private System.Windows.Forms.Button btnAñadirUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.GroupBox gbPrestamos;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Label lblFiltroUsuario;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Panel panelBotonesPrestamos;
        private System.Windows.Forms.Button btnAñadirPrestamos;
        private System.Windows.Forms.Button btnEditarPrestamo;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.GroupBox gbEstadisticas;
        private System.Windows.Forms.DataGridView dgvEstadisticasUsuarios;
        private System.Windows.Forms.Label lblSeleccionarUsuario;
    }
}