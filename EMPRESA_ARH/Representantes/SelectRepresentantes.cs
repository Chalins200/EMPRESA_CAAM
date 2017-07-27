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

namespace EMPRESA_ARH.Representantes
{
    public partial class SelectRepresentantes : Form
    {
        public SelectRepresentantes()
        {
            InitializeComponent();
        }

        private void SelectRepresentantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetConsultas.Rep_Ventas' Puede moverla o quitarla según sea necesario.
            this.rep_VentasTableAdapter.Fill(this.dataSetConsultas.Rep_Ventas);
            
            

            ConexionSQL load2 = new ConexionSQL();
            comboEmpleado.DataSource = load2.leerdatos("Select * from Rep_Ventas");
            comboEmpleado.DisplayMember = "Nombre";
            comboEmpleado.ValueMember = "Num_Empl";
        }

        private void btnMostrarConsultaProd_Click(object sender, EventArgs e)
        {
            if (radioListado.Checked && radioTodas.Checked)
            {
                this.dataGridConsultas.DataSource = this.rep_VentasTableAdapter.GetAll();
            }
            else if (radioListado.Checked && radioOficinas.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.rep_VentasTableAdapter.GetAllOficina(int.Parse(txtOficina.Text));
                }
                catch (Exception err) { }
            }
            else if (radioEmpleado.Checked && radioTodas.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.rep_VentasTableAdapter.GetAllEmpleado(int.Parse(comboEmpleado.SelectedValue.ToString()));
                }
                catch (Exception err) { }
            }
            else if (radioEmpleado.Checked && radioOficinas.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.rep_VentasTableAdapter.GetEmplOfi(int.Parse(comboEmpleado.SelectedValue.ToString()), int.Parse(txtOficina.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMenor.Checked && radioTodas.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.rep_VentasTableAdapter.GetAllEmpleado(int.Parse(txtMenorA.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMenor.Checked && radioOficinas.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.rep_VentasTableAdapter.GetVentaOfi(int.Parse(txtMenorA.Text), int.Parse(txtOficina.Text));
                }
                catch (Exception err) { }
            }

        }
    }
}
