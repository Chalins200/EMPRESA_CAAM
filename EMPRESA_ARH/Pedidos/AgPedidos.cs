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
    public partial class AgPedidos : Form
    {
        Boolean cargado = false;
        public AgPedidos()
        {
            InitializeComponent();
        }

        private void AgPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();
                SqlDataReader dr = load.ConsultaSQL("Select count(Num_Pedido)+1 from Pedidos");
                dr.Read();
                labelNumPed.Text = dr[0].ToString();

                ConexionSQL load1 = new ConexionSQL();
                comboCli.DataSource = load1.leerdatos("Select * from Clientes");
                comboCli.DisplayMember = "Empresa";
                comboCli.ValueMember = "Num_Clie";

                ConexionSQL load2 = new ConexionSQL();
                comboRep.DataSource = load2.leerdatos("Select * from Rep_Ventas");
                comboRep.DisplayMember = "Nombre";
                comboRep.ValueMember = "Num_Empl";
                cargado = true;
            }
            catch (Exception err)
            {

            }
        }

        private void comboCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL load = new ConexionSQL();     
                        
                              
               
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
                Boolean estado = true;
                load.ejecutar("exec Ins_Ped "+ labelNumPed.Text + ",'" + dateAgPed.Value.ToShortDateString()+"',"+comboCli.SelectedValue+","+comboRep.SelectedValue+","+"1"+","+labelTotal.Text+","+labelPutOficina.Text+" ");

                for (int i = 0; i <dataGridViewDetalles.Rows.Count-1; i++)
                {
                    string idfab = (string)dataGridViewDetalles.Rows[i].Cells[0].Value;
                    string codigo = (string)dataGridViewDetalles.Rows[i].Cells[1].Value;
                    string cantidad = (string)dataGridViewDetalles.Rows[i].Cells[2].Value;
                    string precio = dataGridViewDetalles.Rows[i].Cells[4].Value.ToString();
                    string importe = dataGridViewDetalles.Rows[i].Cells[5].Value.ToString();
                    
               load.ejecutar("exec Ins_Ped_De "+labelNumPed.Text+","+idfab+","+codigo+","+cantidad+","+precio+","+importe+"");
                }
                MessageBox.Show("Pedido realizado con exito");
                dataGridViewDetalles.DataSource = null;
                labelTotal.Text=null;
              
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    string idfab, idprod;
                    idfab = (dataGridViewDetalles.CurrentRow.Cells[0].Value.ToString());
                    idprod = (dataGridViewDetalles.CurrentRow.Cells[1].Value.ToString());

                    ConexionSQL load = new ConexionSQL();
                    string descripcion; double precio;
                    SqlDataReader dato = load.ConsultaSQL("Select Descripcion,Precio from Productos where Id_fab='" + idfab + "' and Id_Producto='" + idprod + "'");
                    if (dato.Read())
                    {
                        dataGridViewDetalles.CurrentRow.Cells[3].Value = dato.GetString(0);
                        dataGridViewDetalles.CurrentRow.Cells[4].Value = dato.GetSqlMoney(1).ToDouble();

                    }
                    else{
                    dataGridViewDetalles.CurrentRow.Cells[1].Value = "";
                    dataGridViewDetalles.CurrentRow.Cells[2].Value = ""; 
                    dataGridViewDetalles.CurrentRow.Cells[3].Value = 0;
                    dataGridViewDetalles.CurrentRow.Cells[4].Value = 0; 
                    }
                  
                }
                if (e.ColumnIndex == 2)
                {
                    double precio; try
                    {
                        object cantidad = dataGridViewDetalles.CurrentRow.Cells[2].Value; precio = Double.Parse(dataGridViewDetalles.CurrentRow.Cells[4].Value.ToString()); dataGridViewDetalles.CurrentRow.Cells[5].Value = precio * Double.Parse(cantidad.ToString());
                        double resul = dataGridViewDetalles.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells[5].Value)); labelTotal.Text = Convert.ToString(resul);
                    }
                    catch (Exception x)
                    {
                    }
                }
                if (dataGridViewDetalles.CurrentRow.Cells[2].Value != null)
                {
                    int Import = Convert.ToInt32(dataGridViewDetalles.CurrentRow.Cells[2].Value.ToString().TrimEnd()) * Convert.ToInt32(dataGridViewDetalles.CurrentRow.Cells[4].Value.ToString().TrimEnd());
                    dataGridViewDetalles.CurrentRow.Cells[5].Value = Import;

                }
                
            }
            catch (Exception err) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboRep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                ConexionSQL load = new ConexionSQL();
                string numEmpleado;
                numEmpleado = (comboRep.SelectedValue.ToString());
                SqlDataReader dato = load.ConsultaSQL("Select Oficina_Rep from Rep_ventas where Num_Empl='" + numEmpleado + "'");

                try
                {
                    dato.Read();

                    int oficina = dato.GetInt32(0);
                    labelPutOficina.Text = oficina.ToString();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "bla bla");
                }
            }
        }
    }
}
