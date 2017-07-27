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
    public partial class UPProductos : Form
    {
        
        

        public UPProductos()
        {
            InitializeComponent();
        }

        private void comboClFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            comboClProd.DataSource = load.leerdatos("Select * from Productos where Id_fab='" + comboClFab.Text + "'");          
            comboClProd.DisplayMember = "Id_Producto";
            comboClProd.ValueMember = "Id_Producto";
           
        }

        private void UPProductos_Load(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            comboClFab.DataSource = load.leerdatos("Select distinct Id_fab from Productos");
            comboClFab.DisplayMember = "Id_fab";
            comboClFab.ValueMember = "Id_fab";
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                string cadena = "";
                cadena = "UPDATE Productos set Descripcion='" + txtDesc.Text + "', Precio='" + txtPre.Text + "', Existencias='" + txtExi.Text + "' where Id_fab='" + comboClFab.Text + "' and Id_Producto='" + comboClProd.Text + "'";
                load.ejecutar(cadena);
                MessageBox.Show("Representnate agregado correctamente");
            }
            catch (Exception err) { }
        }

        private void comboClProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            string cadena = "Select Descripcion, Precio, Existencias from Productos where Id_fab='"+comboClFab.Text+"' and Id_Producto='"+comboClProd.Text+"'";
            SqlDataReader dr = load.ConsultaSQL(cadena);
            dr.Read();
            txtDesc.Text = dr[0].ToString();
            txtPre.Text = dr[1].ToString();
            txtExi.Text = dr[2].ToString();
        }
    }
}
