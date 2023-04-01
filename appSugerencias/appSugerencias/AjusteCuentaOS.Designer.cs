namespace appSugerencias
{
    partial class AjusteCuentaOS
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
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.RB_ingreso = new System.Windows.Forms.RadioButton();
            this.RB_egreso = new System.Windows.Forms.RadioButton();
            this.CB_banco = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_cuenta = new System.Windows.Forms.ComboBox();
            this.TB_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_referencia = new System.Windows.Forms.TextBox();
            this.BT_aplicar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUCURSAL";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Location = new System.Drawing.Point(85, 55);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(149, 21);
            this.CB_sucursal.TabIndex = 2;
            this.CB_sucursal.SelectedIndexChanged += new System.EventHandler(this.CB_sucursal_SelectedIndexChanged);
            // 
            // RB_ingreso
            // 
            this.RB_ingreso.AutoSize = true;
            this.RB_ingreso.Location = new System.Drawing.Point(21, 24);
            this.RB_ingreso.Name = "RB_ingreso";
            this.RB_ingreso.Size = new System.Drawing.Size(60, 17);
            this.RB_ingreso.TabIndex = 3;
            this.RB_ingreso.TabStop = true;
            this.RB_ingreso.Text = "Ingreso";
            this.RB_ingreso.UseVisualStyleBackColor = true;
            // 
            // RB_egreso
            // 
            this.RB_egreso.AutoSize = true;
            this.RB_egreso.Location = new System.Drawing.Point(21, 48);
            this.RB_egreso.Name = "RB_egreso";
            this.RB_egreso.Size = new System.Drawing.Size(58, 17);
            this.RB_egreso.TabIndex = 4;
            this.RB_egreso.TabStop = true;
            this.RB_egreso.Text = "Egreso";
            this.RB_egreso.UseVisualStyleBackColor = true;
            // 
            // CB_banco
            // 
            this.CB_banco.FormattingEnabled = true;
            this.CB_banco.Location = new System.Drawing.Point(85, 96);
            this.CB_banco.Name = "CB_banco";
            this.CB_banco.Size = new System.Drawing.Size(149, 21);
            this.CB_banco.TabIndex = 5;
            this.CB_banco.SelectedIndexChanged += new System.EventHandler(this.CB_banco_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BANCO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_egreso);
            this.groupBox1.Controls.Add(this.RB_ingreso);
            this.groupBox1.Location = new System.Drawing.Point(253, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MOVIMIENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CUENTA";
            // 
            // CB_cuenta
            // 
            this.CB_cuenta.FormattingEnabled = true;
            this.CB_cuenta.Location = new System.Drawing.Point(85, 132);
            this.CB_cuenta.Name = "CB_cuenta";
            this.CB_cuenta.Size = new System.Drawing.Size(149, 21);
            this.CB_cuenta.TabIndex = 8;
            this.CB_cuenta.SelectedIndexChanged += new System.EventHandler(this.CB_cuenta_SelectedIndexChanged);
            // 
            // TB_cliente
            // 
            this.TB_cliente.Location = new System.Drawing.Point(141, 170);
            this.TB_cliente.Name = "TB_cliente";
            this.TB_cliente.Size = new System.Drawing.Size(335, 20);
            this.TB_cliente.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CLIENTE BANCARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CANTIDAD";
            // 
            // TB_importe
            // 
            this.TB_importe.Location = new System.Drawing.Point(359, 206);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(117, 20);
            this.TB_importe.TabIndex = 12;
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(383, 12);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "REFERENCIA";
            // 
            // TB_referencia
            // 
            this.TB_referencia.Location = new System.Drawing.Point(93, 241);
            this.TB_referencia.Name = "TB_referencia";
            this.TB_referencia.Size = new System.Drawing.Size(490, 20);
            this.TB_referencia.TabIndex = 15;
            // 
            // BT_aplicar
            // 
            this.BT_aplicar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_aplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_aplicar.ForeColor = System.Drawing.Color.White;
            this.BT_aplicar.Location = new System.Drawing.Point(471, 99);
            this.BT_aplicar.Name = "BT_aplicar";
            this.BT_aplicar.Size = new System.Drawing.Size(112, 55);
            this.BT_aplicar.TabIndex = 17;
            this.BT_aplicar.Text = "Aplicar";
            this.BT_aplicar.UseVisualStyleBackColor = false;
            this.BT_aplicar.Click += new System.EventHandler(this.BT_aplicar_Click);
            // 
            // AjusteCuentaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(605, 314);
            this.Controls.Add(this.BT_aplicar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_referencia);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_importe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_cuenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_banco);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.label1);
            this.Name = "AjusteCuentaOS";
            this.Text = "AjusteCuentaOS";
            this.Load += new System.EventHandler(this.AjusteCuentaOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.RadioButton RB_ingreso;
        private System.Windows.Forms.RadioButton RB_egreso;
        private System.Windows.Forms.ComboBox CB_banco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_cuenta;
        private System.Windows.Forms.TextBox TB_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_referencia;
        private System.Windows.Forms.Button BT_aplicar;
    }
}