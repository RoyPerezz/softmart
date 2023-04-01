namespace appSugerencias
{
    partial class RepGastosxDia
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
            this.DG_reporte = new System.Windows.Forms.DataGridView();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.BT_aceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CHK_respaldo = new System.Windows.Forms.CheckBox();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_GASTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMAUTORIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_reporte
            // 
            this.DG_reporte.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DG_reporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE,
            this.TIPO_GASTO,
            this.DESCRIPCION,
            this.IMPORTE,
            this.IE,
            this.FECHA,
            this.HORA,
            this.USER,
            this.ESTACION,
            this.NUMAUTORIZACION,
            this.CHECK});
            this.DG_reporte.Location = new System.Drawing.Point(3, 60);
            this.DG_reporte.Name = "DG_reporte";
            this.DG_reporte.Size = new System.Drawing.Size(896, 459);
            this.DG_reporte.TabIndex = 0;
            // 
            // DT_fecha
            // 
            this.DT_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_fecha.Location = new System.Drawing.Point(487, 21);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 1;
            // 
            // BT_aceptar
            // 
            this.BT_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_aceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_aceptar.ForeColor = System.Drawing.Color.White;
            this.BT_aceptar.Location = new System.Drawing.Point(692, 9);
            this.BT_aceptar.Name = "BT_aceptar";
            this.BT_aceptar.Size = new System.Drawing.Size(101, 44);
            this.BT_aceptar.TabIndex = 2;
            this.BT_aceptar.Text = "Aceptar";
            this.BT_aceptar.UseVisualStyleBackColor = false;
            this.BT_aceptar.Click += new System.EventHandler(this.BT_aceptar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(799, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHK_respaldo
            // 
            this.CHK_respaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CHK_respaldo.AutoSize = true;
            this.CHK_respaldo.Location = new System.Drawing.Point(389, 23);
            this.CHK_respaldo.Name = "CHK_respaldo";
            this.CHK_respaldo.Size = new System.Drawing.Size(95, 17);
            this.CHK_respaldo.TabIndex = 4;
            this.CHK_respaldo.Text = "Fecha Pasada";
            this.CHK_respaldo.UseVisualStyleBackColor = true;
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO",
            "PREGOT"});
            this.CB_sucursal.Location = new System.Drawing.Point(4, 32);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(142, 21);
            this.CB_sucursal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sucursal";
            // 
            // BT_guardar
            // 
            this.BT_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(799, 527);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(101, 44);
            this.BT_guardar.TabIndex = 7;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // CLAVE
            // 
            this.CLAVE.HeaderText = "CLAVE";
            this.CLAVE.Name = "CLAVE";
            // 
            // TIPO_GASTO
            // 
            this.TIPO_GASTO.HeaderText = "TIPO EGRESO";
            this.TIPO_GASTO.Name = "TIPO_GASTO";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle2;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // IE
            // 
            this.IE.HeaderText = "IE";
            this.IE.Name = "IE";
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
            // USER
            // 
            this.USER.HeaderText = "USUARIO";
            this.USER.Name = "USER";
            // 
            // ESTACION
            // 
            this.ESTACION.HeaderText = "ESTACION";
            this.ESTACION.Name = "ESTACION";
            // 
            // NUMAUTORIZACION
            // 
            this.NUMAUTORIZACION.HeaderText = "NUM. AUTORIZACIÓN";
            this.NUMAUTORIZACION.Name = "NUMAUTORIZACION";
            // 
            // CHECK
            // 
            this.CHECK.HeaderText = "CHECK";
            this.CHECK.Name = "CHECK";
            // 
            // RepGastosxDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(906, 583);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.CHK_respaldo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_aceptar);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.DG_reporte);
            this.Name = "RepGastosxDia";
            this.Text = "RepGastosxDia";
            this.Load += new System.EventHandler(this.RepGastosxDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_reporte;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Button BT_aceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CHK_respaldo;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_GASTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMAUTORIZACION;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK;
    }
}