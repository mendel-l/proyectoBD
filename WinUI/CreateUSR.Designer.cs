namespace WinUI
{
    partial class CreateUSR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CContra = new System.Windows.Forms.TextBox();
            this.TIDP = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.TIDR = new System.Windows.Forms.TextBox();
            this.NomUsr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CContra);
            this.groupBox1.Controls.Add(this.TIDP);
            this.groupBox1.Controls.Add(this.Contra);
            this.groupBox1.Controls.Add(this.TIDR);
            this.groupBox1.Controls.Add(this.NomUsr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(30, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 238);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear usuario";
            // 
            // CContra
            // 
            this.CContra.Location = new System.Drawing.Point(418, 84);
            this.CContra.Name = "CContra";
            this.CContra.Size = new System.Drawing.Size(100, 20);
            this.CContra.TabIndex = 18;
            // 
            // TIDP
            // 
            this.TIDP.Location = new System.Drawing.Point(120, 127);
            this.TIDP.Name = "TIDP";
            this.TIDP.Size = new System.Drawing.Size(169, 20);
            this.TIDP.TabIndex = 17;
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(122, 84);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(169, 20);
            this.Contra.TabIndex = 15;
            // 
            // TIDR
            // 
            this.TIDR.Location = new System.Drawing.Point(120, 174);
            this.TIDR.Name = "TIDR";
            this.TIDR.Size = new System.Drawing.Size(169, 20);
            this.TIDR.TabIndex = 16;
            // 
            // NomUsr
            // 
            this.NomUsr.Location = new System.Drawing.Point(122, 36);
            this.NomUsr.Name = "NomUsr";
            this.NomUsr.Size = new System.Drawing.Size(169, 20);
            this.NomUsr.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID rol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID persona";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Confirmar contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateUSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateUSR";
            this.Text = "gru";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CContra;
        private System.Windows.Forms.TextBox TIDP;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.TextBox TIDR;
        private System.Windows.Forms.TextBox NomUsr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}