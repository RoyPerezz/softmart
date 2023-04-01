namespace appSugerencias
{
    partial class PagosParciales_enlace
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
            this.BT_abrir_enlace = new System.Windows.Forms.Button();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox_2 = new System.Windows.Forms.GroupBox();
            this.TB_compra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_referencia = new System.Windows.Forms.TextBox();
            this.BT_guardar_SPEI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_sucursal = new System.Windows.Forms.TextBox();
            this.CB_patron = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_bancos = new System.Windows.Forms.ComboBox();
            this.CB_cuenta_bancaria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_abrir_enlace
            // 
            this.BT_abrir_enlace.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_abrir_enlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_abrir_enlace.ForeColor = System.Drawing.Color.White;
            this.BT_abrir_enlace.Location = new System.Drawing.Point(40, 29);
            this.BT_abrir_enlace.Name = "BT_abrir_enlace";
            this.BT_abrir_enlace.Size = new System.Drawing.Size(307, 48);
            this.BT_abrir_enlace.TabIndex = 0;
            this.BT_abrir_enlace.Text = "Abrir enlace en google sheets";
            this.BT_abrir_enlace.UseVisualStyleBackColor = false;
            this.BT_abrir_enlace.Click += new System.EventHandler(this.BT_abrir_enlace_Click);
            // 
            // DG_tabla
            // 
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Location = new System.Drawing.Point(16, 19);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(343, 195);
            this.DG_tabla.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG_tabla);
            this.groupBox1.Location = new System.Drawing.Point(29, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abonos del pago parcial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_abrir_enlace);
            this.groupBox2.Location = new System.Drawing.Point(29, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 96);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abrir enlace de orden de compra";
            // 
            // GroupBox_2
            // 
            this.GroupBox_2.Controls.Add(this.CB_cuenta_bancaria);
            this.GroupBox_2.Controls.Add(this.CB_bancos);
            this.GroupBox_2.Controls.Add(this.label5);
            this.GroupBox_2.Controls.Add(this.CB_patron);
            this.GroupBox_2.Controls.Add(this.label4);
            this.GroupBox_2.Controls.Add(this.TB_sucursal);
            this.GroupBox_2.Controls.Add(this.BT_guardar_SPEI);
            this.GroupBox_2.Controls.Add(this.label3);
            this.GroupBox_2.Controls.Add(this.TB_referencia);
            this.GroupBox_2.Controls.Add(this.label2);
            this.GroupBox_2.Controls.Add(this.TB_importe);
            this.GroupBox_2.Controls.Add(this.label1);
            this.GroupBox_2.Controls.Add(this.TB_compra);
            this.GroupBox_2.Location = new System.Drawing.Point(408, 30);
            this.GroupBox_2.Name = "GroupBox_2";
            this.GroupBox_2.Size = new System.Drawing.Size(373, 333);
            this.GroupBox_2.TabIndex = 4;
            this.GroupBox_2.TabStop = false;
            this.GroupBox_2.Text = "Registar pago SPEI";
            // 
            // TB_compra
            // 
            this.TB_compra.Location = new System.Drawing.Point(69, 27);
            this.TB_compra.Name = "TB_compra";
            this.TB_compra.Size = new System.Drawing.Size(100, 20);
            this.TB_compra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importe";
            // 
            // TB_importe
            // 
            this.TB_importe.Location = new System.Drawing.Point(69, 53);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(100, 20);
            this.TB_importe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Referencia";
            // 
            // TB_referencia
            // 
            this.TB_referencia.Location = new System.Drawing.Point(69, 79);
            this.TB_referencia.Name = "TB_referencia";
            this.TB_referencia.Size = new System.Drawing.Size(298, 20);
            this.TB_referencia.TabIndex = 4;
            // 
            // BT_guardar_SPEI
            // 
            this.BT_guardar_SPEI.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar_SPEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar_SPEI.ForeColor = System.Drawing.Color.White;
            this.BT_guardar_SPEI.Location = new System.Drawing.Point(206, 279);
            this.BT_guardar_SPEI.Name = "BT_guardar_SPEI";
            this.BT_guardar_SPEI.Size = new System.Drawing.Size(161, 48);
            this.BT_guardar_SPEI.TabIndex = 1;
            this.BT_guardar_SPEI.Text = "Registrar pago SPEI";
            this.BT_guardar_SPEI.UseVisualStyleBackColor = false;
            this.BT_guardar_SPEI.Click += new System.EventHandler(this.BT_guardar_SPEI_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sucursal";
            // 
            // TB_sucursal
            // 
            this.TB_sucursal.Location = new System.Drawing.Point(267, 27);
            this.TB_sucursal.Name = "TB_sucursal";
            this.TB_sucursal.Size = new System.Drawing.Size(100, 20);
            this.TB_sucursal.TabIndex = 6;
            // 
            // CB_patron
            // 
            this.CB_patron.FormattingEnabled = true;
            this.CB_patron.Location = new System.Drawing.Point(23, 154);
            this.CB_patron.Name = "CB_patron";
            this.CB_patron.Size = new System.Drawing.Size(222, 21);
            this.CB_patron.TabIndex = 8;
            this.CB_patron.SelectedIndexChanged += new System.EventHandler(this.CB_patron_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cuenta bancaria";
            // 
            // CB_bancos
            // 
            this.CB_bancos.FormattingEnabled = true;
            this.CB_bancos.Location = new System.Drawing.Point(23, 181);
            this.CB_bancos.Name = "CB_bancos";
            this.CB_bancos.Size = new System.Drawing.Size(222, 21);
            this.CB_bancos.TabIndex = 10;
            this.CB_bancos.SelectedIndexChanged += new System.EventHandler(this.CB_bancos_SelectedIndexChanged);
            // 
            // CB_cuenta_bancaria
            // 
            this.CB_cuenta_bancaria.FormattingEnabled = true;
            this.CB_cuenta_bancaria.Location = new System.Drawing.Point(23, 210);
            this.CB_cuenta_bancaria.Name = "CB_cuenta_bancaria";
            this.CB_cuenta_bancaria.Size = new System.Drawing.Size(222, 21);
            this.CB_cuenta_bancaria.TabIndex = 11;
            // 
            // PagosParciales_enlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(805, 395);
            this.Controls.Add(this.GroupBox_2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PagosParciales_enlace";
            this.Text = "PagosParciales_enlace";
            this.Load += new System.EventHandler(this.PagosParciales_enlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.GroupBox_2.ResumeLayout(false);
            this.GroupBox_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_abrir_enlace;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GroupBox_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_referencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_compra;
        private System.Windows.Forms.Button BT_guardar_SPEI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_sucursal;
        private System.Windows.Forms.ComboBox CB_cuenta_bancaria;
        private System.Windows.Forms.ComboBox CB_bancos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_patron;
    }
}