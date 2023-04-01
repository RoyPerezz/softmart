namespace appSugerencias
{
    partial class AltaEmpBodega
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_nombre = new System.Windows.Forms.TextBox();
            this.CB_puesto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_registrar = new System.Windows.Forms.Button();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Buscar = new System.Windows.Forms.Button();
            this.BT_modificar = new System.Windows.Forms.Button();
            this.BT_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellidos";
            // 
            // TB_nombre
            // 
            this.TB_nombre.Location = new System.Drawing.Point(12, 101);
            this.TB_nombre.Name = "TB_nombre";
            this.TB_nombre.Size = new System.Drawing.Size(399, 20);
            this.TB_nombre.TabIndex = 1;
            // 
            // CB_puesto
            // 
            this.CB_puesto.FormattingEnabled = true;
            this.CB_puesto.Items.AddRange(new object[] {
            "ETIQUETADOR",
            "BODEGUERO",
            "CUBRE"});
            this.CB_puesto.Location = new System.Drawing.Point(417, 100);
            this.CB_puesto.Name = "CB_puesto";
            this.CB_puesto.Size = new System.Drawing.Size(121, 21);
            this.CB_puesto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puesto";
            // 
            // BT_registrar
            // 
            this.BT_registrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_registrar.ForeColor = System.Drawing.Color.White;
            this.BT_registrar.Location = new System.Drawing.Point(12, 12);
            this.BT_registrar.Name = "BT_registrar";
            this.BT_registrar.Size = new System.Drawing.Size(89, 40);
            this.BT_registrar.TabIndex = 6;
            this.BT_registrar.Text = "Registrar";
            this.BT_registrar.UseVisualStyleBackColor = false;
            this.BT_registrar.Click += new System.EventHandler(this.BT_registrar_Click);
            // 
            // DG_tabla
            // 
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.PUESTO});
            this.DG_tabla.Location = new System.Drawing.Point(12, 127);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(526, 120);
            this.DG_tabla.TabIndex = 7;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentClick);
            this.DG_tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // PUESTO
            // 
            this.PUESTO.HeaderText = "PUESTO";
            this.PUESTO.Name = "PUESTO";
            // 
            // BT_Buscar
            // 
            this.BT_Buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Buscar.ForeColor = System.Drawing.Color.White;
            this.BT_Buscar.Location = new System.Drawing.Point(152, 12);
            this.BT_Buscar.Name = "BT_Buscar";
            this.BT_Buscar.Size = new System.Drawing.Size(89, 40);
            this.BT_Buscar.TabIndex = 8;
            this.BT_Buscar.Text = "Buscar";
            this.BT_Buscar.UseVisualStyleBackColor = false;
            this.BT_Buscar.Click += new System.EventHandler(this.BT_Buscar_Click);
            // 
            // BT_modificar
            // 
            this.BT_modificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_modificar.ForeColor = System.Drawing.Color.White;
            this.BT_modificar.Location = new System.Drawing.Point(295, 12);
            this.BT_modificar.Name = "BT_modificar";
            this.BT_modificar.Size = new System.Drawing.Size(89, 40);
            this.BT_modificar.TabIndex = 9;
            this.BT_modificar.Text = "Modificar";
            this.BT_modificar.UseVisualStyleBackColor = false;
            this.BT_modificar.Click += new System.EventHandler(this.BT_modificar_Click);
            // 
            // BT_eliminar
            // 
            this.BT_eliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar.ForeColor = System.Drawing.Color.White;
            this.BT_eliminar.Location = new System.Drawing.Point(449, 12);
            this.BT_eliminar.Name = "BT_eliminar";
            this.BT_eliminar.Size = new System.Drawing.Size(89, 40);
            this.BT_eliminar.TabIndex = 10;
            this.BT_eliminar.Text = "Eliminar";
            this.BT_eliminar.UseVisualStyleBackColor = false;
            this.BT_eliminar.Click += new System.EventHandler(this.BT_eliminar_Click);
            // 
            // AltaEmpBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(551, 260);
            this.Controls.Add(this.BT_eliminar);
            this.Controls.Add(this.BT_modificar);
            this.Controls.Add(this.BT_Buscar);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.BT_registrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_puesto);
            this.Controls.Add(this.TB_nombre);
            this.Controls.Add(this.label1);
            this.Name = "AltaEmpBodega";
            this.Text = "AltaEmpBodega";
            this.Load += new System.EventHandler(this.AltaEmpBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_nombre;
        private System.Windows.Forms.ComboBox CB_puesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_registrar;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_Buscar;
        private System.Windows.Forms.Button BT_modificar;
        private System.Windows.Forms.Button BT_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
    }
}