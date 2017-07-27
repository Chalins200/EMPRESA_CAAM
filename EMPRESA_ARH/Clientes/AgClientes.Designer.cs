namespace EMPRESA_ARH
{
    partial class AgClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumCli = new System.Windows.Forms.TextBox();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.comboRepClie = new System.Windows.Forms.ComboBox();
            this.txtLimCred = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Representante del cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Limite de credito";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumCli
            // 
            this.txtNumCli.Location = new System.Drawing.Point(166, 16);
            this.txtNumCli.Name = "txtNumCli";
            this.txtNumCli.Size = new System.Drawing.Size(121, 20);
            this.txtNumCli.TabIndex = 5;
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(166, 64);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(121, 20);
            this.txtEmp.TabIndex = 6;
            // 
            // comboRepClie
            // 
            this.comboRepClie.FormattingEnabled = true;
            this.comboRepClie.Location = new System.Drawing.Point(166, 118);
            this.comboRepClie.Name = "comboRepClie";
            this.comboRepClie.Size = new System.Drawing.Size(121, 21);
            this.comboRepClie.TabIndex = 7;
            this.comboRepClie.SelectedIndexChanged += new System.EventHandler(this.comboRepClie_SelectedIndexChanged);
            // 
            // txtLimCred
            // 
            this.txtLimCred.Location = new System.Drawing.Point(166, 171);
            this.txtLimCred.Name = "txtLimCred";
            this.txtLimCred.Size = new System.Drawing.Size(121, 20);
            this.txtLimCred.TabIndex = 8;
            // 
            // AgClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 260);
            this.Controls.Add(this.txtLimCred);
            this.Controls.Add(this.comboRepClie);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.txtNumCli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgClientes";
            this.Text = "AgClientes";
            this.Load += new System.EventHandler(this.AgClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumCli;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.ComboBox comboRepClie;
        private System.Windows.Forms.TextBox txtLimCred;
    }
}