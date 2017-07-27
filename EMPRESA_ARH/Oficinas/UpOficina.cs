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
    public partial class UpOficina : Form
    {
        public UpOficina()
        {
            InitializeComponent();
        }

        private void UpOficina_Load(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                comboOfi.DataSource = load.leerdatos("Select Oficina from Oficinas");
                comboOfi.DisplayMember = "Oficina";
                comboOfi.ValueMember = "Oficina";
                comboDir.DataSource = load.leerdatos("Select distinct Dir from Oficinas");
                comboDir.DisplayMember = "Dir";
                comboDir.ValueMember = "Dir";
            }
            catch (Exception err)
            {

            }
        }

        private void comboOfi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                string cadena = "Select Oficina, Ciudad, Region,Dir,Objetivo,Ventas from Oficinas where Oficina='" + comboOfi.Text + "'";
                SqlDataReader dr = load.ConsultaSQL(cadena);
                dr.Read();
                txtCiu.Text = dr[1].ToString();
                txtReg.Text = dr[2].ToString();
                labelDir.Text = "Director actual:" + dr[3].ToString() + "              Nuevo:";
                txtObj.Text = dr[4].ToString();                
                txtVent.Text = dr[5].ToString();
            }
            catch (Exception err) { }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                String cadena;
                cadena = "Update Oficinas set Ciudad='" + txtCiu.Text + "', Region='" + txtReg.Text + "', Dir='" + comboDir.Text + "',Objetivo='" + txtObj.Text + "',Ventas='" + txtVent.Text + "' where Oficina='" + comboOfi.Text + "'";
                load.ejecutar(cadena);
               MessageBox.Show("Oficina Modificada exitosamente");
            }
            catch (Exception err) { }
        }

        private void comboDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
