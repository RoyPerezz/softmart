namespace appSugerencias.Comisiones.Vista
{
    partial class VRol
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
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.Acciones = new System.Windows.Forms.GroupBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBCalificaxSemana = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbRol = new System.Windows.Forms.TextBox();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.Acciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Controls.Add(this.btBuscar);
            this.Buscar.Controls.Add(this.tbBuscar);
            this.Buscar.Location = new System.Drawing.Point(686, 99);
            this.Buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buscar.Size = new System.Drawing.Size(368, 67);
            this.Buscar.TabIndex = 5;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(242, 26);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(107, 31);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(7, 28);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBuscar.Multiline = true;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(208, 24);
            this.tbBuscar.TabIndex = 0;
            // 
            // dgvRoles
            // 
            this.dgvRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(12, 98);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(649, 513);
            this.dgvRoles.TabIndex = 4;
            this.dgvRoles.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoles_CellMouseDoubleClick);
            // 
            // Acciones
            // 
            this.Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Acciones.Controls.Add(this.btEliminar);
            this.Acciones.Controls.Add(this.btModificar);
            this.Acciones.Controls.Add(this.btNuevo);
            this.Acciones.Location = new System.Drawing.Point(686, 13);
            this.Acciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Acciones.Name = "Acciones";
            this.Acciones.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Acciones.Size = new System.Drawing.Size(369, 78);
            this.Acciones.TabIndex = 3;
            this.Acciones.TabStop = false;
            this.Acciones.Text = "Acciones";
            this.Acciones.Enter += new System.EventHandler(this.Acciones_Enter);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(257, 28);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(104, 33);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Baja";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(131, 30);
            this.btModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(104, 31);
            this.btModificar.TabIndex = 1;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(7, 28);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(104, 34);
            this.btNuevo.TabIndex = 0;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Roles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seccion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkBCalificaxSemana);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Controls.Add(this.tbRol);
            this.groupBox1.Location = new System.Drawing.Point(686, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(368, 225);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar/Editar";
            // 
            // chkBCalificaxSemana
            // 
            this.chkBCalificaxSemana.AutoSize = true;
            this.chkBCalificaxSemana.Location = new System.Drawing.Point(10, 130);
            this.chkBCalificaxSemana.Name = "chkBCalificaxSemana";
            this.chkBCalificaxSemana.Size = new System.Drawing.Size(71, 24);
            this.chkBCalificaxSemana.TabIndex = 7;
            this.chkBCalificaxSemana.Text = "Activo";
            this.chkBCalificaxSemana.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Este Rol se califica por semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(231, 165);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(108, 38);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(35, 165);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(108, 38);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbRol
            // 
            this.tbRol.Location = new System.Drawing.Point(7, 61);
            this.tbRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbRol.Multiline = true;
            this.tbRol.Name = "tbRol";
            this.tbRol.Size = new System.Drawing.Size(280, 24);
            this.tbRol.TabIndex = 0;
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // VRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.Acciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VRol";
            this.Text = "VRol";
            this.Load += new System.EventHandler(this.VRol_Load);
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.Acciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.GroupBox Acciones;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBCalificaxSemana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbRol;
        private System.Windows.Forms.ErrorProvider eprError;
    }
}