
namespace appSugerencias.Gastos_Externos.Vistas
{
    partial class ModificarGastoExternoPago
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
            this.RB_general = new System.Windows.Forms.RadioButton();
            this.RB_tienda = new System.Windows.Forms.RadioButton();
            this.CB_concepto_gral = new System.Windows.Forms.ComboBox();
            this.cbGastos = new System.Windows.Forms.ComboBox();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOGASTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTOGRAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTODETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_modificar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_referencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.RB_tienda_modificacion = new System.Windows.Forms.RadioButton();
            this.RB_general_modificacion = new System.Windows.Forms.RadioButton();
            this.CB_concepto_detalle_modificacion = new System.Windows.Forms.ComboBox();
            this.CB_concepto_gral_modificacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RB_general
            // 
            this.RB_general.AutoSize = true;
            this.RB_general.Location = new System.Drawing.Point(149, 23);
            this.RB_general.Name = "RB_general";
            this.RB_general.Size = new System.Drawing.Size(76, 17);
            this.RB_general.TabIndex = 61;
            this.RB_general.TabStop = true;
            this.RB_general.Text = "GENERAL";
            this.RB_general.UseVisualStyleBackColor = true;
            this.RB_general.CheckedChanged += new System.EventHandler(this.RB_general_CheckedChanged);
            // 
            // RB_tienda
            // 
            this.RB_tienda.AutoSize = true;
            this.RB_tienda.Location = new System.Drawing.Point(48, 23);
            this.RB_tienda.Name = "RB_tienda";
            this.RB_tienda.Size = new System.Drawing.Size(65, 17);
            this.RB_tienda.TabIndex = 60;
            this.RB_tienda.TabStop = true;
            this.RB_tienda.Text = "TIENDA";
            this.RB_tienda.UseVisualStyleBackColor = true;
            this.RB_tienda.CheckedChanged += new System.EventHandler(this.RB_tienda_CheckedChanged);
            // 
            // CB_concepto_gral
            // 
            this.CB_concepto_gral.FormattingEnabled = true;
            this.CB_concepto_gral.Location = new System.Drawing.Point(166, 87);
            this.CB_concepto_gral.Name = "CB_concepto_gral";
            this.CB_concepto_gral.Size = new System.Drawing.Size(232, 21);
            this.CB_concepto_gral.TabIndex = 59;
            this.CB_concepto_gral.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_gral_SelectedIndexChanged);
            // 
            // cbGastos
            // 
            this.cbGastos.FormattingEnabled = true;
            this.cbGastos.Location = new System.Drawing.Point(166, 114);
            this.cbGastos.Name = "cbGastos";
            this.cbGastos.Size = new System.Drawing.Size(232, 21);
            this.cbGastos.TabIndex = 58;
            this.cbGastos.SelectedIndexChanged += new System.EventHandler(this.cbGastos_SelectedIndexChanged);
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(816, 104);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(111, 48);
            this.BT_buscar.TabIndex = 62;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TIPOGASTO,
            this.CONCEPTOGRAL,
            this.CONCEPTODETALLE,
            this.IMPORTE,
            this.REFERENCIA});
            this.DG_tabla.Location = new System.Drawing.Point(20, 34);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(890, 116);
            this.DG_tabla.TabIndex = 63;
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TIPOGASTO
            // 
            this.TIPOGASTO.HeaderText = "TIPO GASTO EXTERNO";
            this.TIPOGASTO.Name = "TIPOGASTO";
            // 
            // CONCEPTOGRAL
            // 
            this.CONCEPTOGRAL.HeaderText = "CONCEPTO GRAL.";
            this.CONCEPTOGRAL.Name = "CONCEPTOGRAL";
            // 
            // CONCEPTODETALLE
            // 
            this.CONCEPTODETALLE.HeaderText = "CONCEPTO DETALLE";
            this.CONCEPTODETALLE.Name = "CONCEPTODETALLE";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.HeaderText = "REFERENCIA";
            this.REFERENCIA.Name = "REFERENCIA";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(726, 19);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "CONCEPTO GRAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "CONCEPTO DETALLE";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "CEDIS",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(166, 60);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(232, 21);
            this.CB_sucursal.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "SUCURSAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_tienda);
            this.groupBox1.Controls.Add(this.cbGastos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_concepto_gral);
            this.groupBox1.Controls.Add(this.CB_sucursal);
            this.groupBox1.Controls.Add(this.RB_general);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BT_buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DT_fecha);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 158);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de pago externo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DG_tabla);
            this.groupBox2.Location = new System.Drawing.Point(10, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 167);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagos externos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BT_modificar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TB_referencia);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TB_importe);
            this.groupBox3.Controls.Add(this.RB_tienda_modificacion);
            this.groupBox3.Controls.Add(this.RB_general_modificacion);
            this.groupBox3.Controls.Add(this.CB_concepto_detalle_modificacion);
            this.groupBox3.Controls.Add(this.CB_concepto_gral_modificacion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.LB_id);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(10, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(932, 167);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar pago externo";
            // 
            // BT_modificar
            // 
            this.BT_modificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_modificar.ForeColor = System.Drawing.Color.White;
            this.BT_modificar.Location = new System.Drawing.Point(815, 109);
            this.BT_modificar.Name = "BT_modificar";
            this.BT_modificar.Size = new System.Drawing.Size(111, 48);
            this.BT_modificar.TabIndex = 69;
            this.BT_modificar.Text = "Modificar";
            this.BT_modificar.UseVisualStyleBackColor = false;
            this.BT_modificar.Click += new System.EventHandler(this.BT_modificar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "REFERENCIA";
            // 
            // TB_referencia
            // 
            this.TB_referencia.Location = new System.Drawing.Point(451, 83);
            this.TB_referencia.Name = "TB_referencia";
            this.TB_referencia.Size = new System.Drawing.Size(475, 20);
            this.TB_referencia.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "IMPORTE";
            // 
            // TB_importe
            // 
            this.TB_importe.Location = new System.Drawing.Point(451, 108);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(100, 20);
            this.TB_importe.TabIndex = 78;
            // 
            // RB_tienda_modificacion
            // 
            this.RB_tienda_modificacion.AutoSize = true;
            this.RB_tienda_modificacion.Location = new System.Drawing.Point(28, 54);
            this.RB_tienda_modificacion.Name = "RB_tienda_modificacion";
            this.RB_tienda_modificacion.Size = new System.Drawing.Size(65, 17);
            this.RB_tienda_modificacion.TabIndex = 76;
            this.RB_tienda_modificacion.TabStop = true;
            this.RB_tienda_modificacion.Text = "TIENDA";
            this.RB_tienda_modificacion.UseVisualStyleBackColor = true;
            this.RB_tienda_modificacion.CheckedChanged += new System.EventHandler(this.RB_tienda_modificacion_CheckedChanged);
            // 
            // RB_general_modificacion
            // 
            this.RB_general_modificacion.AutoSize = true;
            this.RB_general_modificacion.Location = new System.Drawing.Point(129, 54);
            this.RB_general_modificacion.Name = "RB_general_modificacion";
            this.RB_general_modificacion.Size = new System.Drawing.Size(76, 17);
            this.RB_general_modificacion.TabIndex = 77;
            this.RB_general_modificacion.TabStop = true;
            this.RB_general_modificacion.Text = "GENERAL";
            this.RB_general_modificacion.UseVisualStyleBackColor = true;
            this.RB_general_modificacion.CheckedChanged += new System.EventHandler(this.RB_general_modificacion_CheckedChanged);
            // 
            // CB_concepto_detalle_modificacion
            // 
            this.CB_concepto_detalle_modificacion.FormattingEnabled = true;
            this.CB_concepto_detalle_modificacion.Location = new System.Drawing.Point(129, 108);
            this.CB_concepto_detalle_modificacion.Name = "CB_concepto_detalle_modificacion";
            this.CB_concepto_detalle_modificacion.Size = new System.Drawing.Size(232, 21);
            this.CB_concepto_detalle_modificacion.TabIndex = 72;
            this.CB_concepto_detalle_modificacion.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_detalle_modificacion_SelectedIndexChanged);
            // 
            // CB_concepto_gral_modificacion
            // 
            this.CB_concepto_gral_modificacion.FormattingEnabled = true;
            this.CB_concepto_gral_modificacion.Location = new System.Drawing.Point(129, 81);
            this.CB_concepto_gral_modificacion.Name = "CB_concepto_gral_modificacion";
            this.CB_concepto_gral_modificacion.Size = new System.Drawing.Size(232, 21);
            this.CB_concepto_gral_modificacion.TabIndex = 73;
            this.CB_concepto_gral_modificacion.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_gral_modificacion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "CONCEPTO DETALLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "CONCEPTO GRAL";
            // 
            // LB_id
            // 
            this.LB_id.AutoSize = true;
            this.LB_id.Location = new System.Drawing.Point(50, 28);
            this.LB_id.Name = "LB_id";
            this.LB_id.Size = new System.Drawing.Size(0, 13);
            this.LB_id.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "ID";
            // 
            // ModificarGastoExternoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(949, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarGastoExternoPago";
            this.Text = "ModificarGastoExternoPago";
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_general;
        private System.Windows.Forms.RadioButton RB_tienda;
        private System.Windows.Forms.ComboBox CB_concepto_gral;
        private System.Windows.Forms.ComboBox cbGastos;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOGASTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTOGRAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTODETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_referencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.RadioButton RB_tienda_modificacion;
        private System.Windows.Forms.RadioButton RB_general_modificacion;
        private System.Windows.Forms.ComboBox CB_concepto_detalle_modificacion;
        private System.Windows.Forms.ComboBox CB_concepto_gral_modificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_modificar;
    }
}