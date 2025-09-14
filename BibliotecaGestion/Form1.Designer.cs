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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chartLibros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDocumentacion = new System.Windows.Forms.Button();
            this.chartBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(47, 44);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(387, 188);
            this.dgvLibros.TabIndex = 0;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(47, 268);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(142, 268);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(245, 268);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(44, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Adminstrador de libros";
            // 
            // chartLibros
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLibros.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLibros.Legends.Add(legend1);
            this.chartLibros.Location = new System.Drawing.Point(417, 82);
            this.chartLibros.MaximumSize = new System.Drawing.Size(0, 200);
            this.chartLibros.Name = "chartLibros";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLibros.Series.Add(series1);
            this.chartLibros.Size = new System.Drawing.Size(0, 128);
            this.chartLibros.TabIndex = 5;
            this.chartLibros.Text = "chart1";
            // 
            // btnDocumentacion
            // 
            this.btnDocumentacion.Location = new System.Drawing.Point(368, 270);
            this.btnDocumentacion.Name = "btnDocumentacion";
            this.btnDocumentacion.Size = new System.Drawing.Size(99, 23);
            this.btnDocumentacion.TabIndex = 7;
            this.btnDocumentacion.Text = "Documentacion";
            this.btnDocumentacion.UseVisualStyleBackColor = true;
            this.btnDocumentacion.Click += new System.EventHandler(this.btnDocumentacion_Click);
            // 
            // chartBooks
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBooks.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBooks.Legends.Add(legend2);
            this.chartBooks.Location = new System.Drawing.Point(581, 30);
            this.chartBooks.Name = "chartBooks";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBooks.Series.Add(series2);
            this.chartBooks.Size = new System.Drawing.Size(245, 116);
            this.chartBooks.TabIndex = 8;
            this.chartBooks.Text = "chart1";
            // 
            // chartUsers
            // 
            chartArea3.Name = "ChartArea1";
            this.chartUsers.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartUsers.Legends.Add(legend3);
            this.chartUsers.Location = new System.Drawing.Point(581, 174);
            this.chartUsers.Name = "chartUsers";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartUsers.Series.Add(series3);
            this.chartUsers.Size = new System.Drawing.Size(249, 119);
            this.chartUsers.TabIndex = 9;
            this.chartUsers.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 344);
            this.Controls.Add(this.chartUsers);
            this.Controls.Add(this.chartBooks);
            this.Controls.Add(this.btnDocumentacion);
            this.Controls.Add(this.chartLibros);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dgvLibros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibros;
        private System.Windows.Forms.Button btnDocumentacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBooks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsers;
    }
}

