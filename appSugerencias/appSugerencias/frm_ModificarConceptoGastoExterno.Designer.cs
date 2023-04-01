
namespace appSugerencias
{
    partial class frm_ModificarConceptoGastoExterno
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
            System.Windows.Forms.Button button1;
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RB_general = new System.Windows.Forms.RadioButton();
            this.RB_tienda = new System.Windows.Forms.RadioButton();
            this.CB_concepto_gral = new System.Windows.Forms.ComboBox();
            this.tbGastos = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LB_eliminar_concepto_detalle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_eliminar_concepto_gral = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_eliminar_tipo_gasto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_eliminar_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_modificar_concepto_detalle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LB_modificar_concepto_gral = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LB_modificar_tipo_gasto = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LB_modificar_id = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BT_Eliminar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "CONCEPTO DETALLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "CONCEPTO GRAL";
            // 
            // RB_general
            // 
            this.RB_general.AutoSize = true;
            this.RB_general.Location = new System.Drawing.Point(191, 190);
            this.RB_general.Name = "RB_general";
            this.RB_general.Size = new System.Drawing.Size(76, 17);
            this.RB_general.TabIndex = 13;
            this.RB_general.TabStop = true;
            this.RB_general.Text = "GENERAL";
            this.RB_general.UseVisualStyleBackColor = true;
            this.RB_general.CheckedChanged += new System.EventHandler(this.RB_general_CheckedChanged);
            // 
            // RB_tienda
            // 
            this.RB_tienda.AutoSize = true;
            this.RB_tienda.Location = new System.Drawing.Point(90, 190);
            this.RB_tienda.Name = "RB_tienda";
            this.RB_tienda.Size = new System.Drawing.Size(65, 17);
            this.RB_tienda.TabIndex = 12;
            this.RB_tienda.TabStop = true;
            this.RB_tienda.Text = "TIENDA";
            this.RB_tienda.UseVisualStyleBackColor = true;
            this.RB_tienda.CheckedChanged += new System.EventHandler(this.RB_tienda_CheckedChanged);
            // 
            // CB_concepto_gral
            // 
            this.CB_concepto_gral.FormattingEnabled = true;
            this.CB_concepto_gral.Location = new System.Drawing.Point(147, 221);
            this.CB_concepto_gral.Name = "CB_concepto_gral";
            this.CB_concepto_gral.Size = new System.Drawing.Size(267, 21);
            this.CB_concepto_gral.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.DodgerBlue;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(420, 220);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(93, 48);
            button1.TabIndex = 10;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbGastos
            // 
            this.tbGastos.Location = new System.Drawing.Point(147, 248);
            this.tbGastos.Name = "tbGastos";
            this.tbGastos.Size = new System.Drawing.Size(267, 20);
            this.tbGastos.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 361);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LB_modificar_concepto_detalle);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.LB_modificar_concepto_gral);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.LB_modificar_tipo_gasto);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.LB_modificar_id);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(button1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbGastos);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.CB_concepto_gral);
            this.tabPage1.Controls.Add(this.RB_general);
            this.tabPage1.Controls.Add(this.RB_tienda);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BT_Eliminar);
            this.tabPage2.Controls.Add(this.LB_eliminar_concepto_detalle);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.LB_eliminar_concepto_gral);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.LB_eliminar_tipo_gasto);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.LB_eliminar_id);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LB_eliminar_concepto_detalle
            // 
            this.LB_eliminar_concepto_detalle.AutoSize = true;
            this.LB_eliminar_concepto_detalle.Location = new System.Drawing.Point(150, 144);
            this.LB_eliminar_concepto_detalle.Name = "LB_eliminar_concepto_detalle";
            this.LB_eliminar_concepto_detalle.Size = new System.Drawing.Size(0, 13);
            this.LB_eliminar_concepto_detalle.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "CONCEPTO DETALLE";
            // 
            // LB_eliminar_concepto_gral
            // 
            this.LB_eliminar_concepto_gral.AutoSize = true;
            this.LB_eliminar_concepto_gral.Location = new System.Drawing.Point(150, 105);
            this.LB_eliminar_concepto_gral.Name = "LB_eliminar_concepto_gral";
            this.LB_eliminar_concepto_gral.Size = new System.Drawing.Size(0, 13);
            this.LB_eliminar_concepto_gral.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CONCEPTO GRAL";
            // 
            // LB_eliminar_tipo_gasto
            // 
            this.LB_eliminar_tipo_gasto.AutoSize = true;
            this.LB_eliminar_tipo_gasto.Location = new System.Drawing.Point(150, 71);
            this.LB_eliminar_tipo_gasto.Name = "LB_eliminar_tipo_gasto";
            this.LB_eliminar_tipo_gasto.Size = new System.Drawing.Size(0, 13);
            this.LB_eliminar_tipo_gasto.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "TIPO GASTO";
            // 
            // LB_eliminar_id
            // 
            this.LB_eliminar_id.AutoSize = true;
            this.LB_eliminar_id.Location = new System.Drawing.Point(150, 35);
            this.LB_eliminar_id.Name = "LB_eliminar_id";
            this.LB_eliminar_id.Size = new System.Drawing.Size(0, 13);
            this.LB_eliminar_id.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // LB_modificar_concepto_detalle
            // 
            this.LB_modificar_concepto_detalle.AutoSize = true;
            this.LB_modificar_concepto_detalle.Location = new System.Drawing.Point(171, 128);
            this.LB_modificar_concepto_detalle.Name = "LB_modificar_concepto_detalle";
            this.LB_modificar_concepto_detalle.Size = new System.Drawing.Size(0, 13);
            this.LB_modificar_concepto_detalle.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "CONCEPTO DETALLE";
            // 
            // LB_modificar_concepto_gral
            // 
            this.LB_modificar_concepto_gral.AutoSize = true;
            this.LB_modificar_concepto_gral.Location = new System.Drawing.Point(171, 89);
            this.LB_modificar_concepto_gral.Name = "LB_modificar_concepto_gral";
            this.LB_modificar_concepto_gral.Size = new System.Drawing.Size(0, 13);
            this.LB_modificar_concepto_gral.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "CONCEPTO GRAL";
            // 
            // LB_modificar_tipo_gasto
            // 
            this.LB_modificar_tipo_gasto.AutoSize = true;
            this.LB_modificar_tipo_gasto.Location = new System.Drawing.Point(171, 55);
            this.LB_modificar_tipo_gasto.Name = "LB_modificar_tipo_gasto";
            this.LB_modificar_tipo_gasto.Size = new System.Drawing.Size(0, 13);
            this.LB_modificar_tipo_gasto.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(83, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "TIPO GASTO";
            // 
            // LB_modificar_id
            // 
            this.LB_modificar_id.AutoSize = true;
            this.LB_modificar_id.Location = new System.Drawing.Point(171, 19);
            this.LB_modificar_id.Name = "LB_modificar_id";
            this.LB_modificar_id.Size = new System.Drawing.Size(0, 13);
            this.LB_modificar_id.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(137, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "ID";
            // 
            // BT_Eliminar
            // 
            this.BT_Eliminar.BackColor = System.Drawing.Color.Crimson;
            this.BT_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Eliminar.ForeColor = System.Drawing.Color.White;
            this.BT_Eliminar.Location = new System.Drawing.Point(464, 264);
            this.BT_Eliminar.Name = "BT_Eliminar";
            this.BT_Eliminar.Size = new System.Drawing.Size(93, 48);
            this.BT_Eliminar.TabIndex = 16;
            this.BT_Eliminar.Text = "Eliminar";
            this.BT_Eliminar.UseVisualStyleBackColor = false;
            this.BT_Eliminar.Click += new System.EventHandler(this.BT_Eliminar_Click);
            // 
            // frm_ModificarConceptoGastoExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(616, 408);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_ModificarConceptoGastoExterno";
            this.Text = "frm_ModificarConceptoGastoExterno";
            this.Load += new System.EventHandler(this.frm_ModificarConceptoGastoExterno_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton RB_general;
        private System.Windows.Forms.RadioButton RB_tienda;
        private System.Windows.Forms.ComboBox CB_concepto_gral;
        private System.Windows.Forms.TextBox tbGastos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LB_modificar_concepto_detalle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LB_modificar_concepto_gral;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LB_modificar_tipo_gasto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LB_modificar_id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BT_Eliminar;
        private System.Windows.Forms.Label LB_eliminar_concepto_detalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_eliminar_concepto_gral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_eliminar_tipo_gasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_eliminar_id;
        private System.Windows.Forms.Label label1;
    }
}