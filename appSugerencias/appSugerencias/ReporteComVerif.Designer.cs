namespace appSugerencias
{
    partial class ReporteComVerif
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
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.BT_consultar = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_total = new System.Windows.Forms.TextBox();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USUARIO,
            this.FECHA1,
            this.FECHA2,
            this.FECHA3,
            this.FECHA4,
            this.FECHA5,
            this.FECHA6,
            this.FECHA7,
            this.TOTAL});
            this.DG_tabla.Location = new System.Drawing.Point(12, 88);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1079, 276);
            this.DG_tabla.TabIndex = 0;
            // 
            // BT_consultar
            // 
            this.BT_consultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_consultar.ForeColor = System.Drawing.Color.White;
            this.BT_consultar.Location = new System.Drawing.Point(907, 22);
            this.BT_consultar.Name = "BT_consultar";
            this.BT_consultar.Size = new System.Drawing.Size(89, 49);
            this.BT_consultar.TabIndex = 1;
            this.BT_consultar.Text = "TRAER DATOS";
            this.BT_consultar.UseVisualStyleBackColor = false;
            this.BT_consultar.Click += new System.EventHandler(this.BT_consultar_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(1002, 22);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(89, 49);
            this.BT_exportar.TabIndex = 2;
            this.BT_exportar.Text = "EXPORTAR";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(57, 12);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 3;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(57, 51);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "INICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total comisiones";
            // 
            // TB_total
            // 
            this.TB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_total.Location = new System.Drawing.Point(973, 379);
            this.TB_total.Name = "TB_total";
            this.TB_total.Size = new System.Drawing.Size(118, 26);
            this.TB_total.TabIndex = 8;
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            // 
            // FECHA1
            // 
            this.FECHA1.HeaderText = "FECHA1";
            this.FECHA1.Name = "FECHA1";
            // 
            // FECHA2
            // 
            this.FECHA2.HeaderText = "FECHA2";
            this.FECHA2.Name = "FECHA2";
            // 
            // FECHA3
            // 
            this.FECHA3.HeaderText = "FECHA3";
            this.FECHA3.Name = "FECHA3";
            // 
            // FECHA4
            // 
            this.FECHA4.HeaderText = "FECHA4";
            this.FECHA4.Name = "FECHA4";
            // 
            // FECHA5
            // 
            this.FECHA5.HeaderText = "FECHA5";
            this.FECHA5.Name = "FECHA5";
            // 
            // FECHA6
            // 
            this.FECHA6.HeaderText = "FECHA6";
            this.FECHA6.Name = "FECHA6";
            // 
            // FECHA7
            // 
            this.FECHA7.HeaderText = "FECHA7";
            this.FECHA7.Name = "FECHA7";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // ReporteComVerif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1105, 427);
            this.Controls.Add(this.TB_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_consultar);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ReporteComVerif";
            this.Text = "Reporte Comisiones Verificadores";
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_consultar;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}