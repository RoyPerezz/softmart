
namespace appSugerencias.Gastos.Vistas
{
    partial class RegistroEgresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEgresos));
            this.CB_conceptoGral = new System.Windows.Forms.ComboBox();
            this.CB_conceptoDetalle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_registrar = new System.Windows.Forms.Button();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RB_tienda = new System.Windows.Forms.RadioButton();
            this.RB_general = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_cajera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_caja = new System.Windows.Forms.TextBox();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_conceptoGral
            // 
            this.CB_conceptoGral.AutoCompleteCustomSource.AddRange(new string[] {
            "CONCEPTO GRAL1",
            "CONCEPTO GRAL 2",
            "CONCEPTO GRAL 3",
            "CONCEPTO GRAL 4"});
            this.CB_conceptoGral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_conceptoGral.FormattingEnabled = true;
            this.CB_conceptoGral.Items.AddRange(new object[] {
            "CONCEPTO GRAL 1",
            "CONCEPTO GRAL 2",
            "CONCEPTO GRAL 3",
            "CONCEPTO GRAL 4"});
            this.CB_conceptoGral.Location = new System.Drawing.Point(196, 100);
            this.CB_conceptoGral.Name = "CB_conceptoGral";
            this.CB_conceptoGral.Size = new System.Drawing.Size(459, 32);
            this.CB_conceptoGral.TabIndex = 0;
            this.CB_conceptoGral.SelectedIndexChanged += new System.EventHandler(this.CB_conceptoGral_SelectedIndexChanged);
            // 
            // CB_conceptoDetalle
            // 
            this.CB_conceptoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_conceptoDetalle.FormattingEnabled = true;
            this.CB_conceptoDetalle.Items.AddRange(new object[] {
            "CONCEPTO DETALLE 1",
            "CONCEPTO DETALLE 2",
            "CONCEPTO DETALLE 3",
            "CONCEPTO DETALLE 4"});
            this.CB_conceptoDetalle.Location = new System.Drawing.Point(196, 148);
            this.CB_conceptoDetalle.Name = "CB_conceptoDetalle";
            this.CB_conceptoDetalle.Size = new System.Drawing.Size(459, 32);
            this.CB_conceptoDetalle.TabIndex = 1;
            this.CB_conceptoDetalle.SelectedIndexChanged += new System.EventHandler(this.CB_conceptoDetalle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Concepto General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Concepto Detalle";
            // 
            // BT_registrar
            // 
            this.BT_registrar.BackColor = System.Drawing.Color.CadetBlue;
            this.BT_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_registrar.ForeColor = System.Drawing.Color.White;
            this.BT_registrar.Location = new System.Drawing.Point(542, 233);
            this.BT_registrar.Name = "BT_registrar";
            this.BT_registrar.Size = new System.Drawing.Size(113, 55);
            this.BT_registrar.TabIndex = 4;
            this.BT_registrar.Text = "Registrar";
            this.BT_registrar.UseVisualStyleBackColor = false;
            this.BT_registrar.Click += new System.EventHandler(this.BT_registrar_Click);
            // 
            // TB_importe
            // 
            this.TB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importe.Location = new System.Drawing.Point(493, 195);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(162, 29);
            this.TB_importe.TabIndex = 5;
            this.TB_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Importe";
            // 
            // RB_tienda
            // 
            this.RB_tienda.AutoSize = true;
            this.RB_tienda.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_tienda.Location = new System.Drawing.Point(10, 16);
            this.RB_tienda.Name = "RB_tienda";
            this.RB_tienda.Size = new System.Drawing.Size(168, 27);
            this.RB_tienda.TabIndex = 7;
            this.RB_tienda.TabStop = true;
            this.RB_tienda.Text = "Gastos de tienda";
            this.RB_tienda.UseVisualStyleBackColor = true;
            this.RB_tienda.CheckedChanged += new System.EventHandler(this.RB_tienda_CheckedChanged);
            // 
            // RB_general
            // 
            this.RB_general.AutoSize = true;
            this.RB_general.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_general.Location = new System.Drawing.Point(10, 44);
            this.RB_general.Name = "RB_general";
            this.RB_general.Size = new System.Drawing.Size(173, 27);
            this.RB_general.TabIndex = 8;
            this.RB_general.TabStop = true;
            this.RB_general.Text = "Gastos Generales";
            this.RB_general.UseVisualStyleBackColor = true;
            this.RB_general.CheckedChanged += new System.EventHandler(this.RB_general_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_general);
            this.groupBox1.Controls.Add(this.RB_tienda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 81);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de gasto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cajera";
            // 
            // TB_cajera
            // 
            this.TB_cajera.Enabled = false;
            this.TB_cajera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_cajera.Location = new System.Drawing.Point(493, 12);
            this.TB_cajera.Name = "TB_cajera";
            this.TB_cajera.Size = new System.Drawing.Size(162, 29);
            this.TB_cajera.TabIndex = 10;
            this.TB_cajera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Caja";
            // 
            // TB_caja
            // 
            this.TB_caja.Enabled = false;
            this.TB_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_caja.Location = new System.Drawing.Point(493, 46);
            this.TB_caja.Name = "TB_caja";
            this.TB_caja.Size = new System.Drawing.Size(162, 29);
            this.TB_caja.TabIndex = 12;
            this.TB_caja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PB_logo
            // 
            this.PB_logo.Image = ((System.Drawing.Image)(resources.GetObject("PB_logo.Image")));
            this.PB_logo.Location = new System.Drawing.Point(1, 287);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(26, 12);
            this.PB_logo.TabIndex = 14;
            this.PB_logo.TabStop = false;
            this.PB_logo.Visible = false;
            // 
            // RegistroEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(667, 300);
            this.Controls.Add(this.PB_logo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_caja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_cajera);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_importe);
            this.Controls.Add(this.BT_registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_conceptoDetalle);
            this.Controls.Add(this.CB_conceptoGral);
            this.Name = "RegistroEgresos";
            this.Text = "Registrar Egreso";
            this.Load += new System.EventHandler(this.RegistroEgresos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_conceptoGral;
        private System.Windows.Forms.ComboBox CB_conceptoDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_registrar;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RB_tienda;
        private System.Windows.Forms.RadioButton RB_general;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_cajera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_caja;
        private System.Windows.Forms.PictureBox PB_logo;
    }
}