
namespace appSugerencias.Gastos.Vistas
{
    partial class ModificarGasto
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
            this.LB_ticket = new System.Windows.Forms.Label();
            this.LB_tipo_gasto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_concepto_gral = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_concepto_detalle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_tienda = new System.Windows.Forms.RadioButton();
            this.RB_general = new System.Windows.Forms.RadioButton();
            this.CB_concepto_gral = new System.Windows.Forms.ComboBox();
            this.CB_concepto_detalle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_modificar = new System.Windows.Forms.Button();
            this.CBX_respaldo = new System.Windows.Forms.CheckBox();
            this.LB_importe = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_fecha = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TICKET";
            // 
            // LB_ticket
            // 
            this.LB_ticket.AutoSize = true;
            this.LB_ticket.Location = new System.Drawing.Point(168, 18);
            this.LB_ticket.Name = "LB_ticket";
            this.LB_ticket.Size = new System.Drawing.Size(0, 13);
            this.LB_ticket.TabIndex = 1;
            // 
            // LB_tipo_gasto
            // 
            this.LB_tipo_gasto.AutoSize = true;
            this.LB_tipo_gasto.Location = new System.Drawing.Point(168, 47);
            this.LB_tipo_gasto.Name = "LB_tipo_gasto";
            this.LB_tipo_gasto.Size = new System.Drawing.Size(0, 13);
            this.LB_tipo_gasto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIPO GASTO";
            // 
            // LB_concepto_gral
            // 
            this.LB_concepto_gral.AutoSize = true;
            this.LB_concepto_gral.Location = new System.Drawing.Point(168, 73);
            this.LB_concepto_gral.Name = "LB_concepto_gral";
            this.LB_concepto_gral.Size = new System.Drawing.Size(0, 13);
            this.LB_concepto_gral.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONCEPTO GRAL.";
            // 
            // LB_concepto_detalle
            // 
            this.LB_concepto_detalle.AutoSize = true;
            this.LB_concepto_detalle.Location = new System.Drawing.Point(168, 100);
            this.LB_concepto_detalle.Name = "LB_concepto_detalle";
            this.LB_concepto_detalle.Size = new System.Drawing.Size(0, 13);
            this.LB_concepto_detalle.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CONCEPTO DETALLE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_fecha);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LB_importe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LB_concepto_detalle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LB_ticket);
            this.groupBox1.Controls.Add(this.LB_concepto_gral);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LB_tipo_gasto);
            this.groupBox1.Location = new System.Drawing.Point(505, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 169);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del gasto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBX_respaldo);
            this.groupBox2.Controls.Add(this.BT_modificar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CB_concepto_detalle);
            this.groupBox2.Controls.Add(this.CB_concepto_gral);
            this.groupBox2.Controls.Add(this.RB_general);
            this.groupBox2.Controls.Add(this.RB_tienda);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 169);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar gasto";
            // 
            // RB_tienda
            // 
            this.RB_tienda.AutoSize = true;
            this.RB_tienda.Location = new System.Drawing.Point(173, 21);
            this.RB_tienda.Name = "RB_tienda";
            this.RB_tienda.Size = new System.Drawing.Size(65, 17);
            this.RB_tienda.TabIndex = 0;
            this.RB_tienda.TabStop = true;
            this.RB_tienda.Text = "TIENDA";
            this.RB_tienda.UseVisualStyleBackColor = true;
            this.RB_tienda.CheckedChanged += new System.EventHandler(this.RB_tienda_CheckedChanged);
            // 
            // RB_general
            // 
            this.RB_general.AutoSize = true;
            this.RB_general.Location = new System.Drawing.Point(319, 21);
            this.RB_general.Name = "RB_general";
            this.RB_general.Size = new System.Drawing.Size(76, 17);
            this.RB_general.TabIndex = 1;
            this.RB_general.TabStop = true;
            this.RB_general.Text = "GENERAL";
            this.RB_general.UseVisualStyleBackColor = true;
            this.RB_general.CheckedChanged += new System.EventHandler(this.RB_general_CheckedChanged);
            // 
            // CB_concepto_gral
            // 
            this.CB_concepto_gral.FormattingEnabled = true;
            this.CB_concepto_gral.Location = new System.Drawing.Point(153, 59);
            this.CB_concepto_gral.Name = "CB_concepto_gral";
            this.CB_concepto_gral.Size = new System.Drawing.Size(310, 21);
            this.CB_concepto_gral.TabIndex = 2;
            this.CB_concepto_gral.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_gral_SelectedIndexChanged);
            // 
            // CB_concepto_detalle
            // 
            this.CB_concepto_detalle.FormattingEnabled = true;
            this.CB_concepto_detalle.Location = new System.Drawing.Point(153, 100);
            this.CB_concepto_detalle.Name = "CB_concepto_detalle";
            this.CB_concepto_detalle.Size = new System.Drawing.Size(310, 21);
            this.CB_concepto_detalle.TabIndex = 3;
            this.CB_concepto_detalle.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_detalle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CONCEPTO GENERAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CONCEPTO DETALLE";
            // 
            // BT_modificar
            // 
            this.BT_modificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_modificar.ForeColor = System.Drawing.Color.White;
            this.BT_modificar.Location = new System.Drawing.Point(380, 127);
            this.BT_modificar.Name = "BT_modificar";
            this.BT_modificar.Size = new System.Drawing.Size(83, 36);
            this.BT_modificar.TabIndex = 10;
            this.BT_modificar.Text = "Modificar";
            this.BT_modificar.UseVisualStyleBackColor = false;
            this.BT_modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBX_respaldo
            // 
            this.CBX_respaldo.AutoSize = true;
            this.CBX_respaldo.Location = new System.Drawing.Point(303, 138);
            this.CBX_respaldo.Name = "CBX_respaldo";
            this.CBX_respaldo.Size = new System.Drawing.Size(71, 17);
            this.CBX_respaldo.TabIndex = 11;
            this.CBX_respaldo.Text = "Respaldo";
            this.CBX_respaldo.UseVisualStyleBackColor = true;
            // 
            // LB_importe
            // 
            this.LB_importe.AutoSize = true;
            this.LB_importe.Location = new System.Drawing.Point(168, 127);
            this.LB_importe.Name = "LB_importe";
            this.LB_importe.Size = new System.Drawing.Size(0, 13);
            this.LB_importe.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "IMPORTE";
            // 
            // LB_fecha
            // 
            this.LB_fecha.AutoSize = true;
            this.LB_fecha.Location = new System.Drawing.Point(168, 148);
            this.LB_fecha.Name = "LB_fecha";
            this.LB_fecha.Size = new System.Drawing.Size(0, 13);
            this.LB_fecha.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "FECHA";
            // 
            // ModificarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(932, 192);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ModificarGasto";
            this.Text = "ModificarGasto";
            this.Load += new System.EventHandler(this.ModificarGasto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_ticket;
        private System.Windows.Forms.Label LB_tipo_gasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_concepto_gral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_concepto_detalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BT_modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_concepto_detalle;
        private System.Windows.Forms.ComboBox CB_concepto_gral;
        private System.Windows.Forms.RadioButton RB_general;
        private System.Windows.Forms.RadioButton RB_tienda;
        private System.Windows.Forms.CheckBox CBX_respaldo;
        private System.Windows.Forms.Label LB_importe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_fecha;
        private System.Windows.Forms.Label label9;
    }
}