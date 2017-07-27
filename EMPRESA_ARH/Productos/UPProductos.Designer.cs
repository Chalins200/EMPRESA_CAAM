namespace EMPRESA_ARH
{
    partial class UPProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPProductos));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtExi = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboClFab = new System.Windows.Forms.ComboBox();
            this.comboClProd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Actualizar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtExi
            // 
            this.txtExi.Location = new System.Drawing.Point(194, 220);
            this.txtExi.Name = "txtExi";
            this.txtExi.Size = new System.Drawing.Size(121, 20);
            this.txtExi.TabIndex = 22;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(194, 175);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(121, 20);
            this.txtPre.TabIndex = 21;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(194, 120);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(121, 20);
            this.txtDesc.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Existencias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Clave del Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clave del Fabricante";
            // 
            // comboClFab
            // 
            this.comboClFab.FormattingEnabled = true;
            this.comboClFab.Location = new System.Drawing.Point(194, 26);
            this.comboClFab.Name = "comboClFab";
            this.comboClFab.Size = new System.Drawing.Size(121, 21);
            this.comboClFab.TabIndex = 24;
            this.comboClFab.SelectedIndexChanged += new System.EventHandler(this.comboClFab_SelectedIndexChanged);
            // 
            // comboClProd
            // 
            this.comboClProd.FormattingEnabled = true;
            this.comboClProd.Location = new System.Drawing.Point(194, 73);
            this.comboClProd.Name = "comboClProd";
            this.comboClProd.Size = new System.Drawing.Size(121, 21);
            this.comboClProd.TabIndex = 25;
            this.comboClProd.SelectedIndexChanged += new System.EventHandler(this.comboClProd_SelectedIndexChanged);
            // 
            // UPProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(350, 360);
            this.Controls.Add(this.comboClProd);
            this.Controls.Add(this.comboClFab);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtExi);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UPProductos";
            this.Text = "UPProductos";
            this.Load += new System.EventHandler(this.UPProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtExi;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboClFab;
        private System.Windows.Forms.ComboBox comboClProd;
    }
}