using EMPRESA_ARH.DataSetConsultasTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_ARH.Productos
{
    public partial class SelectProductos : Form
    {
        public SelectProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectProductos_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'dataSetConsultas1.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.dataSetConsultas1.Productos);
            //// TODO: esta línea de código carga datos en la tabla 'dataSetConsultas.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.dataSetConsultas.Productos);

            try
            {
                ConexionSQL load = new ConexionSQL();

                comboIDFabricante.DataSource = load.leerdatos("Select distinct ID_fab from PRODUCTOS");                
                comboIDFabricante.DisplayMember = "ID_fab";
                comboIDFabricante.ValueMember = "ID_fab";


            }
            catch (Exception err)
            {


            }

            

        }

        private void btnMostrarConsultaProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioIdFab.Checked && radioAmbos.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataByfab(comboIDFabricante.Text);

                }
                else if (radioTodos.Checked && radioAmbos.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataByAll();
                }
                else if (radioExistenciasMayor.Checked && radioAmbos.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataByMayor(int.Parse(txtMayorA.Text));
                }
                else if (radioExistenciasMenor.Checked && radioAmbos.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataByMenor(int.Parse(txtMenorA.Text));
                }
                if (radioIdFab.Checked && radioEstado.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataBySinExiFab(comboIDFabricante.Text);

                }
                else if (radioTodos.Checked && radioEstado.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataBySinExi();
                }
                else if (radioExistenciasMayor.Checked && radioEstado.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataByMayorSinExi(int.Parse(txtMayorA.Text));
                }
                else if (radioExistenciasMenor.Checked && radioEstado.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataByMenorSinExi(int.Parse(txtMenorA.Text));
                }

                if (radioIdFab.Checked && radioExistencias.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataBySinEstFab(comboIDFabricante.Text);

                }
                else if (radioTodos.Checked && radioExistencias.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataBySinEst();
                }
                else if (radioExistenciasMayor.Checked && radioExistencias.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataByMayorSinEst(int.Parse(txtMayorA.Text));
                }
                else if (radioExistenciasMenor.Checked && radioExistencias.Checked)
                {
                    this.dataGridProductosConsultas.DataSource = this.productosTableAdapter.GetDataByMenorSinEst(int.Parse(txtMenorA.Text));
                }

            }
            catch (Exception err)
            {

            }
        
        }

        private void comoIDFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridProductosConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
