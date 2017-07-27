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
    public partial class AgRepresentantes : Form
    {
        public AgRepresentantes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Representantes_Load(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            comboOfiRep.DataSource = load.leerdatos("Select distinct Oficina_Rep from Rep_Ventas");
            comboOfiRep.DisplayMember = "Oficina_Rep";
            comboOfiRep.ValueMember = "Oficina_Rep";

            comboDirec.DataSource = load.leerdatos("Select distinct Director from Rep_Ventas");
            comboDirec.DisplayMember = "Director";
            comboDirec.ValueMember = "Director";
        }

        private void btnSaveFrom_Click(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            String cadena;
            cadena = "exec Ins_Rep_V  " + txtNumEmple.Text + ",'" + txtNombre.Text + "'," + txtEdad.Text + "," + comboOfiRep.Text + ",'" + txtTitu.Text + "','" + dateContra.Value + "'," + comboDirec.Text + "," + txtCuo.Text + "," + txtVentas.Text + "";
            load.ejecutar(cadena);
            MessageBox.Show("Representante agregado correctamente");
        }

        private void txtVentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboDirec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateContra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTitu_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboOfiRep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumEmple_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
