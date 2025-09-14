namespace BibliotecaGestion
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGestionAvanzada = new System.Windows.Forms.Button();
            this.chartBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLibros = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelGraficos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).BeginInit();
            this.panelLibros.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelGraficos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.GridColor = System.Drawing.Color.LightGray;
            this.dgvLibros.Location = new System.Drawing.Point(10, 35);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(430, 462);
            this.dgvLibros.TabIndex = 0;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(10, 10);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(90, 35);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "➕ Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(110, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 35);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "✏️ Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(210, 10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "🗑️ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(6, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 21);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "📚 Administrador de Libros";
            // 
            // btnGestionAvanzada
            // 
            this.btnGestionAvanzada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btnGestionAvanzada.FlatAppearance.BorderSize = 0;
            this.btnGestionAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionAvanzada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionAvanzada.ForeColor = System.Drawing.Color.White;
            this.btnGestionAvanzada.Location = new System.Drawing.Point(320, 10);
            this.btnGestionAvanzada.Name = "btnGestionAvanzada";
            this.btnGestionAvanzada.Size = new System.Drawing.Size(120, 35);
            this.btnGestionAvanzada.TabIndex = 7;
            this.btnGestionAvanzada.Text = "⚙️ Gestión Avanzada";
            this.btnGestionAvanzada.UseVisualStyleBackColor = false;
            this.btnGestionAvanzada.Click += new System.EventHandler(this.btnGestionAvanzada_Click);
            // 
            // chartBooks
            // 
            this.chartBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            chartArea1.Name = "ChartArea1";
            this.chartBooks.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartBooks.Legends.Add(legend1);
            this.chartBooks.Location = new System.Drawing.Point(10, 10);
            this.chartBooks.Name = "chartBooks";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBooks.Series.Add(series1);
            this.chartBooks.Size = new System.Drawing.Size(450, 280);
            this.chartBooks.TabIndex = 8;
            this.chartBooks.Text = "chart1";
            // 
            // chartUsers
            // 
            this.chartUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            chartArea2.Name = "ChartArea1";
            this.chartUsers.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chartUsers.Legends.Add(legend2);
            this.chartUsers.Location = new System.Drawing.Point(10, 300);
            this.chartUsers.Name = "chartUsers";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartUsers.Series.Add(series2);
            this.chartUsers.Size = new System.Drawing.Size(450, 280);
            this.chartUsers.TabIndex = 9;
            this.chartUsers.Text = "chart2";
            // 
            // panelLibros
            // 
            this.panelLibros.BackColor = System.Drawing.Color.White;
            this.panelLibros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLibros.Controls.Add(this.lblTitulo);
            this.panelLibros.Controls.Add(this.dgvLibros);
            this.panelLibros.Location = new System.Drawing.Point(20, 20);
            this.panelLibros.Name = "panelLibros";
            this.panelLibros.Size = new System.Drawing.Size(460, 534);
            this.panelLibros.TabIndex = 10;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnAñadir);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnGestionAvanzada);
            this.panelBotones.Location = new System.Drawing.Point(20, 560);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(460, 60);
            this.panelBotones.TabIndex = 11;
            // 
            // panelGraficos
            // 
            this.panelGraficos.BackColor = System.Drawing.Color.White;
            this.panelGraficos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraficos.Controls.Add(this.chartBooks);
            this.panelGraficos.Controls.Add(this.chartUsers);
            this.panelGraficos.Location = new System.Drawing.Point(500, 20);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(480, 600);
            this.panelGraficos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelGraficos);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelLibros);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📚 Sistema de Gestión de Biblioteca - Dashboard Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).EndInit();
            this.panelLibros.ResumeLayout(false);
            this.panelLibros.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelGraficos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGestionAvanzada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBooks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsers;
        private System.Windows.Forms.Panel panelLibros;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelGraficos;
    }
}

