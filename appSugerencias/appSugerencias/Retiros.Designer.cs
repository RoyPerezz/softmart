namespace appSugerencias
{
    partial class Retiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retiros));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_num_op = new System.Windows.Forms.TextBox();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_aplicar = new System.Windows.Forms.Button();
            this.LB_usuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_importe = new System.Windows.Forms.Label();
            this.LB_operacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_estacion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTiket = new System.Windows.Forms.TextBox();
            this.checkPago = new System.Windows.Forms.CheckBox();
            this.BT_limpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. Operación";
            // 
            // TB_num_op
            // 
            this.TB_num_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_num_op.Location = new System.Drawing.Point(173, 176);
            this.TB_num_op.Name = "TB_num_op";
            this.TB_num_op.Size = new System.Drawing.Size(271, 26);
            this.TB_num_op.TabIndex = 2;
            // 
            // TB_importe
            // 
            this.TB_importe.Enabled = false;
            this.TB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importe.Location = new System.Drawing.Point(173, 208);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(271, 26);
            this.TB_importe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estación";
            // 
            // BT_aplicar
            // 
            this.BT_aplicar.Location = new System.Drawing.Point(344, 250);
            this.BT_aplicar.Name = "BT_aplicar";
            this.BT_aplicar.Size = new System.Drawing.Size(100, 45);
            this.BT_aplicar.TabIndex = 6;
            this.BT_aplicar.Text = "Aplicar";
            this.BT_aplicar.UseVisualStyleBackColor = true;
            this.BT_aplicar.Click += new System.EventHandler(this.BT_aplicar_Click);
            // 
            // LB_usuario
            // 
            this.LB_usuario.AutoSize = true;
            this.LB_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_usuario.Location = new System.Drawing.Point(16, 9);
            this.LB_usuario.Name = "LB_usuario";
            this.LB_usuario.Size = new System.Drawing.Size(61, 20);
            this.LB_usuario.TabIndex = 7;
            this.LB_usuario.Text = "usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTicket);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LB_importe);
            this.groupBox1.Controls.Add(this.LB_operacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(236, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ultima Venta";
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(113, 24);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(0, 13);
            this.lblTicket.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ticekt";
            // 
            // LB_importe
            // 
            this.LB_importe.AutoSize = true;
            this.LB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_importe.Location = new System.Drawing.Point(115, 68);
            this.LB_importe.Name = "LB_importe";
            this.LB_importe.Size = new System.Drawing.Size(0, 15);
            this.LB_importe.TabIndex = 12;
            // 
            // LB_operacion
            // 
            this.LB_operacion.AutoSize = true;
            this.LB_operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_operacion.Location = new System.Drawing.Point(117, 46);
            this.LB_operacion.Name = "LB_operacion";
            this.LB_operacion.Size = new System.Drawing.Size(0, 15);
            this.LB_operacion.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Importe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Num. Operación";
            // 
            // LB_estacion
            // 
            this.LB_estacion.AutoSize = true;
            this.LB_estacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_estacion.Location = new System.Drawing.Point(100, 74);
            this.LB_estacion.Name = "LB_estacion";
            this.LB_estacion.Size = new System.Drawing.Size(0, 20);
            this.LB_estacion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numero de Ticket";
            // 
            // tbTiket
            // 
            this.tbTiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTiket.Location = new System.Drawing.Point(173, 123);
            this.tbTiket.Name = "tbTiket";
            this.tbTiket.Size = new System.Drawing.Size(271, 26);
            this.tbTiket.TabIndex = 1;
            this.tbTiket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // checkPago
            // 
            this.checkPago.AutoSize = true;
            this.checkPago.Location = new System.Drawing.Point(7, 288);
            this.checkPago.Name = "checkPago";
            this.checkPago.Size = new System.Drawing.Size(113, 17);
            this.checkPago.TabIndex = 12;
            this.checkPago.Text = "Pago Proporcional";
            this.checkPago.UseVisualStyleBackColor = true;
            this.checkPago.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BT_limpiar
            // 
            this.BT_limpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_limpiar.ForeColor = System.Drawing.Color.White;
            this.BT_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("BT_limpiar.Image")));
            this.BT_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_limpiar.Location = new System.Drawing.Point(257, 250);
            this.BT_limpiar.Name = "BT_limpiar";
            this.BT_limpiar.Size = new System.Drawing.Size(42, 45);
            this.BT_limpiar.TabIndex = 30;
            this.BT_limpiar.UseVisualStyleBackColor = false;
            this.BT_limpiar.Click += new System.EventHandler(this.BT_limpiar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(134, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Retiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(458, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_limpiar);
            this.Controls.Add(this.checkPago);
            this.Controls.Add(this.tbTiket);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LB_estacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LB_usuario);
            this.Controls.Add(this.BT_aplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_importe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_num_op);
            this.Controls.Add(this.label1);
            this.Name = "Retiros";
            this.Text = "Retiros con Tarjeta";
            this.Load += new System.EventHandler(this.Retiros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_num_op;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_aplicar;
        private System.Windows.Forms.Label LB_usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LB_importe;
        private System.Windows.Forms.Label LB_operacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_estacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTiket;
        private System.Windows.Forms.CheckBox checkPago;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BT_limpiar;
        private System.Windows.Forms.Button button1;
    }
}