namespace EMPRESA_ARH
{
    partial class UpClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpClientes));
            this.txtLimCred = new System.Windows.Forms.TextBox();
            this.comboRepClie = new System.Windows.Forms.ComboBox();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNumClie = new System.Windows.Forms.ComboBox();
            this.labelUpCliRep = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLimCred
            // 
            this.txtLimCred.Location = new System.Drawing.Point(217, 224);
            this.txtLimCred.Name = "txtLimCred";
            this.txtLimCred.Size = new System.Drawing.Size(121, 20);
            this.txtLimCred.TabIndex = 17;
            // 
            // comboRepClie
            // 
            this.comboRepClie.FormattingEnabled = true;
            this.comboRepClie.Location = new System.Drawing.Point(217, 173);
            this.comboRepClie.Name = "comboRepClie";
            this.comboRepClie.Size = new System.Drawing.Size(121, 21);
            this.comboRepClie.TabIndex = 16;
            this.comboRepClie.SelectedIndexChanged += new System.EventHandler(this.comboRepClie_SelectedIndexChanged);
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(217, 82);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(121, 20);
            this.txtEmp.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Limite de credito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Representante actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero de cliente";
            // 
            // comboNumClie
            // 
            this.comboNumClie.FormattingEnabled = true;
            this.comboNumClie.Location = new System.Drawing.Point(217, 28);
            this.comboNumClie.Name = "comboNumClie";
            this.comboNumClie.Size = new System.Drawing.Size(121, 21);
            this.comboNumClie.TabIndex = 18;
            this.comboNumClie.SelectedIndexChanged += new System.EventHandler(this.comboNumClie_SelectedIndexChanged);
            // 
            // labelUpCliRep
            // 
            this.labelUpCliRep.AutoSize = true;
            this.labelUpCliRep.Location = new System.Drawing.Point(218, 139);
            this.labelUpCliRep.Name = "labelUpCliRep";
            this.labelUpCliRep.Size = new System.Drawing.Size(0, 13);
            this.labelUpCliRep.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Representante nuevo";
            // 
            // UpClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 345);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelUpCliRep);
            this.Controls.Add(this.comboNumClie);
            this.Controls.Add(this.txtLimCred);
            this.Controls.Add(this.comboRepClie);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpClientes";
            this.Text = "UpClientes";
            this.Load += new System.EventHandler(this.UpClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLimCred;
        private System.Windows.Forms.ComboBox comboRepClie;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNumClie;
        private System.Windows.Forms.Label labelUpCliRep;
        private System.Windows.Forms.Label label5;
    }
}