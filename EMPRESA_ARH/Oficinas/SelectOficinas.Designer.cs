namespace EMPRESA_ARH.Oficinas
{
    partial class SelectOficinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectOficinas));
            this.dataGridConsultas = new System.Windows.Forms.DataGridView();
            this.oficinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oficinasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultas = new EMPRESA_ARH.DataSetConsultas();
            this.btnMostrarConsultaProd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboRegion = new System.Windows.Forms.ComboBox();
            this.radioRegion = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMayorA = new System.Windows.Forms.TextBox();
            this.radioMayor = new System.Windows.Forms.RadioButton();
            this.txtMenorA = new System.Windows.Forms.TextBox();
            this.comboNumeroOficina = new System.Windows.Forms.ComboBox();
            this.radioMenor = new System.Windows.Forms.RadioButton();
            this.radioNumeroOficina = new System.Windows.Forms.RadioButton();
            this.radioListado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.oficinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oficinasTableAdapter = new EMPRESA_ARH.DataSetConsultasTableAdapters.OficinasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficinasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oficinasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsultas
            // 
            this.dataGridConsultas.AutoGenerateColumns = false;
            this.dataGridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oficinaDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.dirDataGridViewTextBoxColumn,
            this.objetivoDataGridViewTextBoxColumn,
            this.ventasDataGridViewTextBoxColumn});
            this.dataGridConsultas.DataSource = this.oficinasBindingSource1;
            this.dataGridConsultas.Location = new System.Drawing.Point(28, 298);
            this.dataGridConsultas.Name = "dataGridConsultas";
            this.dataGridConsultas.Size = new System.Drawing.Size(651, 210);
            this.dataGridConsultas.TabIndex = 24;
            // 
            // oficinaDataGridViewTextBoxColumn
            // 
            this.oficinaDataGridViewTextBoxColumn.DataPropertyName = "Oficina";
            this.oficinaDataGridViewTextBoxColumn.HeaderText = "Oficina";
            this.oficinaDataGridViewTextBoxColumn.Name = "oficinaDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // dirDataGridViewTextBoxColumn
            // 
            this.dirDataGridViewTextBoxColumn.DataPropertyName = "Dir";
            this.dirDataGridViewTextBoxColumn.HeaderText = "Dir";
            this.dirDataGridViewTextBoxColumn.Name = "dirDataGridViewTextBoxColumn";
            // 
            // objetivoDataGridViewTextBoxColumn
            // 
            this.objetivoDataGridViewTextBoxColumn.DataPropertyName = "Objetivo";
            this.objetivoDataGridViewTextBoxColumn.HeaderText = "Objetivo";
            this.objetivoDataGridViewTextBoxColumn.Name = "objetivoDataGridViewTextBoxColumn";
            // 
            // ventasDataGridViewTextBoxColumn
            // 
            this.ventasDataGridViewTextBoxColumn.DataPropertyName = "Ventas";
            this.ventasDataGridViewTextBoxColumn.HeaderText = "Ventas";
            this.ventasDataGridViewTextBoxColumn.Name = "ventasDataGridViewTextBoxColumn";
            // 
            // oficinasBindingSource1
            // 
            this.oficinasBindingSource1.DataMember = "Oficinas";
            this.oficinasBindingSource1.DataSource = this.dataSetConsultas;
            // 
            // dataSetConsultas
            // 
            this.dataSetConsultas.DataSetName = "DataSetConsultas";
            this.dataSetConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMostrarConsultaProd
            // 
            this.btnMostrarConsultaProd.Location = new System.Drawing.Point(297, 269);
            this.btnMostrarConsultaProd.Name = "btnMostrarConsultaProd";
            this.btnMostrarConsultaProd.Size = new System.Drawing.Size(137, 23);
            this.btnMostrarConsultaProd.TabIndex = 23;
            this.btnMostrarConsultaProd.Text = "Mostrar";
            this.btnMostrarConsultaProd.UseVisualStyleBackColor = true;
            this.btnMostrarConsultaProd.Click += new System.EventHandler(this.btnMostrarConsultaProd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboRegion);
            this.groupBox2.Controls.Add(this.radioRegion);
            this.groupBox2.Controls.Add(this.radioTodos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(390, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 151);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Oficinas";
            // 
            // comboRegion
            // 
            this.comboRegion.FormattingEnabled = true;
            this.comboRegion.Location = new System.Drawing.Point(82, 71);
            this.comboRegion.Name = "comboRegion";
            this.comboRegion.Size = new System.Drawing.Size(121, 24);
            this.comboRegion.TabIndex = 4;
            // 
            // radioRegion
            // 
            this.radioRegion.AutoSize = true;
            this.radioRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRegion.Location = new System.Drawing.Point(6, 72);
            this.radioRegion.Name = "radioRegion";
            this.radioRegion.Size = new System.Drawing.Size(70, 20);
            this.radioRegion.TabIndex = 1;
            this.radioRegion.Text = "Region";
            this.radioRegion.UseVisualStyleBackColor = true;
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Checked = true;
            this.radioTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTodos.Location = new System.Drawing.Point(6, 31);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(143, 20);
            this.radioTodos.TabIndex = 0;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todas las regiones";
            this.radioTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMayorA);
            this.groupBox1.Controls.Add(this.radioMayor);
            this.groupBox1.Controls.Add(this.txtMenorA);
            this.groupBox1.Controls.Add(this.comboNumeroOficina);
            this.groupBox1.Controls.Add(this.radioMenor);
            this.groupBox1.Controls.Add(this.radioNumeroOficina);
            this.groupBox1.Controls.Add(this.radioListado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 196);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oficinas";
            // 
            // txtMayorA
            // 
            this.txtMayorA.Location = new System.Drawing.Point(174, 144);
            this.txtMayorA.Name = "txtMayorA";
            this.txtMayorA.Size = new System.Drawing.Size(121, 22);
            this.txtMayorA.TabIndex = 6;
            // 
            // radioMayor
            // 
            this.radioMayor.AutoSize = true;
            this.radioMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMayor.Location = new System.Drawing.Point(16, 144);
            this.radioMayor.Name = "radioMayor";
            this.radioMayor.Size = new System.Drawing.Size(123, 20);
            this.radioMayor.TabIndex = 5;
            this.radioMayor.Text = "Ventas  Mayor a";
            this.radioMayor.UseVisualStyleBackColor = true;
            // 
            // txtMenorA
            // 
            this.txtMenorA.Location = new System.Drawing.Point(174, 109);
            this.txtMenorA.Name = "txtMenorA";
            this.txtMenorA.Size = new System.Drawing.Size(121, 22);
            this.txtMenorA.TabIndex = 4;
            // 
            // comboNumeroOficina
            // 
            this.comboNumeroOficina.FormattingEnabled = true;
            this.comboNumeroOficina.Location = new System.Drawing.Point(174, 68);
            this.comboNumeroOficina.Name = "comboNumeroOficina";
            this.comboNumeroOficina.Size = new System.Drawing.Size(121, 24);
            this.comboNumeroOficina.TabIndex = 3;
            // 
            // radioMenor
            // 
            this.radioMenor.AutoSize = true;
            this.radioMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMenor.Location = new System.Drawing.Point(16, 106);
            this.radioMenor.Name = "radioMenor";
            this.radioMenor.Size = new System.Drawing.Size(123, 20);
            this.radioMenor.TabIndex = 2;
            this.radioMenor.Text = "Ventas  Menor a";
            this.radioMenor.UseVisualStyleBackColor = true;
            // 
            // radioNumeroOficina
            // 
            this.radioNumeroOficina.AutoSize = true;
            this.radioNumeroOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNumeroOficina.Location = new System.Drawing.Point(16, 69);
            this.radioNumeroOficina.Name = "radioNumeroOficina";
            this.radioNumeroOficina.Size = new System.Drawing.Size(137, 20);
            this.radioNumeroOficina.TabIndex = 1;
            this.radioNumeroOficina.Text = "Numero de Oficina";
            this.radioNumeroOficina.UseVisualStyleBackColor = true;
            // 
            // radioListado
            // 
            this.radioListado.AutoSize = true;
            this.radioListado.Checked = true;
            this.radioListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioListado.Location = new System.Drawing.Point(16, 31);
            this.radioListado.Name = "radioListado";
            this.radioListado.Size = new System.Drawing.Size(140, 20);
            this.radioListado.TabIndex = 0;
            this.radioListado.TabStop = true;
            this.radioListado.Text = "Listado de Oficinas";
            this.radioListado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consultas de Oficinas";
            // 
            // oficinasBindingSource
            // 
            this.oficinasBindingSource.DataMember = "Oficinas";
            this.oficinasBindingSource.DataSource = this.dataSetConsultas;
            // 
            // oficinasTableAdapter
            // 
            this.oficinasTableAdapter.ClearBeforeFill = true;
            // 
            // SelectOficinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(702, 529);
            this.Controls.Add(this.dataGridConsultas);
            this.Controls.Add(this.btnMostrarConsultaProd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectOficinas";
            this.Text = "SelectOficinas";
            this.Load += new System.EventHandler(this.SelectOficinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficinasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oficinasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsultas;
        private System.Windows.Forms.Button btnMostrarConsultaProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioRegion;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMenorA;
        private System.Windows.Forms.ComboBox comboNumeroOficina;
        private System.Windows.Forms.RadioButton radioMenor;
        private System.Windows.Forms.RadioButton radioNumeroOficina;
        private System.Windows.Forms.RadioButton radioListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRegion;
        private System.Windows.Forms.TextBox txtMayorA;
        private System.Windows.Forms.RadioButton radioMayor;
        private DataSetConsultas dataSetConsultas;
        private System.Windows.Forms.BindingSource oficinasBindingSource;
        private DataSetConsultasTableAdapters.OficinasTableAdapter oficinasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oficinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oficinasBindingSource1;
    }
}