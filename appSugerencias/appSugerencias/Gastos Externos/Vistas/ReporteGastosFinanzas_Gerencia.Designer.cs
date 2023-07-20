
namespace appSugerencias.Gastos_Externos.Vistas
{
    partial class ReporteGastosFinanzas_Gerencia
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTOGRAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTODETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_excel = new System.Windows.Forms.Button();
            this.LB_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_abrir = new System.Windows.Forms.Button();
            this.LB_saldo_finanzas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.CONCEPTOGRAL,
            this.CONCEPTODETALLE,
            this.DESCRIPCION,
            this.IMPORTE,
            this.FOLIO,
            this.FECHA,
            this.CHECK});
            this.DG_tabla.Location = new System.Drawing.Point(-1, 156);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1271, 359);
            this.DG_tabla.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // CONCEPTOGRAL
            // 
            this.CONCEPTOGRAL.HeaderText = "CONCEPTO GENERAL";
            this.CONCEPTOGRAL.Name = "CONCEPTOGRAL";
            // 
            // CONCEPTODETALLE
            // 
            this.CONCEPTODETALLE.HeaderText = "CONCEPTO DETALLE";
            this.CONCEPTODETALLE.Name = "CONCEPTODETALLE";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // FOLIO
            // 
            this.FOLIO.HeaderText = "FOLIO";
            this.FOLIO.Name = "FOLIO";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // CHECK
            // 
            this.CHECK.HeaderText = "CHECK";
            this.CHECK.Name = "CHECK";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(981, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 148);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total gastos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.BT_excel);
            this.panel1.Controls.Add(this.LB_total);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 123);
            this.panel1.TabIndex = 0;
            // 
            // BT_excel
            // 
            this.BT_excel.BackColor = System.Drawing.Color.Green;
            this.BT_excel.ForeColor = System.Drawing.Color.White;
            this.BT_excel.Location = new System.Drawing.Point(190, 4);
            this.BT_excel.Name = "BT_excel";
            this.BT_excel.Size = new System.Drawing.Size(86, 38);
            this.BT_excel.TabIndex = 11;
            this.BT_excel.Text = "Excel";
            this.BT_excel.UseVisualStyleBackColor = false;
            this.BT_excel.Click += new System.EventHandler(this.BT_excel_Click_1);
            // 
            // LB_total
            // 
            this.LB_total.AutoSize = true;
            this.LB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_total.ForeColor = System.Drawing.Color.White;
            this.LB_total.Location = new System.Drawing.Point(55, 61);
            this.LB_total.Name = "LB_total";
            this.LB_total.Size = new System.Drawing.Size(0, 29);
            this.LB_total.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DT_inicio);
            this.groupBox1.Controls.Add(this.DT_fin);
            this.groupBox1.Controls.Add(this.BT_buscar);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 148);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda gastos";
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(132, 54);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 2;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(132, 80);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 1;
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(30, 55);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(96, 45);
            this.BT_buscar.TabIndex = 0;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_guardar);
            this.groupBox2.Location = new System.Drawing.Point(367, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 148);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guardar Estado";
            // 
            // BT_guardar
            // 
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(82, 54);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(96, 45);
            this.BT_guardar.TabIndex = 3;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Location = new System.Drawing.Point(684, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 148);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saldo Finanzas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.BT_abrir);
            this.panel2.Controls.Add(this.LB_saldo_finanzas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 123);
            this.panel2.TabIndex = 0;
            // 
            // BT_abrir
            // 
            this.BT_abrir.BackColor = System.Drawing.Color.Green;
            this.BT_abrir.ForeColor = System.Drawing.Color.White;
            this.BT_abrir.Location = new System.Drawing.Point(135, 4);
            this.BT_abrir.Name = "BT_abrir";
            this.BT_abrir.Size = new System.Drawing.Size(141, 38);
            this.BT_abrir.TabIndex = 11;
            this.BT_abrir.Text = "Abrir estado de cuenta";
            this.BT_abrir.UseVisualStyleBackColor = false;
            this.BT_abrir.Click += new System.EventHandler(this.BT_abrir_Click);
            // 
            // LB_saldo_finanzas
            // 
            this.LB_saldo_finanzas.AutoSize = true;
            this.LB_saldo_finanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_saldo_finanzas.ForeColor = System.Drawing.Color.White;
            this.LB_saldo_finanzas.Location = new System.Drawing.Point(55, 61);
            this.LB_saldo_finanzas.Name = "LB_saldo_finanzas";
            this.LB_saldo_finanzas.Size = new System.Drawing.Size(0, 29);
            this.LB_saldo_finanzas.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "SALDO";
            // 
            // ReporteGastosFinanzas_Gerencia
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1272, 514);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ReporteGastosFinanzas_Gerencia";
            this.Load += new System.EventHandler(this.ReporteGastosFinanzas_Gerencia_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_excel;
        private System.Windows.Forms.Label LB_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BT_guardar;


        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTOGRAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTODETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOLIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_abrir;
        private System.Windows.Forms.Label LB_saldo_finanzas;
        private System.Windows.Forms.Label label2;
    }
}