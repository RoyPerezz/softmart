namespace appSugerencias
{
    partial class ModificarCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_compra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.CB_proveedores = new System.Windows.Forms.ComboBox();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_saldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_referencia = new System.Windows.Forms.TextBox();
            this.BT_modificar = new System.Windows.Forms.Button();
            this.BT_eliminar = new System.Windows.Forms.Button();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.DT_fecha_llegada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_compra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CB_sucursal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 104);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE BUSQUEDA";
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(220, 35);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(95, 47);
            this.BT_buscar.TabIndex = 21;
            this.BT_buscar.Text = "BUSCAR";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "COMPRA";
            // 
            // TB_compra
            // 
            this.TB_compra.Location = new System.Drawing.Point(77, 35);
            this.TB_compra.Name = "TB_compra";
            this.TB_compra.Size = new System.Drawing.Size(136, 20);
            this.TB_compra.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "SUCURSAL";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "BODEGA",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(77, 61);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(136, 21);
            this.CB_sucursal.TabIndex = 10;
            // 
            // CB_proveedores
            // 
            this.CB_proveedores.FormattingEnabled = true;
            this.CB_proveedores.Location = new System.Drawing.Point(98, 103);
            this.CB_proveedores.Name = "CB_proveedores";
            this.CB_proveedores.Size = new System.Drawing.Size(293, 21);
            this.CB_proveedores.TabIndex = 18;
            this.CB_proveedores.SelectedIndexChanged += new System.EventHandler(this.CB_proveedores_SelectedIndexChanged);
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Location = new System.Drawing.Point(397, 103);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(61, 20);
            this.TB_proveedor.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "PROVEEDOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "SALDO";
            // 
            // TB_saldo
            // 
            this.TB_saldo.Location = new System.Drawing.Point(397, 77);
            this.TB_saldo.Name = "TB_saldo";
            this.TB_saldo.Size = new System.Drawing.Size(100, 20);
            this.TB_saldo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "REFERENCIA";
            // 
            // TB_referencia
            // 
            this.TB_referencia.Location = new System.Drawing.Point(98, 77);
            this.TB_referencia.Name = "TB_referencia";
            this.TB_referencia.Size = new System.Drawing.Size(293, 20);
            this.TB_referencia.TabIndex = 14;
            // 
            // BT_modificar
            // 
            this.BT_modificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_modificar.ForeColor = System.Drawing.Color.White;
            this.BT_modificar.Location = new System.Drawing.Point(325, 286);
            this.BT_modificar.Name = "BT_modificar";
            this.BT_modificar.Size = new System.Drawing.Size(95, 47);
            this.BT_modificar.TabIndex = 22;
            this.BT_modificar.Text = "MODIFICAR";
            this.BT_modificar.UseVisualStyleBackColor = false;
            this.BT_modificar.Click += new System.EventHandler(this.BT_modificar_Click);
            // 
            // BT_eliminar
            // 
            this.BT_eliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar.ForeColor = System.Drawing.Color.White;
            this.BT_eliminar.Location = new System.Drawing.Point(439, 286);
            this.BT_eliminar.Name = "BT_eliminar";
            this.BT_eliminar.Size = new System.Drawing.Size(95, 47);
            this.BT_eliminar.TabIndex = 23;
            this.BT_eliminar.Text = "ELIMINAR";
            this.BT_eliminar.UseVisualStyleBackColor = false;
            this.BT_eliminar.Click += new System.EventHandler(this.BT_eliminar_Click);
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.DT_fecha_llegada);
            this.groupbox2.Controls.Add(this.label6);
            this.groupbox2.Controls.Add(this.TB_proveedor);
            this.groupbox2.Controls.Add(this.TB_referencia);
            this.groupbox2.Controls.Add(this.label3);
            this.groupbox2.Controls.Add(this.CB_proveedores);
            this.groupbox2.Controls.Add(this.TB_saldo);
            this.groupbox2.Controls.Add(this.label4);
            this.groupbox2.Controls.Add(this.label5);
            this.groupbox2.Location = new System.Drawing.Point(12, 132);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(522, 148);
            this.groupbox2.TabIndex = 22;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "DATOS DE LA COMPRA";
            // 
            // DT_fecha_llegada
            // 
            this.DT_fecha_llegada.Location = new System.Drawing.Point(297, 19);
            this.DT_fecha_llegada.Name = "DT_fecha_llegada";
            this.DT_fecha_llegada.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha_llegada.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "FECHA LLEGADA";
            // 
            // ModificarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(555, 345);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.BT_eliminar);
            this.Controls.Add(this.BT_modificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarCompra";
            this.Text = "Modificar Datos de Compra";
            this.Load += new System.EventHandler(this.ModificarCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_proveedores;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_saldo;
        private System.Windows.Forms.TextBox TB_compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_referencia;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Button BT_modificar;
        private System.Windows.Forms.Button BT_eliminar;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DT_fecha_llegada;
    }
}