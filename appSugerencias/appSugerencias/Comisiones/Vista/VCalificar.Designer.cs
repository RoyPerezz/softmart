namespace appSugerencias.Comisiones.Vista
{
    partial class VCalificar
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btGuardar = new System.Windows.Forms.Button();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFechas = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btEditarCalif = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbSemana = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbFechasReporte = new System.Windows.Forms.Label();
            this.dtpFechaRevision = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btGenerarReporte = new System.Windows.Forms.Button();
            this.lblFechaReporte2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbRolReporte = new System.Windows.Forms.ComboBox();
            this.dgvRevisionCalif = new System.Windows.Forms.DataGridView();
            this.dgvRevisarTareas = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisionCalif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisarTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tareas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Seccion:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 557);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btGuardar);
            this.tabPage1.Controls.Add(this.dgvCalificaciones);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generar Calificación";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(933, 475);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(102, 32);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.Location = new System.Drawing.Point(16, 137);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.Size = new System.Drawing.Size(1020, 335);
            this.dgvCalificaciones.TabIndex = 6;
            this.dgvCalificaciones.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCalificaciones_CellValidating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbFechas);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(424, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Inicio";
            // 
            // lbFechas
            // 
            this.lbFechas.AutoSize = true;
            this.lbFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechas.Location = new System.Drawing.Point(108, 86);
            this.lbFechas.Name = "lbFechas";
            this.lbFechas.Size = new System.Drawing.Size(60, 24);
            this.lbFechas.TabIndex = 2;
            this.lbFechas.Text = "label1";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(185, 52);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(336, 26);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(185, 20);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(336, 26);
            this.dtpFechaInicial.TabIndex = 0;
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRol);
            this.groupBox2.Controls.Add(this.btBuscar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Rol";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(16, 43);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(221, 28);
            this.cbRol.TabIndex = 3;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(256, 43);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(101, 32);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Consultar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Controls.Add(this.lblCodigo);
            this.tabPage2.Controls.Add(this.dgvRevisarTareas);
            this.tabPage2.Controls.Add(this.btEditarCalif);
            this.tabPage2.Controls.Add(this.dgvRevisionCalif);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Revisar Calificación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(714, 129);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 18);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "label6";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(714, 111);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 18);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "label1";
            // 
            // btEditarCalif
            // 
            this.btEditarCalif.Location = new System.Drawing.Point(898, 459);
            this.btEditarCalif.Name = "btEditarCalif";
            this.btEditarCalif.Size = new System.Drawing.Size(118, 45);
            this.btEditarCalif.TabIndex = 8;
            this.btEditarCalif.Text = "Editar";
            this.btEditarCalif.UseVisualStyleBackColor = true;
            this.btEditarCalif.Click += new System.EventHandler(this.btEditarCalif_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckbSemana);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lbFechasReporte);
            this.groupBox3.Controls.Add(this.dtpFechaRevision);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(996, 98);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Rol";
            // 
            // ckbSemana
            // 
            this.ckbSemana.AutoSize = true;
            this.ckbSemana.Location = new System.Drawing.Point(526, 36);
            this.ckbSemana.Name = "ckbSemana";
            this.ckbSemana.Size = new System.Drawing.Size(171, 24);
            this.ckbSemana.TabIndex = 12;
            this.ckbSemana.Text = "Revisar Encargados";
            this.ckbSemana.UseVisualStyleBackColor = true;
            this.ckbSemana.CheckedChanged += new System.EventHandler(this.ckbSemana_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbFechasReporte
            // 
            this.lbFechasReporte.AutoSize = true;
            this.lbFechasReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechasReporte.Location = new System.Drawing.Point(23, 68);
            this.lbFechasReporte.Name = "lbFechasReporte";
            this.lbFechasReporte.Size = new System.Drawing.Size(60, 24);
            this.lbFechasReporte.TabIndex = 2;
            this.lbFechasReporte.Text = "label1";
            // 
            // dtpFechaRevision
            // 
            this.dtpFechaRevision.Location = new System.Drawing.Point(18, 26);
            this.dtpFechaRevision.Name = "dtpFechaRevision";
            this.dtpFechaRevision.Size = new System.Drawing.Size(336, 26);
            this.dtpFechaRevision.TabIndex = 0;
            this.dtpFechaRevision.ValueChanged += new System.EventHandler(this.dtpFechaRevision_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btGenerarReporte);
            this.tabPage3.Controls.Add(this.lblFechaReporte2);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.dgvReporte);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1042, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btGenerarReporte
            // 
            this.btGenerarReporte.Location = new System.Drawing.Point(910, 448);
            this.btGenerarReporte.Name = "btGenerarReporte";
            this.btGenerarReporte.Size = new System.Drawing.Size(120, 52);
            this.btGenerarReporte.TabIndex = 7;
            this.btGenerarReporte.Text = "Generar Reporte";
            this.btGenerarReporte.UseVisualStyleBackColor = true;
            this.btGenerarReporte.Click += new System.EventHandler(this.btGenerarReporte_Click);
            // 
            // lblFechaReporte2
            // 
            this.lblFechaReporte2.AutoSize = true;
            this.lblFechaReporte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReporte2.Location = new System.Drawing.Point(13, 90);
            this.lblFechaReporte2.Name = "lblFechaReporte2";
            this.lblFechaReporte2.Size = new System.Drawing.Size(60, 24);
            this.lblFechaReporte2.TabIndex = 2;
            this.lblFechaReporte2.Text = "label1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(649, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 41);
            this.button5.TabIndex = 2;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(11, 130);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(1020, 312);
            this.dgvReporte.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpFechaReporte);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 67);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fecha Inicial de la Semana";
            // 
            // dtpFechaReporte
            // 
            this.dtpFechaReporte.Location = new System.Drawing.Point(6, 28);
            this.dtpFechaReporte.Name = "dtpFechaReporte";
            this.dtpFechaReporte.Size = new System.Drawing.Size(336, 26);
            this.dtpFechaReporte.TabIndex = 0;
            this.dtpFechaReporte.ValueChanged += new System.EventHandler(this.dtpFechaReporte_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbRolReporte);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(383, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 67);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rol";
            // 
            // cbRolReporte
            // 
            this.cbRolReporte.FormattingEnabled = true;
            this.cbRolReporte.Location = new System.Drawing.Point(6, 26);
            this.cbRolReporte.Name = "cbRolReporte";
            this.cbRolReporte.Size = new System.Drawing.Size(209, 28);
            this.cbRolReporte.TabIndex = 3;
            // 
            // dgvRevisionCalif
            // 
            this.dgvRevisionCalif.AllowUserToAddRows = false;
            this.dgvRevisionCalif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevisionCalif.Location = new System.Drawing.Point(20, 154);
            this.dgvRevisionCalif.Name = "dgvRevisionCalif";
            this.dgvRevisionCalif.Size = new System.Drawing.Size(671, 299);
            this.dgvRevisionCalif.TabIndex = 7;
            this.dgvRevisionCalif.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRevisionCalif_CellDoubleClick);
            // 
            // dgvRevisarTareas
            // 
            this.dgvRevisarTareas.AllowUserToAddRows = false;
            this.dgvRevisarTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevisarTareas.Location = new System.Drawing.Point(714, 154);
            this.dgvRevisarTareas.Name = "dgvRevisarTareas";
            this.dgvRevisarTareas.Size = new System.Drawing.Size(302, 299);
            this.dgvRevisarTareas.TabIndex = 11;
            // 
            // VCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 624);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VCalificar";
            this.Text = "VCalificar";
            this.Load += new System.EventHandler(this.VCalificar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisionCalif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisarTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbFechas;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEditarCalif;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbSemana;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbFechasReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaRevision;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btGenerarReporte;
        private System.Windows.Forms.Label lblFechaReporte2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpFechaReporte;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbRolReporte;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvRevisarTareas;
        private System.Windows.Forms.DataGridView dgvRevisionCalif;
    }
}