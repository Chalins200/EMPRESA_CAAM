namespace EMPRESA_ARH
{
    partial class UpOficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpOficina));
            this.btnUp = new System.Windows.Forms.Button();
            this.comboDir = new System.Windows.Forms.ComboBox();
            this.txtVent = new System.Windows.Forms.TextBox();
            this.txtObj = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtCiu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboOfi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(66, 339);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(134, 23);
            this.btnUp.TabIndex = 26;
            this.btnUp.Text = "Actualizar";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // comboDir
            // 
            this.comboDir.FormattingEnabled = true;
            this.comboDir.Location = new System.Drawing.Point(111, 185);
            this.comboDir.Name = "comboDir";
            this.comboDir.Size = new System.Drawing.Size(121, 21);
            this.comboDir.TabIndex = 25;
            this.comboDir.SelectedIndexChanged += new System.EventHandler(this.comboDir_SelectedIndexChanged);
            // 
            // txtVent
            // 
            this.txtVent.Location = new System.Drawing.Point(111, 292);
            this.txtVent.Name = "txtVent";
            this.txtVent.Size = new System.Drawing.Size(121, 20);
            this.txtVent.TabIndex = 24;
            // 
            // txtObj
            // 
            this.txtObj.Location = new System.Drawing.Point(111, 238);
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(121, 20);
            this.txtObj.TabIndex = 23;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(111, 131);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(121, 20);
            this.txtReg.TabIndex = 22;
            // 
            // txtCiu
            // 
            this.txtCiu.Location = new System.Drawing.Point(111, 82);
            this.txtCiu.Name = "txtCiu";
            this.txtCiu.Size = new System.Drawing.Size(121, 20);
            this.txtCiu.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Objetivo";
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(28, 188);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(44, 13);
            this.labelDir.TabIndex = 17;
            this.labelDir.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Oficina";
            // 
            // comboOfi
            // 
            this.comboOfi.FormattingEnabled = true;
            this.comboOfi.Location = new System.Drawing.Point(111, 26);
            this.comboOfi.Name = "comboOfi";
            this.comboOfi.Size = new System.Drawing.Size(121, 21);
            this.comboOfi.TabIndex = 27;
            this.comboOfi.SelectedIndexChanged += new System.EventHandler(this.comboOfi_SelectedIndexChanged);
            // 
            // UpOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(274, 383);
            this.Controls.Add(this.comboOfi);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.comboDir);
            this.Controls.Add(this.txtVent);
            this.Controls.Add(this.txtObj);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.txtCiu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpOficina";
            this.Text = "UpOficina";
            this.Load += new System.EventHandler(this.UpOficina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ComboBox comboDir;
        private System.Windows.Forms.TextBox txtVent;
        private System.Windows.Forms.TextBox txtObj;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtCiu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboOfi;
    }
}