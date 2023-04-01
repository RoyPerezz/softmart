namespace appSugerencias
{
    partial class VentasTarjeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.CB_banco = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_cuenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_saldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DG_tarjetas = new System.Windows.Forms.DataGridView();
            this.OPERACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_aceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CHK_mespasado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_status = new System.Windows.Forms.Label();
            this.LB_mensaje = new System.Windows.Forms.Label();
            this.DT_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.BT_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "  ",
            "VALLARTA",
            "RENA",
            "COLOSO",
            "VELAZQUEZ",
            "PREGOT"});
            this.CB_sucursal.Location = new System.Drawing.Point(8, 34);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(121, 24);
            this.CB_sucursal.TabIndex = 1;
            this.CB_sucursal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CB_banco
            // 
            this.CB_banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_banco.FormattingEnabled = true;
            this.CB_banco.Location = new System.Drawing.Point(166, 34);
            this.CB_banco.Name = "CB_banco";
            this.CB_banco.Size = new System.Drawing.Size(141, 24);
            this.CB_banco.TabIndex = 3;
            this.CB_banco.SelectedIndexChanged += new System.EventHandler(this.CB_banco_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banco";
            // 
            // CB_cuenta
            // 
            this.CB_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_cuenta.FormattingEnabled = true;
            this.CB_cuenta.Location = new System.Drawing.Point(343, 34);
            this.CB_cuenta.Name = "CB_cuenta";
            this.CB_cuenta.Size = new System.Drawing.Size(156, 24);
            this.CB_cuenta.TabIndex = 5;
            this.CB_cuenta.SelectedIndexChanged += new System.EventHandler(this.CB_cuenta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cuenta";
            // 
            // TB_saldo
            // 
            this.TB_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_saldo.Location = new System.Drawing.Point(538, 36);
            this.TB_saldo.Name = "TB_saldo";
            this.TB_saldo.Size = new System.Drawing.Size(113, 22);
            this.TB_saldo.TabIndex = 6;
            this.TB_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fecha.Location = new System.Drawing.Point(8, 89);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(246, 22);
            this.DT_fecha.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha";
            // 
            // DG_tarjetas
            // 
            this.DG_tarjetas.AllowUserToAddRows = false;
            this.DG_tarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OPERACION,
            this.IMPORTE,
            this.ESTACION,
            this.USUARIO,
            this.FECHA,
            this.HORA});
            this.DG_tarjetas.Location = new System.Drawing.Point(3, 187);
            this.DG_tarjetas.Name = "DG_tarjetas";
            this.DG_tarjetas.Size = new System.Drawing.Size(643, 327);
            this.DG_tarjetas.TabIndex = 10;
            // 
            // OPERACION
            // 
            this.OPERACION.HeaderText = "NUM. OPERACION";
            this.OPERACION.Name = "OPERACION";
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle1;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // ESTACION
            // 
            this.ESTACION.HeaderText = "ESTACION";
            this.ESTACION.Name = "ESTACION";
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
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
            // BT_aceptar
            // 
            this.BT_aceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_aceptar.ForeColor = System.Drawing.Color.White;
            this.BT_aceptar.Location = new System.Drawing.Point(529, 532);
            this.BT_aceptar.Name = "BT_aceptar";
            this.BT_aceptar.Size = new System.Drawing.Size(117, 44);
            this.BT_aceptar.TabIndex = 11;
            this.BT_aceptar.Text = "Aceptar";
            this.BT_aceptar.UseVisualStyleBackColor = false;
            this.BT_aceptar.Click += new System.EventHandler(this.BT_aceptar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(534, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Traer Datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHK_mespasado
            // 
            this.CHK_mespasado.AutoSize = true;
            this.CHK_mespasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_mespasado.Location = new System.Drawing.Point(262, 91);
            this.CHK_mespasado.Name = "CHK_mespasado";
            this.CHK_mespasado.Size = new System.Drawing.Size(103, 20);
            this.CHK_mespasado.TabIndex = 13;
            this.CHK_mespasado.Text = "Mes pasado";
            this.CHK_mespasado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status de la Conexión:";
            // 
            // LB_status
            // 
            this.LB_status.AutoSize = true;
            this.LB_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_status.Location = new System.Drawing.Point(145, 546);
            this.LB_status.Name = "LB_status";
            this.LB_status.Size = new System.Drawing.Size(8, 16);
            this.LB_status.TabIndex = 15;
            this.LB_status.Text = "\r\n";
            // 
            // LB_mensaje
            // 
            this.LB_mensaje.AutoSize = true;
            this.LB_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_mensaje.Location = new System.Drawing.Point(9, 159);
            this.LB_mensaje.Name = "LB_mensaje";
            this.LB_mensaje.Size = new System.Drawing.Size(0, 16);
            this.LB_mensaje.TabIndex = 16;
            // 
            // DT_fecha2
            // 
            this.DT_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fecha2.Location = new System.Drawing.Point(8, 121);
            this.DT_fecha2.Name = "DT_fecha2";
            this.DT_fecha2.Size = new System.Drawing.Size(246, 22);
            this.DT_fecha2.TabIndex = 17;
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(534, 121);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(117, 44);
            this.BT_exportar.TabIndex = 18;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // VentasTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(658, 590);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.DT_fecha2);
            this.Controls.Add(this.LB_mensaje);
            this.Controls.Add(this.LB_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CHK_mespasado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_aceptar);
            this.Controls.Add(this.DG_tarjetas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_saldo);
            this.Controls.Add(this.CB_cuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_banco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.label1);
            this.Name = "VentasTarjeta";
            this.Text = "VentasTarjeta";
            this.Load += new System.EventHandler(this.VentasTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.ComboBox CB_banco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_saldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DG_tarjetas;
        private System.Windows.Forms.Button BT_aceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.CheckBox CHK_mespasado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_status;
        private System.Windows.Forms.Label LB_mensaje;
        private System.Windows.Forms.DateTimePicker DT_fecha2;
        private System.Windows.Forms.Button BT_exportar;
    }
}