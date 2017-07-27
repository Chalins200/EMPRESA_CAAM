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
    public partial class AgProductos : Form
    {
        public AgProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConexionSQL objeto = new ConexionSQL(); //Instancia de un objeto desde la clase ConexionSQL
            string cadena = "";
            cadena = "INSERT INTO PRODUCTOS (ID_FAB,ID_PRODUCTO,DESCRIPCION,PRECIO,EXISTENCIAS,ESTADO)";
            cadena =cadena+"VALUES ('"+txtClaFab.Text+"','"+txtClaProd.Text+"','"+txtDesc.Text+"',"+txtPre.Text+","+txtExi.Text+",'ACTIVO')";
            objeto.ejecutar(cadena);

        }

        private void txtClaFab_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
