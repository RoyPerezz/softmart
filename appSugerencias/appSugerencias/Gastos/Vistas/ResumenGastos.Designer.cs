
namespace appSugerencias.Gastos.Vistas
{
    partial class ResumenGastos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.BT_egresos = new System.Windows.Forms.Button();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBX_respaldo = new System.Windows.Forms.CheckBox();
            this.BT_gastos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_gastos_finanzas = new System.Windows.Forms.Button();
            this.CONCEPTO_GRAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EGRESOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_EGRESOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_EGRESOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGRESOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_INGRESOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_INGRESOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLAVE_INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONCEPTO_GRAL,
            this.EGRESOS,
            this.IMPORTE_EGRESOS,
            this.TOTAL_EGRESOS,
            this.INGRESOS,
            this.IMPORTE_INGRESOS,
            this.TOTAL_INGRESOS,
            this.DIFERENCIA,
            this.CLAVE,
            this.CLAVE_INGRESO});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_tabla.Location = new System.Drawing.Point(8, 140);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(916, 347);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // BT_egresos
            // 
            this.BT_egresos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_egresos.ForeColor = System.Drawing.Color.White;
            this.BT_egresos.Location = new System.Drawing.Point(477, 51);
            this.BT_egresos.Name = "BT_egresos";
            this.BT_egresos.Size = new System.Drawing.Size(126, 58);
            this.BT_egresos.TabIndex = 1;
            this.BT_egresos.Text = "Egresos";
            this.BT_egresos.UseVisualStyleBackColor = false;
            this.BT_egresos.Click += new System.EventHandler(this.BT_egresos_Click);
            // 
            // DT_fecha
            // 
            this.DT_fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fecha.Location = new System.Drawing.Point(19, 78);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(357, 29);
            this.DT_fecha.TabIndex = 2;
            this.DT_fecha.ValueChanged += new System.EventHandler(this.DT_fecha_ValueChanged);
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "CEDIS",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO",
            "FINANZAS"});
            this.CB_sucursal.Location = new System.Drawing.Point(19, 36);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(357, 32);
            this.CB_sucursal.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBX_respaldo);
            this.groupBox1.Controls.Add(this.BT_egresos);
            this.groupBox1.Controls.Add(this.DT_fecha);
            this.groupBox1.Controls.Add(this.CB_sucursal);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 122);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Egresos";
            // 
            // CBX_respaldo
            // 
            this.CBX_respaldo.AutoSize = true;
            this.CBX_respaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_respaldo.Location = new System.Drawing.Point(494, 19);
            this.CBX_respaldo.Name = "CBX_respaldo";
            this.CBX_respaldo.Size = new System.Drawing.Size(109, 28);
            this.CBX_respaldo.TabIndex = 11;
            this.CBX_respaldo.Text = "Respaldo";
            this.CBX_respaldo.UseVisualStyleBackColor = true;
            // 
            // BT_gastos
            // 
            this.BT_gastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_gastos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_gastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_gastos.ForeColor = System.Drawing.Color.White;
            this.BT_gastos.Location = new System.Drawing.Point(785, 73);
            this.BT_gastos.Name = "BT_gastos";
            this.BT_gastos.Size = new System.Drawing.Size(139, 64);
            this.BT_gastos.TabIndex = 12;
            this.BT_gastos.Text = "Ver todos los gastos";
            this.BT_gastos.UseVisualStyleBackColor = false;
            this.BT_gastos.Click += new System.EventHandler(this.BT_gastos_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(783, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 64);
            this.button1.TabIndex = 13;
            this.button1.Text = "Gastos pendientes de Aprobacion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_gastos_finanzas
            // 
            this.BT_gastos_finanzas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_gastos_finanzas.BackColor = System.Drawing.Color.SeaGreen;
            this.BT_gastos_finanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_gastos_finanzas.ForeColor = System.Drawing.Color.White;
            this.BT_gastos_finanzas.Location = new System.Drawing.Point(638, 6);
            this.BT_gastos_finanzas.Name = "BT_gastos_finanzas";
            this.BT_gastos_finanzas.Size = new System.Drawing.Size(139, 64);
            this.BT_gastos_finanzas.TabIndex = 14;
            this.BT_gastos_finanzas.Text = "Gastos de Finanzas";
            this.BT_gastos_finanzas.UseVisualStyleBackColor = false;
            this.BT_gastos_finanzas.Click += new System.EventHandler(this.BT_gastos_finanzas_Click);
            // 
            // CONCEPTO_GRAL
            // 
            this.CONCEPTO_GRAL.HeaderText = "CONCEPTO GRAL.";
            this.CONCEPTO_GRAL.Name = "CONCEPTO_GRAL";
            // 
            // EGRESOS
            // 
            this.EGRESOS.HeaderText = "EGRESOS";
            this.EGRESOS.Name = "EGRESOS";
            // 
            // IMPORTE_EGRESOS
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE_EGRESOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.IMPORTE_EGRESOS.HeaderText = "IMPORTE";
            this.IMPORTE_EGRESOS.Name = "IMPORTE_EGRESOS";
            // 
            // TOTAL_EGRESOS
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TOTAL_EGRESOS.DefaultCellStyle = dataGridViewCellStyle3;
            this.TOTAL_EGRESOS.HeaderText = "TOTAL EGRESOS";
            this.TOTAL_EGRESOS.Name = "TOTAL_EGRESOS";
            // 
            // INGRESOS
            // 
            this.INGRESOS.HeaderText = "INGRESOS";
            this.INGRESOS.Name = "INGRESOS";
            // 
            // IMPORTE_INGRESOS
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE_INGRESOS.DefaultCellStyle = dataGridViewCellStyle4;
            this.IMPORTE_INGRESOS.HeaderText = "IMPORTE";
            this.IMPORTE_INGRESOS.Name = "IMPORTE_INGRESOS";
            // 
            // TOTAL_INGRESOS
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TOTAL_INGRESOS.DefaultCellStyle = dataGridViewCellStyle5;
            this.TOTAL_INGRESOS.HeaderText = "TOTAL INGRESOS";
            this.TOTAL_INGRESOS.Name = "TOTAL_INGRESOS";
            // 
            // DIFERENCIA
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DIFERENCIA.DefaultCellStyle = dataGridViewCellStyle6;
            this.DIFERENCIA.HeaderText = "DIFERENCIA";
            this.DIFERENCIA.Name = "DIFERENCIA";
            // 
            // CLAVE
            // 
            this.CLAVE.HeaderText = "CLAVE";
            this.CLAVE.Name = "CLAVE";
            this.CLAVE.Visible = false;
            // 
            // CLAVE_INGRESO
            // 
            this.CLAVE_INGRESO.HeaderText = "CLAVE INGRESO";
            this.CLAVE_INGRESO.Name = "CLAVE_INGRESO";
            this.CLAVE_INGRESO.Visible = false;
            // 
            // ResumenGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(934, 499);
            this.Controls.Add(this.BT_gastos_finanzas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_gastos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ResumenGastos";
            this.Text = "ResumenGastos";
            this.Load += new System.EventHandler(this.ResumenGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_egresos;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBX_respaldo;
        private System.Windows.Forms.Button BT_gastos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BT_gastos_finanzas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO_GRAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGRESOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_EGRESOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_EGRESOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGRESOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_INGRESOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_INGRESOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE_INGRESO;
    }
}