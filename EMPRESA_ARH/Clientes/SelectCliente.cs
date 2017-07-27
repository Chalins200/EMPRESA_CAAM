using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_ARH.Clientes
{
    public partial class SelectCliente : Form
    {
        public SelectCliente()
        {
            InitializeComponent();
        }

        private void SelectCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetConsultas.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataSetConsultas.Clientes);

            ConexionSQL load1 = new ConexionSQL();
            comboCliente.DataSource = load1.leerdatos("Select * from Clientes");
            comboCliente.DisplayMember = "Empresa";
            comboCliente.ValueMember = "Num_Clie";
        }

        private void btnMostrarConsultaProd_Click(object sender, EventArgs e)
        {
            if (radioListadoClientes.Checked && radioTodos.Checked)
            {
                this.dataGridConsultas.DataSource = this.clientesTableAdapter.GetAll();
            }
            else if (radioListadoClientes.Checked && radioRep.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.clientesTableAdapter.GetAllRep(int.Parse(txtRepClie.Text));
                }
                catch (Exception err) { }
            }
            else if (radioNumClie.Checked && radioTodos.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.clientesTableAdapter.GetNumClieAll(int.Parse(comboCliente.SelectedValue.ToString()));
                }
                catch (Exception err) { }
            }
            else if (radioNumClie.Checked && radioRep.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.clientesTableAdapter.GetNumClieRep(int.Parse(comboCliente.SelectedValue.ToString()), int.Parse(txtRepClie.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMenorA.Checked && radioTodos.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.clientesTableAdapter.GetMenorAll(int.Parse(txtMenorA.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMenorA.Checked && radioRep.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.clientesTableAdapter.GetMenorRep(int.Parse(txtMenorA.Text), int.Parse(txtRepClie.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMayorA.Checked && radioTodos.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.clientesTableAdapter.GetMayor(int.Parse(txtMayorA.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMayorA.Checked && radioRep.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.clientesTableAdapter.GetMayorRep(int.Parse(txtMayorA.Text), int.Parse(txtRepClie.Text));
                }
                catch (Exception err) { }
            }
        }
    }
}
