namespace EMPRESA_ARH
{
    partial class AgPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgPedidos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCli = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateAgPed = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewDetalles = new System.Windows.Forms.DataGridView();
            this.Id_fab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNumPed = new System.Windows.Forms.Label();
            this.comboRep = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelOficina = new System.Windows.Forms.Label();
            this.labelPutOficina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Representante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // comboCli
            // 
            this.comboCli.FormattingEnabled = true;
            this.comboCli.Location = new System.Drawing.Point(193, 116);
            this.comboCli.Name = "comboCli";
            this.comboCli.Size = new System.Drawing.Size(121, 21);
            this.comboCli.TabIndex = 6;
            this.comboCli.SelectedIndexChanged += new System.EventHandler(this.comboCli_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(644, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Aceptar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateAgPed
            // 
            this.dateAgPed.Location = new System.Drawing.Point(193, 64);
            this.dateAgPed.Name = "dateAgPed";
            this.dateAgPed.Size = new System.Drawing.Size(200, 20);
            this.dateAgPed.TabIndex = 13;
            // 
            // dataGridViewDetalles
            // 
            this.dataGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_fab,
            this.Id_Producto,
            this.Cantidad,
            this.Descripcion,
            this.Precio,
            this.Importe});
            this.dataGridViewDetalles.Location = new System.Drawing.Point(14, 243);
            this.dataGridViewDetalles.Name = "dataGridViewDetalles";
            this.dataGridViewDetalles.Size = new System.Drawing.Size(759, 132);
            this.dataGridViewDetalles.TabIndex = 15;
            this.dataGridViewDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridViewDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Id_fab
            // 
            this.Id_fab.HeaderText = "Id_Fabrica";
            this.Id_fab.Name = "Id_fab";
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id_Producto";
            this.Id_Producto.Name = "Id_Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 220;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // labelNumPed
            // 
            this.labelNumPed.AutoSize = true;
            this.labelNumPed.Location = new System.Drawing.Point(190, 23);
            this.labelNumPed.Name = "labelNumPed";
            this.labelNumPed.Size = new System.Drawing.Size(0, 13);
            this.labelNumPed.TabIndex = 18;
            // 
            // comboRep
            // 
            this.comboRep.FormattingEnabled = true;
            this.comboRep.Location = new System.Drawing.Point(193, 157);
            this.comboRep.Name = "comboRep";
            this.comboRep.Size = new System.Drawing.Size(121, 21);
            this.comboRep.TabIndex = 19;
            this.comboRep.SelectedIndexChanged += new System.EventHandler(this.comboRep_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(145, 394);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotal.TabIndex = 20;
            // 
            // labelOficina
            // 
            this.labelOficina.AutoSize = true;
            this.labelOficina.Location = new System.Drawing.Point(27, 210);
            this.labelOficina.Name = "labelOficina";
            this.labelOficina.Size = new System.Drawing.Size(40, 13);
            this.labelOficina.TabIndex = 21;
            this.labelOficina.Text = "Oficina";
            // 
            // labelPutOficina
            // 
            this.labelPutOficina.AutoSize = true;
            this.labelPutOficina.Location = new System.Drawing.Point(190, 210);
            this.labelPutOficina.Name = "labelPutOficina";
            this.labelPutOficina.Size = new System.Drawing.Size(0, 13);
            this.labelPutOficina.TabIndex = 22;
            // 
            // AgPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(789, 421);
            this.Controls.Add(this.labelPutOficina);
            this.Controls.Add(this.labelOficina);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.comboRep);
            this.Controls.Add(this.labelNumPed);
            this.Controls.Add(this.dataGridViewDetalles);
            this.Controls.Add(this.dateAgPed);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgPedidos";
            this.Text = "AgPedidos";
            this.Load += new System.EventHandler(this.AgPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCli;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateAgPed;
        private System.Windows.Forms.DataGridView dataGridViewDetalles;
        private System.Windows.Forms.Label labelNumPed;
        private System.Windows.Forms.ComboBox comboRep;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_fab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label labelOficina;
        private System.Windows.Forms.Label labelPutOficina;
    }
}