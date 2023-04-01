
namespace appSugerencias.Gastos
{
    partial class AprobacionGastosGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_excel = new System.Windows.Forms.Button();
            this.LB_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.BT_aprobar = new System.Windows.Forms.Button();
            this.BT_gastosXAprobar = new System.Windows.Forms.Button();
            this.ESTADO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENCCAJAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTOGRAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTODETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOTO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOTO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMAUTORIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_aprobar);
            this.groupBox2.Controls.Add(this.BT_guardar);
            this.groupBox2.Location = new System.Drawing.Point(694, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 148);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guardar Estado";
            // 
            // BT_guardar
            // 
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(75, 85);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(96, 45);
            this.BT_guardar.TabIndex = 3;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DT_inicio);
            this.groupBox1.Controls.Add(this.DT_fin);
            this.groupBox1.Controls.Add(this.BT_buscar);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 148);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda gastos";
            // 
            // DT_inicio
            // 
            this.DT_inicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_inicio.Location = new System.Drawing.Point(146, 40);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(484, 35);
            this.DT_inicio.TabIndex = 2;
            // 
            // DT_fin
            // 
            this.DT_fin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fin.Location = new System.Drawing.Point(146, 81);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(484, 35);
            this.DT_fin.TabIndex = 1;
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(9, 41);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(131, 75);
            this.BT_buscar.TabIndex = 0;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(1245, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 148);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total gastos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.BT_excel);
            this.panel1.Controls.Add(this.LB_total);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 123);
            this.panel1.TabIndex = 0;
            // 
            // BT_excel
            // 
            this.BT_excel.BackColor = System.Drawing.Color.Green;
            this.BT_excel.ForeColor = System.Drawing.Color.White;
            this.BT_excel.Location = new System.Drawing.Point(190, 4);
            this.BT_excel.Name = "BT_excel";
            this.BT_excel.Size = new System.Drawing.Size(86, 38);
            this.BT_excel.TabIndex = 11;
            this.BT_excel.Text = "Excel";
            this.BT_excel.UseVisualStyleBackColor = false;
            this.BT_excel.Visible = false;
            // 
            // LB_total
            // 
            this.LB_total.AutoSize = true;
            this.LB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_total.ForeColor = System.Drawing.Color.White;
            this.LB_total.Location = new System.Drawing.Point(55, 61);
            this.LB_total.Name = "LB_total";
            this.LB_total.Size = new System.Drawing.Size(0, 29);
            this.LB_total.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL";
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESTADO,
            this.ID,
            this.ENCCAJAS,
            this.USUARIO,
            this.FECHA,
            this.IMPORTE,
            this.PERSONA,
            this.DESCRIPCION,
            this.CONCEPTOGRAL,
            this.CONCEPTODETALLE,
            this.FOLIO,
            this.FOTO1,
            this.FOTO2,
            this.COMENTARIO,
            this.NUMAUTORIZACION});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle12;
            this.DG_tabla.Location = new System.Drawing.Point(1, 153);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1536, 379);
            this.DG_tabla.TabIndex = 18;
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // BT_aprobar
            // 
            this.BT_aprobar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_aprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_aprobar.ForeColor = System.Drawing.Color.White;
            this.BT_aprobar.Location = new System.Drawing.Point(75, 34);
            this.BT_aprobar.Name = "BT_aprobar";
            this.BT_aprobar.Size = new System.Drawing.Size(96, 45);
            this.BT_aprobar.TabIndex = 4;
            this.BT_aprobar.Text = "Aprobar";
            this.BT_aprobar.UseVisualStyleBackColor = false;
            this.BT_aprobar.Click += new System.EventHandler(this.BT_aprobar_Click);
            // 
            // BT_gastosXAprobar
            // 
            this.BT_gastosXAprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_gastosXAprobar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_gastosXAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_gastosXAprobar.ForeColor = System.Drawing.Color.White;
            this.BT_gastosXAprobar.Location = new System.Drawing.Point(76, 50);
            this.BT_gastosXAprobar.Name = "BT_gastosXAprobar";
            this.BT_gastosXAprobar.Size = new System.Drawing.Size(129, 55);
            this.BT_gastosXAprobar.TabIndex = 5;
            this.BT_gastosXAprobar.Text = "Gastos por Aprobar";
            this.BT_gastosXAprobar.UseVisualStyleBackColor = false;
            this.BT_gastosXAprobar.Click += new System.EventHandler(this.BT_gastosXAprobar_Click);
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Items.AddRange(new object[] {
            "APROBADO",
            "RECHAZADO",
            "CORREGIDO",
            "EN REVISION"});
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ENCCAJAS
            // 
            this.ENCCAJAS.HeaderText = "ENC CAJAS";
            this.ENCCAJAS.Name = "ENCCAJAS";
            this.ENCCAJAS.Visible = false;
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Visible = false;
            // 
            // FECHA
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle8;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle9;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // PERSONA
            // 
            this.PERSONA.HeaderText = "GENERÓ GASTO";
            this.PERSONA.Name = "PERSONA";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // CONCEPTOGRAL
            // 
            this.CONCEPTOGRAL.HeaderText = "CONCEPTO GENERAL";
            this.CONCEPTOGRAL.Name = "CONCEPTOGRAL";
            // 
            // CONCEPTODETALLE
            // 
            this.CONCEPTODETALLE.HeaderText = "CONCEPTO DETALLE";
            this.CONCEPTODETALLE.Name = "CONCEPTODETALLE";
            // 
            // FOLIO
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FOLIO.DefaultCellStyle = dataGridViewCellStyle10;
            this.FOLIO.HeaderText = "FOLIO";
            this.FOLIO.Name = "FOLIO";
            // 
            // FOTO1
            // 
            this.FOTO1.HeaderText = "FOTO1";
            this.FOTO1.Name = "FOTO1";
            this.FOTO1.Visible = false;
            // 
            // FOTO2
            // 
            this.FOTO2.HeaderText = "FOTO2";
            this.FOTO2.Name = "FOTO2";
            this.FOTO2.Visible = false;
            // 
            // COMENTARIO
            // 
            this.COMENTARIO.HeaderText = "COMENTARIO";
            this.COMENTARIO.Name = "COMENTARIO";
            // 
            // NUMAUTORIZACION
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NUMAUTORIZACION.DefaultCellStyle = dataGridViewCellStyle11;
            this.NUMAUTORIZACION.HeaderText = "NUM AUTORIZACION";
            this.NUMAUTORIZACION.Name = "NUMAUTORIZACION";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.BT_gastosXAprobar);
            this.groupBox4.Location = new System.Drawing.Point(969, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 148);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Revisar gastos pendientes";
            // 
            // AprobacionGastosGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1538, 532);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DG_tabla);
            this.Name = "AprobacionGastosGeneral";
            this.Text = "AprobaciónGastosGeneral";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_excel;
        private System.Windows.Forms.Label LB_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_aprobar;
        private System.Windows.Forms.Button BT_gastosXAprobar;
        private System.Windows.Forms.DataGridViewComboBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENCCAJAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTOGRAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTODETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOLIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOTO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOTO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMAUTORIZACION;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}