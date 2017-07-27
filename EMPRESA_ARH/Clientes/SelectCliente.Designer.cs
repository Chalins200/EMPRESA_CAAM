namespace EMPRESA_ARH.Clientes
{
    partial class SelectCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCliente));
            this.dataGridConsultas = new System.Windows.Forms.DataGridView();
            this.numClieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repClieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limCredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultas = new EMPRESA_ARH.DataSetConsultas();
            this.btnMostrarConsultaProd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.txtRepClie = new System.Windows.Forms.TextBox();
            this.radioRep = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMayorA = new System.Windows.Forms.TextBox();
            this.radioMayorA = new System.Windows.Forms.RadioButton();
            this.txtMenorA = new System.Windows.Forms.TextBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.radioMenorA = new System.Windows.Forms.RadioButton();
            this.radioNumClie = new System.Windows.Forms.RadioButton();
            this.radioListadoClientes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new EMPRESA_ARH.DataSetConsultasTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsultas
            // 
            this.dataGridConsultas.AutoGenerateColumns = false;
            this.dataGridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numClieDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.repClieDataGridViewTextBoxColumn,
            this.limCredDataGridViewTextBoxColumn});
            this.dataGridConsultas.DataSource = this.clientesBindingSource1;
            this.dataGridConsultas.Location = new System.Drawing.Point(91, 276);
            this.dataGridConsultas.Name = "dataGridConsultas";
            this.dataGridConsultas.Size = new System.Drawing.Size(491, 223);
            this.dataGridConsultas.TabIndex = 34;
            // 
            // numClieDataGridViewTextBoxColumn
            // 
            this.numClieDataGridViewTextBoxColumn.DataPropertyName = "Num_Clie";
            this.numClieDataGridViewTextBoxColumn.HeaderText = "Num_Clie";
            this.numClieDataGridViewTextBoxColumn.Name = "numClieDataGridViewTextBoxColumn";
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            // 
            // repClieDataGridViewTextBoxColumn
            // 
            this.repClieDataGridViewTextBoxColumn.DataPropertyName = "Rep_Clie";
            this.repClieDataGridViewTextBoxColumn.HeaderText = "Rep_Clie";
            this.repClieDataGridViewTextBoxColumn.Name = "repClieDataGridViewTextBoxColumn";
            // 
            // limCredDataGridViewTextBoxColumn
            // 
            this.limCredDataGridViewTextBoxColumn.DataPropertyName = "Lim_Cred";
            this.limCredDataGridViewTextBoxColumn.HeaderText = "Lim_Cred";
            this.limCredDataGridViewTextBoxColumn.Name = "limCredDataGridViewTextBoxColumn";
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.dataSetConsultas;
            // 
            // dataSetConsultas
            // 
            this.dataSetConsultas.DataSetName = "DataSetConsultas";
            this.dataSetConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMostrarConsultaProd
            // 
            this.btnMostrarConsultaProd.Location = new System.Drawing.Point(448, 187);
            this.btnMostrarConsultaProd.Name = "btnMostrarConsultaProd";
            this.btnMostrarConsultaProd.Size = new System.Drawing.Size(165, 23);
            this.btnMostrarConsultaProd.TabIndex = 33;
            this.btnMostrarConsultaProd.Text = "Mostrar";
            this.btnMostrarConsultaProd.UseVisualStyleBackColor = true;
            this.btnMostrarConsultaProd.Click += new System.EventHandler(this.btnMostrarConsultaProd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioTodos);
            this.groupBox2.Controls.Add(this.txtRepClie);
            this.groupBox2.Controls.Add(this.radioRep);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(386, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 107);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Cliente";
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Checked = true;
            this.radioTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTodos.Location = new System.Drawing.Point(6, 35);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(180, 20);
            this.radioTodos.TabIndex = 6;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos los representantes";
            this.radioTodos.UseVisualStyleBackColor = true;
            // 
            // txtRepClie
            // 
            this.txtRepClie.Location = new System.Drawing.Point(202, 70);
            this.txtRepClie.Name = "txtRepClie";
            this.txtRepClie.Size = new System.Drawing.Size(72, 22);
            this.txtRepClie.TabIndex = 5;
            // 
            // radioRep
            // 
            this.radioRep.AutoSize = true;
            this.radioRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRep.Location = new System.Drawing.Point(6, 72);
            this.radioRep.Name = "radioRep";
            this.radioRep.Size = new System.Drawing.Size(181, 20);
            this.radioRep.TabIndex = 1;
            this.radioRep.Text = "Representante del Cliente";
            this.radioRep.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMayorA);
            this.groupBox1.Controls.Add(this.radioMayorA);
            this.groupBox1.Controls.Add(this.txtMenorA);
            this.groupBox1.Controls.Add(this.comboCliente);
            this.groupBox1.Controls.Add(this.radioMenorA);
            this.groupBox1.Controls.Add(this.radioNumClie);
            this.groupBox1.Controls.Add(this.radioListadoClientes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 185);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtMayorA
            // 
            this.txtMayorA.Location = new System.Drawing.Point(200, 142);
            this.txtMayorA.Name = "txtMayorA";
            this.txtMayorA.Size = new System.Drawing.Size(118, 22);
            this.txtMayorA.TabIndex = 6;
            // 
            // radioMayorA
            // 
            this.radioMayorA.AutoSize = true;
            this.radioMayorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMayorA.Location = new System.Drawing.Point(16, 142);
            this.radioMayorA.Name = "radioMayorA";
            this.radioMayorA.Size = new System.Drawing.Size(179, 20);
            this.radioMayorA.TabIndex = 5;
            this.radioMayorA.Text = "Limite de credito  mayor a";
            this.radioMayorA.UseVisualStyleBackColor = true;
            // 
            // txtMenorA
            // 
            this.txtMenorA.Location = new System.Drawing.Point(200, 104);
            this.txtMenorA.Name = "txtMenorA";
            this.txtMenorA.Size = new System.Drawing.Size(118, 22);
            this.txtMenorA.TabIndex = 4;
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(197, 59);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(121, 24);
            this.comboCliente.TabIndex = 3;
            // 
            // radioMenorA
            // 
            this.radioMenorA.AutoSize = true;
            this.radioMenorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenorA.Location = new System.Drawing.Point(16, 106);
            this.radioMenorA.Name = "radioMenorA";
            this.radioMenorA.Size = new System.Drawing.Size(179, 20);
            this.radioMenorA.TabIndex = 2;
            this.radioMenorA.Text = "Limite de credito  menor a";
            this.radioMenorA.UseVisualStyleBackColor = true;
            // 
            // radioNumClie
            // 
            this.radioNumClie.AutoSize = true;
            this.radioNumClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNumClie.Location = new System.Drawing.Point(16, 63);
            this.radioNumClie.Name = "radioNumClie";
            this.radioNumClie.Size = new System.Drawing.Size(137, 20);
            this.radioNumClie.TabIndex = 1;
            this.radioNumClie.Text = "Numero de Cliente";
            this.radioNumClie.UseVisualStyleBackColor = true;
            // 
            // radioListadoClientes
            // 
            this.radioListadoClientes.AutoSize = true;
            this.radioListadoClientes.Checked = true;
            this.radioListadoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioListadoClientes.Location = new System.Drawing.Point(16, 21);
            this.radioListadoClientes.Name = "radioListadoClientes";
            this.radioListadoClientes.Size = new System.Drawing.Size(140, 20);
            this.radioListadoClientes.TabIndex = 0;
            this.radioListadoClientes.TabStop = true;
            this.radioListadoClientes.Text = "Listado de Clientes";
            this.radioListadoClientes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Consultas de Cliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dataSetConsultas;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // SelectCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 511);
            this.Controls.Add(this.dataGridConsultas);
            this.Controls.Add(this.btnMostrarConsultaProd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectCliente";
            this.Text = "SelectCliente";
            this.Load += new System.EventHandler(this.SelectCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsultas;
        private System.Windows.Forms.Button btnMostrarConsultaProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioRep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMenorA;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.RadioButton radioMenorA;
        private System.Windows.Forms.RadioButton radioNumClie;
        private System.Windows.Forms.RadioButton radioListadoClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.TextBox txtRepClie;
        private System.Windows.Forms.TextBox txtMayorA;
        private System.Windows.Forms.RadioButton radioMayorA;
        private DataSetConsultas dataSetConsultas;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetConsultasTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repClieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limCredDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
    }
}