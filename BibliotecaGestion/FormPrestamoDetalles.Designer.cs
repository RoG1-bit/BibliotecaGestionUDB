namespace BibliotecaGestion
{
    partial class FormPrestamoDetalles
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.lblInfoUsuario = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbLibro = new System.Windows.Forms.GroupBox();
            this.lblInfoLibro = new System.Windows.Forms.Label();
            this.cboLibro = new System.Windows.Forms.ComboBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.panelDevolucion = new System.Windows.Forms.Panel();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.chkDevuelto = new System.Windows.Forms.CheckBox();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.gbLibro.SuspendLayout();
            this.gbFechas.SuspendLayout();
            this.panelDevolucion.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.gbUsuario);
            this.panelPrincipal.Controls.Add(this.gbLibro);
            this.panelPrincipal.Controls.Add(this.gbFechas);
            this.panelPrincipal.Controls.Add(this.lblTitulo);
            this.panelPrincipal.Location = new System.Drawing.Point(25, 25);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(500, 420);
            this.panelPrincipal.TabIndex = 0;
            // 
            // gbUsuario
            // 
            this.gbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gbUsuario.Controls.Add(this.lblInfoUsuario);
            this.gbUsuario.Controls.Add(this.cboUsuario);
            this.gbUsuario.Controls.Add(this.lblUsuario);
            this.gbUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.gbUsuario.Location = new System.Drawing.Point(30, 60);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(440, 90);
            this.gbUsuario.TabIndex = 0;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuario del préstamo";
            // 
            // lblInfoUsuario
            // 
            this.lblInfoUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblInfoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblInfoUsuario.Location = new System.Drawing.Point(20, 60);
            this.lblInfoUsuario.Name = "lblInfoUsuario";
            this.lblInfoUsuario.Size = new System.Drawing.Size(400, 20);
            this.lblInfoUsuario.TabIndex = 2;
            this.lblInfoUsuario.Text = "Seleccione un usuario para ver información adicional";
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(70, 30);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(350, 23);
            this.cboUsuario.TabIndex = 1;
            this.cboUsuario.SelectedIndexChanged += new System.EventHandler(this.cboUsuario_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lblUsuario.Location = new System.Drawing.Point(20, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // gbLibro
            // 
            this.gbLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gbLibro.Controls.Add(this.lblInfoLibro);
            this.gbLibro.Controls.Add(this.cboLibro);
            this.gbLibro.Controls.Add(this.lblLibro);
            this.gbLibro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.gbLibro.Location = new System.Drawing.Point(30, 170);
            this.gbLibro.Name = "gbLibro";
            this.gbLibro.Size = new System.Drawing.Size(440, 90);
            this.gbLibro.TabIndex = 1;
            this.gbLibro.TabStop = false;
            this.gbLibro.Text = "Libro a prestar";
            // 
            // lblInfoLibro
            // 
            this.lblInfoLibro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblInfoLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblInfoLibro.Location = new System.Drawing.Point(20, 60);
            this.lblInfoLibro.Name = "lblInfoLibro";
            this.lblInfoLibro.Size = new System.Drawing.Size(400, 20);
            this.lblInfoLibro.TabIndex = 2;
            this.lblInfoLibro.Text = "Seleccione un libro para ver información adicional";
            // 
            // cboLibro
            // 
            this.cboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLibro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLibro.FormattingEnabled = true;
            this.cboLibro.Location = new System.Drawing.Point(70, 30);
            this.cboLibro.Name = "cboLibro";
            this.cboLibro.Size = new System.Drawing.Size(350, 23);
            this.cboLibro.TabIndex = 1;
            this.cboLibro.SelectedIndexChanged += new System.EventHandler(this.cboLibro_SelectedIndexChanged);
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lblLibro.Location = new System.Drawing.Point(20, 33);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(36, 15);
            this.lblLibro.TabIndex = 0;
            this.lblLibro.Text = "Libro:";
            // 
            // gbFechas
            // 
            this.gbFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gbFechas.Controls.Add(this.panelDevolucion);
            this.gbFechas.Controls.Add(this.chkDevuelto);
            this.gbFechas.Controls.Add(this.dtpFechaPrestamo);
            this.gbFechas.Controls.Add(this.lblFechaPrestamo);
            this.gbFechas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.gbFechas.Location = new System.Drawing.Point(30, 280);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(440, 120);
            this.gbFechas.TabIndex = 2;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Fechas del préstamo";
            // 
            // panelDevolucion
            // 
            this.panelDevolucion.Controls.Add(this.dtpFechaDevolucion);
            this.panelDevolucion.Controls.Add(this.lblFechaDevolucion);
            this.panelDevolucion.Enabled = false;
            this.panelDevolucion.Location = new System.Drawing.Point(20, 85);
            this.panelDevolucion.Name = "panelDevolucion";
            this.panelDevolucion.Size = new System.Drawing.Size(400, 30);
            this.panelDevolucion.TabIndex = 3;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(140, 3);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(120, 23);
            this.dtpFechaDevolucion.TabIndex = 1;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lblFechaDevolucion.Location = new System.Drawing.Point(3, 6);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(121, 15);
            this.lblFechaDevolucion.TabIndex = 0;
            this.lblFechaDevolucion.Text = "Fecha de devolución:";
            // 
            // chkDevuelto
            // 
            this.chkDevuelto.AutoSize = true;
            this.chkDevuelto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkDevuelto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.chkDevuelto.Location = new System.Drawing.Point(20, 60);
            this.chkDevuelto.Name = "chkDevuelto";
            this.chkDevuelto.Size = new System.Drawing.Size(173, 19);
            this.chkDevuelto.TabIndex = 2;
            this.chkDevuelto.Text = "Marcar como devuelto ahora";
            this.chkDevuelto.UseVisualStyleBackColor = true;
            this.chkDevuelto.CheckedChanged += new System.EventHandler(this.chkDevuelto_CheckedChanged);
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(160, 30);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(120, 23);
            this.dtpFechaPrestamo.TabIndex = 1;
            this.dtpFechaPrestamo.Value = System.DateTime.Now;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lblFechaPrestamo.Location = new System.Drawing.Point(20, 33);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(109, 15);
            this.lblFechaPrestamo.TabIndex = 0;
            this.lblFechaPrestamo.Text = "Fecha de préstamo:";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Location = new System.Drawing.Point(25, 460);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(500, 60);
            this.panelBotones.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(300, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 32);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(400, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(153, 21);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Gestión de préstamo";
            // 
            // FormPrestamoDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(550, 540);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrestamoDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Gestión - Préstamos";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbLibro.ResumeLayout(false);
            this.gbLibro.PerformLayout();
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            this.panelDevolucion.ResumeLayout(false);
            this.panelDevolucion.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label lblInfoUsuario;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbLibro;
        private System.Windows.Forms.Label lblInfoLibro;
        private System.Windows.Forms.ComboBox cboLibro;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.Panel panelDevolucion;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.CheckBox chkDevuelto;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
    }
}