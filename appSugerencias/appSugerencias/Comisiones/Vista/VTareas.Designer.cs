namespace appSugerencias.Comisiones.Vista
{
    partial class VTareas
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
            this.components = new System.ComponentModel.Container();
            this.Acciones = new System.Windows.Forms.GroupBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTopeSemanal = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.nudTopeDiario = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEliminar = new System.Windows.Forms.CheckBox();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudTopeSemanal = new System.Windows.Forms.NumericUpDown();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Acciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopeDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopeSemanal)).BeginInit();
            this.SuspendLayout();
            // 
            // Acciones
            // 
            this.Acciones.Controls.Add(this.btEliminar);
            this.Acciones.Controls.Add(this.btModificar);
            this.Acciones.Controls.Add(this.btNuevo);
            this.Acciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acciones.Location = new System.Drawing.Point(694, 115);
            this.Acciones.Name = "Acciones";
            this.Acciones.Size = new System.Drawing.Size(361, 69);
            this.Acciones.TabIndex = 2;
            this.Acciones.TabStop = false;
            this.Acciones.Text = "Acciones";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(254, 22);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(101, 32);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Baja";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(132, 22);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(101, 32);
            this.btModificar.TabIndex = 1;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(6, 22);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(101, 32);
            this.btNuevo.TabIndex = 0;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tareas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seccion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudTopeSemanal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudTopeDiario);
            this.groupBox1.Controls.Add(this.lblTopeSemanal);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(695, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 355);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar/Editar";
            // 
            // lblTopeSemanal
            // 
            this.lblTopeSemanal.AutoSize = true;
            this.lblTopeSemanal.Location = new System.Drawing.Point(0, 244);
            this.lblTopeSemanal.Name = "lblTopeSemanal";
            this.lblTopeSemanal.Size = new System.Drawing.Size(112, 20);
            this.lblTopeSemanal.TabIndex = 10;
            this.lblTopeSemanal.Text = "Tope Semanal";
            // 
            // btCancelar
            // 
            this.btCancelar.Enabled = false;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(214, 307);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(117, 32);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // tbRol
            // 
            this.tbRol.Location = new System.Drawing.Point(6, 50);
            this.tbRol.Multiline = true;
            this.tbRol.Name = "tbRol";
            this.tbRol.Size = new System.Drawing.Size(278, 27);
            this.tbRol.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol";
            // 
            // btGuardar
            // 
            this.btGuardar.Enabled = false;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(30, 307);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(117, 32);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(6, 106);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(348, 72);
            this.tbDescripcion.TabIndex = 0;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvTareas.Location = new System.Drawing.Point(13, 115);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(676, 499);
            this.dgvTareas.TabIndex = 12;
            this.dgvTareas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTareas_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRol);
            this.groupBox2.Controls.Add(this.btBuscar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(700, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Rol";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(254, 22);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(101, 32);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Consultar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(6, 26);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(221, 28);
            this.cbRol.TabIndex = 3;
            // 
            // nudTopeDiario
            // 
            this.nudTopeDiario.Location = new System.Drawing.Point(11, 211);
            this.nudTopeDiario.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTopeDiario.Name = "nudTopeDiario";
            this.nudTopeDiario.Size = new System.Drawing.Size(71, 26);
            this.nudTopeDiario.TabIndex = 12;
            this.nudTopeDiario.ValueChanged += new System.EventHandler(this.nudTopeDiario_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tope Diario";
            // 
            // cbxEliminar
            // 
            this.cbxEliminar.AutoSize = true;
            this.cbxEliminar.Location = new System.Drawing.Point(13, 91);
            this.cbxEliminar.Name = "cbxEliminar";
            this.cbxEliminar.Size = new System.Drawing.Size(74, 20);
            this.cbxEliminar.TabIndex = 16;
            this.cbxEliminar.Text = "Eliminar";
            this.cbxEliminar.UseVisualStyleBackColor = true;
            this.cbxEliminar.CheckedChanged += new System.EventHandler(this.cbxEliminar_CheckedChanged);
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // nudTopeSemanal
            // 
            this.nudTopeSemanal.Location = new System.Drawing.Point(11, 267);
            this.nudTopeSemanal.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudTopeSemanal.Name = "nudTopeSemanal";
            this.nudTopeSemanal.Size = new System.Drawing.Size(71, 26);
            this.nudTopeSemanal.TabIndex = 14;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // VTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 624);
            this.Controls.Add(this.cbxEliminar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.Acciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VTareas";
            this.Text = "VTareas";
            this.Load += new System.EventHandler(this.VTareas_Load);
            this.Acciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTopeDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopeSemanal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Acciones;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTopeSemanal;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTopeDiario;
        private System.Windows.Forms.CheckBox cbxEliminar;
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.NumericUpDown nudTopeSemanal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}