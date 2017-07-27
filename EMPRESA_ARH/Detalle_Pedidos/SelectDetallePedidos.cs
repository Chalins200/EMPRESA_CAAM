using EMPRESA_ARH.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_ARH.Detalle_Pedidos
{
    public partial class SelectDetallePedidos : Form
    {
        public SelectDetallePedidos()
        {
            InitializeComponent();
        }

        private void SelectDetallePedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetConsultas.Pedido_Detalles' Puede moverla o quitarla según sea necesario.
            this.pedido_DetallesTableAdapter.Fill(this.dataSetConsultas.Pedido_Detalles);


            ConexionSQL load1 = new ConexionSQL();
            comboNumeroPedido.DataSource = load1.leerdatos("Select distinct Num_Pedido from Pedidos");
            comboNumeroPedido.DisplayMember = "Num_Pedido";
            comboNumeroPedido.ValueMember = "Num_Pedido";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                this.dataGridConsultas.DataSource = this.pedido_DetallesTableAdapter.GetAllNum(int.Parse(comboNumeroPedido.Text));
            }
            catch (Exception err) { }
        }
    }
}
