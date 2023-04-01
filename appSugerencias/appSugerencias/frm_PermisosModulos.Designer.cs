namespace appSugerencias
{
    partial class frm_PermisosModulos
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvModulos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBALL = new System.Windows.Forms.CheckBox();
            this.cbTiendas = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCEDIS = new System.Windows.Forms.Label();
            this.lblVA = new System.Windows.Forms.Label();
            this.lblRE = new System.Windows.Forms.Label();
            this.lblCO = new System.Windows.Forms.Label();
            this.lblVL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvEmpleados.Location = new System.Drawing.Point(29, 53);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(428, 633);
            this.dgvEmpleados.TabIndex = 31;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // dgvModulos
            // 
            this.dgvModulos.AllowUserToAddRows = false;
            this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvModulos.Location = new System.Drawing.Point(499, 35);
            this.dgvModulos.Name = "dgvModulos";
            this.dgvModulos.Size = new System.Drawing.Size(549, 651);
            this.dgvModulos.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Modulo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor";
            this.Column3.Name = "Column3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(962, 695);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 38);
            this.button2.TabIndex = 34;
            this.button2.Text = "Guardar Permisos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBALL
            // 
            this.checkBALL.AutoSize = true;
            this.checkBALL.Location = new System.Drawing.Point(996, 11);
            this.checkBALL.Name = "checkBALL";
            this.checkBALL.Size = new System.Drawing.Size(56, 17);
            this.checkBALL.TabIndex = 36;
            this.checkBALL.Text = "Todos";
            this.checkBALL.UseVisualStyleBackColor = true;
            this.checkBALL.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbTiendas
            // 
            this.cbTiendas.FormattingEnabled = true;
            this.cbTiendas.Location = new System.Drawing.Point(88, 12);
            this.cbTiendas.Name = "cbTiendas";
            this.cbTiendas.Size = new System.Drawing.Size(121, 21);
            this.cbTiendas.TabIndex = 37;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 21);
            this.button4.TabIndex = 38;
            this.button4.Text = "consultar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tienda";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Usuario";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Area";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(494, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 29);
            this.lblUsuario.TabIndex = 40;
            this.lblUsuario.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 713);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "CEDIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "VA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 713);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "RE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 713);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "CO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 713);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "VL";
            // 
            // lblCEDIS
            // 
            this.lblCEDIS.AutoSize = true;
            this.lblCEDIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEDIS.Location = new System.Drawing.Point(81, 713);
            this.lblCEDIS.Name = "lblCEDIS";
            this.lblCEDIS.Size = new System.Drawing.Size(23, 16);
            this.lblCEDIS.TabIndex = 46;
            this.lblCEDIS.Text = "---";
            // 
            // lblVA
            // 
            this.lblVA.AutoSize = true;
            this.lblVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVA.Location = new System.Drawing.Point(146, 713);
            this.lblVA.Name = "lblVA";
            this.lblVA.Size = new System.Drawing.Size(23, 16);
            this.lblVA.TabIndex = 47;
            this.lblVA.Text = "---";
            // 
            // lblRE
            // 
            this.lblRE.AutoSize = true;
            this.lblRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRE.Location = new System.Drawing.Point(210, 713);
            this.lblRE.Name = "lblRE";
            this.lblRE.Size = new System.Drawing.Size(23, 16);
            this.lblRE.TabIndex = 48;
            this.lblRE.Text = "---";
            // 
            // lblCO
            // 
            this.lblCO.AutoSize = true;
            this.lblCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCO.Location = new System.Drawing.Point(274, 713);
            this.lblCO.Name = "lblCO";
            this.lblCO.Size = new System.Drawing.Size(23, 16);
            this.lblCO.TabIndex = 49;
            this.lblCO.Text = "---";
            // 
            // lblVL
            // 
            this.lblVL.AutoSize = true;
            this.lblVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVL.Location = new System.Drawing.Point(347, 713);
            this.lblVL.Name = "lblVL";
            this.lblVL.Size = new System.Drawing.Size(23, 16);
            this.lblVL.TabIndex = 50;
            this.lblVL.Text = "---";
            // 
            // frm_PermisosModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 745);
            this.Controls.Add(this.lblVL);
            this.Controls.Add(this.lblCO);
            this.Controls.Add(this.lblRE);
            this.Controls.Add(this.lblVA);
            this.Controls.Add(this.lblCEDIS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbTiendas);
            this.Controls.Add(this.checkBALL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvModulos);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "frm_PermisosModulos";
            this.Text = "frm_PermisosModulos";
            this.Load += new System.EventHandler(this.frm_PermisosModulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dgvModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBALL;
        private System.Windows.Forms.ComboBox cbTiendas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCEDIS;
        private System.Windows.Forms.Label lblVA;
        private System.Windows.Forms.Label lblRE;
        private System.Windows.Forms.Label lblCO;
        private System.Windows.Forms.Label lblVL;
    }
}