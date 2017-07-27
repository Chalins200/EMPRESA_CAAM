using EMPRESA_ARH.Clientes;
using EMPRESA_ARH.DataSetConsultasTableAdapters;
using EMPRESA_ARH.Oficinas;
using EMPRESA_ARH.Pedidos;
using EMPRESA_ARH.Productos;
using EMPRESA_ARH.Representantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_ARH
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void insertarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgProductos AgP = new AgProductos();
            AgP.Show();
            
        }

        private void agregarRepresentantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgRepresentantes AgRep = new AgRepresentantes();
            AgRep.Show();
        }

        private void acualizarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UPProductos UPPro = new UPProductos();
            UPPro.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProductos DelPro = new DeleteProductos();
            DelPro.Show();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgClientes Ag = new AgClientes();
            Ag.Show();
           
            
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpClientes Up = new UpClientes();
            Up.Show();
        }

        private void modificarRepresentanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpRepresentantes Up = new UpRepresentantes();
            Up.Show();
        }

        private void agregarOficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgOficina Ag = new AgOficina();
            Ag.Show();
        }

        private void modificarOficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpOficina Up = new UpOficina();
            Up.Show();
        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgPedidos Ag = new AgPedidos();
            Ag.Show();
            DataSetConsultas dataSet = new DataSetConsultas();
           
        }

        private void modificarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpPedidos Up = new UpPedidos();
            Up.Show();
        }

        private void agregarDetaleDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void modificarDetalleDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultasProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectProductos sel = new SelectProductos();
            sel.Show();

        }

        private void oficinasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasDeRepresentantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectRepresentantes sel = new SelectRepresentantes();
            sel.Show();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectCliente sel = new SelectCliente();
            sel.Show();

        }

        private void consultarOficinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectOficinas sel = new SelectOficinas();
            sel.Show();
        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectPedidos sel = new SelectPedidos();
            sel.Show();
        }
    }
}
