namespace Cefre
{
    partial class Form1
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
            this.listFozde = new System.Windows.Forms.ListBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbTulajdonos = new System.Windows.Forms.TextBox();
            this.alapitas = new System.Windows.Forms.DateTimePicker();
            this.btnFelvesz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFozde
            // 
            this.listFozde.FormattingEnabled = true;
            this.listFozde.Location = new System.Drawing.Point(12, 22);
            this.listFozde.Name = "listFozde";
            this.listFozde.Size = new System.Drawing.Size(120, 95);
            this.listFozde.TabIndex = 0;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(163, 22);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(100, 20);
            this.tbNev.TabIndex = 1;
            // 
            // tbTulajdonos
            // 
            this.tbTulajdonos.Location = new System.Drawing.Point(163, 61);
            this.tbTulajdonos.Name = "tbTulajdonos";
            this.tbTulajdonos.Size = new System.Drawing.Size(100, 20);
            this.tbTulajdonos.TabIndex = 2;
            // 
            // alapitas
            // 
            this.alapitas.Location = new System.Drawing.Point(163, 97);
            this.alapitas.Name = "alapitas";
            this.alapitas.Size = new System.Drawing.Size(144, 20);
            this.alapitas.TabIndex = 3;
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.Location = new System.Drawing.Point(163, 144);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(75, 23);
            this.btnFelvesz.TabIndex = 4;
            this.btnFelvesz.Text = "Felvesz";
            this.btnFelvesz.UseVisualStyleBackColor = true;
            this.btnFelvesz.Click += new System.EventHandler(this.btnFelvesz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFelvesz);
            this.Controls.Add(this.alapitas);
            this.Controls.Add(this.tbTulajdonos);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.listFozde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFozde;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbTulajdonos;
        private System.Windows.Forms.DateTimePicker alapitas;
        private System.Windows.Forms.Button btnFelvesz;
    }
}

