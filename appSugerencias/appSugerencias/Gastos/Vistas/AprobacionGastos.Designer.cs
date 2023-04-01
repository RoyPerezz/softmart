
namespace appSugerencias.Gastos.Vistas
{
    partial class AprobacionGastos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.BT_aprobar = new System.Windows.Forms.Button();
            this.LB_sucursal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REVISION1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMREV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COM_SRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TICKET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENCAJAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_AUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOTO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOTO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOTO3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ESTADO,
            this.IMPORTE,
            this.DESCRIPCION,
            this.REVISION1,
            this.CONCEPTO,
            this.DETALLE,
            this.COMENTARIO,
            this.COMREV2,
            this.COM_SRA,
            this.USUARIO,
            this.TICKET,
            this.ENCAJAS,
            this.NUM_AUTO,
            this.FOTO1,
            this.FOTO2,
            this.FOTO3});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_tabla.Location = new System.Drawing.Point(2, 121);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1421, 330);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentClick);
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            this.DG_tabla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellEndEdit);
            // 
            // BT_guardar
            // 
            this.BT_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(1313, 55);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(107, 57);
            this.BT_guardar.TabIndex = 1;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // BT_aprobar
            // 
            this.BT_aprobar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BT_aprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_aprobar.ForeColor = System.Drawing.Color.White;
            this.BT_aprobar.Location = new System.Drawing.Point(2, 55);
            this.BT_aprobar.Name = "BT_aprobar";
            this.BT_aprobar.Size = new System.Drawing.Size(107, 57);
            this.BT_aprobar.TabIndex = 2;
            this.BT_aprobar.Text = "Aprobar";
            this.BT_aprobar.UseVisualStyleBackColor = false;
            this.BT_aprobar.Click += new System.EventHandler(this.BT_aprobar_Click);
            // 
            // LB_sucursal
            // 
            this.LB_sucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_sucursal.AutoSize = true;
            this.LB_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_sucursal.ForeColor = System.Drawing.Color.White;
            this.LB_sucursal.Location = new System.Drawing.Point(21, 37);
            this.LB_sucursal.Name = "LB_sucursal";
            this.LB_sucursal.Size = new System.Drawing.Size(0, 24);
            this.LB_sucursal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total";
            // 
            // LB_total
            // 
            this.LB_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_total.AutoSize = true;
            this.LB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_total.ForeColor = System.Drawing.Color.White;
            this.LB_total.Location = new System.Drawing.Point(88, 39);
            this.LB_total.Name = "LB_total";
            this.LB_total.Size = new System.Drawing.Size(0, 24);
            this.LB_total.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.LB_sucursal);
            this.panel1.Location = new System.Drawing.Point(768, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LB_total);
            this.panel2.Location = new System.Drawing.Point(1046, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 100);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Items.AddRange(new object[] {
            "EN REVISION",
            "APROBADO",
            "CORREGIDO",
            "RECHAZADO"});
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle2;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // REVISION1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.REVISION1.DefaultCellStyle = dataGridViewCellStyle3;
            this.REVISION1.HeaderText = "REVISION";
            this.REVISION1.Name = "REVISION1";
            this.REVISION1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CONCEPTO
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CONCEPTO.DefaultCellStyle = dataGridViewCellStyle4;
            this.CONCEPTO.HeaderText = "CONCEPTO";
            this.CONCEPTO.Name = "CONCEPTO";
            this.CONCEPTO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DETALLE
            // 
            this.DETALLE.HeaderText = "DESCRIP. DETALLADA";
            this.DETALLE.Name = "DETALLE";
            this.DETALLE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // COMENTARIO
            // 
            this.COMENTARIO.HeaderText = "COM. REVISION";
            this.COMENTARIO.Name = "COMENTARIO";
            // 
            // COMREV2
            // 
            this.COMREV2.HeaderText = "COM. REVISION2";
            this.COMREV2.Name = "COMREV2";
            // 
            // COM_SRA
            // 
            this.COM_SRA.HeaderText = "COM. SRA";
            this.COM_SRA.Name = "COM_SRA";
            // 
            // USUARIO
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.USUARIO.DefaultCellStyle = dataGridViewCellStyle5;
            this.USUARIO.HeaderText = "CAJERA";
            this.USUARIO.Name = "USUARIO";
            // 
            // TICKET
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TICKET.DefaultCellStyle = dataGridViewCellStyle6;
            this.TICKET.HeaderText = "TICKET";
            this.TICKET.Name = "TICKET";
            // 
            // ENCAJAS
            // 
            this.ENCAJAS.HeaderText = "ENC. CAJAS";
            this.ENCAJAS.Name = "ENCAJAS";
            // 
            // NUM_AUTO
            // 
            this.NUM_AUTO.HeaderText = "NUM. AUTORIZACION";
            this.NUM_AUTO.Name = "NUM_AUTO";
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
            // FOTO3
            // 
            this.FOTO3.HeaderText = "FOTO3";
            this.FOTO3.Name = "FOTO3";
            this.FOTO3.Visible = false;
            // 
            // AprobacionGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1424, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_aprobar);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.DG_tabla);
            this.Name = "AprobacionGastos";
            this.Text = "AprobacionGastos";
            this.Load += new System.EventHandler(this.AprobacionGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Button BT_aprobar;
        private System.Windows.Forms.Label LB_sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn REVISION1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMREV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM_SRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TICKET;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENCAJAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_AUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOTO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOTO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOTO3;
    }
}