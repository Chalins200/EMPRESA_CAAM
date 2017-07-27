using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data; 
using System.Drawing; 
using System.Windows.Forms;

namespace EMPRESA_ARH
{
    class ConexionSQL
    {
        SqlConnection conn= new SqlConnection() ;

        public ConexionSQL(){
            conectar();
        }

        void conectar() {
            conn.ConnectionString = "Data Source=CHALINS;Initial Catalog=EMPRESA_CAAM;Integrated Security=True";
            if (conn.State == System.Data.ConnectionState.Closed); {
                MessageBox.Show("Abierto");
                conn.Open ();
            }        
        }


        public void ejecutar(string Sqltexto)
        {
            SqlCommand comando = new SqlCommand(Sqltexto, conn);
            comando.ExecuteNonQuery();
            MessageBox.Show("El producto se agrego correctamente");
            
        }

        public SqlDataReader ConsultaSQL(string Sqltexto)
        {
            SqlCommand command1 = new SqlCommand(Sqltexto, conn);
            return command1.ExecuteReader();
        }

        public BindingSource leerdatos(string Sqltexto)
        {
            BindingSource bindingSource1 = new BindingSource();
            SqlCommand command1 = new SqlCommand(Sqltexto, conn); 
            SqlDataAdapter adapter = new SqlDataAdapter(); 
            adapter.SelectCommand = command1; 
            DataTable table = new DataTable(); 
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            bindingSource1.DataSource = table; 
            return bindingSource1;
        }
        public void llenarCombo(string Sqltexto, ComboBox cmb)
        {
            SqlCommand command1 = new SqlCommand(Sqltexto, conn);
            SqlDataReader reader1 = command1.ExecuteReader();
            cmb.Items.Clear();
            while (reader1.Read())
            {
                cmb.Items.Add(reader1[0]);
            }
            reader1.Close();
        }

    }
}
