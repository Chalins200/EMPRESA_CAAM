namespace EMPRESA_ARH
{
    partial class DeleteProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProductos));
            this.comboClProd = new System.Windows.Forms.ComboBox();
            this.comboClFab = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelDelProEst = new System.Windows.Forms.Label();
            this.labelSetEst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboClProd
            // 
            this.comboClProd.FormattingEnabled = true;
            this.comboClProd.Location = new System.Drawing.Point(186, 76);
            this.comboClProd.Name = "comboClProd";
            this.comboClProd.Size = new System.Drawing.Size(121, 21);
            this.comboClProd.TabIndex = 29;
            this.comboClProd.SelectedIndexChanged += new System.EventHandler(this.comboClProd_SelectedIndexChanged);
            // 
            // comboClFab
            // 
            this.comboClFab.FormattingEnabled = true;
            this.comboClFab.Location = new System.Drawing.Point(186, 29);
            this.comboClFab.Name = "comboClFab";
            this.comboClFab.Size = new System.Drawing.Size(121, 21);
            this.comboClFab.TabIndex = 28;
            this.comboClFab.SelectedIndexChanged += new System.EventHandler(this.comboClFab_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Clave del Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Clave del Fabricante";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(130, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Descontinuar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelDelProEst
            // 
            this.labelDelProEst.AutoSize = true;
            this.labelDelProEst.Location = new System.Drawing.Point(25, 128);
            this.labelDelProEst.Name = "labelDelProEst";
            this.labelDelProEst.Size = new System.Drawing.Size(40, 13);
            this.labelDelProEst.TabIndex = 31;
            this.labelDelProEst.Text = "Estado";
            // 
            // labelSetEst
            // 
            this.labelSetEst.AutoSize = true;
            this.labelSetEst.Location = new System.Drawing.Point(184, 128);
            this.labelSetEst.Name = "labelSetEst";
            this.labelSetEst.Size = new System.Drawing.Size(0, 13);
            this.labelSetEst.TabIndex = 32;
            // 
            // DeleteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(326, 262);
            this.Controls.Add(this.labelSetEst);
            this.Controls.Add(this.labelDelProEst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboClProd);
            this.Controls.Add(this.comboClFab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteProductos";
            this.Text = "DeleteProductos";
            this.Load += new System.EventHandler(this.DeleteProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboClProd;
        private System.Windows.Forms.ComboBox comboClFab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelDelProEst;
        private System.Windows.Forms.Label labelSetEst;
    }
}