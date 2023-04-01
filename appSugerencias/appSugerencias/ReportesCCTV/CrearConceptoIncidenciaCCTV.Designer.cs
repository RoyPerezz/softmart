namespace appSugerencias.ReportesCCTV
{
    partial class CrearConceptoIncidenciaCCTV
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
            this.BT_crearConcepto = new System.Windows.Forms.Button();
            this.TB_concepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_crearConcepto
            // 
            this.BT_crearConcepto.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_crearConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_crearConcepto.ForeColor = System.Drawing.Color.White;
            this.BT_crearConcepto.Location = new System.Drawing.Point(395, 75);
            this.BT_crearConcepto.Name = "BT_crearConcepto";
            this.BT_crearConcepto.Size = new System.Drawing.Size(82, 41);
            this.BT_crearConcepto.TabIndex = 0;
            this.BT_crearConcepto.Text = "Crear";
            this.BT_crearConcepto.UseVisualStyleBackColor = false;
            this.BT_crearConcepto.Click += new System.EventHandler(this.BT_crearConcepto_Click);
            // 
            // TB_concepto
            // 
            this.TB_concepto.Location = new System.Drawing.Point(15, 38);
            this.TB_concepto.Name = "TB_concepto";
            this.TB_concepto.Size = new System.Drawing.Size(462, 20);
            this.TB_concepto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONCEPTO";
            // 
            // CrearConceptoIncidenciaCCTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(491, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_concepto);
            this.Controls.Add(this.BT_crearConcepto);
            this.Name = "CrearConceptoIncidenciaCCTV";
            this.Text = "Crear concepto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_crearConcepto;
        private System.Windows.Forms.TextBox TB_concepto;
        private System.Windows.Forms.Label label1;
    }
}