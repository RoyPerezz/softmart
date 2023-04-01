namespace appSugerencias
{
    partial class ModificarDatosDev
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
            this.BT_guardar = new System.Windows.Forms.Button();
            this.CB_proveedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_idProv = new System.Windows.Forms.TextBox();
            this.TB_factura = new System.Windows.Forms.TextBox();
            this.TB_observacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_sucursal = new System.Windows.Forms.TextBox();
            this.TB_compra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_guardar
            // 
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(343, 137);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(111, 41);
            this.BT_guardar.TabIndex = 0;
            this.BT_guardar.Text = "Aplicar Cambios";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // CB_proveedores
            // 
            this.CB_proveedores.FormattingEnabled = true;
            this.CB_proveedores.Location = new System.Drawing.Point(97, 48);
            this.CB_proveedores.Name = "CB_proveedores";
            this.CB_proveedores.Size = new System.Drawing.Size(273, 21);
            this.CB_proveedores.TabIndex = 1;
            this.CB_proveedores.SelectedIndexChanged += new System.EventHandler(this.CB_proveedores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROVEEDOR";
            // 
            // TB_idProv
            // 
            this.TB_idProv.Location = new System.Drawing.Point(376, 49);
            this.TB_idProv.Name = "TB_idProv";
            this.TB_idProv.Size = new System.Drawing.Size(78, 20);
            this.TB_idProv.TabIndex = 3;
            // 
            // TB_factura
            // 
            this.TB_factura.Location = new System.Drawing.Point(97, 75);
            this.TB_factura.Name = "TB_factura";
            this.TB_factura.Size = new System.Drawing.Size(357, 20);
            this.TB_factura.TabIndex = 4;
            // 
            // TB_observacion
            // 
            this.TB_observacion.Location = new System.Drawing.Point(97, 101);
            this.TB_observacion.Name = "TB_observacion";
            this.TB_observacion.Size = new System.Drawing.Size(357, 20);
            this.TB_observacion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FACTURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OBSERVACION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_compra);
            this.groupBox1.Controls.Add(this.TB_sucursal);
            this.groupBox1.Controls.Add(this.BT_guardar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_proveedores);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_observacion);
            this.groupBox1.Controls.Add(this.TB_idProv);
            this.groupBox1.Controls.Add(this.TB_factura);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // TB_sucursal
            // 
            this.TB_sucursal.Location = new System.Drawing.Point(97, 22);
            this.TB_sucursal.Name = "TB_sucursal";
            this.TB_sucursal.Size = new System.Drawing.Size(87, 20);
            this.TB_sucursal.TabIndex = 8;
            // 
            // TB_compra
            // 
            this.TB_compra.Location = new System.Drawing.Point(292, 23);
            this.TB_compra.Name = "TB_compra";
            this.TB_compra.Size = new System.Drawing.Size(78, 20);
            this.TB_compra.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SUCURSAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "COMPRA";
            // 
            // ModificarDatosDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(504, 237);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarDatosDev";
            this.Text = "ModificarDatosDev";
            this.Load += new System.EventHandler(this.ModificarDatosDev_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.ComboBox CB_proveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_idProv;
        private System.Windows.Forms.TextBox TB_factura;
        private System.Windows.Forms.TextBox TB_observacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_compra;
        private System.Windows.Forms.TextBox TB_sucursal;
    }
}