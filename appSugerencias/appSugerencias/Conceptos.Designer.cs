﻿namespace appSugerencias
{
    partial class Conceptos
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
            this.DG_conceptos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CB_concepto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_conceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_conceptos
            // 
            this.DG_conceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_conceptos.Location = new System.Drawing.Point(121, 132);
            this.DG_conceptos.Name = "DG_conceptos";
            this.DG_conceptos.Size = new System.Drawing.Size(589, 159);
            this.DG_conceptos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_concepto
            // 
            this.CB_concepto.FormattingEnabled = true;
            this.CB_concepto.Items.AddRange(new object[] {
            "   ",
            "EGRESOS",
            "INGRESOS"});
            this.CB_concepto.Location = new System.Drawing.Point(132, 62);
            this.CB_concepto.Name = "CB_concepto";
            this.CB_concepto.Size = new System.Drawing.Size(121, 21);
            this.CB_concepto.TabIndex = 2;
            // 
            // Conceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_concepto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DG_conceptos);
            this.Name = "Conceptos";
            this.Text = "Conceptos";
            this.Load += new System.EventHandler(this.Conceptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_conceptos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_conceptos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_concepto;
    }
}