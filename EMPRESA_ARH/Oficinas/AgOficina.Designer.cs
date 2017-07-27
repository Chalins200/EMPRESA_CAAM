namespace EMPRESA_ARH
{
    partial class AgOficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgOficina));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOfi = new System.Windows.Forms.TextBox();
            this.txtCiu = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtObj = new System.Windows.Forms.TextBox();
            this.txtVent = new System.Windows.Forms.TextBox();
            this.comboDir = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Oficina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Director";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Objetivo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ventas";
            // 
            // txtOfi
            // 
            this.txtOfi.Location = new System.Drawing.Point(114, 26);
            this.txtOfi.Name = "txtOfi";
            this.txtOfi.Size = new System.Drawing.Size(121, 20);
            this.txtOfi.TabIndex = 6;
            // 
            // txtCiu
            // 
            this.txtCiu.Location = new System.Drawing.Point(114, 62);
            this.txtCiu.Name = "txtCiu";
            this.txtCiu.Size = new System.Drawing.Size(121, 20);
            this.txtCiu.TabIndex = 7;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(114, 98);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(121, 20);
            this.txtReg.TabIndex = 8;
            // 
            // txtObj
            // 
            this.txtObj.Location = new System.Drawing.Point(114, 178);
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(121, 20);
            this.txtObj.TabIndex = 10;
            // 
            // txtVent
            // 
            this.txtVent.Location = new System.Drawing.Point(114, 219);
            this.txtVent.Name = "txtVent";
            this.txtVent.Size = new System.Drawing.Size(121, 20);
            this.txtVent.TabIndex = 11;
            // 
            // comboDir
            // 
            this.comboDir.FormattingEnabled = true;
            this.comboDir.Location = new System.Drawing.Point(114, 138);
            this.comboDir.Name = "comboDir";
            this.comboDir.Size = new System.Drawing.Size(121, 21);
            this.comboDir.TabIndex = 12;
            this.comboDir.SelectedIndexChanged += new System.EventHandler(this.comboDir_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(74, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AgOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(287, 319);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboDir);
            this.Controls.Add(this.txtVent);
            this.Controls.Add(this.txtObj);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.txtCiu);
            this.Controls.Add(this.txtOfi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgOficina";
            this.Text = "AgOficina";
            this.Load += new System.EventHandler(this.AgOficina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOfi;
        private System.Windows.Forms.TextBox txtCiu;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtObj;
        private System.Windows.Forms.TextBox txtVent;
        private System.Windows.Forms.ComboBox comboDir;
        private System.Windows.Forms.Button btnAdd;
    }
}