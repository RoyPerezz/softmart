namespace appSugerencias
{
    partial class InsertarRegistroMovSinv
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
            this.CB_tipo_mov = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_articulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_cantidad = new System.Windows.Forms.TextBox();
            this.BT_guardad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_movimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CB_tipo_mov
            // 
            this.CB_tipo_mov.FormattingEnabled = true;
            this.CB_tipo_mov.Items.AddRange(new object[] {
            "COM",
            "DV"});
            this.CB_tipo_mov.Location = new System.Drawing.Point(39, 93);
            this.CB_tipo_mov.Name = "CB_tipo_mov";
            this.CB_tipo_mov.Size = new System.Drawing.Size(161, 21);
            this.CB_tipo_mov.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIPO DE MOVIMIENTO";
            // 
            // TB_articulo
            // 
            this.TB_articulo.Location = new System.Drawing.Point(234, 94);
            this.TB_articulo.Name = "TB_articulo";
            this.TB_articulo.Size = new System.Drawing.Size(152, 20);
            this.TB_articulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ARTICULO";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(419, 94);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "FECHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CANTIDAD";
            // 
            // TB_cantidad
            // 
            this.TB_cantidad.Location = new System.Drawing.Point(39, 145);
            this.TB_cantidad.Name = "TB_cantidad";
            this.TB_cantidad.Size = new System.Drawing.Size(71, 20);
            this.TB_cantidad.TabIndex = 6;
            // 
            // BT_guardad
            // 
            this.BT_guardad.Location = new System.Drawing.Point(503, 145);
            this.BT_guardad.Name = "BT_guardad";
            this.BT_guardad.Size = new System.Drawing.Size(116, 54);
            this.BT_guardad.TabIndex = 8;
            this.BT_guardad.Text = "INSERTAR";
            this.BT_guardad.UseVisualStyleBackColor = true;
            this.BT_guardad.Click += new System.EventHandler(this.BT_guardad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "SUCURSAL";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "BODEGA",
            "VALLARTA",
            "RENA",
            "COLOSO",
            "VELAZQUEZ"});
            this.CB_sucursal.Location = new System.Drawing.Point(39, 35);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(161, 21);
            this.CB_sucursal.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "MOVIMIENTO";
            // 
            // TB_movimiento
            // 
            this.TB_movimiento.Location = new System.Drawing.Point(234, 35);
            this.TB_movimiento.Name = "TB_movimiento";
            this.TB_movimiento.Size = new System.Drawing.Size(152, 20);
            this.TB_movimiento.TabIndex = 11;
            // 
            // InsertarRegistroMovSinv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 278);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_movimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.BT_guardad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_articulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_tipo_mov);
            this.Name = "InsertarRegistroMovSinv";
            this.Text = "InsertarRegistroMovSinv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_tipo_mov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_articulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_cantidad;
        private System.Windows.Forms.Button BT_guardad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_movimiento;
    }
}