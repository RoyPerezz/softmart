namespace appSugerencias
{
    partial class EliminarCalifBod
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
            this.BT_eliminar = new System.Windows.Forms.Button();
            this.CB_empleados = new System.Windows.Forms.ComboBox();
            this.TB_idemp = new System.Windows.Forms.TextBox();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCARGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAJA_SURTIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_califEtiquetador = new System.Windows.Forms.Button();
            this.TB_registro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_eliminarCalifEtiquetador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_eliminar
            // 
            this.BT_eliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar.ForeColor = System.Drawing.Color.White;
            this.BT_eliminar.Location = new System.Drawing.Point(463, 57);
            this.BT_eliminar.Name = "BT_eliminar";
            this.BT_eliminar.Size = new System.Drawing.Size(106, 51);
            this.BT_eliminar.TabIndex = 0;
            this.BT_eliminar.Text = "Eliminar";
            this.BT_eliminar.UseVisualStyleBackColor = false;
            this.BT_eliminar.Click += new System.EventHandler(this.BT_eliminar_Click);
            // 
            // CB_empleados
            // 
            this.CB_empleados.FormattingEnabled = true;
            this.CB_empleados.Location = new System.Drawing.Point(23, 30);
            this.CB_empleados.Name = "CB_empleados";
            this.CB_empleados.Size = new System.Drawing.Size(490, 21);
            this.CB_empleados.TabIndex = 1;
            this.CB_empleados.SelectedIndexChanged += new System.EventHandler(this.CB_empleados_SelectedIndexChanged);
            // 
            // TB_idemp
            // 
            this.TB_idemp.Location = new System.Drawing.Point(531, 30);
            this.TB_idemp.Name = "TB_idemp";
            this.TB_idemp.Size = new System.Drawing.Size(38, 20);
            this.TB_idemp.TabIndex = 2;
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(24, 83);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha";
            // 
            // DG_tabla
            // 
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REGISTRO,
            this.EMPLEADO,
            this.DESCARGA,
            this.CAJA_SURTIDA,
            this.TOTAL});
            this.DG_tabla.Location = new System.Drawing.Point(23, 181);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(545, 150);
            this.DG_tabla.TabIndex = 6;
            // 
            // REGISTRO
            // 
            this.REGISTRO.HeaderText = "REGISTRO";
            this.REGISTRO.Name = "REGISTRO";
            // 
            // EMPLEADO
            // 
            this.EMPLEADO.HeaderText = "EMPLEADO";
            this.EMPLEADO.Name = "EMPLEADO";
            // 
            // DESCARGA
            // 
            this.DESCARGA.HeaderText = "DESCARGA";
            this.DESCARGA.Name = "DESCARGA";
            // 
            // CAJA_SURTIDA
            // 
            this.CAJA_SURTIDA.HeaderText = "CAJA SURTIDA";
            this.CAJA_SURTIDA.Name = "CAJA_SURTIDA";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // BT_califEtiquetador
            // 
            this.BT_califEtiquetador.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_califEtiquetador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_califEtiquetador.ForeColor = System.Drawing.Color.White;
            this.BT_califEtiquetador.Location = new System.Drawing.Point(23, 134);
            this.BT_califEtiquetador.Name = "BT_califEtiquetador";
            this.BT_califEtiquetador.Size = new System.Drawing.Size(106, 41);
            this.BT_califEtiquetador.TabIndex = 7;
            this.BT_califEtiquetador.Text = "Calificacion Etiquetador";
            this.BT_califEtiquetador.UseVisualStyleBackColor = false;
            this.BT_califEtiquetador.Click += new System.EventHandler(this.BT_califEtiquetador_Click);
            // 
            // TB_registro
            // 
            this.TB_registro.Location = new System.Drawing.Point(415, 348);
            this.TB_registro.Name = "TB_registro";
            this.TB_registro.Size = new System.Drawing.Size(38, 20);
            this.TB_registro.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(20, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Captura el número de registro de la calificación que deseas eliminar";
            // 
            // BT_eliminarCalifEtiquetador
            // 
            this.BT_eliminarCalifEtiquetador.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_eliminarCalifEtiquetador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminarCalifEtiquetador.ForeColor = System.Drawing.Color.White;
            this.BT_eliminarCalifEtiquetador.Location = new System.Drawing.Point(463, 337);
            this.BT_eliminarCalifEtiquetador.Name = "BT_eliminarCalifEtiquetador";
            this.BT_eliminarCalifEtiquetador.Size = new System.Drawing.Size(106, 51);
            this.BT_eliminarCalifEtiquetador.TabIndex = 10;
            this.BT_eliminarCalifEtiquetador.Text = "Eliminar";
            this.BT_eliminarCalifEtiquetador.UseVisualStyleBackColor = false;
            this.BT_eliminarCalifEtiquetador.Click += new System.EventHandler(this.BT_eliminarCalifEtiquetador_Click);
            // 
            // EliminarCalifBod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(594, 432);
            this.Controls.Add(this.BT_eliminarCalifEtiquetador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_registro);
            this.Controls.Add(this.BT_califEtiquetador);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.TB_idemp);
            this.Controls.Add(this.CB_empleados);
            this.Controls.Add(this.BT_eliminar);
            this.Name = "EliminarCalifBod";
            this.Text = "Eliminar Calificación";
            this.Load += new System.EventHandler(this.EliminarCalifBod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_eliminar;
        private System.Windows.Forms.ComboBox CB_empleados;
        private System.Windows.Forms.TextBox TB_idemp;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCARGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAJA_SURTIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Button BT_califEtiquetador;
        private System.Windows.Forms.TextBox TB_registro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_eliminarCalifEtiquetador;
    }
}