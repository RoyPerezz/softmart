
namespace appSugerencias.Gastos_Externos.Vistas
{
    partial class RegistrarPersonaGeneraGasto
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
            this.BT_registrar = new System.Windows.Forms.Button();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_nombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_modificar_nombre = new System.Windows.Forms.TextBox();
            this.BT_modificar = new System.Windows.Forms.Button();
            this.TB_buscar_nombre = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_registrar
            // 
            this.BT_registrar.Location = new System.Drawing.Point(276, 189);
            this.BT_registrar.Name = "BT_registrar";
            this.BT_registrar.Size = new System.Drawing.Size(81, 34);
            this.BT_registrar.TabIndex = 0;
            this.BT_registrar.Text = "Registrar";
            this.BT_registrar.UseVisualStyleBackColor = true;
            this.BT_registrar.Click += new System.EventHandler(this.BT_registrar_Click);
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE});
            this.DG_tabla.Location = new System.Drawing.Point(411, -1);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(389, 452);
            this.DG_tabla.TabIndex = 1;
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE COMPLETO";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 451);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TB_nombre);
            this.tabPage1.Controls.Add(this.BT_registrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Persona";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la persona que genera el gasto";
            // 
            // TB_nombre
            // 
            this.TB_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_nombre.Location = new System.Drawing.Point(29, 154);
            this.TB_nombre.Name = "TB_nombre";
            this.TB_nombre.Size = new System.Drawing.Size(328, 29);
            this.TB_nombre.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BT_eliminar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TB_buscar_nombre);
            this.tabPage2.Controls.Add(this.Buscar);
            this.tabPage2.Controls.Add(this.TB_id);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TB_modificar_nombre);
            this.tabPage2.Controls.Add(this.BT_modificar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TB_id
            // 
            this.TB_id.Enabled = false;
            this.TB_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_id.Location = new System.Drawing.Point(315, 140);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(49, 29);
            this.TB_id.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de la persona que genera el gasto";
            // 
            // TB_modificar_nombre
            // 
            this.TB_modificar_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_modificar_nombre.Location = new System.Drawing.Point(36, 175);
            this.TB_modificar_nombre.Name = "TB_modificar_nombre";
            this.TB_modificar_nombre.Size = new System.Drawing.Size(328, 29);
            this.TB_modificar_nombre.TabIndex = 4;
            // 
            // BT_modificar
            // 
            this.BT_modificar.Location = new System.Drawing.Point(189, 210);
            this.BT_modificar.Name = "BT_modificar";
            this.BT_modificar.Size = new System.Drawing.Size(81, 34);
            this.BT_modificar.TabIndex = 3;
            this.BT_modificar.Text = "Modificar";
            this.BT_modificar.UseVisualStyleBackColor = true;
            this.BT_modificar.Click += new System.EventHandler(this.BT_modificar_Click);
            // 
            // TB_buscar_nombre
            // 
            this.TB_buscar_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_buscar_nombre.Location = new System.Drawing.Point(36, 45);
            this.TB_buscar_nombre.Name = "TB_buscar_nombre";
            this.TB_buscar_nombre.Size = new System.Drawing.Size(328, 29);
            this.TB_buscar_nombre.TabIndex = 8;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(283, 80);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(81, 34);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar persona";
            // 
            // BT_eliminar
            // 
            this.BT_eliminar.Location = new System.Drawing.Point(283, 210);
            this.BT_eliminar.Name = "BT_eliminar";
            this.BT_eliminar.Size = new System.Drawing.Size(81, 34);
            this.BT_eliminar.TabIndex = 10;
            this.BT_eliminar.Text = "Eliminar";
            this.BT_eliminar.UseVisualStyleBackColor = true;
            this.BT_eliminar.Click += new System.EventHandler(this.BT_eliminar_Click);
            // 
            // RegistrarPersonaGeneraGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DG_tabla);
            this.Name = "RegistrarPersonaGeneraGasto";
            this.Text = "RegistrarPersonaGeneraGasto";
            this.Load += new System.EventHandler(this.RegistrarPersonaGeneraGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_registrar;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_nombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_modificar_nombre;
        private System.Windows.Forms.Button BT_modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_buscar_nombre;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button BT_eliminar;
    }
}