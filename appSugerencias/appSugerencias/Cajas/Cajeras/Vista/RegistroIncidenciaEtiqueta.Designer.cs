
namespace appSugerencias.Cajas.Cajeras.Vista
{
    partial class RegistroIncidenciaEtiqueta
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
            this.button1 = new System.Windows.Forms.Button();
            this.TB_articulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_descripcion = new System.Windows.Forms.TextBox();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.CB_incidencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_caja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(506, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_articulo
            // 
            this.TB_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_articulo.Location = new System.Drawing.Point(138, 103);
            this.TB_articulo.Name = "TB_articulo";
            this.TB_articulo.Size = new System.Drawing.Size(160, 26);
            this.TB_articulo.TabIndex = 1;
            this.TB_articulo.Enter += new System.EventHandler(this.TB_articulo_Enter);
            this.TB_articulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_articulo_KeyDown);
            this.TB_articulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARTICULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "DESCRIPCION";
            // 
            // TB_descripcion
            // 
            this.TB_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_descripcion.Location = new System.Drawing.Point(138, 132);
            this.TB_descripcion.Name = "TB_descripcion";
            this.TB_descripcion.Size = new System.Drawing.Size(404, 26);
            this.TB_descripcion.TabIndex = 3;
            // 
            // DT_fecha
            // 
            this.DT_fecha.Enabled = false;
            this.DT_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fecha.Location = new System.Drawing.Point(341, 12);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(297, 26);
            this.DT_fecha.TabIndex = 5;
            // 
            // CB_incidencia
            // 
            this.CB_incidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_incidencia.FormattingEnabled = true;
            this.CB_incidencia.Location = new System.Drawing.Point(138, 161);
            this.CB_incidencia.Name = "CB_incidencia";
            this.CB_incidencia.Size = new System.Drawing.Size(258, 28);
            this.CB_incidencia.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "INCIDENCIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "USUARIO";
            // 
            // TB_usuario
            // 
            this.TB_usuario.Enabled = false;
            this.TB_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_usuario.Location = new System.Drawing.Point(104, 15);
            this.TB_usuario.Name = "TB_usuario";
            this.TB_usuario.Size = new System.Drawing.Size(160, 26);
            this.TB_usuario.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "CAJA";
            // 
            // TB_caja
            // 
            this.TB_caja.Enabled = false;
            this.TB_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_caja.Location = new System.Drawing.Point(104, 47);
            this.TB_caja.Name = "TB_caja";
            this.TB_caja.Size = new System.Drawing.Size(160, 26);
            this.TB_caja.TabIndex = 10;
            // 
            // RegistroIncidenciaEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(650, 308);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_caja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_incidencia);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_articulo);
            this.Controls.Add(this.button1);
            this.Name = "RegistroIncidenciaEtiqueta";
            this.Text = "RegistroIncidenciaEtiqueta";
            this.Load += new System.EventHandler(this.RegistroIncidenciaEtiqueta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.ComboBox CB_incidencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_usuario;
        public System.Windows.Forms.TextBox TB_articulo;
        public System.Windows.Forms.TextBox TB_descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_caja;
    }
}