using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_ARH.Oficinas
{
    public partial class SelectOficinas : Form
    {
        public SelectOficinas()
        {
            InitializeComponent();
        }

        private void SelectOficinas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetConsultas.Oficinas' Puede moverla o quitarla según sea necesario.
            this.oficinasTableAdapter.Fill(this.dataSetConsultas.Oficinas);
            ConexionSQL load1 = new ConexionSQL();
            comboNumeroOficina.DataSource = load1.leerdatos("Select * from Oficinas");
            comboNumeroOficina.DisplayMember = "Oficina";
            comboNumeroOficina.ValueMember = "Oficina";

            ConexionSQL load2 = new ConexionSQL();
            comboRegion.DataSource = load2.leerdatos("Select distinct Region from Oficinas");
            comboRegion.DisplayMember = "Region";
            comboRegion.ValueMember = "Region";
        }

        private void btnMostrarConsultaProd_Click(object sender, EventArgs e)
        {
            if (radioListado.Checked && radioTodos.Checked)
            {
                this.dataGridConsultas.DataSource = this.oficinasTableAdapter.GetAll();
            }
            else if (radioListado.Checked && radioRegion.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.oficinasTableAdapter.GetAllReg(comboRegion.Text);
                }
                catch (Exception err) { }
            }
            else if (radioNumeroOficina.Checked && radioTodos.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.oficinasTableAdapter.GetOficinaAll(int.Parse(comboNumeroOficina.SelectedValue.ToString()));
                }
                catch (Exception err) { }
            }
            else if (radioNumeroOficina.Checked && radioRegion.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.oficinasTableAdapter.GetOficinaReg(int.Parse(comboNumeroOficina.SelectedValue.ToString()), comboRegion.Text);
                }
                catch (Exception err) { }
            }
            else if (radioMenor.Checked && radioTodos.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.oficinasTableAdapter.GetMenorAll(int.Parse(txtMenorA.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMenor.Checked && radioRegion.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.oficinasTableAdapter.GetMenorRegion(int.Parse(txtMenorA.Text), comboRegion.Text);
                }
                catch (Exception err) { }
            }
            else if (radioMayor.Checked && radioTodos.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.oficinasTableAdapter.GetMayorAll(int.Parse(txtMayorA.Text));
                }
                catch (Exception err) { }
            }
            else if (radioMayor.Checked && radioRegion.Checked)
            {
                try
                {
                    this.dataGridConsultas.DataSource = this.oficinasTableAdapter.GetMayorRegion(int.Parse(txtMayorA.Text), comboRegion.Text);
                }
                catch (Exception err) { }
            }
        }
    }
}
