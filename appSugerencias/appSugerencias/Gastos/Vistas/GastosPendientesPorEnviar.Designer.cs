
namespace appSugerencias.Gastos.Vistas
{
    partial class GastosPendientesPorEnviar
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
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TICKET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_GASTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_pendientes = new System.Windows.Forms.Button();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.CBX_respaldo = new System.Windows.Forms.CheckBox();
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
            this.DG_tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONCEPTO,
            this.DESCRIPCION,
            this.IMPORTE,
            this.TICKET,
            this.FECHA_GASTO});
            this.DG_tabla.Location = new System.Drawing.Point(2, 84);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(797, 365);
            this.DG_tabla.TabIndex = 0;
            // 
            // CONCEPTO
            // 
            this.CONCEPTO.HeaderText = "CONCEPTO";
            this.CONCEPTO.Name = "CONCEPTO";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle1;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // TICKET
            // 
            this.TICKET.HeaderText = "TICKET";
            this.TICKET.Name = "TICKET";
            // 
            // FECHA_GASTO
            // 
            this.FECHA_GASTO.HeaderText = "FECHA";
            this.FECHA_GASTO.Name = "FECHA_GASTO";
            // 
            // BT_pendientes
            // 
            this.BT_pendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_pendientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_pendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_pendientes.ForeColor = System.Drawing.Color.White;
            this.BT_pendientes.Location = new System.Drawing.Point(561, 24);
            this.BT_pendientes.Name = "BT_pendientes";
            this.BT_pendientes.Size = new System.Drawing.Size(116, 41);
            this.BT_pendientes.TabIndex = 1;
            this.BT_pendientes.Text = "Gastos pendientes";
            this.BT_pendientes.UseVisualStyleBackColor = false;
            this.BT_pendientes.Click += new System.EventHandler(this.BT_pendientes_Click);
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(8, 14);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 2;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(8, 45);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 3;
            // 
            // BT_exportar
            // 
            this.BT_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_exportar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(683, 24);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(116, 41);
            this.BT_exportar.TabIndex = 4;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // CBX_respaldo
            // 
            this.CBX_respaldo.AutoSize = true;
            this.CBX_respaldo.Location = new System.Drawing.Point(244, 14);
            this.CBX_respaldo.Name = "CBX_respaldo";
            this.CBX_respaldo.Size = new System.Drawing.Size(71, 17);
            this.CBX_respaldo.TabIndex = 5;
            this.CBX_respaldo.Text = "Respaldo";
            this.CBX_respaldo.UseVisualStyleBackColor = true;
            // 
            // GastosPendientesPorEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBX_respaldo);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.BT_pendientes);
            this.Controls.Add(this.DG_tabla);
            this.Name = "GastosPendientesPorEnviar";
            this.Text = "GastosPendientesPorEnviar";
            this.Load += new System.EventHandler(this.GastosPendientesPorEnviar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_pendientes;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TICKET;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_GASTO;
        private System.Windows.Forms.CheckBox CBX_respaldo;
    }
}