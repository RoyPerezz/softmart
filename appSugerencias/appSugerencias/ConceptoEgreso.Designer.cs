namespace appSugerencias
{
    partial class ConceptoEgreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConceptoEgreso));
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.FLUJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_caja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_gral = new System.Windows.Forms.ComboBox();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.BT_egresos = new System.Windows.Forms.Button();
            this.TB_concepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_flujo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_detalle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_concepto_gral = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_concepto_detalle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_general = new System.Windows.Forms.RadioButton();
            this.RB_tienda = new System.Windows.Forms.RadioButton();
            this.BT_imprimir = new System.Windows.Forms.Button();
            this.CB_impresoras = new System.Windows.Forms.ComboBox();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.RB_imprimir_caja = new System.Windows.Forms.RadioButton();
            this.RB_reimprimir_enc_cajas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FLUJO,
            this.CONCEPTO,
            this.DESCRIPCION,
            this.IMPORTE,
            this.FECHA,
            this.HORA});
            this.DG_tabla.Location = new System.Drawing.Point(1, 38);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(756, 568);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellDoubleClick);
            // 
            // FLUJO
            // 
            this.FLUJO.HeaderText = "FLUJO";
            this.FLUJO.Name = "FLUJO";
            // 
            // CONCEPTO
            // 
            this.CONCEPTO.HeaderText = "CONCEPTO";
            this.CONCEPTO.Name = "CONCEPTO";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle3;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // HORA
            // 
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            // 
            // CB_caja
            // 
            this.CB_caja.FormattingEnabled = true;
            this.CB_caja.Items.AddRange(new object[] {
            "CAJA1",
            "CAJA2",
            "CAJA3",
            "CAJA4",
            "CAJA5",
            "CAJA6",
            "CAJA7",
            "CAJA8"});
            this.CB_caja.Location = new System.Drawing.Point(34, 48);
            this.CB_caja.Name = "CB_caja";
            this.CB_caja.Size = new System.Drawing.Size(121, 21);
            this.CB_caja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Concepto general";
            // 
            // CB_gral
            // 
            this.CB_gral.FormattingEnabled = true;
            this.CB_gral.Location = new System.Drawing.Point(36, 72);
            this.CB_gral.Name = "CB_gral";
            this.CB_gral.Size = new System.Drawing.Size(315, 21);
            this.CB_gral.TabIndex = 3;
            this.CB_gral.SelectedIndexChanged += new System.EventHandler(this.CB_gral_SelectedIndexChanged_1);
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(166, 48);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 5;
            // 
            // BT_egresos
            // 
            this.BT_egresos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_egresos.ForeColor = System.Drawing.Color.White;
            this.BT_egresos.Location = new System.Drawing.Point(260, 219);
            this.BT_egresos.Name = "BT_egresos";
            this.BT_egresos.Size = new System.Drawing.Size(106, 45);
            this.BT_egresos.TabIndex = 6;
            this.BT_egresos.Text = "Buscar egresos";
            this.BT_egresos.UseVisualStyleBackColor = false;
            this.BT_egresos.Click += new System.EventHandler(this.BT_egresos_Click);
            // 
            // TB_concepto
            // 
            this.TB_concepto.Enabled = false;
            this.TB_concepto.Location = new System.Drawing.Point(36, 166);
            this.TB_concepto.Name = "TB_concepto";
            this.TB_concepto.Size = new System.Drawing.Size(100, 20);
            this.TB_concepto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Concepto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Flujo";
            // 
            // TB_flujo
            // 
            this.TB_flujo.Enabled = false;
            this.TB_flujo.Location = new System.Drawing.Point(34, 101);
            this.TB_flujo.Name = "TB_flujo";
            this.TB_flujo.Size = new System.Drawing.Size(100, 20);
            this.TB_flujo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(260, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cambiar concepto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Concepto detalle";
            // 
            // CB_detalle
            // 
            this.CB_detalle.FormattingEnabled = true;
            this.CB_detalle.Location = new System.Drawing.Point(35, 117);
            this.CB_detalle.Name = "CB_detalle";
            this.CB_detalle.Size = new System.Drawing.Size(315, 21);
            this.CB_detalle.TabIndex = 14;
            this.CB_detalle.SelectedIndexChanged += new System.EventHandler(this.CB_detalle_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Concepto general";
            // 
            // TB_concepto_gral
            // 
            this.TB_concepto_gral.Enabled = false;
            this.TB_concepto_gral.Location = new System.Drawing.Point(34, 146);
            this.TB_concepto_gral.Name = "TB_concepto_gral";
            this.TB_concepto_gral.Size = new System.Drawing.Size(332, 20);
            this.TB_concepto_gral.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Concepto detalle";
            // 
            // TB_concepto_detalle
            // 
            this.TB_concepto_detalle.Enabled = false;
            this.TB_concepto_detalle.Location = new System.Drawing.Point(34, 193);
            this.TB_concepto_detalle.Name = "TB_concepto_detalle";
            this.TB_concepto_detalle.Size = new System.Drawing.Size(332, 20);
            this.TB_concepto_detalle.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_egresos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DT_fecha);
            this.groupBox1.Controls.Add(this.CB_caja);
            this.groupBox1.Controls.Add(this.TB_concepto_detalle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_concepto_gral);
            this.groupBox1.Controls.Add(this.TB_flujo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(763, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 275);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de gasto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_general);
            this.groupBox2.Controls.Add(this.RB_tienda);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.CB_gral);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TB_concepto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CB_detalle);
            this.groupBox2.Location = new System.Drawing.Point(763, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 226);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de gasto";
            // 
            // RB_general
            // 
            this.RB_general.AutoSize = true;
            this.RB_general.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_general.Location = new System.Drawing.Point(193, 19);
            this.RB_general.Name = "RB_general";
            this.RB_general.Size = new System.Drawing.Size(173, 27);
            this.RB_general.TabIndex = 8;
            this.RB_general.TabStop = true;
            this.RB_general.Text = "Gastos Generales";
            this.RB_general.UseVisualStyleBackColor = true;
            this.RB_general.CheckedChanged += new System.EventHandler(this.RB_general_CheckedChanged);
            // 
            // RB_tienda
            // 
            this.RB_tienda.AutoSize = true;
            this.RB_tienda.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_tienda.Location = new System.Drawing.Point(16, 19);
            this.RB_tienda.Name = "RB_tienda";
            this.RB_tienda.Size = new System.Drawing.Size(168, 27);
            this.RB_tienda.TabIndex = 7;
            this.RB_tienda.TabStop = true;
            this.RB_tienda.Text = "Gastos de tienda";
            this.RB_tienda.UseVisualStyleBackColor = true;
            this.RB_tienda.CheckedChanged += new System.EventHandler(this.RB_tienda_CheckedChanged);
            // 
            // BT_imprimir
            // 
            this.BT_imprimir.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_imprimir.ForeColor = System.Drawing.Color.White;
            this.BT_imprimir.Location = new System.Drawing.Point(1041, 561);
            this.BT_imprimir.Name = "BT_imprimir";
            this.BT_imprimir.Size = new System.Drawing.Size(106, 45);
            this.BT_imprimir.TabIndex = 20;
            this.BT_imprimir.Text = "Reimprimir Ticket";
            this.BT_imprimir.UseVisualStyleBackColor = false;
            this.BT_imprimir.Click += new System.EventHandler(this.BT_imprimir_Click);
            // 
            // CB_impresoras
            // 
            this.CB_impresoras.FormattingEnabled = true;
            this.CB_impresoras.Location = new System.Drawing.Point(764, 585);
            this.CB_impresoras.Name = "CB_impresoras";
            this.CB_impresoras.Size = new System.Drawing.Size(199, 21);
            this.CB_impresoras.TabIndex = 20;
            // 
            // PB_logo
            // 
            this.PB_logo.Image = ((System.Drawing.Image)(resources.GetObject("PB_logo.Image")));
            this.PB_logo.Location = new System.Drawing.Point(1115, 20);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(26, 12);
            this.PB_logo.TabIndex = 22;
            this.PB_logo.TabStop = false;
            this.PB_logo.Visible = false;
            // 
            // RB_imprimir_caja
            // 
            this.RB_imprimir_caja.AutoSize = true;
            this.RB_imprimir_caja.Location = new System.Drawing.Point(764, 551);
            this.RB_imprimir_caja.Name = "RB_imprimir_caja";
            this.RB_imprimir_caja.Size = new System.Drawing.Size(111, 17);
            this.RB_imprimir_caja.TabIndex = 23;
            this.RB_imprimir_caja.TabStop = true;
            this.RB_imprimir_caja.Text = "Reimprimir en caja";
            this.RB_imprimir_caja.UseVisualStyleBackColor = true;
            this.RB_imprimir_caja.CheckedChanged += new System.EventHandler(this.RB_imprimir_caja_CheckedChanged);
            // 
            // RB_reimprimir_enc_cajas
            // 
            this.RB_reimprimir_enc_cajas.AutoSize = true;
            this.RB_reimprimir_enc_cajas.Location = new System.Drawing.Point(896, 551);
            this.RB_reimprimir_enc_cajas.Name = "RB_reimprimir_enc_cajas";
            this.RB_reimprimir_enc_cajas.Size = new System.Drawing.Size(122, 17);
            this.RB_reimprimir_enc_cajas.TabIndex = 24;
            this.RB_reimprimir_enc_cajas.TabStop = true;
            this.RB_reimprimir_enc_cajas.Text = "Reimprimir enc cajas";
            this.RB_reimprimir_enc_cajas.UseVisualStyleBackColor = true;
            this.RB_reimprimir_enc_cajas.CheckedChanged += new System.EventHandler(this.RB_reimprimir_enc_cajas_CheckedChanged);
            // 
            // ConceptoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1170, 618);
            this.Controls.Add(this.RB_reimprimir_enc_cajas);
            this.Controls.Add(this.RB_imprimir_caja);
            this.Controls.Add(this.PB_logo);
            this.Controls.Add(this.CB_impresoras);
            this.Controls.Add(this.BT_imprimir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ConceptoEgreso";
            this.Text = "ConceptoEgreso";
            this.Load += new System.EventHandler(this.ConceptoEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.ComboBox CB_caja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_gral;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Button BT_egresos;
        private System.Windows.Forms.TextBox TB_concepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_flujo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLUJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_detalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_concepto_gral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_concepto_detalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_imprimir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CB_impresoras;
        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.RadioButton RB_general;
        private System.Windows.Forms.RadioButton RB_tienda;
        private System.Windows.Forms.RadioButton RB_imprimir_caja;
        private System.Windows.Forms.RadioButton RB_reimprimir_enc_cajas;
    }
}