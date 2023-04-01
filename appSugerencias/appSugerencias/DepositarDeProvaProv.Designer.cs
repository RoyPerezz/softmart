namespace appSugerencias
{
    partial class DepositarDeProvaProv
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
            this.BT_deposito = new System.Windows.Forms.Button();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_referencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_id2 = new System.Windows.Forms.TextBox();
            this.CB_proveedores = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_deposito
            // 
            this.BT_deposito.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_deposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_deposito.ForeColor = System.Drawing.Color.White;
            this.BT_deposito.Location = new System.Drawing.Point(229, 467);
            this.BT_deposito.Name = "BT_deposito";
            this.BT_deposito.Size = new System.Drawing.Size(237, 49);
            this.BT_deposito.TabIndex = 0;
            this.BT_deposito.Text = "DEPOSITAR";
            this.BT_deposito.UseVisualStyleBackColor = false;
            this.BT_deposito.Click += new System.EventHandler(this.BT_deposito_Click);
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_proveedor.Location = new System.Drawing.Point(11, 54);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(376, 26);
            this.TB_proveedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROVEEDOR";
            // 
            // TB_id
            // 
            this.TB_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_id.Location = new System.Drawing.Point(393, 54);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(72, 26);
            this.TB_id.TabIndex = 5;
            // 
            // TB_importe
            // 
            this.TB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importe.Location = new System.Drawing.Point(88, 80);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(128, 26);
            this.TB_importe.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IMPORTE";
            // 
            // CB_tipo
            // 
            this.CB_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_tipo.FormattingEnabled = true;
            this.CB_tipo.Items.AddRange(new object[] {
            "DEPOSITO",
            "DEPOSITO/EFECTIVO",
            "SPEI"});
            this.CB_tipo.Location = new System.Drawing.Point(88, 47);
            this.CB_tipo.Name = "CB_tipo";
            this.CB_tipo.Size = new System.Drawing.Size(128, 28);
            this.CB_tipo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TIPO PAGO";
            // 
            // TB_referencia
            // 
            this.TB_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_referencia.Location = new System.Drawing.Point(88, 111);
            this.TB_referencia.Name = "TB_referencia";
            this.TB_referencia.Size = new System.Drawing.Size(572, 26);
            this.TB_referencia.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "REFERENCIA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_id);
            this.groupBox1.Controls.Add(this.TB_proveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 117);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROVEEDOR QUE ENVIA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DT_fecha);
            this.groupBox2.Controls.Add(this.TB_referencia);
            this.groupBox2.Controls.Add(this.TB_importe);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CB_tipo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 162);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DEL PAGO";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(460, 19);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TB_id2);
            this.groupBox3.Controls.Add(this.CB_proveedores);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(682, 139);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PROVEEDOR QUE RECIBE";
            // 
            // TB_id2
            // 
            this.TB_id2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_id2.Location = new System.Drawing.Point(393, 72);
            this.TB_id2.Name = "TB_id2";
            this.TB_id2.Size = new System.Drawing.Size(72, 26);
            this.TB_id2.TabIndex = 6;
            // 
            // CB_proveedores
            // 
            this.CB_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_proveedores.FormattingEnabled = true;
            this.CB_proveedores.Location = new System.Drawing.Point(10, 72);
            this.CB_proveedores.Name = "CB_proveedores";
            this.CB_proveedores.Size = new System.Drawing.Size(376, 28);
            this.CB_proveedores.TabIndex = 1;
            this.CB_proveedores.SelectedIndexChanged += new System.EventHandler(this.CB_proveedores_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "PROVEEDOR A QUIEN SE LE DEPOSITA";
            // 
            // DepositarDeProvaProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(707, 528);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_deposito);
            this.Name = "DepositarDeProvaProv";
            this.Text = "DepositarDeProvaProv";
            this.Load += new System.EventHandler(this.DepositarDeProvaProv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_deposito;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_referencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_id2;
        private System.Windows.Forms.ComboBox CB_proveedores;
        private System.Windows.Forms.Label label14;
    }
}