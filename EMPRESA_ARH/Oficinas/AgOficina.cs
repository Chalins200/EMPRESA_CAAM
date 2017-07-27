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
    public partial class AgOficina : Form
    {
        public AgOficina()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AgOficina_Load(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                comboDir.DataSource = load.leerdatos("Select distinct Dir from Oficinas");
                comboDir.DisplayMember = "Dir";
                comboDir.ValueMember = "Dir";
            }
            catch (Exception err)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();

                string cadena = "exec Ins_Ofi '" + txtOfi.Text + "','" + txtCiu.Text + "','" + txtReg.Text + "','" + comboDir.Text + "','" + txtObj.Text + "','" + txtVent.Text + "'";
                load.ejecutar(cadena);
                MessageBox.Show("Oficina agregada exitosamente");
            }
            catch (Exception err)
            {

            }
        }

        private void comboDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
