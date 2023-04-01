
namespace appSugerencias.Gastos.Vistas
{
    partial class RegistrarConceptoEgreso
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
            this.TB_clave = new System.Windows.Forms.TextBox();
            this.TB_conceptoDetalle = new System.Windows.Forms.TextBox();
            this.CB_tipo_gasto = new System.Windows.Forms.ComboBox();
            this.CB_conceptoGral = new System.Windows.Forms.ComboBox();
            this.BT_registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_clave
            // 
            this.TB_clave.Location = new System.Drawing.Point(124, 123);
            this.TB_clave.Name = "TB_clave";
            this.TB_clave.Size = new System.Drawing.Size(100, 20);
            this.TB_clave.TabIndex = 0;
            // 
            // TB_conceptoDetalle
            // 
            this.TB_conceptoDetalle.Location = new System.Drawing.Point(124, 149);
            this.TB_conceptoDetalle.Name = "TB_conceptoDetalle";
            this.TB_conceptoDetalle.Size = new System.Drawing.Size(271, 20);
            this.TB_conceptoDetalle.TabIndex = 1;
            // 
            // CB_tipo_gasto
            // 
            this.CB_tipo_gasto.AutoCompleteCustomSource.AddRange(new string[] {
            "EGRESOS DE TIENDA",
            "EGRESOS GENERALES"});
            this.CB_tipo_gasto.FormattingEnabled = true;
            this.CB_tipo_gasto.Items.AddRange(new object[] {
            "TIENDA",
            "GENERAL"});
            this.CB_tipo_gasto.Location = new System.Drawing.Point(124, 65);
            this.CB_tipo_gasto.Name = "CB_tipo_gasto";
            this.CB_tipo_gasto.Size = new System.Drawing.Size(271, 21);
            this.CB_tipo_gasto.TabIndex = 2;
            this.CB_tipo_gasto.SelectedIndexChanged += new System.EventHandler(this.CB_tipo_gasto_SelectedIndexChanged);
            // 
            // CB_conceptoGral
            // 
            this.CB_conceptoGral.FormattingEnabled = true;
            this.CB_conceptoGral.Location = new System.Drawing.Point(124, 92);
            this.CB_conceptoGral.Name = "CB_conceptoGral";
            this.CB_conceptoGral.Size = new System.Drawing.Size(271, 21);
            this.CB_conceptoGral.TabIndex = 3;
            // 
            // BT_registrar
            // 
            this.BT_registrar.Location = new System.Drawing.Point(311, 175);
            this.BT_registrar.Name = "BT_registrar";
            this.BT_registrar.Size = new System.Drawing.Size(84, 38);
            this.BT_registrar.TabIndex = 4;
            this.BT_registrar.Text = "Registrar";
            this.BT_registrar.UseVisualStyleBackColor = true;
            this.BT_registrar.Click += new System.EventHandler(this.BT_registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Egreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Concepto General";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clave concepto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Concepto Detalle";
            // 
            // RegistrarConceptoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 245);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_registrar);
            this.Controls.Add(this.CB_conceptoGral);
            this.Controls.Add(this.CB_tipo_gasto);
            this.Controls.Add(this.TB_conceptoDetalle);
            this.Controls.Add(this.TB_clave);
            this.Name = "RegistrarConceptoEgreso";
            this.Text = "RegistrarConceptoEgreso";
            this.Load += new System.EventHandler(this.RegistrarConceptoEgreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_clave;
        private System.Windows.Forms.TextBox TB_conceptoDetalle;
        private System.Windows.Forms.ComboBox CB_tipo_gasto;
        private System.Windows.Forms.ComboBox CB_conceptoGral;
        private System.Windows.Forms.Button BT_registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}