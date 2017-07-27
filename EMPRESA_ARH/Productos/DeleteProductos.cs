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
    public partial class DeleteProductos : Form
    {
        public DeleteProductos()
        {
            InitializeComponent();
        }

        private void DeleteProductos_Load(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            comboClFab.DataSource = load.leerdatos("Select distinct Id_fab from Productos");
            comboClFab.DisplayMember = "Id_fab";
            comboClFab.ValueMember = "Id_fab";
            
        }

        private void comboClFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            comboClProd.DataSource = load.leerdatos("Select * from Productos where Id_fab='" + comboClFab.Text + "'");
            comboClProd.DisplayMember = "Id_Producto";
            comboClProd.ValueMember = "Id_Producto";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            load.ejecutar("update productos  set estado ='Descontinuado' where Id_fab='" + comboClFab.Text + "' and Id_Producto='" + comboClProd.Text + "'");   
            MessageBox.Show("El producto ha sido descontinuado");
            
        }

        private void comboClProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionSQL load = new ConexionSQL();
            string cadena = "Select Estado from Productos where Id_fab='" + comboClFab.Text + "' and Id_Producto='" + comboClProd.Text + "'";
            SqlDataReader dr = load.ConsultaSQL(cadena);
            dr.Read();
            labelSetEst.Text= dr[0].ToString();
            
        }
    }
}
