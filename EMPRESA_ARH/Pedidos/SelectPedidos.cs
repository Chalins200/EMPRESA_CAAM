using EMPRESA_ARH.Detalle_Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_ARH.Pedidos
{
    public partial class SelectPedidos : Form
    {
        public int NumeroPed=0;
        public SelectPedidos()
        {
            InitializeComponent();
        }

        private void SelectPedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetConsultas.Pedidos' Puede moverla o quitarla según sea necesario.
            this.pedidosTableAdapter.Fill(this.dataSetConsultas.Pedidos);
            // TODO: esta línea de código carga datos en la tabla 'dataSetConsultas.Pedido_Detalles' Puede moverla o quitarla según sea necesario.
            this.pedido_DetallesTableAdapter.Fill(this.dataSetConsultas.Pedido_Detalles);

            ConexionSQL load1 = new ConexionSQL();
            comboNumeroPedido.DataSource = load1.leerdatos("Select * from Pedidos");
            comboNumeroPedido.DisplayMember = "Num_Pedido";
            comboNumeroPedido.ValueMember = "Num_Pedido";

            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboActivoInactivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void btnMostrarConsultaProd_Click(object sender, EventArgs e)
        {
            Byte est;

            if (radioListado.Checked && radioTodos.Checked)
            {
                this.dataGridConsultas.DataSource = this.pedidosTableAdapter.GetAll();
            }
            else if (radioListado.Checked && radioEstado.Checked)
            {
                try
                {
                    if (comboActivoInactivo.Text.Equals("Activo"))
                    {
                        est = 1;
                    }else
                    {
                        est = 0;
                    }

                    this.dataGridConsultas.DataSource = this.pedidosTableAdapter.GetAllEstado(est);
                    
                }
                catch (Exception err) { }
            }
            else if (radioNumeroPedido.Checked && radioTodos.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.pedidosTableAdapter.GetNumAll(int.Parse(comboNumeroPedido.SelectedValue.ToString()));
                }
                catch (Exception err) { }
            }
            else if (radioNumeroPedido.Checked && radioEstado.Checked)
            {
                try
                {
                    if (comboActivoInactivo.Text.Equals("Activo"))
                    {
                        est = 1;
                    }
                    else
                    {
                        est = 0;
                    }

                    this.dataGridConsultas.DataSource = this.pedidosTableAdapter.GetNumEstado(int.Parse(comboNumeroPedido.SelectedValue.ToString()),est);
                }
                catch (Exception err) { }
            }
            else if (radioMenor.Checked && radioTodos.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.pedidosTableAdapter.GetMenorAll(int.Parse(txtMenorA.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMenor.Checked && radioEstado.Checked)
            {
                try
                {
                    if (comboActivoInactivo.Text.Equals("Activo"))
                    {
                        est = 1;
                    }
                    else
                    {
                        est = 0;
                    }

                    this.dataGridConsultas.DataSource = this.pedidosTableAdapter.GetMenorEstado(int.Parse(txtMenorA.Text),est);
                }
                catch (Exception err) { }
            }
            else if (radioMayor.Checked && radioTodos.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.pedidosTableAdapter.GetMayorAll(int.Parse(txtMayorA.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMayor.Checked && radioEstado.Checked)
            {
                try
                {
                    if (comboActivoInactivo.Text.Equals("Activo"))
                    {
                        est = 1;
                    }
                    else
                    {
                        est = 0;
                    }

                    this.dataGridConsultas.DataSource = this.pedidosTableAdapter.GetMayorEstado(int.Parse(txtMayorA.Text), est);
                }
                catch (Exception err) { }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SelectDetallePedidos sel = new SelectDetallePedidos();



                sel.Show();
            
        }
    }
}
