namespace appSugerencias
{
    partial class Rep_pagoproveedores_Finanzas
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
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_reporte = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGARA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_DEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_EFE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FINANZAS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AUXFIN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GERENTEGRAL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.BT_aceptar = new System.Windows.Forms.Button();
            this.CHK_respaldo = new System.Windows.Forms.CheckBox();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.DT_fecha_efe = new System.Windows.Forms.DateTimePicker();
            this.TB_disponible = new System.Windows.Forms.TextBox();
            this.BT_efectivo = new System.Windows.Forms.Button();
            this.DT_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "  ",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(12, 64);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(121, 21);
            this.CB_sucursal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sucursal";
            // 
            // DG_reporte
            // 
            this.DG_reporte.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DG_reporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PROVEEDOR,
            this.PAGARA,
            this.MONTO,
            this.BANCO,
            this.CUENTA,
            this.FECHA_DEP,
            this.FECHA_EFE,
            this.TIENDA,
            this.COMPRA,
            this.REFERENCIA,
            this.STATUS,
            this.FINANZAS,
            this.AUXFIN,
            this.GERENTEGRAL});
            this.DG_reporte.Location = new System.Drawing.Point(12, 104);
            this.DG_reporte.Name = "DG_reporte";
            this.DG_reporte.Size = new System.Drawing.Size(1824, 333);
            this.DG_reporte.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            // 
            // PAGARA
            // 
            this.PAGARA.HeaderText = "DEPOSITAR A";
            this.PAGARA.Name = "PAGARA";
            // 
            // MONTO
            // 
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            // 
            // BANCO
            // 
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.Name = "BANCO";
            // 
            // CUENTA
            // 
            this.CUENTA.HeaderText = "CUENTA";
            this.CUENTA.Name = "CUENTA";
            // 
            // FECHA_DEP
            // 
            this.FECHA_DEP.HeaderText = "FECHA DEP.";
            this.FECHA_DEP.Name = "FECHA_DEP";
            // 
            // FECHA_EFE
            // 
            this.FECHA_EFE.HeaderText = "FECHA EFE.";
            this.FECHA_EFE.Name = "FECHA_EFE";
            // 
            // TIENDA
            // 
            this.TIENDA.HeaderText = "TIENDA";
            this.TIENDA.Name = "TIENDA";
            // 
            // COMPRA
            // 
            this.COMPRA.HeaderText = "COMPRA";
            this.COMPRA.Name = "COMPRA";
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.HeaderText = "REFERENCIA";
            this.REFERENCIA.Name = "REFERENCIA";
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            // 
            // FINANZAS
            // 
            this.FINANZAS.HeaderText = "FINANZAS";
            this.FINANZAS.Name = "FINANZAS";
            // 
            // AUXFIN
            // 
            this.AUXFIN.HeaderText = "AUX. FINANZAS";
            this.AUXFIN.Name = "AUXFIN";
            // 
            // GERENTEGRAL
            // 
            this.GERENTEGRAL.HeaderText = "GERENTE GRAL.";
            this.GERENTEGRAL.Name = "GERENTEGRAL";
            this.GERENTEGRAL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GERENTEGRAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(167, 32);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 3;
            // 
            // BT_aceptar
            // 
            this.BT_aceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_aceptar.ForeColor = System.Drawing.Color.White;
            this.BT_aceptar.Location = new System.Drawing.Point(387, 32);
            this.BT_aceptar.Name = "BT_aceptar";
            this.BT_aceptar.Size = new System.Drawing.Size(131, 54);
            this.BT_aceptar.TabIndex = 4;
            this.BT_aceptar.Text = "Aceptar";
            this.BT_aceptar.UseVisualStyleBackColor = false;
            this.BT_aceptar.Click += new System.EventHandler(this.BT_aceptar_Click);
            // 
            // CHK_respaldo
            // 
            this.CHK_respaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CHK_respaldo.AutoSize = true;
            this.CHK_respaldo.Location = new System.Drawing.Point(1395, 54);
            this.CHK_respaldo.Name = "CHK_respaldo";
            this.CHK_respaldo.Size = new System.Drawing.Size(71, 17);
            this.CHK_respaldo.TabIndex = 5;
            this.CHK_respaldo.Text = "Respaldo";
            this.CHK_respaldo.UseVisualStyleBackColor = true;
            // 
            // BT_guardar
            // 
            this.BT_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(1705, 443);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(131, 54);
            this.BT_guardar.TabIndex = 6;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // DT_fecha_efe
            // 
            this.DT_fecha_efe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_fecha_efe.Location = new System.Drawing.Point(1636, 34);
            this.DT_fecha_efe.Name = "DT_fecha_efe";
            this.DT_fecha_efe.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha_efe.TabIndex = 7;
            // 
            // TB_disponible
            // 
            this.TB_disponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_disponible.Location = new System.Drawing.Point(1736, 68);
            this.TB_disponible.Name = "TB_disponible";
            this.TB_disponible.Size = new System.Drawing.Size(100, 20);
            this.TB_disponible.TabIndex = 8;
            // 
            // BT_efectivo
            // 
            this.BT_efectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_efectivo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_efectivo.ForeColor = System.Drawing.Color.White;
            this.BT_efectivo.Location = new System.Drawing.Point(1490, 34);
            this.BT_efectivo.Name = "BT_efectivo";
            this.BT_efectivo.Size = new System.Drawing.Size(131, 54);
            this.BT_efectivo.TabIndex = 9;
            this.BT_efectivo.Text = "Efectivo";
            this.BT_efectivo.UseVisualStyleBackColor = false;
            this.BT_efectivo.Click += new System.EventHandler(this.BT_efectivo_Click);
            // 
            // DT_fecha2
            // 
            this.DT_fecha2.Location = new System.Drawing.Point(167, 65);
            this.DT_fecha2.Name = "DT_fecha2";
            this.DT_fecha2.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "TOTAL";
            // 
            // TB_total
            // 
            this.TB_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_total.BackColor = System.Drawing.Color.Black;
            this.TB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_total.ForeColor = System.Drawing.Color.Lime;
            this.TB_total.Location = new System.Drawing.Point(81, 457);
            this.TB_total.Name = "TB_total";
            this.TB_total.Size = new System.Drawing.Size(146, 26);
            this.TB_total.TabIndex = 12;
            // 
            // Rep_pagoproveedores_Finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1848, 508);
            this.Controls.Add(this.TB_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DT_fecha2);
            this.Controls.Add(this.BT_efectivo);
            this.Controls.Add(this.TB_disponible);
            this.Controls.Add(this.DT_fecha_efe);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.CHK_respaldo);
            this.Controls.Add(this.BT_aceptar);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.DG_reporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_sucursal);
            this.Name = "Rep_pagoproveedores_Finanzas";
            this.Text = "Rep_pagoproveedores_Finanzas";
            this.Load += new System.EventHandler(this.Rep_pagoproveedores_Finanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_reporte;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Button BT_aceptar;
        private System.Windows.Forms.CheckBox CHK_respaldo;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.DateTimePicker DT_fecha_efe;
        private System.Windows.Forms.TextBox TB_disponible;
        private System.Windows.Forms.Button BT_efectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_DEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_EFE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FINANZAS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AUXFIN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GERENTEGRAL;
        private System.Windows.Forms.DateTimePicker DT_fecha2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_total;
    }
}