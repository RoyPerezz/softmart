
namespace appSugerencias
{
    partial class DepositoEntreCuentasOsmart
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
            this.TB_cuenta = new System.Windows.Forms.Label();
            this.TB_cuenta_origen = new System.Windows.Forms.TextBox();
            this.TB_deposito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_cliente_bancario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_banco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_cuenta_destino = new System.Windows.Forms.TextBox();
            this.TB_cliente_origen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_banco_origen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_referencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_depositar
            // 
            this.BT_depositar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_depositar.ForeColor = System.Drawing.Color.White;
            this.BT_depositar.Location = new System.Drawing.Point(754, 307);
            this.BT_depositar.Name = "BT_depositar";
            this.BT_depositar.Size = new System.Drawing.Size(100, 51);
            this.BT_depositar.TabIndex = 0;
            this.BT_depositar.Text = "Depositar";
            this.BT_depositar.UseVisualStyleBackColor = false;
            this.BT_depositar.Click += new System.EventHandler(this.BT_depositar_Click);
            // 
            // TB_cuenta
            // 
            this.TB_cuenta.AutoSize = true;
            this.TB_cuenta.Location = new System.Drawing.Point(276, 68);
            this.TB_cuenta.Name = "TB_cuenta";
            this.TB_cuenta.Size = new System.Drawing.Size(41, 13);
            this.TB_cuenta.TabIndex = 1;
            this.TB_cuenta.Text = "Cuenta";
            // 
            // TB_cuenta_origen
            // 
            this.TB_cuenta_origen.Location = new System.Drawing.Point(320, 65);
            this.TB_cuenta_origen.Name = "TB_cuenta_origen";
            this.TB_cuenta_origen.Size = new System.Drawing.Size(195, 20);
            this.TB_cuenta_origen.TabIndex = 2;
            // 
            // TB_deposito
            // 
            this.TB_deposito.Location = new System.Drawing.Point(63, 93);
            this.TB_deposito.Name = "TB_deposito";
            this.TB_deposito.Size = new System.Drawing.Size(195, 20);
            this.TB_deposito.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Depósito";
            // 
            // TB_fecha
            // 
            this.TB_fecha.Location = new System.Drawing.Point(622, 30);
            this.TB_fecha.Name = "TB_fecha";
            this.TB_fecha.Size = new System.Drawing.Size(195, 20);
            this.TB_fecha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha";
            // 
            // CB_cliente_bancario
            // 
            this.CB_cliente_bancario.FormattingEnabled = true;
            this.CB_cliente_bancario.Location = new System.Drawing.Point(85, 28);
            this.CB_cliente_bancario.Name = "CB_cliente_bancario";
            this.CB_cliente_bancario.Size = new System.Drawing.Size(315, 21);
            this.CB_cliente_bancario.TabIndex = 7;
            this.CB_cliente_bancario.SelectedIndexChanged += new System.EventHandler(this.CB_cliente_bancario_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Depositar a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Banco";
            // 
            // CB_banco
            // 
            this.CB_banco.FormattingEnabled = true;
            this.CB_banco.Location = new System.Drawing.Point(85, 55);
            this.CB_banco.Name = "CB_banco";
            this.CB_banco.Size = new System.Drawing.Size(161, 21);
            this.CB_banco.TabIndex = 9;
            this.CB_banco.SelectedIndexChanged += new System.EventHandler(this.CB_banco_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cuenta";
            // 
            // TB_cuenta_destino
            // 
            this.TB_cuenta_destino.Location = new System.Drawing.Point(85, 85);
            this.TB_cuenta_destino.Name = "TB_cuenta_destino";
            this.TB_cuenta_destino.Size = new System.Drawing.Size(195, 20);
            this.TB_cuenta_destino.TabIndex = 13;
            // 
            // TB_cliente_origen
            // 
            this.TB_cliente_origen.Location = new System.Drawing.Point(622, 65);
            this.TB_cliente_origen.Name = "TB_cliente_origen";
            this.TB_cliente_origen.Size = new System.Drawing.Size(195, 20);
            this.TB_cliente_origen.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cliente bancario";
            // 
            // TB_banco_origen
            // 
            this.TB_banco_origen.Location = new System.Drawing.Point(63, 63);
            this.TB_banco_origen.Name = "TB_banco_origen";
            this.TB_banco_origen.Size = new System.Drawing.Size(195, 20);
            this.TB_banco_origen.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(22, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Banco";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_cliente_origen);
            this.groupBox1.Controls.Add(this.TB_banco_origen);
            this.groupBox1.Controls.Add(this.TB_cuenta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TB_cuenta_origen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_deposito);
            this.groupBox1.Controls.Add(this.TB_fecha);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 156);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta Origen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_referencia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TB_cuenta_destino);
            this.groupBox2.Controls.Add(this.CB_cliente_bancario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CB_banco);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 127);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta Destino";
            // 
            // TB_referencia
            // 
            this.TB_referencia.Location = new System.Drawing.Point(376, 85);
            this.TB_referencia.Name = "TB_referencia";
            this.TB_referencia.Size = new System.Drawing.Size(441, 20);
            this.TB_referencia.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Referencia";
            // 
            // DepositoEntreCuentasOsmart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(866, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_depositar);
            this.Name = "DepositoEntreCuentasOsmart";
            this.Text = "DepositoEntreCuentasOsmart";
            this.Load += new System.EventHandler(this.DepositoEntreCuentasOsmart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_depositar;
        private System.Windows.Forms.Label TB_cuenta;
        private System.Windows.Forms.TextBox TB_cuenta_origen;
        private System.Windows.Forms.TextBox TB_deposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_cliente_bancario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_banco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_cuenta_destino;
        private System.Windows.Forms.TextBox TB_cliente_origen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_banco_origen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_referencia;
        private System.Windows.Forms.Label label8;
    }
}