namespace EMPRESA_ARH.Representantes
{
    partial class SelectRepresentantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectRepresentantes));
            this.dataGridConsultas = new System.Windows.Forms.DataGridView();
            this.numEmplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oficinaRepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repVentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultas = new EMPRESA_ARH.DataSetConsultas();
            this.btnMostrarConsultaProd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioTodas = new System.Windows.Forms.RadioButton();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.radioOficinas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMenorA = new System.Windows.Forms.TextBox();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.radioMenor = new System.Windows.Forms.RadioButton();
            this.radioEmpleado = new System.Windows.Forms.RadioButton();
            this.radioListado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.repVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rep_VentasTableAdapter = new EMPRESA_ARH.DataSetConsultasTableAdapters.Rep_VentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVentasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsultas
            // 
            this.dataGridConsultas.AutoGenerateColumns = false;
            this.dataGridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numEmplDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.oficinaRepDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.contratoDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.cuotaDataGridViewTextBoxColumn,
            this.ventasDataGridViewTextBoxColumn});
            this.dataGridConsultas.DataSource = this.repVentasBindingSource1;
            this.dataGridConsultas.Location = new System.Drawing.Point(12, 273);
            this.dataGridConsultas.Name = "dataGridConsultas";
            this.dataGridConsultas.Size = new System.Drawing.Size(955, 210);
            this.dataGridConsultas.TabIndex = 14;
            // 
            // numEmplDataGridViewTextBoxColumn
            // 
            this.numEmplDataGridViewTextBoxColumn.DataPropertyName = "Num_Empl";
            this.numEmplDataGridViewTextBoxColumn.HeaderText = "Num_Empl";
            this.numEmplDataGridViewTextBoxColumn.Name = "numEmplDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // oficinaRepDataGridViewTextBoxColumn
            // 
            this.oficinaRepDataGridViewTextBoxColumn.DataPropertyName = "Oficina_Rep";
            this.oficinaRepDataGridViewTextBoxColumn.HeaderText = "Oficina_Rep";
            this.oficinaRepDataGridViewTextBoxColumn.Name = "oficinaRepDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // contratoDataGridViewTextBoxColumn
            // 
            this.contratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato";
            this.contratoDataGridViewTextBoxColumn.HeaderText = "Contrato";
            this.contratoDataGridViewTextBoxColumn.Name = "contratoDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // cuotaDataGridViewTextBoxColumn
            // 
            this.cuotaDataGridViewTextBoxColumn.DataPropertyName = "Cuota";
            this.cuotaDataGridViewTextBoxColumn.HeaderText = "Cuota";
            this.cuotaDataGridViewTextBoxColumn.Name = "cuotaDataGridViewTextBoxColumn";
            // 
            // ventasDataGridViewTextBoxColumn
            // 
            this.ventasDataGridViewTextBoxColumn.DataPropertyName = "Ventas";
            this.ventasDataGridViewTextBoxColumn.HeaderText = "Ventas";
            this.ventasDataGridViewTextBoxColumn.Name = "ventasDataGridViewTextBoxColumn";
            // 
            // repVentasBindingSource1
            // 
            this.repVentasBindingSource1.DataMember = "Rep_Ventas";
            this.repVentasBindingSource1.DataSource = this.dataSetConsultas;
            // 
            // dataSetConsultas
            // 
            this.dataSetConsultas.DataSetName = "DataSetConsultas";
            this.dataSetConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMostrarConsultaProd
            // 
            this.btnMostrarConsultaProd.Location = new System.Drawing.Point(446, 235);
            this.btnMostrarConsultaProd.Name = "btnMostrarConsultaProd";
            this.btnMostrarConsultaProd.Size = new System.Drawing.Size(148, 23);
            this.btnMostrarConsultaProd.TabIndex = 13;
            this.btnMostrarConsultaProd.Text = "Mostrar";
            this.btnMostrarConsultaProd.UseVisualStyleBackColor = true;
            this.btnMostrarConsultaProd.Click += new System.EventHandler(this.btnMostrarConsultaProd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioTodas);
            this.groupBox2.Controls.Add(this.txtOficina);
            this.groupBox2.Controls.Add(this.radioOficinas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(370, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 124);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Representantes";
            // 
            // radioTodas
            // 
            this.radioTodas.AutoSize = true;
            this.radioTodas.Checked = true;
            this.radioTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTodas.Location = new System.Drawing.Point(6, 31);
            this.radioTodas.Name = "radioTodas";
            this.radioTodas.Size = new System.Drawing.Size(136, 20);
            this.radioTodas.TabIndex = 6;
            this.radioTodas.TabStop = true;
            this.radioTodas.Text = "Todas las oficinas";
            this.radioTodas.UseVisualStyleBackColor = true;
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(93, 73);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(72, 22);
            this.txtOficina.TabIndex = 5;
            // 
            // radioOficinas
            // 
            this.radioOficinas.AutoSize = true;
            this.radioOficinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOficinas.Location = new System.Drawing.Point(6, 73);
            this.radioOficinas.Name = "radioOficinas";
            this.radioOficinas.Size = new System.Drawing.Size(67, 20);
            this.radioOficinas.TabIndex = 0;
            this.radioOficinas.Text = "Oficina";
            this.radioOficinas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMenorA);
            this.groupBox1.Controls.Add(this.comboEmpleado);
            this.groupBox1.Controls.Add(this.radioMenor);
            this.groupBox1.Controls.Add(this.radioEmpleado);
            this.groupBox1.Controls.Add(this.radioListado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 149);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repesentantes";
            // 
            // txtMenorA
            // 
            this.txtMenorA.Location = new System.Drawing.Point(193, 88);
            this.txtMenorA.Name = "txtMenorA";
            this.txtMenorA.Size = new System.Drawing.Size(117, 22);
            this.txtMenorA.TabIndex = 4;
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(193, 56);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(121, 24);
            this.comboEmpleado.TabIndex = 3;
            // 
            // radioMenor
            // 
            this.radioMenor.AutoSize = true;
            this.radioMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenor.Location = new System.Drawing.Point(16, 88);
            this.radioMenor.Name = "radioMenor";
            this.radioMenor.Size = new System.Drawing.Size(123, 20);
            this.radioMenor.TabIndex = 2;
            this.radioMenor.TabStop = true;
            this.radioMenor.Text = "Ventas  menor a";
            this.radioMenor.UseVisualStyleBackColor = true;
            // 
            // radioEmpleado
            // 
            this.radioEmpleado.AutoSize = true;
            this.radioEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEmpleado.Location = new System.Drawing.Point(16, 57);
            this.radioEmpleado.Name = "radioEmpleado";
            this.radioEmpleado.Size = new System.Drawing.Size(159, 20);
            this.radioEmpleado.TabIndex = 1;
            this.radioEmpleado.TabStop = true;
            this.radioEmpleado.Text = "Numero de Empleado";
            this.radioEmpleado.UseVisualStyleBackColor = true;
            // 
            // radioListado
            // 
            this.radioListado.AutoSize = true;
            this.radioListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioListado.Location = new System.Drawing.Point(16, 31);
            this.radioListado.Name = "radioListado";
            this.radioListado.Size = new System.Drawing.Size(188, 20);
            this.radioListado.TabIndex = 0;
            this.radioListado.TabStop = true;
            this.radioListado.Text = "Listado de Representantes";
            this.radioListado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consultas de Representantes";
            // 
            // repVentasBindingSource
            // 
            this.repVentasBindingSource.DataMember = "Rep_Ventas";
            this.repVentasBindingSource.DataSource = this.dataSetConsultas;
            // 
            // rep_VentasTableAdapter
            // 
            this.rep_VentasTableAdapter.ClearBeforeFill = true;
            // 
            // SelectRepresentantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(985, 522);
            this.Controls.Add(this.dataGridConsultas);
            this.Controls.Add(this.btnMostrarConsultaProd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectRepresentantes";
            this.Text = "SelectRepresentantes";
            this.Load += new System.EventHandler(this.SelectRepresentantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVentasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repVentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsultas;
        private System.Windows.Forms.Button btnMostrarConsultaProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioOficinas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMenorA;
        private System.Windows.Forms.ComboBox comboEmpleado;
        private System.Windows.Forms.RadioButton radioMenor;
        private System.Windows.Forms.RadioButton radioEmpleado;
        private System.Windows.Forms.RadioButton radioListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioTodas;
        private System.Windows.Forms.TextBox txtOficina;
        private DataSetConsultas dataSetConsultas;
        private System.Windows.Forms.BindingSource repVentasBindingSource;
        private DataSetConsultasTableAdapters.Rep_VentasTableAdapter rep_VentasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEmplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oficinaRepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource repVentasBindingSource1;
    }
}