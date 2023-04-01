namespace appSugerencias
{
    partial class DevolverDineroACuentaOsmart
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
            this.BT_depositar = new System.Windows.Forms.Button();
            this.TB_nombreProv = new System.Windows.Forms.TextBox();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_referencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_compra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_importeComp = new System.Windows.Forms.TextBox();
            this.CHX_importe = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_mov = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_sucursal = new System.Windows.Forms.TextBox();
            this.CB_cuentaOsmart = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_banco = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_cliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CB_sucursal_banco = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CHX_deposito_sinprov = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_depositar
            // 
            this.BT_depositar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_depositar.ForeColor = System.Drawing.Color.White;
            this.BT_depositar.Location = new System.Drawing.Point(678, 139);
            this.BT_depositar.Name = "BT_depositar";
            this.BT_depositar.Size = new System.Drawing.Size(93, 46);
            this.BT_depositar.TabIndex = 0;
            this.BT_depositar.Text = "Depositar";
            this.BT_depositar.UseVisualStyleBackColor = false;
            this.BT_depositar.Click += new System.EventHandler(this.BT_depositar_Click);
            // 
            // TB_nombreProv
            // 
            this.TB_nombreProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_nombreProv.Location = new System.Drawing.Point(120, 53);
            this.TB_nombreProv.Name = "TB_nombreProv";
            this.TB_nombreProv.ReadOnly = true;
            this.TB_nombreProv.Size = new System.Drawing.Size(541, 22);
            this.TB_nombreProv.TabIndex = 1;
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_proveedor.Location = new System.Drawing.Point(697, 53);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.ReadOnly = true;
            this.TB_proveedor.Size = new System.Drawing.Size(60, 22);
            this.TB_proveedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROVEEDOR";
            // 
            // TB_importe
            // 
            this.TB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importe.Location = new System.Drawing.Point(558, 162);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(106, 22);
            this.TB_importe.TabIndex = 4;
            this.TB_importe.TextChanged += new System.EventHandler(this.TB_importe_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "IMPORTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "REFERENCIA";
            // 
            // TB_referencia
            // 
            this.TB_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_referencia.Location = new System.Drawing.Point(120, 136);
            this.TB_referencia.Name = "TB_referencia";
            this.TB_referencia.Size = new System.Drawing.Size(637, 22);
            this.TB_referencia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "COMPRA";
            // 
            // TB_compra
            // 
            this.TB_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_compra.Location = new System.Drawing.Point(120, 96);
            this.TB_compra.Name = "TB_compra";
            this.TB_compra.ReadOnly = true;
            this.TB_compra.Size = new System.Drawing.Size(69, 22);
            this.TB_compra.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "IMPORTE COMPRA";
            // 
            // TB_importeComp
            // 
            this.TB_importeComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importeComp.Location = new System.Drawing.Point(652, 174);
            this.TB_importeComp.Name = "TB_importeComp";
            this.TB_importeComp.ReadOnly = true;
            this.TB_importeComp.Size = new System.Drawing.Size(106, 22);
            this.TB_importeComp.TabIndex = 10;
            // 
            // CHX_importe
            // 
            this.CHX_importe.AutoSize = true;
            this.CHX_importe.Location = new System.Drawing.Point(516, 139);
            this.CHX_importe.Name = "CHX_importe";
            this.CHX_importe.Size = new System.Drawing.Size(148, 17);
            this.CHX_importe.TabIndex = 12;
            this.CHX_importe.Text = "Importe total de la compra";
            this.CHX_importe.UseVisualStyleBackColor = true;
            this.CHX_importe.CheckedChanged += new System.EventHandler(this.CHX_importe_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "MOVIMIENTO";
            // 
            // TB_mov
            // 
            this.TB_mov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_mov.Location = new System.Drawing.Point(395, 96);
            this.TB_mov.Name = "TB_mov";
            this.TB_mov.ReadOnly = true;
            this.TB_mov.Size = new System.Drawing.Size(69, 22);
            this.TB_mov.TabIndex = 13;
            this.TB_mov.Text = "DV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "SUCURSAL";
            // 
            // TB_sucursal
            // 
            this.TB_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_sucursal.Location = new System.Drawing.Point(644, 93);
            this.TB_sucursal.Name = "TB_sucursal";
            this.TB_sucursal.ReadOnly = true;
            this.TB_sucursal.Size = new System.Drawing.Size(113, 22);
            this.TB_sucursal.TabIndex = 15;
            // 
            // CB_cuentaOsmart
            // 
            this.CB_cuentaOsmart.FormattingEnabled = true;
            this.CB_cuentaOsmart.Location = new System.Drawing.Point(609, 64);
            this.CB_cuentaOsmart.Name = "CB_cuentaOsmart";
            this.CB_cuentaOsmart.Size = new System.Drawing.Size(161, 21);
            this.CB_cuentaOsmart.TabIndex = 17;
            this.CB_cuentaOsmart.SelectedIndexChanged += new System.EventHandler(this.CB_cuentaOsmart_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(544, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "CUENTA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(291, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "BANCO";
            // 
            // CB_banco
            // 
            this.CB_banco.FormattingEnabled = true;
            this.CB_banco.Location = new System.Drawing.Point(347, 64);
            this.CB_banco.Name = "CB_banco";
            this.CB_banco.Size = new System.Drawing.Size(161, 21);
            this.CB_banco.TabIndex = 19;
            this.CB_banco.SelectedIndexChanged += new System.EventHandler(this.CB_banco_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "CLIENTE BANCARIO";
            // 
            // TB_cliente
            // 
            this.TB_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_cliente.Location = new System.Drawing.Point(241, 99);
            this.TB_cliente.Name = "TB_cliente";
            this.TB_cliente.ReadOnly = true;
            this.TB_cliente.Size = new System.Drawing.Size(530, 22);
            this.TB_cliente.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_nombreProv);
            this.groupBox1.Controls.Add(this.TB_proveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_referencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_compra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TB_importeComp);
            this.groupBox1.Controls.Add(this.TB_sucursal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TB_mov);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 213);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LA COMPRA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CHX_deposito_sinprov);
            this.groupBox2.Controls.Add(this.CB_sucursal_banco);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CB_banco);
            this.groupBox2.Controls.Add(this.BT_depositar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TB_importe);
            this.groupBox2.Controls.Add(this.TB_cliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CHX_importe);
            this.groupBox2.Controls.Add(this.CB_cuentaOsmart);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 194);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS BANCARIOS";
            // 
            // CB_sucursal_banco
            // 
            this.CB_sucursal_banco.FormattingEnabled = true;
            this.CB_sucursal_banco.Items.AddRange(new object[] {
            "BODEGA",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal_banco.Location = new System.Drawing.Point(110, 62);
            this.CB_sucursal_banco.Name = "CB_sucursal_banco";
            this.CB_sucursal_banco.Size = new System.Drawing.Size(161, 21);
            this.CB_sucursal_banco.TabIndex = 23;
            this.CB_sucursal_banco.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "SUCURSAL";
            // 
            // CHX_deposito_sinprov
            // 
            this.CHX_deposito_sinprov.AutoSize = true;
            this.CHX_deposito_sinprov.Location = new System.Drawing.Point(30, 28);
            this.CHX_deposito_sinprov.Name = "CHX_deposito_sinprov";
            this.CHX_deposito_sinprov.Size = new System.Drawing.Size(136, 17);
            this.CHX_deposito_sinprov.TabIndex = 17;
            this.CHX_deposito_sinprov.Text = "DEPOSITO EFECTIVO";
            this.CHX_deposito_sinprov.UseVisualStyleBackColor = true;
            // 
            // DevolverDineroACuentaOsmart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(820, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "DevolverDineroACuentaOsmart";
            this.Text = "DevolverDineroACuentaOsmart";
            this.Load += new System.EventHandler(this.DevolverDineroACuentaOsmart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_depositar;
        private System.Windows.Forms.TextBox TB_nombreProv;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_referencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_compra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_importeComp;
        private System.Windows.Forms.CheckBox CHX_importe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_mov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_sucursal;
        private System.Windows.Forms.ComboBox CB_cuentaOsmart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_banco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CB_sucursal_banco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CHX_deposito_sinprov;
    }
}