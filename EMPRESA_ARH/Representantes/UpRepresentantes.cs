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
    public partial class UpRepresentantes : Form
    {
        public UpRepresentantes()
        {
            InitializeComponent();
        }

        private void UpRepresentantes_Load(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            comboNumEmp.DataSource = load.leerdatos("Select Num_Empl from Rep_Ventas");
            comboNumEmp.DisplayMember = "Num_Empl";
            comboNumEmp.ValueMember = "Num_Empl";
            comboDirec.DataSource = load.leerdatos("Select distinct Director from Rep_Ventas");
            comboDirec.DisplayMember = "Director";
            comboDirec.ValueMember = "Director";
            comboOfiRep.DataSource = load.leerdatos("Select distinct Oficina_Rep from Rep_Ventas");
            comboOfiRep.DisplayMember = "Oficina_Rep";
            comboOfiRep.ValueMember = "Oficina_Rep";
        }

        private void comboNumEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                string cadena = "Select Num_Empl, Nombre, Edad,Oficina_Rep,Titulo,Contrato,Director,Cuota, Ventas from Rep_Ventas where Num_Empl='" + comboNumEmp.Text + "'";
                SqlDataReader dr = load.ConsultaSQL(cadena);
                dr.Read();
                txtNombre.Text = dr[1].ToString();
                txtEdad.Text = dr[2].ToString();
                labelOfi.Text = "Oficina de Representacion actual:" + dr[3].ToString() + "               Nueva:";
                txtTitu.Text = dr[4].ToString();
                dateContra.Text = dr[5].ToString();
                labelDir.Text = "Director actual: " + dr[6].ToString() + "                               Nuevo: ";
                txtCuo.Text = dr[7].ToString();
                txtVentas.Text = dr[8].ToString();
            }
            catch (Exception err) { }
        }

        private void btnSaveFrom_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                String cadena;
                cadena = "Update Rep_Ventas set Nombre='" + txtNombre.Text + "', Edad='" + txtEdad.Text + "', Oficina_Rep='" + comboOfiRep.Text + "',Titulo='" + txtTitu.Text + "',Contrato='" + dateContra.Value + "',Director='" + comboDirec.Text + "',Cuota='" + txtCuo.Text + "', Ventas='" + txtVentas.Text + "' where Num_Empl='" + comboNumEmp.Text + "'";
                load.ejecutar(cadena);
                MessageBox.Show("Representante Modificado exitosamente");
            }catch(Exception err){}
        }

        private void comboDirec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboOfiRep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
