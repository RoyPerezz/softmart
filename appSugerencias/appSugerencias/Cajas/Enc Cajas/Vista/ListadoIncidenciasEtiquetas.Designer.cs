
namespace appSugerencias.Cajas.Enc_Cajas.Vista
{
    partial class ListadoIncidenciasEtiquetas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INCIDENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUTAFOTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREFOTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DT_inicio
            // 
            this.DT_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_inicio.Location = new System.Drawing.Point(129, 19);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 0;
            this.DT_inicio.ValueChanged += new System.EventHandler(this.DT_inicio_ValueChanged);
            // 
            // DT_fin
            // 
            this.DT_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_fin.Location = new System.Drawing.Point(129, 45);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 1;
            this.DT_fin.ValueChanged += new System.EventHandler(this.DT_fin_ValueChanged);
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ARTICULO,
            this.DESCRIPCION,
            this.FECHA,
            this.USUARIO,
            this.CAJA,
            this.INCIDENCIA,
            this.RUTAFOTO,
            this.NOMBREFOTO});
            this.DG_tabla.Location = new System.Drawing.Point(1, 92);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(799, 357);
            this.DG_tabla.TabIndex = 2;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentClick);
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ARTICULO
            // 
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // FECHA
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle3;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // USUARIO
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.USUARIO.DefaultCellStyle = dataGridViewCellStyle4;
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            // 
            // CAJA
            // 
            this.CAJA.HeaderText = "CAJA";
            this.CAJA.Name = "CAJA";
            // 
            // INCIDENCIA
            // 
            this.INCIDENCIA.HeaderText = "INCIDENCIA";
            this.INCIDENCIA.Name = "INCIDENCIA";
            // 
            // RUTAFOTO
            // 
            this.RUTAFOTO.HeaderText = "RUTA FOTO";
            this.RUTAFOTO.Name = "RUTAFOTO";
            this.RUTAFOTO.Visible = false;
            // 
            // NOMBREFOTO
            // 
            this.NOMBREFOTO.HeaderText = "NOMBRE FOTO";
            this.NOMBREFOTO.Name = "NOMBREFOTO";
            this.NOMBREFOTO.Visible = false;
            // 
            // BT_buscar
            // 
            this.BT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(8, 19);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(115, 46);
            this.BT_buscar.TabIndex = 3;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_exportar.BackColor = System.Drawing.Color.Green;
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(673, 19);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(115, 46);
            this.BT_exportar.TabIndex = 4;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // ListadoIncidenciasEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Name = "ListadoIncidenciasEtiquetas";
            this.Text = "ListadoIncidenciasEtiquetas";
            this.Load += new System.EventHandler(this.ListadoIncidenciasEtiquetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCIDENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUTAFOTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREFOTO;
        private System.Windows.Forms.Button BT_exportar;
    }
}