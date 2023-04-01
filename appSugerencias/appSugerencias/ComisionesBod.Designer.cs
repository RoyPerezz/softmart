namespace appSugerencias
{
    partial class ComisionesBod
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
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_consultar = new System.Windows.Forms.Button();
            this.BT_calcular = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MERC_NO_RESAGADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MERC_SIN_DAÑO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APOYO_ETI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAL_ETIQUETADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_PAGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.FECHA1,
            this.FECHA2,
            this.FECHA3,
            this.FECHA4,
            this.FECHA5,
            this.FECHA6,
            this.FECHA7,
            this.MERC_NO_RESAGADA,
            this.MERC_SIN_DAÑO,
            this.APOYO_ETI,
            this.COMENTARIO,
            this.MAL_ETIQUETADO,
            this.ASEO,
            this.TOTAL_PAGAR});
            this.DG_tabla.Location = new System.Drawing.Point(3, 99);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1430, 298);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(52, 15);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 1;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(52, 53);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "INICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FIN";
            // 
            // BT_consultar
            // 
            this.BT_consultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_consultar.ForeColor = System.Drawing.Color.White;
            this.BT_consultar.Location = new System.Drawing.Point(268, 12);
            this.BT_consultar.Name = "BT_consultar";
            this.BT_consultar.Size = new System.Drawing.Size(101, 61);
            this.BT_consultar.TabIndex = 5;
            this.BT_consultar.Text = "TRAER DATOS";
            this.BT_consultar.UseVisualStyleBackColor = false;
            this.BT_consultar.Click += new System.EventHandler(this.BT_consultar_Click);
            // 
            // BT_calcular
            // 
            this.BT_calcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_calcular.ForeColor = System.Drawing.Color.White;
            this.BT_calcular.Location = new System.Drawing.Point(375, 12);
            this.BT_calcular.Name = "BT_calcular";
            this.BT_calcular.Size = new System.Drawing.Size(101, 61);
            this.BT_calcular.TabIndex = 6;
            this.BT_calcular.Text = "CALCULAR";
            this.BT_calcular.UseVisualStyleBackColor = false;
            this.BT_calcular.Click += new System.EventHandler(this.BT_calcular_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(482, 12);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(101, 61);
            this.BT_exportar.TabIndex = 7;
            this.BT_exportar.Text = "EXPORTAR";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
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
            // MERC_NO_RESAGADA
            // 
            this.MERC_NO_RESAGADA.HeaderText = "MERC. NO RESGADA";
            this.MERC_NO_RESAGADA.Name = "MERC_NO_RESAGADA";
            // 
            // MERC_SIN_DAÑO
            // 
            this.MERC_SIN_DAÑO.HeaderText = "MERC. NO DAÑADA";
            this.MERC_SIN_DAÑO.Name = "MERC_SIN_DAÑO";
            // 
            // APOYO_ETI
            // 
            this.APOYO_ETI.HeaderText = "APOYO ETIQUETADOR";
            this.APOYO_ETI.Name = "APOYO_ETI";
            // 
            // COMENTARIO
            // 
            this.COMENTARIO.HeaderText = "COMENTARIO";
            this.COMENTARIO.Name = "COMENTARIO";
            // 
            // MAL_ETIQUETADO
            // 
            this.MAL_ETIQUETADO.HeaderText = "MAL ETIQUETADO";
            this.MAL_ETIQUETADO.Name = "MAL_ETIQUETADO";
            // 
            // ASEO
            // 
            this.ASEO.HeaderText = "FALTA DE ASEO";
            this.ASEO.Name = "ASEO";
            // 
            // TOTAL_PAGAR
            // 
            this.TOTAL_PAGAR.HeaderText = "TOTAL";
            this.TOTAL_PAGAR.Name = "TOTAL_PAGAR";
            // 
            // TB_total
            // 
            this.TB_total.BackColor = System.Drawing.Color.Black;
            this.TB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_total.ForeColor = System.Drawing.Color.Lime;
            this.TB_total.Location = new System.Drawing.Point(1314, 404);
            this.TB_total.Name = "TB_total";
            this.TB_total.Size = new System.Drawing.Size(119, 26);
            this.TB_total.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1196, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TOTAL COMISIONES";
            // 
            // ComisionesBod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1436, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_total);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_calcular);
            this.Controls.Add(this.BT_consultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ComisionesBod";
            this.Text = "ComisionesBod";
            this.Load += new System.EventHandler(this.ComisionesBod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_consultar;
        private System.Windows.Forms.Button BT_calcular;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MERC_NO_RESAGADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MERC_SIN_DAÑO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APOYO_ETI;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAL_ETIQUETADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASEO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_PAGAR;
        private System.Windows.Forms.TextBox TB_total;
        private System.Windows.Forms.Label label3;
    }
}