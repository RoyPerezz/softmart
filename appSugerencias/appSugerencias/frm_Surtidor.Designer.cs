namespace appSugerencias
{
    partial class frm_Surtidor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSurtidor = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EXIS_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURTIR_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXIS_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURTIR_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXIS_CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURTIR_CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXIS_VL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURTIR_VL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXIS_PM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURTIR_PM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.cbLinea = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurtidor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSurtidor
            // 
            this.dgvSurtidor.AllowUserToAddRows = false;
            this.dgvSurtidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSurtidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column9,
            this.EXIS_VA,
            this.SURTIR_VA,
            this.EXIS_RE,
            this.SURTIR_RE,
            this.EXIS_CO,
            this.SURTIR_CO,
            this.EXIS_VL,
            this.SURTIR_VL,
            this.EXIS_PM,
            this.SURTIR_PM});
            this.dgvSurtidor.Location = new System.Drawing.Point(9, 12);
            this.dgvSurtidor.Name = "dgvSurtidor";
            this.dgvSurtidor.Size = new System.Drawing.Size(1274, 861);
            this.dgvSurtidor.TabIndex = 0;
            this.dgvSurtidor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSutidor_CellContentClick);
            this.dgvSurtidor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSutidor_CellFormatting);
            this.dgvSurtidor.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSutidor_CellValidated);
            this.dgvSurtidor.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSutidor_CellValidating);
            this.dgvSurtidor.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSutidor_CellValueChanged);
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "No";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Articulo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
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
            this.Column3.HeaderText = "Exist.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Pzs x Caja";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cantidad en Caja";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Surtir";
            this.Column9.Name = "Column9";
            // 
            // EXIS_VA
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.EXIS_VA.DefaultCellStyle = dataGridViewCellStyle25;
            this.EXIS_VA.HeaderText = "Existencia Vallarta";
            this.EXIS_VA.Name = "EXIS_VA";
            this.EXIS_VA.ReadOnly = true;
            this.EXIS_VA.Width = 60;
            // 
            // SURTIR_VA
            // 
            this.SURTIR_VA.HeaderText = "Surtir Vallarta";
            this.SURTIR_VA.Name = "SURTIR_VA";
            this.SURTIR_VA.Width = 60;
            // 
            // EXIS_RE
            // 
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EXIS_RE.DefaultCellStyle = dataGridViewCellStyle26;
            this.EXIS_RE.HeaderText = "Existencias Rena";
            this.EXIS_RE.Name = "EXIS_RE";
            this.EXIS_RE.ReadOnly = true;
            this.EXIS_RE.Width = 60;
            // 
            // SURTIR_RE
            // 
            this.SURTIR_RE.HeaderText = "Surtir Rena";
            this.SURTIR_RE.Name = "SURTIR_RE";
            this.SURTIR_RE.Width = 60;
            // 
            // EXIS_CO
            // 
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EXIS_CO.DefaultCellStyle = dataGridViewCellStyle27;
            this.EXIS_CO.HeaderText = "Existencia Coloso";
            this.EXIS_CO.Name = "EXIS_CO";
            this.EXIS_CO.ReadOnly = true;
            this.EXIS_CO.Width = 60;
            // 
            // SURTIR_CO
            // 
            this.SURTIR_CO.HeaderText = "Surtir Coloso";
            this.SURTIR_CO.Name = "SURTIR_CO";
            this.SURTIR_CO.Width = 60;
            // 
            // EXIS_VL
            // 
            this.EXIS_VL.HeaderText = "Existencia Velazquez";
            this.EXIS_VL.Name = "EXIS_VL";
            this.EXIS_VL.ReadOnly = true;
            this.EXIS_VL.Width = 60;
            // 
            // SURTIR_VL
            // 
            this.SURTIR_VL.HeaderText = "Surtir Velazquez";
            this.SURTIR_VL.Name = "SURTIR_VL";
            this.SURTIR_VL.Width = 60;
            // 
            // EXIS_PM
            // 
            this.EXIS_PM.HeaderText = "Existencia Pregot";
            this.EXIS_PM.Name = "EXIS_PM";
            this.EXIS_PM.ReadOnly = true;
            this.EXIS_PM.Width = 60;
            // 
            // SURTIR_PM
            // 
            this.SURTIR_PM.HeaderText = "Surtir Pregot";
            this.SURTIR_PM.Name = "SURTIR_PM";
            this.SURTIR_PM.Width = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1313, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(1313, 139);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(141, 51);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbLinea
            // 
            this.cbLinea.FormattingEnabled = true;
            this.cbLinea.Location = new System.Drawing.Point(1289, 22);
            this.cbLinea.Name = "cbLinea";
            this.cbLinea.Size = new System.Drawing.Size(194, 21);
            this.cbLinea.TabIndex = 3;
            this.cbLinea.SelectedIndexChanged += new System.EventHandler(this.cbLinea_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1313, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1313, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 59);
            this.button4.TabIndex = 13;
            this.button4.Text = "Revisar solicitud";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // frm_Surtidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1495, 885);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbLinea);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSurtidor);
            this.Name = "frm_Surtidor";
            this.Text = "frm_Surtidor";
            this.Load += new System.EventHandler(this.frm_Surtidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurtidor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSurtidor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ComboBox cbLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXIS_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURTIR_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXIS_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURTIR_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXIS_CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURTIR_CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXIS_VL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURTIR_VL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXIS_PM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURTIR_PM;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}