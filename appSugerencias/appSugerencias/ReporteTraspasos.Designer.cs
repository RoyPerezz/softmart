namespace appSugerencias
{
    partial class ReporteTraspasos
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
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DG_traspasos = new System.Windows.Forms.DataGridView();
            this.TRASPASO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_detalle_traspasos = new System.Windows.Forms.DataGridView();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_conexion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_aplicado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_fecha_aplicacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_motivo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_destino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_origen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_creador = new System.Windows.Forms.TextBox();
            this.TB_status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_fecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_pdf = new System.Windows.Forms.Button();
            this.TB_observacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_traspasos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_detalle_traspasos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Location = new System.Drawing.Point(52, 35);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(150, 21);
            this.CB_sucursal.TabIndex = 0;
            this.CB_sucursal.SelectedIndexChanged += new System.EventHandler(this.CB_sucursal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sucursal";
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(51, 63);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(203, 20);
            this.DT_inicio.TabIndex = 2;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(51, 98);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(203, 20);
            this.DT_fin.TabIndex = 3;
            // 
            // DG_traspasos
            // 
            this.DG_traspasos.AllowUserToAddRows = false;
            this.DG_traspasos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DG_traspasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_traspasos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TRASPASO});
            this.DG_traspasos.Location = new System.Drawing.Point(5, 169);
            this.DG_traspasos.Name = "DG_traspasos";
            this.DG_traspasos.Size = new System.Drawing.Size(143, 467);
            this.DG_traspasos.TabIndex = 4;
            this.DG_traspasos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_traspasos_CellContentDoubleClick);
            // 
            // TRASPASO
            // 
            this.TRASPASO.HeaderText = "TRASPASO";
            this.TRASPASO.Name = "TRASPASO";
            // 
            // DG_detalle_traspasos
            // 
            this.DG_detalle_traspasos.AllowUserToAddRows = false;
            this.DG_detalle_traspasos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_detalle_traspasos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_detalle_traspasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_detalle_traspasos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARTICULO,
            this.DESCRIPCION,
            this.CANTIDAD});
            this.DG_detalle_traspasos.Location = new System.Drawing.Point(154, 169);
            this.DG_detalle_traspasos.Name = "DG_detalle_traspasos";
            this.DG_detalle_traspasos.Size = new System.Drawing.Size(924, 467);
            this.DG_detalle_traspasos.TabIndex = 5;
            // 
            // ARTICULO
            // 
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fin";
            // 
            // LB_conexion
            // 
            this.LB_conexion.AutoSize = true;
            this.LB_conexion.Location = new System.Drawing.Point(255, 38);
            this.LB_conexion.Name = "LB_conexion";
            this.LB_conexion.Size = new System.Drawing.Size(0, 13);
            this.LB_conexion.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_buscar);
            this.groupBox1.Controls.Add(this.DT_fin);
            this.groupBox1.Controls.Add(this.LB_conexion);
            this.groupBox1.Controls.Add(this.CB_sucursal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DT_inicio);
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(260, 63);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(75, 55);
            this.BT_buscar.TabIndex = 9;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TB_aplicado);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TB_fecha_aplicacion);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TB_id);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TB_motivo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TB_destino);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TB_origen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TB_creador);
            this.groupBox2.Controls.Add(this.TB_status);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TB_fecha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(353, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 128);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // TB_aplicado
            // 
            this.TB_aplicado.Location = new System.Drawing.Point(616, 64);
            this.TB_aplicado.Name = "TB_aplicado";
            this.TB_aplicado.Size = new System.Drawing.Size(100, 20);
            this.TB_aplicado.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(544, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Aplicado por";
            // 
            // TB_fecha_aplicacion
            // 
            this.TB_fecha_aplicacion.Location = new System.Drawing.Point(616, 22);
            this.TB_fecha_aplicacion.Name = "TB_fecha_aplicacion";
            this.TB_fecha_aplicacion.Size = new System.Drawing.Size(100, 20);
            this.TB_fecha_aplicacion.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(522, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Fecha aplicación";
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(54, 23);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(100, 20);
            this.TB_id.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Traspaso";
            // 
            // TB_motivo
            // 
            this.TB_motivo.Location = new System.Drawing.Point(49, 102);
            this.TB_motivo.Name = "TB_motivo";
            this.TB_motivo.Size = new System.Drawing.Size(667, 20);
            this.TB_motivo.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Motivo";
            // 
            // TB_destino
            // 
            this.TB_destino.Location = new System.Drawing.Point(210, 64);
            this.TB_destino.Name = "TB_destino";
            this.TB_destino.Size = new System.Drawing.Size(100, 20);
            this.TB_destino.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Destino";
            // 
            // TB_origen
            // 
            this.TB_origen.Location = new System.Drawing.Point(53, 64);
            this.TB_origen.Name = "TB_origen";
            this.TB_origen.Size = new System.Drawing.Size(100, 20);
            this.TB_origen.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Origen";
            // 
            // TB_creador
            // 
            this.TB_creador.Location = new System.Drawing.Point(411, 64);
            this.TB_creador.Name = "TB_creador";
            this.TB_creador.Size = new System.Drawing.Size(100, 20);
            this.TB_creador.TabIndex = 6;
            // 
            // TB_status
            // 
            this.TB_status.Location = new System.Drawing.Point(211, 24);
            this.TB_status.Name = "TB_status";
            this.TB_status.Size = new System.Drawing.Size(100, 20);
            this.TB_status.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Creado por";
            // 
            // TB_fecha
            // 
            this.TB_fecha.Location = new System.Drawing.Point(411, 22);
            this.TB_fecha.Name = "TB_fecha";
            this.TB_fecha.Size = new System.Drawing.Size(100, 20);
            this.TB_fecha.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha creación";
            // 
            // BT_pdf
            // 
            this.BT_pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_pdf.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_pdf.ForeColor = System.Drawing.Color.White;
            this.BT_pdf.Location = new System.Drawing.Point(910, 639);
            this.BT_pdf.Name = "BT_pdf";
            this.BT_pdf.Size = new System.Drawing.Size(168, 40);
            this.BT_pdf.TabIndex = 10;
            this.BT_pdf.Text = "PDF";
            this.BT_pdf.UseVisualStyleBackColor = false;
            this.BT_pdf.Click += new System.EventHandler(this.BT_pdf_Click);
            // 
            // TB_observacion
            // 
            this.TB_observacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_observacion.Location = new System.Drawing.Point(154, 650);
            this.TB_observacion.Name = "TB_observacion";
            this.TB_observacion.Size = new System.Drawing.Size(734, 20);
            this.TB_observacion.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 653);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Observación";
            // 
            // ReporteTraspasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1090, 688);
            this.Controls.Add(this.TB_observacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BT_pdf);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_detalle_traspasos);
            this.Controls.Add(this.DG_traspasos);
            this.Name = "ReporteTraspasos";
            this.Text = "ReporteTraspasos";
            this.Load += new System.EventHandler(this.ReporteTraspasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_traspasos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_detalle_traspasos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DataGridView DG_traspasos;
        private System.Windows.Forms.DataGridView DG_detalle_traspasos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_conexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRASPASO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_motivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_destino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_origen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_creador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_pdf;
        private System.Windows.Forms.TextBox TB_observacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_aplicado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_fecha_aplicacion;
        private System.Windows.Forms.Label label13;
    }
}