namespace appSugerencias
{
    partial class AgregarMovKardex
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
            this.BT_insertar = new System.Windows.Forms.Button();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_operacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_movimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_entsal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_tipo_mov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_no_referen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_articulo = new System.Windows.Forms.TextBox();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_cantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_insertar
            // 
            this.BT_insertar.Location = new System.Drawing.Point(438, 241);
            this.BT_insertar.Name = "BT_insertar";
            this.BT_insertar.Size = new System.Drawing.Size(94, 55);
            this.BT_insertar.TabIndex = 0;
            this.BT_insertar.Text = "button1";
            this.BT_insertar.UseVisualStyleBackColor = true;
            this.BT_insertar.Click += new System.EventHandler(this.BT_insertar_Click);
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "CEDIS",
            "VALLARTA",
            "RENA",
            "COLOSO",
            "VELAZQUEZ"});
            this.CB_sucursal.Location = new System.Drawing.Point(108, 63);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(121, 21);
            this.CB_sucursal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SUCURSAL";
            // 
            // TB_operacion
            // 
            this.TB_operacion.Location = new System.Drawing.Point(108, 105);
            this.TB_operacion.Name = "TB_operacion";
            this.TB_operacion.Size = new System.Drawing.Size(100, 20);
            this.TB_operacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "OPERACION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MOVIMIENTO";
            // 
            // TB_movimiento
            // 
            this.TB_movimiento.Location = new System.Drawing.Point(108, 131);
            this.TB_movimiento.Name = "TB_movimiento";
            this.TB_movimiento.Size = new System.Drawing.Size(100, 20);
            this.TB_movimiento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ENT SAL";
            // 
            // TB_entsal
            // 
            this.TB_entsal.Location = new System.Drawing.Point(108, 157);
            this.TB_entsal.Name = "TB_entsal";
            this.TB_entsal.Size = new System.Drawing.Size(100, 20);
            this.TB_entsal.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TIPO MOV";
            // 
            // TB_tipo_mov
            // 
            this.TB_tipo_mov.Location = new System.Drawing.Point(108, 183);
            this.TB_tipo_mov.Name = "TB_tipo_mov";
            this.TB_tipo_mov.Size = new System.Drawing.Size(100, 20);
            this.TB_tipo_mov.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "REFERENCIA";
            // 
            // TB_no_referen
            // 
            this.TB_no_referen.Location = new System.Drawing.Point(118, 209);
            this.TB_no_referen.Name = "TB_no_referen";
            this.TB_no_referen.Size = new System.Drawing.Size(100, 20);
            this.TB_no_referen.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ARTICULO";
            // 
            // TB_articulo
            // 
            this.TB_articulo.Location = new System.Drawing.Point(118, 241);
            this.TB_articulo.Name = "TB_articulo";
            this.TB_articulo.Size = new System.Drawing.Size(100, 20);
            this.TB_articulo.TabIndex = 13;
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(40, 276);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "cantidad";
            // 
            // TB_cantidad
            // 
            this.TB_cantidad.Location = new System.Drawing.Point(118, 313);
            this.TB_cantidad.Name = "TB_cantidad";
            this.TB_cantidad.Size = new System.Drawing.Size(100, 20);
            this.TB_cantidad.TabIndex = 16;
            // 
            // AgregarMovKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_cantidad);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_articulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_no_referen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_tipo_mov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_entsal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_movimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_operacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.BT_insertar);
            this.Name = "AgregarMovKardex";
            this.Text = "AgregarMovKardex";
            this.Load += new System.EventHandler(this.AgregarMovKardex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_insertar;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_operacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_movimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_entsal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_tipo_mov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_no_referen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_articulo;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_cantidad;
    }
}