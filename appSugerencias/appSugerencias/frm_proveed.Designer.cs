namespace appSugerencias
{
    partial class frm_proveed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_actualiza = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.tbColonia = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbCredito = new System.Windows.Forms.TextBox();
            this.tbRFC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRFC = new System.Windows.Forms.DataGridView();
            this.tbRFCBusqueda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblVl = new System.Windows.Forms.Label();
            this.lblCo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblVa = new System.Windows.Forms.Label();
            this.lblRe = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFC)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(771, 55);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(405, 20);
            this.tbNombre.TabIndex = 105;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(906, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 13);
            this.label15.TabIndex = 103;
            this.label15.Text = "Sin guiones ni  caracteres -#$/()";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1113, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 101;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_actualiza
            // 
            this.btn_actualiza.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_actualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualiza.ForeColor = System.Drawing.Color.White;
            this.btn_actualiza.Location = new System.Drawing.Point(982, 461);
            this.btn_actualiza.Name = "btn_actualiza";
            this.btn_actualiza.Size = new System.Drawing.Size(156, 53);
            this.btn_actualiza.TabIndex = 100;
            this.btn_actualiza.Text = "Actualizar Datos";
            this.btn_actualiza.UseVisualStyleBackColor = false;
            this.btn_actualiza.Click += new System.EventHandler(this.btn_actualiza_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Location = new System.Drawing.Point(771, 461);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(142, 53);
            this.btn_nuevo.TabIndex = 99;
            this.btn_nuevo.Text = "Nuevo Cliente";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(771, 222);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(118, 20);
            this.tbEstado.TabIndex = 83;
            this.tbEstado.Text = "GUERRERO";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(771, 397);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(259, 20);
            this.tbEmail.TabIndex = 91;
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(771, 358);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(73, 20);
            this.tbCP.TabIndex = 90;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(771, 324);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(311, 20);
            this.tbTelefono.TabIndex = 88;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(771, 290);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(118, 20);
            this.tbPais.TabIndex = 86;
            this.tbPais.Text = "MEXICO";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(771, 256);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(164, 20);
            this.tbLocalidad.TabIndex = 84;
            this.tbLocalidad.Text = "ACAPULCO DE JUAREZ";
            // 
            // tbColonia
            // 
            this.tbColonia.Location = new System.Drawing.Point(771, 171);
            this.tbColonia.Multiline = true;
            this.tbColonia.Name = "tbColonia";
            this.tbColonia.Size = new System.Drawing.Size(405, 32);
            this.tbColonia.TabIndex = 77;
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(771, 121);
            this.tbCalle.Multiline = true;
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(405, 36);
            this.tbCalle.TabIndex = 76;
            // 
            // tbCredito
            // 
            this.tbCredito.Location = new System.Drawing.Point(771, 87);
            this.tbCredito.Name = "tbCredito";
            this.tbCredito.Size = new System.Drawing.Size(118, 20);
            this.tbCredito.TabIndex = 75;
            // 
            // tbRFC
            // 
            this.tbRFC.Location = new System.Drawing.Point(771, 20);
            this.tbRFC.Name = "tbRFC";
            this.tbRFC.Size = new System.Drawing.Size(129, 20);
            this.tbRFC.TabIndex = 74;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(434, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 61);
            this.button1.TabIndex = 73;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRFC
            // 
            this.dgvRFC.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRFC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRFC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRFC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column1});
            this.dgvRFC.Location = new System.Drawing.Point(21, 110);
            this.dgvRFC.Name = "dgvRFC";
            this.dgvRFC.ReadOnly = true;
            this.dgvRFC.Size = new System.Drawing.Size(593, 461);
            this.dgvRFC.TabIndex = 72;
            this.dgvRFC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRFC_CellDoubleClick);
            // 
            // tbRFCBusqueda
            // 
            this.tbRFCBusqueda.Location = new System.Drawing.Point(127, 49);
            this.tbRFCBusqueda.Name = "tbRFCBusqueda";
            this.tbRFCBusqueda.Size = new System.Drawing.Size(262, 20);
            this.tbRFCBusqueda.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(981, 553);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 107;
            this.label12.Text = "RE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(939, 553);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 20);
            this.label13.TabIndex = 108;
            this.label13.Text = "VA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(1107, 553);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 20);
            this.label17.TabIndex = 109;
            this.label17.Text = "VA";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(1064, 553);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 20);
            this.label18.TabIndex = 110;
            this.label18.Text = "CO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(1024, 553);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 20);
            this.label19.TabIndex = 111;
            this.label19.Text = "VL";
            // 
            // lblVl
            // 
            this.lblVl.AutoSize = true;
            this.lblVl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVl.ForeColor = System.Drawing.Color.Black;
            this.lblVl.Location = new System.Drawing.Point(1027, 578);
            this.lblVl.Name = "lblVl";
            this.lblVl.Size = new System.Drawing.Size(14, 18);
            this.lblVl.TabIndex = 116;
            this.lblVl.Text = "-";
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCo.ForeColor = System.Drawing.Color.Black;
            this.lblCo.Location = new System.Drawing.Point(1067, 578);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(14, 18);
            this.lblCo.TabIndex = 115;
            this.lblCo.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(1110, 578);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 18);
            this.label22.TabIndex = 114;
            this.label22.Text = "VA";
            // 
            // lblVa
            // 
            this.lblVa.AutoSize = true;
            this.lblVa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVa.ForeColor = System.Drawing.Color.Black;
            this.lblVa.Location = new System.Drawing.Point(942, 578);
            this.lblVa.Name = "lblVa";
            this.lblVa.Size = new System.Drawing.Size(14, 18);
            this.lblVa.TabIndex = 113;
            this.lblVa.Text = "-";
            // 
            // lblRe
            // 
            this.lblRe.AutoSize = true;
            this.lblRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRe.ForeColor = System.Drawing.Color.Black;
            this.lblRe.Location = new System.Drawing.Point(984, 578);
            this.lblRe.Name = "lblRe";
            this.lblRe.Size = new System.Drawing.Size(14, 18);
            this.lblRe.TabIndex = 112;
            this.lblRe.Text = "-";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Proveedor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Razon Social";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 290;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RFC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(711, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 16);
            this.label20.TabIndex = 117;
            this.label20.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(686, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 118;
            this.label3.Text = "Nombre";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(633, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 16);
            this.label21.TabIndex = 119;
            this.label21.Text = "Dias de Credito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 120;
            this.label2.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(686, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 121;
            this.label4.Text = "Colonia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(692, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 16);
            this.label16.TabIndex = 122;
            this.label16.Text = "Estado";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(672, 256);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 16);
            this.label23.TabIndex = 123;
            this.label23.Text = "Localidad";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(710, 294);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 16);
            this.label24.TabIndex = 124;
            this.label24.Text = "Pais";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(679, 328);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 16);
            this.label25.TabIndex = 125;
            this.label25.Text = "Telefono";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(643, 362);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 16);
            this.label26.TabIndex = 126;
            this.label26.Text = "Codigo Postal";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(620, 401);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(137, 16);
            this.label27.TabIndex = 127;
            this.label27.Text = "Correo Electronico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 128;
            this.label5.Text = "Proveedor";
            // 
            // frm_proveed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1208, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblVl);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblVa);
            this.Controls.Add(this.lblRe);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_actualiza);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.tbColonia);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.tbCredito);
            this.Controls.Add(this.tbRFC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRFC);
            this.Controls.Add(this.tbRFCBusqueda);
            this.Name = "frm_proveed";
            this.Text = "frm_proveed";
            this.Load += new System.EventHandler(this.frm_proveed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_actualiza;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.TextBox tbColonia;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.TextBox tbCredito;
        private System.Windows.Forms.TextBox tbRFC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRFC;
        private System.Windows.Forms.TextBox tbRFCBusqueda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblVl;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblVa;
        private System.Windows.Forms.Label lblRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label5;
    }
}