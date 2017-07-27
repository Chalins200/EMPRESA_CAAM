using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_ARH
{
    public partial class UpPedidos : Form
    {
        public UpPedidos()
        {
            InitializeComponent();
        }

        private void UpPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                comboNumPed.DataSource = load.leerdatos("Select Num_Pedido from Pedidos");
                comboNumPed.DisplayMember = "Num_Pedido";
                comboNumPed.ValueMember = "Num_Pedido";
                comboCli.DataSource = load.leerdatos("Select Num_Clie from Clientes");
                comboCli.DisplayMember = "Num_Clie";
                comboCli.ValueMember = "Num_Clie";
            }
            catch (Exception err) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                String cadena;
                cadena = "Update Pedidos set Fecha_Pedido='" + dateAgPed.Value + "', Num_Clie='" + comboCli.Text + "', Rep='" +txtRep.Text + "',Estado='" +txtEst.Text + "',Total='" + txtTot.Text + "' where Num_Pedido='" +comboNumPed.Text + "'";
                load.ejecutar(cadena);
                MessageBox.Show("Pedido Modificado exitosamente");
            }
            catch (Exception err) { }
        }

        private void comboCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();


                string cadena = "Select Rep_Clie from Clientes where Num_Clie='" + comboCli.Text + "'";
                SqlDataReader dr = load.ConsultaSQL(cadena);
                dr.Read();
                txtRep.Text = dr[0].ToString();


            }
            catch (Exception err)
            {

            }
        }

        private void comboNumPed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                string cadena = "Select Num_Pedido, Fecha_Pedido, Num_Clie,Rep,Estado,Total from Pedidos where Num_Pedido='" + comboNumPed.Text + "'";
                SqlDataReader dr = load.ConsultaSQL(cadena);
                dr.Read();
                dateAgPed.Text = dr[1].ToString();
                labelIdCli.Text = "Id Cliente actual: " + dr[2].ToString() + "        Nuevo:";
                txtEst.Text = dr[4].ToString();
                txtTot.Text = dr[5].ToString();
            }
            catch (Exception err) { }
        }
    }
}
