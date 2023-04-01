namespace appSugerencias
{
    partial class CalificarCubreAlmacen
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
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BT_calificar = new System.Windows.Forms.Button();
            this.CB_cubreJefeAlmacen = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.CB_limpieza = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_limpieza = new System.Windows.Forms.TextBox();
            this.TB_clave_descrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_clave_descrip = new System.Windows.Forms.ComboBox();
            this.TB_baños = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_baños = new System.Windows.Forms.ComboBox();
            this.TB_merc_pendiente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_merc_pendiente = new System.Windows.Forms.ComboBox();
            this.TB_pasillos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_pasillos = new System.Windows.Forms.ComboBox();
            this.TB_empaques = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_empaques = new System.Windows.Forms.ComboBox();
            this.TB_fuera_empaque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_fuera_empaque = new System.Windows.Forms.ComboBox();
            this.TB_devoluciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_devoluciones = new System.Windows.Forms.ComboBox();
            this.TB_reparto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_reparto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(202, 44);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(137, 21);
            this.CB_sucursal.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(152, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "TIENDA";
            // 
            // BT_calificar
            // 
            this.BT_calificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_calificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_calificar.ForeColor = System.Drawing.Color.White;
            this.BT_calificar.Location = new System.Drawing.Point(705, 351);
            this.BT_calificar.Name = "BT_calificar";
            this.BT_calificar.Size = new System.Drawing.Size(100, 59);
            this.BT_calificar.TabIndex = 42;
            this.BT_calificar.Text = "CALIFICAR";
            this.BT_calificar.UseVisualStyleBackColor = false;
            this.BT_calificar.Click += new System.EventHandler(this.BT_calificar_Click);
            // 
            // CB_cubreJefeAlmacen
            // 
            this.CB_cubreJefeAlmacen.FormattingEnabled = true;
            this.CB_cubreJefeAlmacen.Location = new System.Drawing.Point(56, 11);
            this.CB_cubreJefeAlmacen.Name = "CB_cubreJefeAlmacen";
            this.CB_cubreJefeAlmacen.Size = new System.Drawing.Size(283, 21);
            this.CB_cubreJefeAlmacen.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(578, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "FIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(564, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "INICIO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "CUBRE";
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(605, 47);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 37;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(605, 9);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 36;
            // 
            // CB_limpieza
            // 
            this.CB_limpieza.FormattingEnabled = true;
            this.CB_limpieza.Items.AddRange(new object[] {
            "DEFICIENTE",
            "INFERIOR",
            "MEDIO INFERIOR",
            "MEDIO SUPERIOR",
            "SUPERIOR",
            "MUY SUPERIOR"});
            this.CB_limpieza.Location = new System.Drawing.Point(12, 96);
            this.CB_limpieza.Name = "CB_limpieza";
            this.CB_limpieza.Size = new System.Drawing.Size(121, 21);
            this.CB_limpieza.TabIndex = 45;
            this.CB_limpieza.SelectedIndexChanged += new System.EventHandler(this.CB_limpieza_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "LIMPIEZA INTERIOR Y EXTERIOR";
            // 
            // TB_limpieza
            // 
            this.TB_limpieza.Location = new System.Drawing.Point(320, 98);
            this.TB_limpieza.Name = "TB_limpieza";
            this.TB_limpieza.Size = new System.Drawing.Size(52, 20);
            this.TB_limpieza.TabIndex = 47;
            // 
            // TB_clave_descrip
            // 
            this.TB_clave_descrip.Location = new System.Drawing.Point(353, 131);
            this.TB_clave_descrip.Name = "TB_clave_descrip";
            this.TB_clave_descrip.Size = new System.Drawing.Size(52, 20);
            this.TB_clave_descrip.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "CLAVE Y DESCRIPCION EN PRODUCTOS";
            // 
            // CB_clave_descrip
            // 
            this.CB_clave_descrip.FormattingEnabled = true;
            this.CB_clave_descrip.Items.AddRange(new object[] {
            "DEFICIENTE",
            "INFERIOR",
            "MEDIO INFERIOR",
            "MEDIO SUPERIOR",
            "SUPERIOR",
            "MUY SUPERIOR"});
            this.CB_clave_descrip.Location = new System.Drawing.Point(12, 130);
            this.CB_clave_descrip.Name = "CB_clave_descrip";
            this.CB_clave_descrip.Size = new System.Drawing.Size(121, 21);
            this.CB_clave_descrip.TabIndex = 48;
            this.CB_clave_descrip.SelectedIndexChanged += new System.EventHandler(this.CB_clave_descrip_SelectedIndexChanged);
            // 
            // TB_baños
            // 
            this.TB_baños.Location = new System.Drawing.Point(231, 166);
            this.TB_baños.Name = "TB_baños";
            this.TB_baños.Size = new System.Drawing.Size(52, 20);
            this.TB_baños.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "BAÑOS LIMPIOS";
            // 
            // CB_baños
            // 
            this.CB_baños.FormattingEnabled = true;
            this.CB_baños.Items.AddRange(new object[] {
            "DEFICIENTE",
            "INFERIOR",
            "MEDIO INFERIOR",
            "MEDIO SUPERIOR",
            "SUPERIOR",
            "MUY SUPERIOR"});
            this.CB_baños.Location = new System.Drawing.Point(12, 166);
            this.CB_baños.Name = "CB_baños";
            this.CB_baños.Size = new System.Drawing.Size(121, 21);
            this.CB_baños.TabIndex = 51;
            this.CB_baños.SelectedIndexChanged += new System.EventHandler(this.CB_baños_SelectedIndexChanged);
            // 
            // TB_merc_pendiente
            // 
            this.TB_merc_pendiente.Location = new System.Drawing.Point(380, 205);
            this.TB_merc_pendiente.Name = "TB_merc_pendiente";
            this.TB_merc_pendiente.Size = new System.Drawing.Size(52, 20);
            this.TB_merc_pendiente.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "MENOS MERCANCIA PENDIENTE DE ENVIAR";
            // 
            // CB_merc_pendiente
            // 
            this.CB_merc_pendiente.FormattingEnabled = true;
            this.CB_merc_pendiente.Items.AddRange(new object[] {
            "DEFICIENTE",
            "INFERIOR",
            "MEDIO INFERIOR",
            "MEDIO SUPERIOR",
            "SUPERIOR",
            "MUY SUPERIOR"});
            this.CB_merc_pendiente.Location = new System.Drawing.Point(12, 205);
            this.CB_merc_pendiente.Name = "CB_merc_pendiente";
            this.CB_merc_pendiente.Size = new System.Drawing.Size(121, 21);
            this.CB_merc_pendiente.TabIndex = 54;
            this.CB_merc_pendiente.SelectedIndexChanged += new System.EventHandler(this.CB_merc_pendiente_SelectedIndexChanged);
            // 
            // TB_pasillos
            // 
            this.TB_pasillos.Location = new System.Drawing.Point(403, 241);
            this.TB_pasillos.Name = "TB_pasillos";
            this.TB_pasillos.Size = new System.Drawing.Size(52, 20);
            this.TB_pasillos.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "PASILLOS DESPEJADOS NO MERCANCIA EN PISO";
            // 
            // CB_pasillos
            // 
            this.CB_pasillos.FormattingEnabled = true;
            this.CB_pasillos.Items.AddRange(new object[] {
            "DEFICIENTE",
            "INFERIOR",
            "MEDIO INFERIOR",
            "MEDIO SUPERIOR",
            "SUPERIOR",
            "MUY SUPERIOR"});
            this.CB_pasillos.Location = new System.Drawing.Point(12, 240);
            this.CB_pasillos.Name = "CB_pasillos";
            this.CB_pasillos.Size = new System.Drawing.Size(121, 21);
            this.CB_pasillos.TabIndex = 57;
            this.CB_pasillos.SelectedIndexChanged += new System.EventHandler(this.CB_pasillos_SelectedIndexChanged);
            // 
            // TB_empaques
            // 
            this.TB_empaques.Location = new System.Drawing.Point(287, 279);
            this.TB_empaques.Name = "TB_empaques";
            this.TB_empaques.Size = new System.Drawing.Size(52, 20);
            this.TB_empaques.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "EMPAQUES BIEN SELLADOS";
            // 
            // CB_empaques
            // 
            this.CB_empaques.FormattingEnabled = true;
            this.CB_empaques.Items.AddRange(new object[] {
            "DEFICIENTE",
            "INFERIOR",
            "MEDIO INFERIOR",
            "MEDIO SUPERIOR",
            "SUPERIOR",
            "MUY SUPERIOR"});
            this.CB_empaques.Location = new System.Drawing.Point(12, 279);
            this.CB_empaques.Name = "CB_empaques";
            this.CB_empaques.Size = new System.Drawing.Size(121, 21);
            this.CB_empaques.TabIndex = 60;
            this.CB_empaques.SelectedIndexChanged += new System.EventHandler(this.CB_empaques_SelectedIndexChanged);
            // 
            // TB_fuera_empaque
            // 
            this.TB_fuera_empaque.Location = new System.Drawing.Point(353, 317);
            this.TB_fuera_empaque.Name = "TB_fuera_empaque";
            this.TB_fuera_empaque.Size = new System.Drawing.Size(52, 20);
            this.TB_fuera_empaque.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "NO MERCANCIA FUERA DE SU EMPAQUE";
            // 
            // CB_fuera_empaque
            // 
            this.CB_fuera_empaque.FormattingEnabled = true;
            this.CB_fuera_empaque.Items.AddRange(new object[] {
            "DEFICIENTE",
            "INFERIOR",
            "MEDIO INFERIOR",
            "MEDIO SUPERIOR",
            "SUPERIOR",
            "MUY SUPERIOR"});
            this.CB_fuera_empaque.Location = new System.Drawing.Point(12, 317);
            this.CB_fuera_empaque.Name = "CB_fuera_empaque";
            this.CB_fuera_empaque.Size = new System.Drawing.Size(121, 21);
            this.CB_fuera_empaque.TabIndex = 63;
            this.CB_fuera_empaque.SelectedIndexChanged += new System.EventHandler(this.CB_fuera_empaque_SelectedIndexChanged);
            // 
            // TB_devoluciones
            // 
            this.TB_devoluciones.Location = new System.Drawing.Point(394, 353);
            this.TB_devoluciones.Name = "TB_devoluciones";
            this.TB_devoluciones.Size = new System.Drawing.Size(52, 20);
            this.TB_devoluciones.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "NO REZAGO DE DEVOLUCIONES A PROVEEDOR";
            // 
            // CB_devoluciones
            // 
            this.CB_devoluciones.FormattingEnabled = true;
            this.CB_devoluciones.Items.AddRange(new object[] {
            "DEFICIENTE",
            "INFERIOR",
            "MEDIO INFERIOR",
            "MEDIO SUPERIOR",
            "SUPERIOR",
            "MUY SUPERIOR"});
            this.CB_devoluciones.Location = new System.Drawing.Point(12, 353);
            this.CB_devoluciones.Name = "CB_devoluciones";
            this.CB_devoluciones.Size = new System.Drawing.Size(121, 21);
            this.CB_devoluciones.TabIndex = 66;
            this.CB_devoluciones.SelectedIndexChanged += new System.EventHandler(this.CB_devoluciones_SelectedIndexChanged);
            // 
            // TB_reparto
            // 
            this.TB_reparto.Location = new System.Drawing.Point(330, 390);
            this.TB_reparto.Name = "TB_reparto";
            this.TB_reparto.Size = new System.Drawing.Size(52, 20);
            this.TB_reparto.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "REPARTO DE 3 A 5 DIAS DE ATRASO";
            // 
            // CB_reparto
            // 
            this.CB_reparto.FormattingEnabled = true;
            this.CB_reparto.Items.AddRange(new object[] {
            "DEFICIENTE",
            "INFERIOR",
            "MEDIO INFERIOR",
            "MEDIO SUPERIOR",
            "SUPERIOR",
            "MUY SUPERIOR"});
            this.CB_reparto.Location = new System.Drawing.Point(12, 389);
            this.CB_reparto.Name = "CB_reparto";
            this.CB_reparto.Size = new System.Drawing.Size(121, 21);
            this.CB_reparto.TabIndex = 69;
            this.CB_reparto.SelectedIndexChanged += new System.EventHandler(this.CB_reparto_SelectedIndexChanged);
            // 
            // CalificarCubreAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(817, 423);
            this.Controls.Add(this.TB_reparto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CB_reparto);
            this.Controls.Add(this.TB_devoluciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CB_devoluciones);
            this.Controls.Add(this.TB_fuera_empaque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_fuera_empaque);
            this.Controls.Add(this.TB_empaques);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_empaques);
            this.Controls.Add(this.TB_pasillos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_pasillos);
            this.Controls.Add(this.TB_merc_pendiente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_merc_pendiente);
            this.Controls.Add(this.TB_baños);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_baños);
            this.Controls.Add(this.TB_clave_descrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_clave_descrip);
            this.Controls.Add(this.TB_limpieza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_limpieza);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BT_calificar);
            this.Controls.Add(this.CB_cubreJefeAlmacen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Name = "CalificarCubreAlmacen";
            this.Text = "CalificarCubreAlmacen";
            this.Load += new System.EventHandler(this.CalificarCubreAlmacen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BT_calificar;
        private System.Windows.Forms.ComboBox CB_cubreJefeAlmacen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.ComboBox CB_limpieza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_limpieza;
        private System.Windows.Forms.TextBox TB_clave_descrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_clave_descrip;
        private System.Windows.Forms.TextBox TB_baños;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_baños;
        private System.Windows.Forms.TextBox TB_merc_pendiente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_merc_pendiente;
        private System.Windows.Forms.TextBox TB_pasillos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_pasillos;
        private System.Windows.Forms.TextBox TB_empaques;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_empaques;
        private System.Windows.Forms.TextBox TB_fuera_empaque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_fuera_empaque;
        private System.Windows.Forms.TextBox TB_devoluciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_devoluciones;
        private System.Windows.Forms.TextBox TB_reparto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_reparto;
    }
}