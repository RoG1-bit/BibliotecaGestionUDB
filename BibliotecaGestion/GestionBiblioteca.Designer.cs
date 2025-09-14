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
            this.gbUsusarios = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAñadirUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.btnAñadirPrestamos = new System.Windows.Forms.Button();
            this.btnEditarPrestamo = new System.Windows.Forms.Button();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbUsusarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsusarios
            // 
            this.gbUsusarios.Controls.Add(this.dgvUsuarios);
            this.gbUsusarios.Location = new System.Drawing.Point(3, 12);
            this.gbUsusarios.Name = "gbUsusarios";
            this.gbUsusarios.Size = new System.Drawing.Size(416, 163);
            this.gbUsusarios.TabIndex = 0;
            this.gbUsusarios.TabStop = false;
            this.gbUsusarios.Text = "Admistradar Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(19, 29);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(391, 118);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // btnAñadirUsuario
            // 
            this.btnAñadirUsuario.Location = new System.Drawing.Point(3, 181);
            this.btnAñadirUsuario.Name = "btnAñadirUsuario";
            this.btnAñadirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirUsuario.TabIndex = 1;
            this.btnAñadirUsuario.Text = "Añadir";
            this.btnAñadirUsuario.UseVisualStyleBackColor = true;
            this.btnAñadirUsuario.Click += new System.EventHandler(this.btnAñadirUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(93, 181);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarUsuario.TabIndex = 2;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(183, 181);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.dgvPrestamos);
            this.gb2.Location = new System.Drawing.Point(3, 246);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(416, 138);
            this.gb2.TabIndex = 4;
            this.gb2.TabStop = false;
            this.gb2.Text = "Gestionar Prestamos";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(6, 29);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(404, 94);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(45, 34);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(255, 21);
            this.cboUsuarios.TabIndex = 5;
            // 
            // btnAñadirPrestamos
            // 
            this.btnAñadirPrestamos.Location = new System.Drawing.Point(3, 404);
            this.btnAñadirPrestamos.Name = "btnAñadirPrestamos";
            this.btnAñadirPrestamos.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirPrestamos.TabIndex = 6;
            this.btnAñadirPrestamos.Text = "Añadir";
            this.btnAñadirPrestamos.UseVisualStyleBackColor = true;
            this.btnAñadirPrestamos.Click += new System.EventHandler(this.btnAñadirPrestamos_Click);
            // 
            // btnEditarPrestamo
            // 
            this.btnEditarPrestamo.Location = new System.Drawing.Point(113, 403);
            this.btnEditarPrestamo.Name = "btnEditarPrestamo";
            this.btnEditarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPrestamo.TabIndex = 7;
            this.btnEditarPrestamo.Text = "Editar";
            this.btnEditarPrestamo.UseVisualStyleBackColor = true;
            this.btnEditarPrestamo.Click += new System.EventHandler(this.btnEditarPrestamo_Click);
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(254, 403);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPrestamo.TabIndex = 8;
            this.btnEliminarPrestamo.Text = "Eliminar";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(458, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 152);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // GestionBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.btnEditarPrestamo);
            this.Controls.Add(this.btnAñadirPrestamos);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnAñadirUsuario);
            this.Controls.Add(this.gbUsusarios);
            this.Name = "GestionBiblioteca";
            this.Text = "GestionBiblioteca";
            this.Load += new System.EventHandler(this.GestionBiblioteca_Load);
            this.gbUsusarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsusarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnAñadirUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Button btnAñadirPrestamos;
        private System.Windows.Forms.Button btnEditarPrestamo;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}