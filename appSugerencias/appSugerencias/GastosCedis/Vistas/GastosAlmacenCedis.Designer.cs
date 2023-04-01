
namespace appSugerencias.Gastos.Vistas
{
    partial class GastosAlmacenCedis
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
            this.components = new System.ComponentModel.Container();
            this.CB_concepto_gral = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.TB_folioSalida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.BT_iniciar_camara = new System.Windows.Forms.Button();
            this.BT_cargar2 = new System.Windows.Forms.Button();
            this.TB_cargar = new System.Windows.Forms.Button();
            this.TB_descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_camaras = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_contador = new System.Windows.Forms.Label();
            this.TB_comentario_rev = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.BT_foto2 = new System.Windows.Forms.Button();
            this.BT_foto = new System.Windows.Forms.Button();
            this.PB_imagen2 = new System.Windows.Forms.PictureBox();
            this.PB_imagen1 = new System.Windows.Forms.PictureBox();
            this.CB_conceptoDetalle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_concepto_gral
            // 
            this.CB_concepto_gral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_concepto_gral.FormattingEnabled = true;
            this.CB_concepto_gral.Location = new System.Drawing.Point(21, 93);
            this.CB_concepto_gral.Name = "CB_concepto_gral";
            this.CB_concepto_gral.Size = new System.Drawing.Size(308, 28);
            this.CB_concepto_gral.TabIndex = 76;
            this.CB_concepto_gral.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_gral_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "CONCEPTO DETALLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "CONCEPTO GRAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_importe
            // 
            this.TB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importe.Location = new System.Drawing.Point(21, 218);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(172, 26);
            this.TB_importe.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "IMPORTE";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fecha.Location = new System.Drawing.Point(21, 347);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(308, 26);
            this.DT_fecha.TabIndex = 82;
            // 
            // TB_folioSalida
            // 
            this.TB_folioSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_folioSalida.Location = new System.Drawing.Point(21, 282);
            this.TB_folioSalida.Name = "TB_folioSalida";
            this.TB_folioSalida.Size = new System.Drawing.Size(172, 26);
            this.TB_folioSalida.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 83;
            this.label4.Text = "FOLIO SALIDA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "FECHA";
            // 
            // BT_guardar
            // 
            this.BT_guardar.Location = new System.Drawing.Point(1089, 565);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(103, 42);
            this.BT_guardar.TabIndex = 86;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = true;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // BT_iniciar_camara
            // 
            this.BT_iniciar_camara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BT_iniciar_camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_iniciar_camara.ForeColor = System.Drawing.Color.Black;
            this.BT_iniciar_camara.Location = new System.Drawing.Point(212, 33);
            this.BT_iniciar_camara.Name = "BT_iniciar_camara";
            this.BT_iniciar_camara.Size = new System.Drawing.Size(117, 39);
            this.BT_iniciar_camara.TabIndex = 89;
            this.BT_iniciar_camara.Text = "Iniciar Cámara";
            this.BT_iniciar_camara.UseVisualStyleBackColor = false;
            this.BT_iniciar_camara.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_cargar2
            // 
            this.BT_cargar2.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_cargar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cargar2.ForeColor = System.Drawing.Color.White;
            this.BT_cargar2.Location = new System.Drawing.Point(649, 458);
            this.BT_cargar2.Name = "BT_cargar2";
            this.BT_cargar2.Size = new System.Drawing.Size(546, 39);
            this.BT_cargar2.TabIndex = 91;
            this.BT_cargar2.Text = "Cargar imagen";
            this.BT_cargar2.UseVisualStyleBackColor = false;
            this.BT_cargar2.Click += new System.EventHandler(this.BT_cargar2_Click);
            // 
            // TB_cargar
            // 
            this.TB_cargar.BackColor = System.Drawing.Color.DodgerBlue;
            this.TB_cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_cargar.ForeColor = System.Drawing.Color.White;
            this.TB_cargar.Location = new System.Drawing.Point(335, 546);
            this.TB_cargar.Name = "TB_cargar";
            this.TB_cargar.Size = new System.Drawing.Size(302, 40);
            this.TB_cargar.TabIndex = 90;
            this.TB_cargar.Text = "Cargar imagen";
            this.TB_cargar.UseVisualStyleBackColor = false;
            this.TB_cargar.Click += new System.EventHandler(this.TB_cargar_Click);
            // 
            // TB_descripcion
            // 
            this.TB_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_descripcion.Location = new System.Drawing.Point(21, 413);
            this.TB_descripcion.Multiline = true;
            this.TB_descripcion.Name = "TB_descripcion";
            this.TB_descripcion.Size = new System.Drawing.Size(308, 72);
            this.TB_descripcion.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "DESCRIPCION DETALLADA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Lista de cámaras";
            // 
            // CB_camaras
            // 
            this.CB_camaras.FormattingEnabled = true;
            this.CB_camaras.Location = new System.Drawing.Point(99, 6);
            this.CB_camaras.Name = "CB_camaras";
            this.CB_camaras.Size = new System.Drawing.Size(230, 21);
            this.CB_camaras.TabIndex = 97;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LB_contador
            // 
            this.LB_contador.AutoSize = true;
            this.LB_contador.Location = new System.Drawing.Point(140, 46);
            this.LB_contador.Name = "LB_contador";
            this.LB_contador.Size = new System.Drawing.Size(13, 13);
            this.LB_contador.TabIndex = 99;
            this.LB_contador.Text = "0";
            // 
            // TB_comentario_rev
            // 
            this.TB_comentario_rev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_comentario_rev.Location = new System.Drawing.Point(21, 548);
            this.TB_comentario_rev.Multiline = true;
            this.TB_comentario_rev.Name = "TB_comentario_rev";
            this.TB_comentario_rev.ReadOnly = true;
            this.TB_comentario_rev.Size = new System.Drawing.Size(308, 73);
            this.TB_comentario_rev.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 101;
            this.label8.Text = "COMENTARIO REVISION";
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox0.Location = new System.Drawing.Point(1201, 9);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(10, 339);
            this.pictureBox0.TabIndex = 94;
            this.pictureBox0.TabStop = false;
            this.pictureBox0.Visible = false;
            // 
            // BT_foto2
            // 
            this.BT_foto2.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_foto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_foto2.ForeColor = System.Drawing.Color.White;
            this.BT_foto2.Image = global::appSugerencias.Properties.Resources.camara__2_;
            this.BT_foto2.Location = new System.Drawing.Point(649, 492);
            this.BT_foto2.Name = "BT_foto2";
            this.BT_foto2.Size = new System.Drawing.Size(546, 39);
            this.BT_foto2.TabIndex = 93;
            this.BT_foto2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_foto2.UseVisualStyleBackColor = false;
            this.BT_foto2.Click += new System.EventHandler(this.BT_foto2_Click);
            // 
            // BT_foto
            // 
            this.BT_foto.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_foto.ForeColor = System.Drawing.Color.White;
            this.BT_foto.Image = global::appSugerencias.Properties.Resources.camara__2_;
            this.BT_foto.Location = new System.Drawing.Point(335, 581);
            this.BT_foto.Name = "BT_foto";
            this.BT_foto.Size = new System.Drawing.Size(302, 40);
            this.BT_foto.TabIndex = 92;
            this.BT_foto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_foto.UseVisualStyleBackColor = false;
            this.BT_foto.Click += new System.EventHandler(this.BT_foto_Click);
            // 
            // PB_imagen2
            // 
            this.PB_imagen2.BackColor = System.Drawing.SystemColors.Control;
            this.PB_imagen2.Location = new System.Drawing.Point(646, 5);
            this.PB_imagen2.Name = "PB_imagen2";
            this.PB_imagen2.Size = new System.Drawing.Size(549, 419);
            this.PB_imagen2.TabIndex = 88;
            this.PB_imagen2.TabStop = false;
            // 
            // PB_imagen1
            // 
            this.PB_imagen1.BackColor = System.Drawing.SystemColors.Control;
            this.PB_imagen1.Location = new System.Drawing.Point(335, 5);
            this.PB_imagen1.Name = "PB_imagen1";
            this.PB_imagen1.Size = new System.Drawing.Size(302, 526);
            this.PB_imagen1.TabIndex = 87;
            this.PB_imagen1.TabStop = false;
            this.PB_imagen1.Click += new System.EventHandler(this.PB_imagen1_Click);
            // 
            // CB_conceptoDetalle
            // 
            this.CB_conceptoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_conceptoDetalle.FormattingEnabled = true;
            this.CB_conceptoDetalle.Location = new System.Drawing.Point(21, 156);
            this.CB_conceptoDetalle.Name = "CB_conceptoDetalle";
            this.CB_conceptoDetalle.Size = new System.Drawing.Size(308, 28);
            this.CB_conceptoDetalle.TabIndex = 102;
            // 
            // GastosAlmacenCedis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1211, 630);
            this.Controls.Add(this.CB_conceptoDetalle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_comentario_rev);
            this.Controls.Add(this.LB_contador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_camaras);
            this.Controls.Add(this.TB_descripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox0);
            this.Controls.Add(this.BT_foto2);
            this.Controls.Add(this.BT_foto);
            this.Controls.Add(this.BT_cargar2);
            this.Controls.Add(this.TB_cargar);
            this.Controls.Add(this.BT_iniciar_camara);
            this.Controls.Add(this.PB_imagen2);
            this.Controls.Add(this.PB_imagen1);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_folioSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.TB_importe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_concepto_gral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GastosAlmacenCedis";
            this.Text = "GastosAlmacenCedis";
            this.Load += new System.EventHandler(this.GastosAlmacenCedis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_concepto_gral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.TextBox TB_folioSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.PictureBox PB_imagen1;
        private System.Windows.Forms.PictureBox PB_imagen2;
        private System.Windows.Forms.Button BT_iniciar_camara;
        private System.Windows.Forms.Button BT_foto2;
        private System.Windows.Forms.Button BT_foto;
        private System.Windows.Forms.Button BT_cargar2;
        private System.Windows.Forms.Button TB_cargar;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.TextBox TB_descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_camaras;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_contador;
        private System.Windows.Forms.TextBox TB_comentario_rev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_conceptoDetalle;
    }
}