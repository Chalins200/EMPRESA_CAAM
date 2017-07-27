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
    public partial class AgClientes : Form
    {
        public AgClientes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgClientes_Load(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            comboRepClie.DataSource = load.leerdatos("Select * from Rep_Ventas ");
            comboRepClie.DisplayMember = "Num_Empl";
            comboRepClie.ValueMember = "Num_Empl";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();      
                    
            string cadena = "exec Ins_Cli '"+txtNumCli.Text +"','"+txtEmp.Text+"','"+comboRepClie.Text+"','"+txtLimCred.Text+"'";
           load.ejecutar(cadena);
           MessageBox.Show("Cliente agregado exitosamente");


        }

        private void comboRepClie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
