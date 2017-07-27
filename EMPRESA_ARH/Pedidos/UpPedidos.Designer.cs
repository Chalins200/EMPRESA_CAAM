namespace EMPRESA_ARH
{
    partial class UpPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpPedidos));
            this.txtRep = new System.Windows.Forms.TextBox();
            this.dateAgPed = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.txtEst = new System.Windows.Forms.TextBox();
            this.comboCli = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIdCli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNumPed = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtRep
            // 
            this.txtRep.Enabled = false;
            this.txtRep.Location = new System.Drawing.Point(208, 200);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(121, 20);
            this.txtRep.TabIndex = 27;
            // 
            // dateAgPed
            // 
            this.dateAgPed.Location = new System.Drawing.Point(169, 105);
            this.dateAgPed.Name = "dateAgPed";
            this.dateAgPed.Size = new System.Drawing.Size(200, 20);
            this.dateAgPed.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(169, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(208, 298);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(121, 20);
            this.txtTot.TabIndex = 24;
            // 
            // txtEst
            // 
            this.txtEst.Location = new System.Drawing.Point(208, 251);
            this.txtEst.Name = "txtEst";
            this.txtEst.Size = new System.Drawing.Size(121, 20);
            this.txtEst.TabIndex = 23;
            // 
            // comboCli
            // 
            this.comboCli.FormattingEnabled = true;
            this.comboCli.Location = new System.Drawing.Point(208, 157);
            this.comboCli.Name = "comboCli";
            this.comboCli.Size = new System.Drawing.Size(121, 21);
            this.comboCli.TabIndex = 21;
            this.comboCli.SelectedIndexChanged += new System.EventHandler(this.comboCli_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Id Representante";
            // 
            // labelIdCli
            // 
            this.labelIdCli.AutoSize = true;
            this.labelIdCli.Location = new System.Drawing.Point(42, 160);
            this.labelIdCli.Name = "labelIdCli";
            this.labelIdCli.Size = new System.Drawing.Size(51, 13);
            this.labelIdCli.TabIndex = 17;
            this.labelIdCli.Text = "Id Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Numero de Pedido";
            // 
            // comboNumPed
            // 
            this.comboNumPed.FormattingEnabled = true;
            this.comboNumPed.Location = new System.Drawing.Point(208, 56);
            this.comboNumPed.Name = "comboNumPed";
            this.comboNumPed.Size = new System.Drawing.Size(121, 21);
            this.comboNumPed.TabIndex = 28;
            this.comboNumPed.SelectedIndexChanged += new System.EventHandler(this.comboNumPed_SelectedIndexChanged);
            // 
            // UpPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(411, 437);
            this.Controls.Add(this.comboNumPed);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.dateAgPed);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.txtEst);
            this.Controls.Add(this.comboCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelIdCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpPedidos";
            this.Text = "UpPedidos";
            this.Load += new System.EventHandler(this.UpPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.DateTimePicker dateAgPed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.TextBox txtEst;
        private System.Windows.Forms.ComboBox comboCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelIdCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNumPed;
    }
}