namespace EMPRESA_ARH.Productos
{
    partial class SelectProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPoductos = new System.Windows.Forms.GroupBox();
            this.txtMayorA = new System.Windows.Forms.TextBox();
            this.radioExistenciasMayor = new System.Windows.Forms.RadioButton();
            this.txtMenorA = new System.Windows.Forms.TextBox();
            this.comboIDFabricante = new System.Windows.Forms.ComboBox();
            this.radioExistenciasMenor = new System.Windows.Forms.RadioButton();
            this.radioIdFab = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioAmbos = new System.Windows.Forms.RadioButton();
            this.radioEstado = new System.Windows.Forms.RadioButton();
            this.radioExistencias = new System.Windows.Forms.RadioButton();
            this.btnMostrarConsultaProd = new System.Windows.Forms.Button();
            this.dataGridProductosConsultas = new System.Windows.Forms.DataGridView();
            this.productosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultas1 = new EMPRESA_ARH.DataSetConsultas();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultas = new EMPRESA_ARH.DataSetConsultas();
            this.productosTableAdapter = new EMPRESA_ARH.DataSetConsultasTableAdapters.ProductosTableAdapter();
            this.dataSetConsultas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idfabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPoductos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductosConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas de Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxPoductos
            // 
            this.groupBoxPoductos.Controls.Add(this.txtMayorA);
            this.groupBoxPoductos.Controls.Add(this.radioExistenciasMayor);
            this.groupBoxPoductos.Controls.Add(this.txtMenorA);
            this.groupBoxPoductos.Controls.Add(this.comboIDFabricante);
            this.groupBoxPoductos.Controls.Add(this.radioExistenciasMenor);
            this.groupBoxPoductos.Controls.Add(this.radioIdFab);
            this.groupBoxPoductos.Controls.Add(this.radioTodos);
            this.groupBoxPoductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPoductos.Location = new System.Drawing.Point(38, 88);
            this.groupBoxPoductos.Name = "groupBoxPoductos";
            this.groupBoxPoductos.Size = new System.Drawing.Size(366, 164);
            this.groupBoxPoductos.TabIndex = 1;
            this.groupBoxPoductos.TabStop = false;
            this.groupBoxPoductos.Text = "Productos";
            // 
            // txtMayorA
            // 
            this.txtMayorA.Location = new System.Drawing.Point(256, 120);
            this.txtMayorA.Name = "txtMayorA";
            this.txtMayorA.Size = new System.Drawing.Size(91, 22);
            this.txtMayorA.TabIndex = 6;
            // 
            // radioExistenciasMayor
            // 
            this.radioExistenciasMayor.AutoSize = true;
            this.radioExistenciasMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioExistenciasMayor.Location = new System.Drawing.Point(16, 120);
            this.radioExistenciasMayor.Name = "radioExistenciasMayor";
            this.radioExistenciasMayor.Size = new System.Drawing.Size(234, 20);
            this.radioExistenciasMayor.TabIndex = 5;
            this.radioExistenciasMayor.TabStop = true;
            this.radioExistenciasMayor.Text = "Productos con existencias mayor a";
            this.radioExistenciasMayor.UseVisualStyleBackColor = true;
            // 
            // txtMenorA
            // 
            this.txtMenorA.Location = new System.Drawing.Point(256, 86);
            this.txtMenorA.Name = "txtMenorA";
            this.txtMenorA.Size = new System.Drawing.Size(91, 22);
            this.txtMenorA.TabIndex = 4;
            // 
            // comboIDFabricante
            // 
            this.comboIDFabricante.FormattingEnabled = true;
            this.comboIDFabricante.Location = new System.Drawing.Point(226, 53);
            this.comboIDFabricante.Name = "comboIDFabricante";
            this.comboIDFabricante.Size = new System.Drawing.Size(121, 24);
            this.comboIDFabricante.TabIndex = 3;
            this.comboIDFabricante.SelectedIndexChanged += new System.EventHandler(this.comoIDFabricante_SelectedIndexChanged);
            // 
            // radioExistenciasMenor
            // 
            this.radioExistenciasMenor.AutoSize = true;
            this.radioExistenciasMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioExistenciasMenor.Location = new System.Drawing.Point(16, 87);
            this.radioExistenciasMenor.Name = "radioExistenciasMenor";
            this.radioExistenciasMenor.Size = new System.Drawing.Size(234, 20);
            this.radioExistenciasMenor.TabIndex = 2;
            this.radioExistenciasMenor.TabStop = true;
            this.radioExistenciasMenor.Text = "Productos con existencias menor a";
            this.radioExistenciasMenor.UseVisualStyleBackColor = true;
            // 
            // radioIdFab
            // 
            this.radioIdFab.AutoSize = true;
            this.radioIdFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIdFab.Location = new System.Drawing.Point(16, 54);
            this.radioIdFab.Name = "radioIdFab";
            this.radioIdFab.Size = new System.Drawing.Size(171, 20);
            this.radioIdFab.TabIndex = 1;
            this.radioIdFab.TabStop = true;
            this.radioIdFab.Text = "Productos del fabricante";
            this.radioIdFab.UseVisualStyleBackColor = true;
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Checked = true;
            this.radioTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTodos.Location = new System.Drawing.Point(16, 21);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(152, 20);
            this.radioTodos.TabIndex = 0;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Listado de productos";
            this.radioTodos.UseVisualStyleBackColor = true;
            this.radioTodos.CheckedChanged += new System.EventHandler(this.radioTodos_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioAmbos);
            this.groupBox2.Controls.Add(this.radioEstado);
            this.groupBox2.Controls.Add(this.radioExistencias);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(422, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventario de productos";
            // 
            // radioAmbos
            // 
            this.radioAmbos.AutoSize = true;
            this.radioAmbos.Checked = true;
            this.radioAmbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAmbos.Location = new System.Drawing.Point(6, 87);
            this.radioAmbos.Name = "radioAmbos";
            this.radioAmbos.Size = new System.Drawing.Size(69, 20);
            this.radioAmbos.TabIndex = 3;
            this.radioAmbos.TabStop = true;
            this.radioAmbos.Text = "Ambos";
            this.radioAmbos.UseVisualStyleBackColor = true;
            // 
            // radioEstado
            // 
            this.radioEstado.AutoSize = true;
            this.radioEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEstado.Location = new System.Drawing.Point(6, 61);
            this.radioEstado.Name = "radioEstado";
            this.radioEstado.Size = new System.Drawing.Size(172, 20);
            this.radioEstado.TabIndex = 2;
            this.radioEstado.TabStop = true;
            this.radioEstado.Text = "Estado de los productos";
            this.radioEstado.UseVisualStyleBackColor = true;
            // 
            // radioExistencias
            // 
            this.radioExistencias.AutoSize = true;
            this.radioExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioExistencias.Location = new System.Drawing.Point(6, 33);
            this.radioExistencias.Name = "radioExistencias";
            this.radioExistencias.Size = new System.Drawing.Size(140, 20);
            this.radioExistencias.TabIndex = 0;
            this.radioExistencias.TabStop = true;
            this.radioExistencias.Text = "Total del inventario";
            this.radioExistencias.UseVisualStyleBackColor = true;
            // 
            // btnMostrarConsultaProd
            // 
            this.btnMostrarConsultaProd.Location = new System.Drawing.Point(309, 258);
            this.btnMostrarConsultaProd.Name = "btnMostrarConsultaProd";
            this.btnMostrarConsultaProd.Size = new System.Drawing.Size(137, 23);
            this.btnMostrarConsultaProd.TabIndex = 3;
            this.btnMostrarConsultaProd.Text = "Mostrar";
            this.btnMostrarConsultaProd.UseVisualStyleBackColor = true;
            this.btnMostrarConsultaProd.Click += new System.EventHandler(this.btnMostrarConsultaProd_Click);
            // 
            // dataGridProductosConsultas
            // 
            this.dataGridProductosConsultas.AutoGenerateColumns = false;
            this.dataGridProductosConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductosConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfabDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.existenciasDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridProductosConsultas.DataSource = this.productosBindingSource3;
            this.dataGridProductosConsultas.Location = new System.Drawing.Point(42, 297);
            this.dataGridProductosConsultas.Name = "dataGridProductosConsultas";
            this.dataGridProductosConsultas.Size = new System.Drawing.Size(651, 243);
            this.dataGridProductosConsultas.TabIndex = 4;
            this.dataGridProductosConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductosConsultas_CellContentClick);
            // 
            // productosBindingSource2
            // 
            this.productosBindingSource2.DataMember = "Productos";
            this.productosBindingSource2.DataSource = this.dataSetConsultas1;
            // 
            // dataSetConsultas1
            // 
            this.dataSetConsultas1.DataSetName = "DataSetConsultas";
            this.dataSetConsultas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.dataSetConsultas1;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.dataSetConsultas;
            // 
            // dataSetConsultas
            // 
            this.dataSetConsultas.DataSetName = "DataSetConsultas";
            this.dataSetConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetConsultas1BindingSource
            // 
            this.dataSetConsultas1BindingSource.DataSource = this.dataSetConsultas1;
            this.dataSetConsultas1BindingSource.Position = 0;
            // 
            // productosBindingSource3
            // 
            this.productosBindingSource3.DataMember = "Productos";
            this.productosBindingSource3.DataSource = this.dataSetConsultas1;
            // 
            // idfabDataGridViewTextBoxColumn
            // 
            this.idfabDataGridViewTextBoxColumn.DataPropertyName = "Id_fab";
            this.idfabDataGridViewTextBoxColumn.HeaderText = "Id_fab";
            this.idfabDataGridViewTextBoxColumn.Name = "idfabDataGridViewTextBoxColumn";
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // existenciasDataGridViewTextBoxColumn
            // 
            this.existenciasDataGridViewTextBoxColumn.DataPropertyName = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.HeaderText = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.Name = "existenciasDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // SelectProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(723, 552);
            this.Controls.Add(this.dataGridProductosConsultas);
            this.Controls.Add(this.btnMostrarConsultaProd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPoductos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectProductos";
            this.Text = "SelectProductos";
            this.Load += new System.EventHandler(this.SelectProductos_Load);
            this.groupBoxPoductos.ResumeLayout(false);
            this.groupBoxPoductos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductosConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPoductos;
        private System.Windows.Forms.TextBox txtMenorA;
        private System.Windows.Forms.ComboBox comboIDFabricante;
        private System.Windows.Forms.RadioButton radioExistenciasMenor;
        private System.Windows.Forms.RadioButton radioIdFab;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioEstado;
        private System.Windows.Forms.RadioButton radioExistencias;
        private System.Windows.Forms.Button btnMostrarConsultaProd;
        private System.Windows.Forms.DataGridView dataGridProductosConsultas;
        private DataSetConsultas dataSetConsultas;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DataSetConsultasTableAdapters.ProductosTableAdapter productosTableAdapter;
        private DataSetConsultas dataSetConsultas1;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private System.Windows.Forms.TextBox txtMayorA;
        private System.Windows.Forms.RadioButton radioExistenciasMayor;
        private System.Windows.Forms.RadioButton radioAmbos;
        private System.Windows.Forms.BindingSource productosBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosBindingSource3;
        private System.Windows.Forms.BindingSource dataSetConsultas1BindingSource;
    }
}