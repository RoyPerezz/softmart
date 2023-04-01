namespace appSugerencias
{
    partial class PagosEncCajas
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.TB_filtro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_referencia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_transferencia = new System.Windows.Forms.ComboBox();
            this.LB_etiqueta = new System.Windows.Forms.Label();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.CHK_transferencia = new System.Windows.Forms.CheckBox();
            this.BT_reporte = new System.Windows.Forms.Button();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDOR";
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(102, 55);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(444, 21);
            this.CB_proveedor.TabIndex = 1;
            // 
            // TB_filtro
            // 
            this.TB_filtro.Location = new System.Drawing.Point(71, 39);
            this.TB_filtro.Name = "TB_filtro";
            this.TB_filtro.Size = new System.Drawing.Size(444, 20);
            this.TB_filtro.TabIndex = 2;
            this.TB_filtro.TextChanged += new System.EventHandler(this.TB_filtro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FILTRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "IMPORTE";
            // 
            // TB_importe
            // 
            this.TB_importe.Location = new System.Drawing.Point(100, 90);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(159, 20);
            this.TB_importe.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "REFERENCIA";
            // 
            // TB_referencia
            // 
            this.TB_referencia.Location = new System.Drawing.Point(102, 122);
            this.TB_referencia.Name = "TB_referencia";
            this.TB_referencia.Size = new System.Drawing.Size(377, 20);
            this.TB_referencia.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_transferencia);
            this.groupBox1.Controls.Add(this.LB_etiqueta);
            this.groupBox1.Controls.Add(this.TB_importe);
            this.groupBox1.Controls.Add(this.CB_proveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_referencia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(23, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 166);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PROVEEDOR";
            // 
            // CB_transferencia
            // 
            this.CB_transferencia.FormattingEnabled = true;
            this.CB_transferencia.Location = new System.Drawing.Point(137, 28);
            this.CB_transferencia.Name = "CB_transferencia";
            this.CB_transferencia.Size = new System.Drawing.Size(409, 21);
            this.CB_transferencia.TabIndex = 18;
            this.CB_transferencia.Visible = false;
            this.CB_transferencia.SelectedIndexChanged += new System.EventHandler(this.CB_transferencia_SelectedIndexChanged);
            // 
            // LB_etiqueta
            // 
            this.LB_etiqueta.AutoSize = true;
            this.LB_etiqueta.Location = new System.Drawing.Point(21, 31);
            this.LB_etiqueta.Name = "LB_etiqueta";
            this.LB_etiqueta.Size = new System.Drawing.Size(110, 13);
            this.LB_etiqueta.TabIndex = 17;
            this.LB_etiqueta.Text = "TRANSFERENCIA A:";
            this.LB_etiqueta.Visible = false;
            // 
            // BT_guardar
            // 
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(495, 285);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(100, 49);
            this.BT_guardar.TabIndex = 19;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // CHK_transferencia
            // 
            this.CHK_transferencia.AutoSize = true;
            this.CHK_transferencia.Location = new System.Drawing.Point(504, 80);
            this.CHK_transferencia.Name = "CHK_transferencia";
            this.CHK_transferencia.Size = new System.Drawing.Size(91, 17);
            this.CHK_transferencia.TabIndex = 19;
            this.CHK_transferencia.Text = "Transferencia";
            this.CHK_transferencia.UseVisualStyleBackColor = true;
            this.CHK_transferencia.CheckedChanged += new System.EventHandler(this.CHK_transferencia_CheckedChanged);
            // 
            // BT_reporte
            // 
            this.BT_reporte.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_reporte.ForeColor = System.Drawing.Color.White;
            this.BT_reporte.Location = new System.Drawing.Point(24, 285);
            this.BT_reporte.Name = "BT_reporte";
            this.BT_reporte.Size = new System.Drawing.Size(100, 49);
            this.BT_reporte.TabIndex = 20;
            this.BT_reporte.Text = "Historial";
            this.BT_reporte.UseVisualStyleBackColor = false;
            this.BT_reporte.Click += new System.EventHandler(this.BT_reporte_Click);
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(403, 12);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 21;
            // 
            // PagosEncCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(615, 345);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.BT_reporte);
            this.Controls.Add(this.CHK_transferencia);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_filtro);
            this.Name = "PagosEncCajas";
            this.Text = "PagosEncCajas";
            this.Load += new System.EventHandler(this.PagosEncCajas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.TextBox TB_filtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_referencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.ComboBox CB_transferencia;
        private System.Windows.Forms.Label LB_etiqueta;
        private System.Windows.Forms.CheckBox CHK_transferencia;
        private System.Windows.Forms.Button BT_reporte;
        private System.Windows.Forms.DateTimePicker DT_fecha;
    }
}