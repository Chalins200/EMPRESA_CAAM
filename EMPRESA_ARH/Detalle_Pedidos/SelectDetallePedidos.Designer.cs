﻿namespace EMPRESA_ARH.Detalle_Pedidos
{
    partial class SelectDetallePedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDetallePedidos));
            this.dataGridConsultas = new System.Windows.Forms.DataGridView();
            this.numPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoDetallesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultas = new EMPRESA_ARH.DataSetConsultas();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboNumeroPedido = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pedidoDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedido_DetallesTableAdapter = new EMPRESA_ARH.DataSetConsultasTableAdapters.Pedido_DetallesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsultas
            // 
            this.dataGridConsultas.AutoGenerateColumns = false;
            this.dataGridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPedidoDataGridViewTextBoxColumn,
            this.idfabDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.cantDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn});
            this.dataGridConsultas.DataSource = this.pedidoDetallesBindingSource1;
            this.dataGridConsultas.Location = new System.Drawing.Point(12, 113);
            this.dataGridConsultas.Name = "dataGridConsultas";
            this.dataGridConsultas.Size = new System.Drawing.Size(643, 293);
            this.dataGridConsultas.TabIndex = 29;
            // 
            // numPedidoDataGridViewTextBoxColumn
            // 
            this.numPedidoDataGridViewTextBoxColumn.DataPropertyName = "Num_Pedido";
            this.numPedidoDataGridViewTextBoxColumn.HeaderText = "Num_Pedido";
            this.numPedidoDataGridViewTextBoxColumn.Name = "numPedidoDataGridViewTextBoxColumn";
            // 
            // idfabDataGridViewTextBoxColumn
            // 
            this.idfabDataGridViewTextBoxColumn.DataPropertyName = "Id_fab";
            this.idfabDataGridViewTextBoxColumn.HeaderText = "Id_fab";
            this.idfabDataGridViewTextBoxColumn.Name = "idfabDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // cantDataGridViewTextBoxColumn
            // 
            this.cantDataGridViewTextBoxColumn.DataPropertyName = "Cant";
            this.cantDataGridViewTextBoxColumn.HeaderText = "Cant";
            this.cantDataGridViewTextBoxColumn.Name = "cantDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            // 
            // pedidoDetallesBindingSource1
            // 
            this.pedidoDetallesBindingSource1.DataMember = "Pedido_Detalles";
            this.pedidoDetallesBindingSource1.DataSource = this.dataSetConsultas;
            // 
            // dataSetConsultas
            // 
            this.dataSetConsultas.DataSetName = "DataSetConsultas";
            this.dataSetConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Detalles Pedido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Ver datalle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboNumeroPedido
            // 
            this.comboNumeroPedido.FormattingEnabled = true;
            this.comboNumeroPedido.Location = new System.Drawing.Point(220, 68);
            this.comboNumeroPedido.Name = "comboNumeroPedido";
            this.comboNumeroPedido.Size = new System.Drawing.Size(121, 21);
            this.comboNumeroPedido.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Numero de pedido";
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
            // SelectDetallePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboNumeroPedido);
            this.Controls.Add(this.dataGridConsultas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectDetallePedidos";
            this.Text = "SelectDetallePedidos";
            this.Load += new System.EventHandler(this.SelectDetallePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsultas;
        private System.Windows.Forms.Label label1;
        private DataSetConsultas dataSetConsultas;
        private System.Windows.Forms.BindingSource pedidoDetallesBindingSource;
        private DataSetConsultasTableAdapters.Pedido_DetallesTableAdapter pedido_DetallesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboNumeroPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource pedidoDetallesBindingSource1;
    }
}