
namespace appSugerencias.Gastos.Vistas
{
    partial class AgregarFotoEncCajas
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
            this.LB_concepto = new System.Windows.Forms.Label();
            this.LB_descripcion = new System.Windows.Forms.Label();
            this.LB_importe = new System.Windows.Forms.Label();
            this.TB_detalle = new System.Windows.Forms.TextBox();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.TB_cargar = new System.Windows.Forms.Button();
            this.LB_fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_cargar2 = new System.Windows.Forms.Button();
            this.BT_cargar3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_foto = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CB_camaras = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_foto2 = new System.Windows.Forms.Button();
            this.BT_foto3 = new System.Windows.Forms.Button();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_contador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_concepto
            // 
            this.LB_concepto.AutoSize = true;
            this.LB_concepto.Location = new System.Drawing.Point(666, 15);
            this.LB_concepto.Name = "LB_concepto";
            this.LB_concepto.Size = new System.Drawing.Size(35, 13);
            this.LB_concepto.TabIndex = 0;
            this.LB_concepto.Text = "label1";
            this.LB_concepto.Click += new System.EventHandler(this.LB_concepto_Click);
            // 
            // LB_descripcion
            // 
            this.LB_descripcion.AutoSize = true;
            this.LB_descripcion.Location = new System.Drawing.Point(666, 38);
            this.LB_descripcion.Name = "LB_descripcion";
            this.LB_descripcion.Size = new System.Drawing.Size(35, 13);
            this.LB_descripcion.TabIndex = 1;
            this.LB_descripcion.Text = "label2";
            this.LB_descripcion.Click += new System.EventHandler(this.LB_descripcion_Click);
            // 
            // LB_importe
            // 
            this.LB_importe.AutoSize = true;
            this.LB_importe.Location = new System.Drawing.Point(666, 61);
            this.LB_importe.Name = "LB_importe";
            this.LB_importe.Size = new System.Drawing.Size(35, 13);
            this.LB_importe.TabIndex = 2;
            this.LB_importe.Text = "label3";
            this.LB_importe.Click += new System.EventHandler(this.LB_importe_Click);
            // 
            // TB_detalle
            // 
            this.TB_detalle.Location = new System.Drawing.Point(543, 446);
            this.TB_detalle.Multiline = true;
            this.TB_detalle.Name = "TB_detalle";
            this.TB_detalle.Size = new System.Drawing.Size(364, 51);
            this.TB_detalle.TabIndex = 4;
            this.TB_detalle.TextChanged += new System.EventHandler(this.TB_detalle_TextChanged);
            // 
            // BT_guardar
            // 
            this.BT_guardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(777, 525);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(113, 41);
            this.BT_guardar.TabIndex = 5;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // TB_cargar
            // 
            this.TB_cargar.BackColor = System.Drawing.Color.DodgerBlue;
            this.TB_cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_cargar.ForeColor = System.Drawing.Color.White;
            this.TB_cargar.Location = new System.Drawing.Point(6, 493);
            this.TB_cargar.Name = "TB_cargar";
            this.TB_cargar.Size = new System.Drawing.Size(252, 39);
            this.TB_cargar.TabIndex = 6;
            this.TB_cargar.Text = "Cargar imagen";
            this.TB_cargar.UseVisualStyleBackColor = false;
            this.TB_cargar.Click += new System.EventHandler(this.TB_cargar_Click);
            // 
            // LB_fecha
            // 
            this.LB_fecha.AutoSize = true;
            this.LB_fecha.Location = new System.Drawing.Point(666, 88);
            this.LB_fecha.Name = "LB_fecha";
            this.LB_fecha.Size = new System.Drawing.Size(35, 13);
            this.LB_fecha.TabIndex = 7;
            this.LB_fecha.Text = "label3";
            this.LB_fecha.Click += new System.EventHandler(this.LB_fecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CONCEPTO GRAL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "IMPORTE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "FECHA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción Detallada";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BT_cargar2
            // 
            this.BT_cargar2.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_cargar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cargar2.ForeColor = System.Drawing.Color.White;
            this.BT_cargar2.Location = new System.Drawing.Point(264, 493);
            this.BT_cargar2.Name = "BT_cargar2";
            this.BT_cargar2.Size = new System.Drawing.Size(252, 39);
            this.BT_cargar2.TabIndex = 15;
            this.BT_cargar2.Text = "Cargar imagen";
            this.BT_cargar2.UseVisualStyleBackColor = false;
            this.BT_cargar2.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_cargar3
            // 
            this.BT_cargar3.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_cargar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cargar3.ForeColor = System.Drawing.Color.White;
            this.BT_cargar3.Location = new System.Drawing.Point(761, 355);
            this.BT_cargar3.Name = "BT_cargar3";
            this.BT_cargar3.Size = new System.Drawing.Size(146, 43);
            this.BT_cargar3.TabIndex = 17;
            this.BT_cargar3.Text = "Cargar imagen";
            this.BT_cargar3.UseVisualStyleBackColor = false;
            this.BT_cargar3.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "CONCEPTO DETALLE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(540, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Aquí sube las fotos rectangulares";
            // 
            // BT_foto
            // 
            this.BT_foto.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_foto.ForeColor = System.Drawing.Color.White;
            this.BT_foto.Image = global::appSugerencias.Properties.Resources.camara__2_;
            this.BT_foto.Location = new System.Drawing.Point(6, 527);
            this.BT_foto.Name = "BT_foto";
            this.BT_foto.Size = new System.Drawing.Size(252, 39);
            this.BT_foto.TabIndex = 20;
            this.BT_foto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_foto.UseVisualStyleBackColor = false;
            this.BT_foto.Click += new System.EventHandler(this.BT_foto_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Location = new System.Drawing.Point(543, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(364, 228);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(264, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 426);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(6, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 426);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CB_camaras
            // 
            this.CB_camaras.FormattingEnabled = true;
            this.CB_camaras.Location = new System.Drawing.Point(12, 29);
            this.CB_camaras.Name = "CB_camaras";
            this.CB_camaras.Size = new System.Drawing.Size(246, 21);
            this.CB_camaras.TabIndex = 21;
            this.CB_camaras.SelectedIndexChanged += new System.EventHandler(this.CB_camaras_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Lista de cámaras";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(264, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "Iniciar Cámara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BT_foto2
            // 
            this.BT_foto2.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_foto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_foto2.ForeColor = System.Drawing.Color.White;
            this.BT_foto2.Image = global::appSugerencias.Properties.Resources.camara__2_;
            this.BT_foto2.Location = new System.Drawing.Point(264, 527);
            this.BT_foto2.Name = "BT_foto2";
            this.BT_foto2.Size = new System.Drawing.Size(252, 39);
            this.BT_foto2.TabIndex = 24;
            this.BT_foto2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_foto2.UseVisualStyleBackColor = false;
            this.BT_foto2.Click += new System.EventHandler(this.button3_Click);
            // 
            // BT_foto3
            // 
            this.BT_foto3.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_foto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_foto3.ForeColor = System.Drawing.Color.White;
            this.BT_foto3.Image = global::appSugerencias.Properties.Resources.camara__2_;
            this.BT_foto3.Location = new System.Drawing.Point(761, 397);
            this.BT_foto3.Name = "BT_foto3";
            this.BT_foto3.Size = new System.Drawing.Size(146, 43);
            this.BT_foto3.TabIndex = 25;
            this.BT_foto3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_foto3.UseVisualStyleBackColor = false;
            this.BT_foto3.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox0.Location = new System.Drawing.Point(913, 121);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(10, 426);
            this.pictureBox0.TabIndex = 26;
            this.pictureBox0.TabStop = false;
            this.pictureBox0.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LB_contador
            // 
            this.LB_contador.AutoSize = true;
            this.LB_contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_contador.Location = new System.Drawing.Point(395, 22);
            this.LB_contador.Name = "LB_contador";
            this.LB_contador.Size = new System.Drawing.Size(24, 25);
            this.LB_contador.TabIndex = 27;
            this.LB_contador.Text = "0";
            // 
            // AgregarFotoEncCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(926, 569);
            this.Controls.Add(this.LB_contador);
            this.Controls.Add(this.pictureBox0);
            this.Controls.Add(this.BT_foto3);
            this.Controls.Add(this.BT_foto2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_camaras);
            this.Controls.Add(this.BT_foto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BT_cargar3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BT_cargar2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_fecha);
            this.Controls.Add(this.TB_cargar);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.TB_detalle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_importe);
            this.Controls.Add(this.LB_descripcion);
            this.Controls.Add(this.LB_concepto);
            this.Name = "AgregarFotoEncCajas";
            this.Text = "AgregarFotoEncCajas";
            this.Load += new System.EventHandler(this.AgregarFotoEncCajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_concepto;
        private System.Windows.Forms.Label LB_descripcion;
        private System.Windows.Forms.Label LB_importe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_detalle;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Button TB_cargar;
        private System.Windows.Forms.Label LB_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_cargar2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BT_cargar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_foto;
        private System.Windows.Forms.ComboBox CB_camaras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BT_foto2;
        private System.Windows.Forms.Button BT_foto3;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_contador;
    }
}