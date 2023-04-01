
namespace appSugerencias.Gastos.Vistas
{
    partial class ReporteGastos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.TICKET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_GASTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO_GRAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO_DETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP_DETALLADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_AUTORIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RB_tienda = new System.Windows.Forms.RadioButton();
            this.RB_general = new System.Windows.Forms.RadioButton();
            this.CB_concepto_gral = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_concepto_detalle = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RB_general_todos = new System.Windows.Forms.RadioButton();
            this.RB_tienda_todos = new System.Windows.Forms.RadioButton();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.RB_todos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBX_respaldo = new System.Windows.Forms.CheckBox();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_excel = new System.Windows.Forms.Button();
            this.LB_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.DG_tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TICKET,
            this.TIPO_GASTO,
            this.CONCEPTO_GRAL,
            this.CONCEPTO_DETALLE,
            this.DESCRIP_DETALLADA,
            this.IMPORTE,
            this.FECHA,
            this.NUM_AUTORIZACION});
            this.DG_tabla.Location = new System.Drawing.Point(6, 207);
            this.DG_tabla.Name = "DG_tabla";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_tabla.Size = new System.Drawing.Size(1035, 358);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // TICKET
            // 
            this.TICKET.HeaderText = "TICKET";
            this.TICKET.Name = "TICKET";
            // 
            // TIPO_GASTO
            // 
            this.TIPO_GASTO.HeaderText = "TIPO GASTO";
            this.TIPO_GASTO.Name = "TIPO_GASTO";
            // 
            // CONCEPTO_GRAL
            // 
            this.CONCEPTO_GRAL.HeaderText = "CONCEPTO GRAL.";
            this.CONCEPTO_GRAL.Name = "CONCEPTO_GRAL";
            // 
            // CONCEPTO_DETALLE
            // 
            this.CONCEPTO_DETALLE.HeaderText = "CONCEPTO DETALLE";
            this.CONCEPTO_DETALLE.Name = "CONCEPTO_DETALLE";
            // 
            // DESCRIP_DETALLADA
            // 
            this.DESCRIP_DETALLADA.HeaderText = "DESCRIPCION DETALLADA";
            this.DESCRIP_DETALLADA.Name = "DESCRIP_DETALLADA";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle4;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // NUM_AUTORIZACION
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NUM_AUTORIZACION.DefaultCellStyle = dataGridViewCellStyle5;
            this.NUM_AUTORIZACION.HeaderText = "NUM. AUTORIZACION";
            this.NUM_AUTORIZACION.Name = "NUM_AUTORIZACION";
            // 
            // RB_tienda
            // 
            this.RB_tienda.AutoSize = true;
            this.RB_tienda.Location = new System.Drawing.Point(8, 65);
            this.RB_tienda.Name = "RB_tienda";
            this.RB_tienda.Size = new System.Drawing.Size(65, 17);
            this.RB_tienda.TabIndex = 6;
            this.RB_tienda.TabStop = true;
            this.RB_tienda.Text = "TIENDA";
            this.RB_tienda.UseVisualStyleBackColor = true;
            this.RB_tienda.CheckedChanged += new System.EventHandler(this.RB_tienda_CheckedChanged);
            // 
            // RB_general
            // 
            this.RB_general.AutoSize = true;
            this.RB_general.Location = new System.Drawing.Point(8, 90);
            this.RB_general.Name = "RB_general";
            this.RB_general.Size = new System.Drawing.Size(76, 17);
            this.RB_general.TabIndex = 7;
            this.RB_general.TabStop = true;
            this.RB_general.Text = "GENERAL";
            this.RB_general.UseVisualStyleBackColor = true;
            this.RB_general.CheckedChanged += new System.EventHandler(this.RB_general_CheckedChanged);
            // 
            // CB_concepto_gral
            // 
            this.CB_concepto_gral.FormattingEnabled = true;
            this.CB_concepto_gral.Location = new System.Drawing.Point(100, 135);
            this.CB_concepto_gral.Name = "CB_concepto_gral";
            this.CB_concepto_gral.Size = new System.Drawing.Size(267, 21);
            this.CB_concepto_gral.TabIndex = 8;
            this.CB_concepto_gral.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_gral_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Concepto General";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Concepto Detalle";
            // 
            // CB_concepto_detalle
            // 
            this.CB_concepto_detalle.FormattingEnabled = true;
            this.CB_concepto_detalle.Location = new System.Drawing.Point(100, 162);
            this.CB_concepto_detalle.Name = "CB_concepto_detalle";
            this.CB_concepto_detalle.Size = new System.Drawing.Size(267, 21);
            this.CB_concepto_detalle.TabIndex = 10;
            this.CB_concepto_detalle.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_detalle_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RB_general_todos);
            this.groupBox1.Controls.Add(this.RB_tienda_todos);
            this.groupBox1.Controls.Add(this.CB_sucursal);
            this.groupBox1.Controls.Add(this.RB_todos);
            this.groupBox1.Controls.Add(this.CB_concepto_gral);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RB_tienda);
            this.groupBox1.Controls.Add(this.CB_concepto_detalle);
            this.groupBox1.Controls.Add(this.RB_general);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sucursal";
            // 
            // RB_general_todos
            // 
            this.RB_general_todos.AutoSize = true;
            this.RB_general_todos.Location = new System.Drawing.Point(8, 42);
            this.RB_general_todos.Name = "RB_general_todos";
            this.RB_general_todos.Size = new System.Drawing.Size(202, 17);
            this.RB_general_todos.TabIndex = 15;
            this.RB_general_todos.TabStop = true;
            this.RB_general_todos.Text = "TODOS LOS GASTOS GENERALES";
            this.RB_general_todos.UseVisualStyleBackColor = true;
            // 
            // RB_tienda_todos
            // 
            this.RB_tienda_todos.AutoSize = true;
            this.RB_tienda_todos.Location = new System.Drawing.Point(8, 19);
            this.RB_tienda_todos.Name = "RB_tienda_todos";
            this.RB_tienda_todos.Size = new System.Drawing.Size(195, 17);
            this.RB_tienda_todos.TabIndex = 14;
            this.RB_tienda_todos.TabStop = true;
            this.RB_tienda_todos.Text = "TODOS LOS GASTOS DE TIENDA";
            this.RB_tienda_todos.UseVisualStyleBackColor = true;
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "CEDIS",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO",
            "FINANZAS"});
            this.CB_sucursal.Location = new System.Drawing.Point(151, 108);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(216, 21);
            this.CB_sucursal.TabIndex = 13;
            // 
            // RB_todos
            // 
            this.RB_todos.AutoSize = true;
            this.RB_todos.Location = new System.Drawing.Point(8, 113);
            this.RB_todos.Name = "RB_todos";
            this.RB_todos.Size = new System.Drawing.Size(63, 17);
            this.RB_todos.TabIndex = 12;
            this.RB_todos.TabStop = true;
            this.RB_todos.Text = "TODOS";
            this.RB_todos.UseVisualStyleBackColor = true;
            this.RB_todos.CheckedChanged += new System.EventHandler(this.RB_todos_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBX_respaldo);
            this.groupBox2.Controls.Add(this.BT_buscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DT_fin);
            this.groupBox2.Controls.Add(this.DT_inicio);
            this.groupBox2.Location = new System.Drawing.Point(428, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 148);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // CBX_respaldo
            // 
            this.CBX_respaldo.AutoSize = true;
            this.CBX_respaldo.Location = new System.Drawing.Point(79, 98);
            this.CBX_respaldo.Name = "CBX_respaldo";
            this.CBX_respaldo.Size = new System.Drawing.Size(71, 17);
            this.CBX_respaldo.TabIndex = 11;
            this.CBX_respaldo.Text = "Respaldo";
            this.CBX_respaldo.UseVisualStyleBackColor = true;
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(156, 81);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(109, 48);
            this.BT_buscar.TabIndex = 10;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "FIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "INICIO";
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(65, 50);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 7;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(65, 24);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(750, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 148);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total gastos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.BT_excel);
            this.panel1.Controls.Add(this.LB_total);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BT_excel
            // 
            this.BT_excel.BackColor = System.Drawing.Color.Green;
            this.BT_excel.ForeColor = System.Drawing.Color.White;
            this.BT_excel.Location = new System.Drawing.Point(190, 4);
            this.BT_excel.Name = "BT_excel";
            this.BT_excel.Size = new System.Drawing.Size(86, 38);
            this.BT_excel.TabIndex = 11;
            this.BT_excel.Text = "Excel";
            this.BT_excel.UseVisualStyleBackColor = false;
            this.BT_excel.Click += new System.EventHandler(this.BT_excel_Click);
            // 
            // LB_total
            // 
            this.LB_total.AutoSize = true;
            this.LB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_total.ForeColor = System.Drawing.Color.White;
            this.LB_total.Location = new System.Drawing.Point(55, 61);
            this.LB_total.Name = "LB_total";
            this.LB_total.Size = new System.Drawing.Size(0, 29);
            this.LB_total.TabIndex = 12;
            this.LB_total.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL";
            // 
            // ReporteGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ReporteGastos";
            this.Text = "ReporteGastos";
            this.Load += new System.EventHandler(this.ReporteGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.RadioButton RB_tienda;
        private System.Windows.Forms.RadioButton RB_general;
        private System.Windows.Forms.ComboBox CB_concepto_gral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_concepto_detalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RB_todos;
        private System.Windows.Forms.Button BT_excel;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.RadioButton RB_general_todos;
        private System.Windows.Forms.RadioButton RB_tienda_todos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CBX_respaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TICKET;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_GASTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO_GRAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO_DETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP_DETALLADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_AUTORIZACION;
    }
}