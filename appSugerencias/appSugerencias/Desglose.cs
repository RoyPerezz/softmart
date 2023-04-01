using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class Desglose : Form
    {
        DataTable pagos = new DataTable();
        string compra = "";

        public Desglose(DataTable datos,string compra)
        {
            InitializeComponent();
            pagos = datos;
            this.compra = compra;
        }

  


   
       
        private void Desglose_Load(object sender, EventArgs e)
        {
            DG_tabla.DataSource = pagos;
            DG_tabla.Columns[5].Width = 150;
            DG_tabla.Columns[6].Width = 250;

            TB_compra.Text = compra;
            DG_tabla.Columns[0].DefaultCellStyle.Format = "C2";


        }
    }
}
