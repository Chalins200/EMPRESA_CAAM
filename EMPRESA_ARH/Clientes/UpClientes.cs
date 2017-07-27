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
    public partial class UpClientes : Form
    {
        public UpClientes()
        {
            InitializeComponent();
        }

        private void UpClientes_Load(object sender, EventArgs e)
        {
            
            try
            {
                ConexionSQL load = new ConexionSQL();
                comboNumClie.DataSource = load.leerdatos("Select * from Clientes");
                comboNumClie.DisplayMember = "Num_Clie";
                comboNumClie.ValueMember = "Num_Clie";
                comboRepClie.DataSource = load.leerdatos("Select distinct Rep_Clie from Clientes");
                comboRepClie.DisplayMember = "Rep_Clie";
                comboRepClie.ValueMember = "Rep_Clie";
               
            }
            catch (Exception err)
            { }
        
        }

        private void comboNumClie_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ConexionSQL load = new ConexionSQL();
                string cadena = "Select Num_Clie, Empresa, Rep_Clie, Lim_Cred from Clientes where Num_Clie='" + comboNumClie.Text + "'";
                SqlDataReader dr = load.ConsultaSQL(cadena);
                dr.Read();
                labelUpCliRep.Text = dr[2].ToString();
                txtEmp.Text = dr[1].ToString();
                txtLimCred.Text = dr[3].ToString();

               
            }
            catch (Exception err)
            {

            }
    
        }

        private void comboRepClie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                string cadena = "";
                cadena = "UPDATE Clientes set Empresa='" + txtEmp.Text + "', Rep_Clie='" + comboRepClie.Text + "', Lim_Cred='" + txtLimCred.Text + "' where Num_Clie='" + comboNumClie.Text + "'";
                load.ejecutar(cadena);
                MessageBox.Show("Cliente actualizado con exito");
            }
            catch(Exception err) { }
        }
    }
}
