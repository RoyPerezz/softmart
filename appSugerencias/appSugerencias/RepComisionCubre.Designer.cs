﻿namespace appSugerencias
{
    partial class RepComisionCubre
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
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ASPECTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.TB_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASPECTOS});
            this.DG_tabla.Location = new System.Drawing.Point(-2, 85);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(844, 332);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentClick);
            // 
            // ASPECTOS
            // 
            this.ASPECTOS.HeaderText = "ASPECTOS A CALIFICAR";
            this.ASPECTOS.Name = "ASPECTOS";
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(61, 9);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 1;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(61, 47);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "INICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FIN";
            // 
            // BT_buscar
            // 
            this.BT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(637, 12);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(98, 51);
            this.BT_buscar.TabIndex = 5;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(741, 12);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(98, 51);
            this.BT_exportar.TabIndex = 6;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // TB_total
            // 
            this.TB_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_total.BackColor = System.Drawing.Color.Black;
            this.TB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_total.ForeColor = System.Drawing.Color.Lime;
            this.TB_total.Location = new System.Drawing.Point(686, 423);
            this.TB_total.Name = "TB_total";
            this.TB_total.Size = new System.Drawing.Size(153, 29);
            this.TB_total.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOTAL";
            // 
            // RepComisionCubre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(844, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_total);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.DG_tabla);
            this.Name = "RepComisionCubre";
            this.Text = "RepComisionCubre";
            this.Load += new System.EventHandler(this.RepComisionCubre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASPECTOS;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.TextBox TB_total;
        private System.Windows.Forms.Label label3;
    }
}