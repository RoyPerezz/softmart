
namespace appSugerencias.Piso_de_venta.Vista
{
    partial class ReporteArticulosExistencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.CB_lineas = new System.Windows.Forms.ComboBox();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_MAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_MEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXISTENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REVISADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_cantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
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
            this.NUM,
            this.ARTICULO,
            this.DESCRIPCION,
            this.PRECIO_MAY,
            this.PRECIO_MEN,
            this.EXISTENCIA,
            this.REVISADO});
            this.DG_tabla.Location = new System.Drawing.Point(1, 112);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(798, 339);
            this.DG_tabla.TabIndex = 0;
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(12, 39);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(90, 46);
            this.BT_buscar.TabIndex = 1;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.CadetBlue;
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(134, 39);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(94, 46);
            this.BT_exportar.TabIndex = 2;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // CB_lineas
            // 
            this.CB_lineas.FormattingEnabled = true;
            this.CB_lineas.Location = new System.Drawing.Point(12, 12);
            this.CB_lineas.Name = "CB_lineas";
            this.CB_lineas.Size = new System.Drawing.Size(216, 21);
            this.CB_lineas.TabIndex = 3;
            this.CB_lineas.SelectedIndexChanged += new System.EventHandler(this.CB_lineas_SelectedIndexChanged);
            // 
            // NUM
            // 
            this.NUM.HeaderText = "NUM.";
            this.NUM.Name = "NUM";
            this.NUM.Visible = false;
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
            // PRECIO_MAY
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PRECIO_MAY.DefaultCellStyle = dataGridViewCellStyle4;
            this.PRECIO_MAY.HeaderText = "PRECIO MAY.";
            this.PRECIO_MAY.Name = "PRECIO_MAY";
            // 
            // PRECIO_MEN
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PRECIO_MEN.DefaultCellStyle = dataGridViewCellStyle5;
            this.PRECIO_MEN.HeaderText = "PRECIO MENUDEO";
            this.PRECIO_MEN.Name = "PRECIO_MEN";
            // 
            // EXISTENCIA
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EXISTENCIA.DefaultCellStyle = dataGridViewCellStyle6;
            this.EXISTENCIA.HeaderText = "EXISTENCIA";
            this.EXISTENCIA.Name = "EXISTENCIA";
            // 
            // REVISADO
            // 
            this.REVISADO.HeaderText = "REVISADO";
            this.REVISADO.Name = "REVISADO";
            this.REVISADO.Visible = false;
            // 
            // LB_cantidad
            // 
            this.LB_cantidad.AutoSize = true;
            this.LB_cantidad.Location = new System.Drawing.Point(661, 96);
            this.LB_cantidad.Name = "LB_cantidad";
            this.LB_cantidad.Size = new System.Drawing.Size(0, 13);
            this.LB_cantidad.TabIndex = 4;
            // 
            // ReporteArticulosExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_cantidad);
            this.Controls.Add(this.CB_lineas);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ReporteArticulosExistencia";
            this.Text = "ReporteArticulosExistencia";
            this.Load += new System.EventHandler(this.ReporteArticulosExistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.ComboBox CB_lineas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_MAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_MEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXISTENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REVISADO;
        private System.Windows.Forms.Label LB_cantidad;
    }
}