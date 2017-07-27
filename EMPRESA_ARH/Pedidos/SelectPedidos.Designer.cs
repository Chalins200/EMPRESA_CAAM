namespace EMPRESA_ARH.Pedidos
{
    partial class SelectPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPedidos));
            this.dataGridConsultas = new System.Windows.Forms.DataGridView();
            this.numPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numClieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultas = new EMPRESA_ARH.DataSetConsultas();
            this.btnMostrarConsultaProd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboActivoInactivo = new System.Windows.Forms.ComboBox();
            this.radioEstado = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMayorA = new System.Windows.Forms.TextBox();
            this.radioMayor = new System.Windows.Forms.RadioButton();
            this.txtMenorA = new System.Windows.Forms.TextBox();
            this.comboNumeroPedido = new System.Windows.Forms.ComboBox();
            this.radioMenor = new System.Windows.Forms.RadioButton();
            this.radioNumeroPedido = new System.Windows.Forms.RadioButton();
            this.radioListado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pedidosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoDetallesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedido_DetallesTableAdapter = new EMPRESA_ARH.DataSetConsultasTableAdapters.Pedido_DetallesTableAdapter();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new EMPRESA_ARH.DataSetConsultasTableAdapters.PedidosTableAdapter();
            this.pedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsultas
            // 
            this.dataGridConsultas.AutoGenerateColumns = false;
            this.dataGridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPedidoDataGridViewTextBoxColumn,
            this.fechaPedidoDataGridViewTextBoxColumn,
            this.numClieDataGridViewTextBoxColumn,
            this.repDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridConsultas.DataSource = this.pedidosBindingSource3;
            this.dataGridConsultas.Location = new System.Drawing.Point(60, 275);
            this.dataGridConsultas.Name = "dataGridConsultas";
            this.dataGridConsultas.Size = new System.Drawing.Size(651, 210);
            this.dataGridConsultas.TabIndex = 19;
            // 
            // numPedidoDataGridViewTextBoxColumn
            // 
            this.numPedidoDataGridViewTextBoxColumn.DataPropertyName = "Num_Pedido";
            this.numPedidoDataGridViewTextBoxColumn.HeaderText = "Num_Pedido";
            this.numPedidoDataGridViewTextBoxColumn.Name = "numPedidoDataGridViewTextBoxColumn";
            // 
            // fechaPedidoDataGridViewTextBoxColumn
            // 
            this.fechaPedidoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Pedido";
            this.fechaPedidoDataGridViewTextBoxColumn.HeaderText = "Fecha_Pedido";
            this.fechaPedidoDataGridViewTextBoxColumn.Name = "fechaPedidoDataGridViewTextBoxColumn";
            // 
            // numClieDataGridViewTextBoxColumn
            // 
            this.numClieDataGridViewTextBoxColumn.DataPropertyName = "Num_Clie";
            this.numClieDataGridViewTextBoxColumn.HeaderText = "Num_Clie";
            this.numClieDataGridViewTextBoxColumn.Name = "numClieDataGridViewTextBoxColumn";
            // 
            // repDataGridViewTextBoxColumn
            // 
            this.repDataGridViewTextBoxColumn.DataPropertyName = "Rep";
            this.repDataGridViewTextBoxColumn.HeaderText = "Rep";
            this.repDataGridViewTextBoxColumn.Name = "repDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // pedidosBindingSource3
            // 
            this.pedidosBindingSource3.DataMember = "Pedidos";
            this.pedidosBindingSource3.DataSource = this.dataSetConsultas;
            // 
            // dataSetConsultas
            // 
            this.dataSetConsultas.DataSetName = "DataSetConsultas";
            this.dataSetConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMostrarConsultaProd
            // 
            this.btnMostrarConsultaProd.Location = new System.Drawing.Point(328, 246);
            this.btnMostrarConsultaProd.Name = "btnMostrarConsultaProd";
            this.btnMostrarConsultaProd.Size = new System.Drawing.Size(137, 23);
            this.btnMostrarConsultaProd.TabIndex = 18;
            this.btnMostrarConsultaProd.Text = "Mostrar";
            this.btnMostrarConsultaProd.UseVisualStyleBackColor = true;
            this.btnMostrarConsultaProd.Click += new System.EventHandler(this.btnMostrarConsultaProd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboActivoInactivo);
            this.groupBox2.Controls.Add(this.radioEstado);
            this.groupBox2.Controls.Add(this.radioTodos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(484, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboActivoInactivo
            // 
            this.comboActivoInactivo.FormattingEnabled = true;
            this.comboActivoInactivo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboActivoInactivo.Location = new System.Drawing.Point(138, 64);
            this.comboActivoInactivo.Name = "comboActivoInactivo";
            this.comboActivoInactivo.Size = new System.Drawing.Size(121, 24);
            this.comboActivoInactivo.TabIndex = 7;
            this.comboActivoInactivo.SelectedIndexChanged += new System.EventHandler(this.comboActivoInactivo_SelectedIndexChanged);
            // 
            // radioEstado
            // 
            this.radioEstado.AutoSize = true;
            this.radioEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEstado.Location = new System.Drawing.Point(6, 64);
            this.radioEstado.Name = "radioEstado";
            this.radioEstado.Size = new System.Drawing.Size(113, 20);
            this.radioEstado.TabIndex = 21;
            this.radioEstado.Text = "Activo/Inactivo";
            this.radioEstado.UseVisualStyleBackColor = true;
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Checked = true;
            this.radioTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTodos.Location = new System.Drawing.Point(6, 31);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(66, 20);
            this.radioTodos.TabIndex = 2;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMayorA);
            this.groupBox1.Controls.Add(this.radioMayor);
            this.groupBox1.Controls.Add(this.txtMenorA);
            this.groupBox1.Controls.Add(this.comboNumeroPedido);
            this.groupBox1.Controls.Add(this.radioMenor);
            this.groupBox1.Controls.Add(this.radioNumeroPedido);
            this.groupBox1.Controls.Add(this.radioListado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 175);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido";
            // 
            // txtMayorA
            // 
            this.txtMayorA.Location = new System.Drawing.Point(177, 125);
            this.txtMayorA.Name = "txtMayorA";
            this.txtMayorA.Size = new System.Drawing.Size(121, 22);
            this.txtMayorA.TabIndex = 6;
            // 
            // radioMayor
            // 
            this.radioMayor.AutoSize = true;
            this.radioMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMayor.Location = new System.Drawing.Point(16, 125);
            this.radioMayor.Name = "radioMayor";
            this.radioMayor.Size = new System.Drawing.Size(112, 20);
            this.radioMayor.TabIndex = 5;
            this.radioMayor.Text = "Total  mayor a";
            this.radioMayor.UseVisualStyleBackColor = true;
            // 
            // txtMenorA
            // 
            this.txtMenorA.Location = new System.Drawing.Point(177, 97);
            this.txtMenorA.Name = "txtMenorA";
            this.txtMenorA.Size = new System.Drawing.Size(121, 22);
            this.txtMenorA.TabIndex = 4;
            // 
            // comboNumeroPedido
            // 
            this.comboNumeroPedido.FormattingEnabled = true;
            this.comboNumeroPedido.Location = new System.Drawing.Point(177, 64);
            this.comboNumeroPedido.Name = "comboNumeroPedido";
            this.comboNumeroPedido.Size = new System.Drawing.Size(121, 24);
            this.comboNumeroPedido.TabIndex = 3;
            // 
            // radioMenor
            // 
            this.radioMenor.AutoSize = true;
            this.radioMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenor.Location = new System.Drawing.Point(16, 97);
            this.radioMenor.Name = "radioMenor";
            this.radioMenor.Size = new System.Drawing.Size(112, 20);
            this.radioMenor.TabIndex = 2;
            this.radioMenor.Text = "Total  menor a";
            this.radioMenor.UseVisualStyleBackColor = true;
            // 
            // radioNumeroPedido
            // 
            this.radioNumeroPedido.AutoSize = true;
            this.radioNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNumeroPedido.Location = new System.Drawing.Point(16, 68);
            this.radioNumeroPedido.Name = "radioNumeroPedido";
            this.radioNumeroPedido.Size = new System.Drawing.Size(140, 20);
            this.radioNumeroPedido.TabIndex = 1;
            this.radioNumeroPedido.Text = "Numero de Pedido";
            this.radioNumeroPedido.UseVisualStyleBackColor = true;
            // 
            // radioListado
            // 
            this.radioListado.AutoSize = true;
            this.radioListado.Checked = true;
            this.radioListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioListado.Location = new System.Drawing.Point(16, 31);
            this.radioListado.Name = "radioListado";
            this.radioListado.Size = new System.Drawing.Size(143, 20);
            this.radioListado.TabIndex = 0;
            this.radioListado.TabStop = true;
            this.radioListado.Text = "Listado de Pedidos";
            this.radioListado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Consultas de Pedidos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ver datalle de pedidos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pedidosBindingSource2
            // 
            this.pedidosBindingSource2.DataMember = "Pedidos";
            this.pedidosBindingSource2.DataSource = this.dataSetConsultas;
            // 
            // pedidoDetallesBindingSource1
            // 
            this.pedidoDetallesBindingSource1.DataMember = "Pedido_Detalles";
            this.pedidoDetallesBindingSource1.DataSource = this.dataSetConsultas;
            // 
            // pedidoDetallesBindingSource
            // 
            this.pedidoDetallesBindingSource.DataMember = "Pedido_Detalles";
            this.pedidoDetallesBindingSource.DataSource = this.dataSetConsultas;
            // 
            // pedido_DetallesTableAdapter
            // 
            this.pedido_DetallesTableAdapter.ClearBeforeFill = true;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.dataSetConsultas;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // pedidosBindingSource1
            // 
            this.pedidosBindingSource1.DataMember = "Pedidos";
            this.pedidosBindingSource1.DataSource = this.dataSetConsultas;
            // 
            // dataSetConsultasBindingSource
            // 
            this.dataSetConsultasBindingSource.DataSource = this.dataSetConsultas;
            this.dataSetConsultasBindingSource.Position = 0;
            // 
            // SelectPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(785, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridConsultas);
            this.Controls.Add(this.btnMostrarConsultaProd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectPedidos";
            this.Text = "SelectPedidos";
            this.Load += new System.EventHandler(this.SelectPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsultas;
        private System.Windows.Forms.Button btnMostrarConsultaProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMenorA;
        private System.Windows.Forms.RadioButton radioMenor;
        private System.Windows.Forms.RadioButton radioNumeroPedido;
        private System.Windows.Forms.RadioButton radioListado;
        private System.Windows.Forms.Label label1;
        private DataSetConsultas dataSetConsultas;
        private System.Windows.Forms.BindingSource pedidoDetallesBindingSource;
        private DataSetConsultasTableAdapters.Pedido_DetallesTableAdapter pedido_DetallesTableAdapter;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private DataSetConsultasTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.BindingSource pedidoDetallesBindingSource1;
        private System.Windows.Forms.BindingSource pedidosBindingSource1;
        private System.Windows.Forms.ComboBox comboActivoInactivo;
        private System.Windows.Forms.RadioButton radioEstado;
        private System.Windows.Forms.TextBox txtMayorA;
        private System.Windows.Forms.RadioButton radioMayor;
        private System.Windows.Forms.BindingSource pedidosBindingSource2;
        public System.Windows.Forms.ComboBox comboNumeroPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pedidosBindingSource3;
        private System.Windows.Forms.BindingSource dataSetConsultasBindingSource;
    }
}