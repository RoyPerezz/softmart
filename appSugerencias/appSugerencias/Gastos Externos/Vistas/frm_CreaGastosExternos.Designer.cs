namespace appSugerencias
{
    partial class frm_CreaGastosExterno
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
            this.tbGastos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.CB_concepto_gral = new System.Windows.Forms.ComboBox();
            this.RB_tienda = new System.Windows.Forms.RadioButton();
            this.RB_general = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO_GRAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGastos
            // 
            this.tbGastos.Location = new System.Drawing.Point(134, 95);
            this.tbGastos.Name = "tbGastos";
            this.tbGastos.Size = new System.Drawing.Size(267, 20);
            this.tbGastos.TabIndex = 0;
            this.tbGastos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(407, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvGastos
            // 
            this.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.CONCEPTO_GRAL,
            this.TIPO});
            this.dgvGastos.Location = new System.Drawing.Point(12, 124);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.Size = new System.Drawing.Size(723, 296);
            this.dgvGastos.TabIndex = 2;
            this.dgvGastos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellContentDoubleClick);
            // 
            // CB_concepto_gral
            // 
            this.CB_concepto_gral.FormattingEnabled = true;
            this.CB_concepto_gral.Location = new System.Drawing.Point(134, 68);
            this.CB_concepto_gral.Name = "CB_concepto_gral";
            this.CB_concepto_gral.Size = new System.Drawing.Size(267, 21);
            this.CB_concepto_gral.TabIndex = 3;
            this.CB_concepto_gral.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_gral_SelectedIndexChanged);
            // 
            // RB_tienda
            // 
            this.RB_tienda.AutoSize = true;
            this.RB_tienda.Location = new System.Drawing.Point(77, 37);
            this.RB_tienda.Name = "RB_tienda";
            this.RB_tienda.Size = new System.Drawing.Size(65, 17);
            this.RB_tienda.TabIndex = 5;
            this.RB_tienda.TabStop = true;
            this.RB_tienda.Text = "TIENDA";
            this.RB_tienda.UseVisualStyleBackColor = true;
            this.RB_tienda.CheckedChanged += new System.EventHandler(this.RB_tienda_CheckedChanged);
            // 
            // RB_general
            // 
            this.RB_general.AutoSize = true;
            this.RB_general.Location = new System.Drawing.Point(178, 37);
            this.RB_general.Name = "RB_general";
            this.RB_general.Size = new System.Drawing.Size(76, 17);
            this.RB_general.TabIndex = 6;
            this.RB_general.TabStop = true;
            this.RB_general.Text = "GENERAL";
            this.RB_general.UseVisualStyleBackColor = true;
            this.RB_general.CheckedChanged += new System.EventHandler(this.RB_general_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CONCEPTO GRAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CONCEPTO DETALLE";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(614, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Actualizar tabla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IDGasto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CONCEPTO";
            this.Column2.Name = "Column2";
            // 
            // CONCEPTO_GRAL
            // 
            this.CONCEPTO_GRAL.HeaderText = "CONCEPTO GRAL";
            this.CONCEPTO_GRAL.Name = "CONCEPTO_GRAL";
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO GASTO";
            this.TIPO.Name = "TIPO";
            // 
            // frm_CreaGastosExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(747, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RB_general);
            this.Controls.Add(this.RB_tienda);
            this.Controls.Add(this.CB_concepto_gral);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbGastos);
            this.Name = "frm_CreaGastosExterno";
            this.Text = "frm_CreGastosExternos";
            this.Load += new System.EventHandler(this.frm_CreaGastosExterno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGastos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.ComboBox CB_concepto_gral;
        private System.Windows.Forms.RadioButton RB_tienda;
        private System.Windows.Forms.RadioButton RB_general;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO_GRAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
    }
}