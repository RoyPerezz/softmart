namespace appSugerencias
{
    partial class CalificarJefeAlmacenCedis
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
            this.TB_reparto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_reparto = new System.Windows.Forms.ComboBox();
            this.TB_devoluciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_devoluciones = new System.Windows.Forms.ComboBox();
            this.TB_fuera_empaque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_fuera_empaque = new System.Windows.Forms.ComboBox();
            this.TB_empaques = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_empaques = new System.Windows.Forms.ComboBox();
            this.TB_pasillos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_pasillos = new System.Windows.Forms.ComboBox();
            this.TB_merc_pendiente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_merc_pendiente = new System.Windows.Forms.ComboBox();
            this.TB_baños = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_baños = new System.Windows.Forms.ComboBox();
            this.TB_clave_descrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_clave_descrip = new System.Windows.Forms.ComboBox();
            this.TB_limpieza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_limpieza = new System.Windows.Forms.ComboBox();
            this.BT_calificar = new System.Windows.Forms.Button();
            this.CB_JefeAlmacenCedis = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TB_reparto
            // 
            this.TB_reparto.Location = new System.Drawing.Point(399, 379);
            this.TB_reparto.Name = "TB_reparto";
            this.TB_reparto.Size = new System.Drawing.Size(52, 20);
            this.TB_reparto.TabIndex = 107;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 13);
            this.label9.TabIndex = 106;
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
            this.CB_reparto.Location = new System.Drawing.Point(7, 378);
            this.CB_reparto.Name = "CB_reparto";
            this.CB_reparto.Size = new System.Drawing.Size(121, 21);
            this.CB_reparto.TabIndex = 105;
            this.CB_reparto.SelectedIndexChanged += new System.EventHandler(this.CB_reparto_SelectedIndexChanged);
            // 
            // TB_devoluciones
            // 
            this.TB_devoluciones.Location = new System.Drawing.Point(399, 342);
            this.TB_devoluciones.Name = "TB_devoluciones";
            this.TB_devoluciones.Size = new System.Drawing.Size(52, 20);
            this.TB_devoluciones.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 13);
            this.label8.TabIndex = 103;
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
            this.CB_devoluciones.Location = new System.Drawing.Point(7, 342);
            this.CB_devoluciones.Name = "CB_devoluciones";
            this.CB_devoluciones.Size = new System.Drawing.Size(121, 21);
            this.CB_devoluciones.TabIndex = 102;
            this.CB_devoluciones.SelectedIndexChanged += new System.EventHandler(this.CB_devoluciones_SelectedIndexChanged);
            // 
            // TB_fuera_empaque
            // 
            this.TB_fuera_empaque.Location = new System.Drawing.Point(399, 306);
            this.TB_fuera_empaque.Name = "TB_fuera_empaque";
            this.TB_fuera_empaque.Size = new System.Drawing.Size(52, 20);
            this.TB_fuera_empaque.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 100;
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
            this.CB_fuera_empaque.Location = new System.Drawing.Point(7, 306);
            this.CB_fuera_empaque.Name = "CB_fuera_empaque";
            this.CB_fuera_empaque.Size = new System.Drawing.Size(121, 21);
            this.CB_fuera_empaque.TabIndex = 99;
            this.CB_fuera_empaque.SelectedIndexChanged += new System.EventHandler(this.CB_fuera_empaque_SelectedIndexChanged);
            // 
            // TB_empaques
            // 
            this.TB_empaques.Location = new System.Drawing.Point(399, 268);
            this.TB_empaques.Name = "TB_empaques";
            this.TB_empaques.Size = new System.Drawing.Size(52, 20);
            this.TB_empaques.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 97;
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
            this.CB_empaques.Location = new System.Drawing.Point(7, 268);
            this.CB_empaques.Name = "CB_empaques";
            this.CB_empaques.Size = new System.Drawing.Size(121, 21);
            this.CB_empaques.TabIndex = 96;
            this.CB_empaques.SelectedIndexChanged += new System.EventHandler(this.CB_empaques_SelectedIndexChanged);
            // 
            // TB_pasillos
            // 
            this.TB_pasillos.Location = new System.Drawing.Point(399, 230);
            this.TB_pasillos.Name = "TB_pasillos";
            this.TB_pasillos.Size = new System.Drawing.Size(52, 20);
            this.TB_pasillos.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 13);
            this.label5.TabIndex = 94;
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
            this.CB_pasillos.Location = new System.Drawing.Point(7, 229);
            this.CB_pasillos.Name = "CB_pasillos";
            this.CB_pasillos.Size = new System.Drawing.Size(121, 21);
            this.CB_pasillos.TabIndex = 93;
            this.CB_pasillos.SelectedIndexChanged += new System.EventHandler(this.CB_pasillos_SelectedIndexChanged);
            // 
            // TB_merc_pendiente
            // 
            this.TB_merc_pendiente.Location = new System.Drawing.Point(399, 194);
            this.TB_merc_pendiente.Name = "TB_merc_pendiente";
            this.TB_merc_pendiente.Size = new System.Drawing.Size(52, 20);
            this.TB_merc_pendiente.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 91;
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
            this.CB_merc_pendiente.Location = new System.Drawing.Point(7, 194);
            this.CB_merc_pendiente.Name = "CB_merc_pendiente";
            this.CB_merc_pendiente.Size = new System.Drawing.Size(121, 21);
            this.CB_merc_pendiente.TabIndex = 90;
            this.CB_merc_pendiente.SelectedIndexChanged += new System.EventHandler(this.CB_merc_pendiente_SelectedIndexChanged);
            // 
            // TB_baños
            // 
            this.TB_baños.Location = new System.Drawing.Point(399, 155);
            this.TB_baños.Name = "TB_baños";
            this.TB_baños.Size = new System.Drawing.Size(52, 20);
            this.TB_baños.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 88;
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
            this.CB_baños.Location = new System.Drawing.Point(7, 155);
            this.CB_baños.Name = "CB_baños";
            this.CB_baños.Size = new System.Drawing.Size(121, 21);
            this.CB_baños.TabIndex = 87;
            this.CB_baños.SelectedIndexChanged += new System.EventHandler(this.CB_baños_SelectedIndexChanged);
            // 
            // TB_clave_descrip
            // 
            this.TB_clave_descrip.Location = new System.Drawing.Point(399, 120);
            this.TB_clave_descrip.Name = "TB_clave_descrip";
            this.TB_clave_descrip.Size = new System.Drawing.Size(52, 20);
            this.TB_clave_descrip.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 85;
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
            this.CB_clave_descrip.Location = new System.Drawing.Point(7, 119);
            this.CB_clave_descrip.Name = "CB_clave_descrip";
            this.CB_clave_descrip.Size = new System.Drawing.Size(121, 21);
            this.CB_clave_descrip.TabIndex = 84;
            this.CB_clave_descrip.SelectedIndexChanged += new System.EventHandler(this.CB_clave_descrip_SelectedIndexChanged);
            // 
            // TB_limpieza
            // 
            this.TB_limpieza.Location = new System.Drawing.Point(399, 87);
            this.TB_limpieza.Name = "TB_limpieza";
            this.TB_limpieza.Size = new System.Drawing.Size(52, 20);
            this.TB_limpieza.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "LIMPIEZA INTERIOR Y EXTERIOR";
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
            this.CB_limpieza.Location = new System.Drawing.Point(7, 85);
            this.CB_limpieza.Name = "CB_limpieza";
            this.CB_limpieza.Size = new System.Drawing.Size(121, 21);
            this.CB_limpieza.TabIndex = 81;
            this.CB_limpieza.SelectedIndexChanged += new System.EventHandler(this.CB_limpieza_SelectedIndexChanged);
            // 
            // BT_calificar
            // 
            this.BT_calificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_calificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_calificar.ForeColor = System.Drawing.Color.White;
            this.BT_calificar.Location = new System.Drawing.Point(685, 342);
            this.BT_calificar.Name = "BT_calificar";
            this.BT_calificar.Size = new System.Drawing.Size(115, 64);
            this.BT_calificar.TabIndex = 78;
            this.BT_calificar.Text = "CALIFICAR";
            this.BT_calificar.UseVisualStyleBackColor = false;
            this.BT_calificar.Click += new System.EventHandler(this.BT_calificar_Click);
            // 
            // CB_JefeAlmacenCedis
            // 
            this.CB_JefeAlmacenCedis.FormattingEnabled = true;
            this.CB_JefeAlmacenCedis.Location = new System.Drawing.Point(7, 29);
            this.CB_JefeAlmacenCedis.Name = "CB_JefeAlmacenCedis";
            this.CB_JefeAlmacenCedis.Size = new System.Drawing.Size(283, 21);
            this.CB_JefeAlmacenCedis.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(573, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 76;
            this.label12.Text = "FIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(559, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "INICIO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "ALMACEN CEDIS";
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(600, 63);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 73;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(600, 25);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 72;
            // 
            // CalificarJefeAlmacenCedis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(808, 418);
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
            this.Controls.Add(this.BT_calificar);
            this.Controls.Add(this.CB_JefeAlmacenCedis);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Name = "CalificarJefeAlmacenCedis";
            this.Text = "CalificarJefeAlmacenCedis";
            this.Load += new System.EventHandler(this.CalificarJefeAlmacenCedis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_reparto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_reparto;
        private System.Windows.Forms.TextBox TB_devoluciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_devoluciones;
        private System.Windows.Forms.TextBox TB_fuera_empaque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_fuera_empaque;
        private System.Windows.Forms.TextBox TB_empaques;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_empaques;
        private System.Windows.Forms.TextBox TB_pasillos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_pasillos;
        private System.Windows.Forms.TextBox TB_merc_pendiente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_merc_pendiente;
        private System.Windows.Forms.TextBox TB_baños;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_baños;
        private System.Windows.Forms.TextBox TB_clave_descrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_clave_descrip;
        private System.Windows.Forms.TextBox TB_limpieza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_limpieza;
        private System.Windows.Forms.Button BT_calificar;
        private System.Windows.Forms.ComboBox CB_JefeAlmacenCedis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DateTimePicker DT_inicio;
    }
}