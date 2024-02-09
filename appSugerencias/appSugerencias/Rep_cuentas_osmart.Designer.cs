namespace appSugerencias
{
    partial class Rep_cuentas_osmart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.CB_banco = new System.Windows.Forms.ComboBox();
            this.CB_cuentas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.BT_estado_cuenta = new System.Windows.Forms.Button();
            this.BT_Exportar = new System.Windows.Forms.Button();
            this.BT_ajuste = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGARA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUC_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "BODEGA",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO",
            "PREGOT"});
            this.CB_sucursal.Location = new System.Drawing.Point(30, 38);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(121, 21);
            this.CB_sucursal.TabIndex = 0;
            this.CB_sucursal.SelectedIndexChanged += new System.EventHandler(this.CB_sucursal_SelectedIndexChanged);
            // 
            // CB_banco
            // 
            this.CB_banco.FormattingEnabled = true;
            this.CB_banco.Location = new System.Drawing.Point(381, 38);
            this.CB_banco.Name = "CB_banco";
            this.CB_banco.Size = new System.Drawing.Size(157, 21);
            this.CB_banco.TabIndex = 1;
            this.CB_banco.SelectedIndexChanged += new System.EventHandler(this.CB_banco_SelectedIndexChanged);
            // 
            // CB_cuentas
            // 
            this.CB_cuentas.FormattingEnabled = true;
            this.CB_cuentas.Location = new System.Drawing.Point(671, 38);
            this.CB_cuentas.Name = "CB_cuentas";
            this.CB_cuentas.Size = new System.Drawing.Size(226, 21);
            this.CB_cuentas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sucursal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuenta";
            // 
            // DG_tabla
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG_tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MOV,
            this.PAGARA,
            this.FECHA,
            this.REFERENCIA,
            this.SUCURSAL,
            this.INGRESO,
            this.EGRESO,
            this.SALDO,
            this.TIENDA,
            this.SUC_PAGO});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle12;
            this.DG_tabla.Location = new System.Drawing.Point(30, 122);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(867, 380);
            this.DG_tabla.TabIndex = 6;
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // BT_estado_cuenta
            // 
            this.BT_estado_cuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_estado_cuenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_estado_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_estado_cuenta.ForeColor = System.Drawing.Color.White;
            this.BT_estado_cuenta.Location = new System.Drawing.Point(697, 75);
            this.BT_estado_cuenta.Name = "BT_estado_cuenta";
            this.BT_estado_cuenta.Size = new System.Drawing.Size(97, 41);
            this.BT_estado_cuenta.TabIndex = 7;
            this.BT_estado_cuenta.Text = "Estado de Cuenta";
            this.BT_estado_cuenta.UseVisualStyleBackColor = false;
            this.BT_estado_cuenta.Click += new System.EventHandler(this.BT_estado_cuenta_Click);
            // 
            // BT_Exportar
            // 
            this.BT_Exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_Exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Exportar.ForeColor = System.Drawing.Color.White;
            this.BT_Exportar.Location = new System.Drawing.Point(800, 75);
            this.BT_Exportar.Name = "BT_Exportar";
            this.BT_Exportar.Size = new System.Drawing.Size(97, 41);
            this.BT_Exportar.TabIndex = 8;
            this.BT_Exportar.Text = "Exportar";
            this.BT_Exportar.UseVisualStyleBackColor = false;
            this.BT_Exportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_ajuste
            // 
            this.BT_ajuste.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_ajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ajuste.ForeColor = System.Drawing.Color.White;
            this.BT_ajuste.Location = new System.Drawing.Point(30, 75);
            this.BT_ajuste.Name = "BT_ajuste";
            this.BT_ajuste.Size = new System.Drawing.Size(97, 41);
            this.BT_ajuste.TabIndex = 9;
            this.BT_ajuste.Text = "Aplicar Ajuste";
            this.BT_ajuste.UseVisualStyleBackColor = false;
            this.BT_ajuste.Click += new System.EventHandler(this.BT_ajuste_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // MOV
            // 
            this.MOV.HeaderText = "MOVIMIENTO";
            this.MOV.Name = "MOV";
            // 
            // PAGARA
            // 
            this.PAGARA.HeaderText = "SE PAGÓ A:";
            this.PAGARA.Name = "PAGARA";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.HeaderText = "REFERENCIA";
            this.REFERENCIA.Name = "REFERENCIA";
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.HeaderText = "SE APLICÓ EN";
            this.SUCURSAL.Name = "SUCURSAL";
            // 
            // INGRESO
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.INGRESO.DefaultCellStyle = dataGridViewCellStyle9;
            this.INGRESO.HeaderText = "INGRESO";
            this.INGRESO.Name = "INGRESO";
            // 
            // EGRESO
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.EGRESO.DefaultCellStyle = dataGridViewCellStyle10;
            this.EGRESO.HeaderText = "EGRESO";
            this.EGRESO.Name = "EGRESO";
            // 
            // SALDO
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SALDO.DefaultCellStyle = dataGridViewCellStyle11;
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            // 
            // TIENDA
            // 
            this.TIENDA.HeaderText = "TIENDA";
            this.TIENDA.Name = "TIENDA";
            this.TIENDA.Visible = false;
            // 
            // SUC_PAGO
            // 
            this.SUC_PAGO.HeaderText = "SUC_PAGO";
            this.SUC_PAGO.Name = "SUC_PAGO";
            this.SUC_PAGO.Visible = false;
            // 
            // Rep_cuentas_osmart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(909, 514);
            this.Controls.Add(this.BT_ajuste);
            this.Controls.Add(this.BT_Exportar);
            this.Controls.Add(this.BT_estado_cuenta);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_cuentas);
            this.Controls.Add(this.CB_banco);
            this.Controls.Add(this.CB_sucursal);
            this.Name = "Rep_cuentas_osmart";
            this.Text = "Rep_cuentas_osmart";
            this.Load += new System.EventHandler(this.Rep_cuentas_osmart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.ComboBox CB_banco;
        private System.Windows.Forms.ComboBox CB_cuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_estado_cuenta;
        private System.Windows.Forms.Button BT_Exportar;
        private System.Windows.Forms.Button BT_ajuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUC_PAGO;
    }
}