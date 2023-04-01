namespace appSugerencias
{
    partial class frm_agregarEmpleado
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
            this.label9 = new System.Windows.Forms.Label();
            this.cbPatron = new System.Windows.Forms.ComboBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.ckbNuevoEmpleado = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.lblBo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCo = new System.Windows.Forms.Label();
            this.lblVL = new System.Windows.Forms.Label();
            this.lblRe = new System.Windows.Forms.Label();
            this.lblVa = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblRena = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_Apa = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.tb_idEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Salario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_IdChecador = new System.Windows.Forms.TextBox();
            this.tb_Ama = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 129;
            this.label9.Text = "Patron";
            // 
            // cbPatron
            // 
            this.cbPatron.FormattingEnabled = true;
            this.cbPatron.Items.AddRange(new object[] {
            "CAJAS",
            "PISO DE VENTA",
            "BODEGA"});
            this.cbPatron.Location = new System.Drawing.Point(190, 488);
            this.cbPatron.Name = "cbPatron";
            this.cbPatron.Size = new System.Drawing.Size(208, 21);
            this.cbPatron.TabIndex = 128;
            // 
            // btActualizar
            // 
            this.btActualizar.Enabled = false;
            this.btActualizar.Location = new System.Drawing.Point(1080, 563);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(93, 41);
            this.btActualizar.TabIndex = 127;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // ckbNuevoEmpleado
            // 
            this.ckbNuevoEmpleado.AutoSize = true;
            this.ckbNuevoEmpleado.Checked = true;
            this.ckbNuevoEmpleado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNuevoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNuevoEmpleado.Location = new System.Drawing.Point(22, 21);
            this.ckbNuevoEmpleado.Name = "ckbNuevoEmpleado";
            this.ckbNuevoEmpleado.Size = new System.Drawing.Size(147, 20);
            this.ckbNuevoEmpleado.TabIndex = 126;
            this.ckbNuevoEmpleado.Text = "Nuevo Empleado";
            this.ckbNuevoEmpleado.UseVisualStyleBackColor = true;
            this.ckbNuevoEmpleado.CheckedChanged += new System.EventHandler(this.ckbNuevoEmpleado_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(693, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 125;
            this.label8.Text = "Buscar:";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(772, 19);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(238, 20);
            this.tbFiltro.TabIndex = 124;
            this.tbFiltro.TextChanged += new System.EventHandler(this.tbFiltro_TextChanged);
            // 
            // lblBo
            // 
            this.lblBo.AutoSize = true;
            this.lblBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBo.Location = new System.Drawing.Point(533, 272);
            this.lblBo.Name = "lblBo";
            this.lblBo.Size = new System.Drawing.Size(23, 16);
            this.lblBo.TabIndex = 123;
            this.lblBo.Text = "---";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(579, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 122;
            this.label16.Text = "CEDIS";
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCo.Location = new System.Drawing.Point(533, 224);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(23, 16);
            this.lblCo.TabIndex = 121;
            this.lblCo.Text = "---";
            // 
            // lblVL
            // 
            this.lblVL.AutoSize = true;
            this.lblVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVL.Location = new System.Drawing.Point(533, 179);
            this.lblVL.Name = "lblVL";
            this.lblVL.Size = new System.Drawing.Size(23, 16);
            this.lblVL.TabIndex = 120;
            this.lblVL.Text = "---";
            // 
            // lblRe
            // 
            this.lblRe.AutoSize = true;
            this.lblRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRe.Location = new System.Drawing.Point(533, 129);
            this.lblRe.Name = "lblRe";
            this.lblRe.Size = new System.Drawing.Size(23, 16);
            this.lblRe.TabIndex = 119;
            this.lblRe.Text = "---";
            // 
            // lblVa
            // 
            this.lblVa.AutoSize = true;
            this.lblVa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVa.Location = new System.Drawing.Point(533, 79);
            this.lblVa.Name = "lblVa";
            this.lblVa.Size = new System.Drawing.Size(23, 16);
            this.lblVa.TabIndex = 118;
            this.lblVa.Text = "---";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(579, 220);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 20);
            this.label20.TabIndex = 117;
            this.label20.Text = "COLOSO";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(579, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 20);
            this.label21.TabIndex = 116;
            this.label21.Text = "VELAZQUEZ";
            // 
            // lblRena
            // 
            this.lblRena.AutoSize = true;
            this.lblRena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRena.Location = new System.Drawing.Point(579, 126);
            this.lblRena.Name = "lblRena";
            this.lblRena.Size = new System.Drawing.Size(54, 20);
            this.lblRena.TabIndex = 115;
            this.lblRena.Text = "RENA";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(579, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 20);
            this.label23.TabIndex = 114;
            this.label23.Text = "VALLARTA";
            // 
            // tb_Apa
            // 
            this.tb_Apa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Apa.Location = new System.Drawing.Point(190, 258);
            this.tb_Apa.Name = "tb_Apa";
            this.tb_Apa.Size = new System.Drawing.Size(298, 29);
            this.tb_Apa.TabIndex = 105;
            this.tb_Apa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Apa_KeyPress);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(588, 563);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(93, 41);
            this.btGuardar.TabIndex = 113;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "Id Empleado";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "CAJAS",
            "PISO DE VENTA",
            "BODEGA"});
            this.cbRol.Location = new System.Drawing.Point(190, 433);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(121, 21);
            this.cbRol.TabIndex = 112;
            // 
            // tb_idEmpleado
            // 
            this.tb_idEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idEmpleado.Location = new System.Drawing.Point(190, 79);
            this.tb_idEmpleado.Name = "tb_idEmpleado";
            this.tb_idEmpleado.Size = new System.Drawing.Size(135, 29);
            this.tb_idEmpleado.TabIndex = 100;
            this.tb_idEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_idEmpleado_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 24);
            this.label7.TabIndex = 111;
            this.label7.Text = "Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 101;
            this.label2.Text = "Id Checador";
            // 
            // tb_Salario
            // 
            this.tb_Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salario.Location = new System.Drawing.Point(190, 374);
            this.tb_Salario.Name = "tb_Salario";
            this.tb_Salario.Size = new System.Drawing.Size(158, 29);
            this.tb_Salario.TabIndex = 110;
            this.tb_Salario.Text = "1";
            this.tb_Salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Salario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 102;
            this.label3.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 109;
            this.label6.Text = "Salario";
            // 
            // tb_IdChecador
            // 
            this.tb_IdChecador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IdChecador.Location = new System.Drawing.Point(190, 134);
            this.tb_IdChecador.Name = "tb_IdChecador";
            this.tb_IdChecador.Size = new System.Drawing.Size(135, 29);
            this.tb_IdChecador.TabIndex = 103;
            this.tb_IdChecador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IdChecador_KeyPress);
            // 
            // tb_Ama
            // 
            this.tb_Ama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ama.Location = new System.Drawing.Point(190, 318);
            this.tb_Ama.Name = "tb_Ama";
            this.tb_Ama.Size = new System.Drawing.Size(298, 29);
            this.tb_Ama.TabIndex = 108;
            this.tb_Ama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Ama_KeyPress);
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nombre.Location = new System.Drawing.Point(190, 194);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(298, 29);
            this.tb_Nombre.TabIndex = 104;
            this.tb_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 107;
            this.label5.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 106;
            this.label4.Text = "Apellido Paterno";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1192, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 98;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8,
            this.Column9});
            this.dgvEmpleados.Location = new System.Drawing.Point(697, 47);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(656, 510);
            this.dgvEmpleados.TabIndex = 97;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Empleado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id Checador";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Apellido Paterno";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Apellido Materno";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Salario";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Salario";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Rol";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Patron";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // frm_agregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1365, 613);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPatron);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.ckbNuevoEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.lblBo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.lblVL);
            this.Controls.Add(this.lblRe);
            this.Controls.Add(this.lblVa);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblRena);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tb_Apa);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.tb_idEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Salario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_IdChecador);
            this.Controls.Add(this.tb_Ama);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "frm_agregarEmpleado";
            this.Text = "frm_agregarEmpleado";
            this.Load += new System.EventHandler(this.frm_agregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPatron;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.CheckBox ckbNuevoEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label lblBo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.Label lblVL;
        private System.Windows.Forms.Label lblRe;
        private System.Windows.Forms.Label lblVa;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblRena;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_Apa;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.TextBox tb_idEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Salario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_IdChecador;
        private System.Windows.Forms.TextBox tb_Ama;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}