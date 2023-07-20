using appSugerencias.Stock_Compras.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Stock_Compras.Vista
{
    public partial class FormatoPedido : Form
    {
        private List<Pedido> Listapedido;
        public FormatoPedido(List<Pedido> Listapedido)
        {

            this.Listapedido = Listapedido;

            InitializeComponent();
        }

        private void FormatoPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
