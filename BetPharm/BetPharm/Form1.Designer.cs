namespace BetPharm
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
            this.btnLekovi = new System.Windows.Forms.Button();
            this.btnEvidencija = new System.Windows.Forms.Button();
            this.btnVanRokTrajanja = new System.Windows.Forms.Button();
            this.btnPronadjiLek = new System.Windows.Forms.Button();
            this.txtNazivLeka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLekovi
            // 
            this.btnLekovi.Location = new System.Drawing.Point(14, 80);
            this.btnLekovi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLekovi.Name = "btnLekovi";
            this.btnLekovi.Size = new System.Drawing.Size(104, 25);
            this.btnLekovi.TabIndex = 0;
            this.btnLekovi.Text = "Dodaj lek";
            this.btnLekovi.UseVisualStyleBackColor = true;
            this.btnLekovi.Click += new System.EventHandler(this.btnLekovi_Click);
            // 
            // btnEvidencija
            // 
            this.btnEvidencija.Location = new System.Drawing.Point(259, 80);
            this.btnEvidencija.Name = "btnEvidencija";
            this.btnEvidencija.Size = new System.Drawing.Size(124, 23);
            this.btnEvidencija.TabIndex = 3;
            this.btnEvidencija.Text = "Evidencija o prodaji";
            this.btnEvidencija.UseVisualStyleBackColor = true;
            this.btnEvidencija.Click += new System.EventHandler(this.btnEvidencija_Click);
            // 
            // btnVanRokTrajanja
            // 
            this.btnVanRokTrajanja.Location = new System.Drawing.Point(138, 80);
            this.btnVanRokTrajanja.Name = "btnVanRokTrajanja";
            this.btnVanRokTrajanja.Size = new System.Drawing.Size(104, 23);
            this.btnVanRokTrajanja.TabIndex = 2;
            this.btnVanRokTrajanja.Text = "Istekao rok trajanja";
            this.btnVanRokTrajanja.UseVisualStyleBackColor = true;
            this.btnVanRokTrajanja.Click += new System.EventHandler(this.btnVanRokTrajanja_Click);
            // 
            // btnPronadjiLek
            // 
            this.btnPronadjiLek.Location = new System.Drawing.Point(127, 28);
            this.btnPronadjiLek.Name = "btnPronadjiLek";
            this.btnPronadjiLek.Size = new System.Drawing.Size(75, 23);
            this.btnPronadjiLek.TabIndex = 1;
            this.btnPronadjiLek.Text = "Pronadji lek";
            this.btnPronadjiLek.UseVisualStyleBackColor = true;
            this.btnPronadjiLek.Click += new System.EventHandler(this.btnPronadjiLek_Click);
            // 
            // txtNazivLeka
            // 
            this.txtNazivLeka.CausesValidation = false;
            this.txtNazivLeka.Location = new System.Drawing.Point(12, 28);
            this.txtNazivLeka.Name = "txtNazivLeka";
            this.txtNazivLeka.Size = new System.Drawing.Size(100, 20);
            this.txtNazivLeka.TabIndex = 0;
            this.txtNazivLeka.Text = "Naziv leka";
            this.txtNazivLeka.Click += new System.EventHandler(this.txtNazivLeka_Click);
            this.txtNazivLeka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNazivLeka_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Odjavite se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEvidencija);
            this.Controls.Add(this.btnVanRokTrajanja);
            this.Controls.Add(this.btnLekovi);
            this.Controls.Add(this.txtNazivLeka);
            this.Controls.Add(this.btnPronadjiLek);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLekovi;
        private System.Windows.Forms.Button btnPronadjiLek;
        private System.Windows.Forms.TextBox txtNazivLeka;
        private System.Windows.Forms.Button btnVanRokTrajanja;
        private System.Windows.Forms.Button btnEvidencija;
        private System.Windows.Forms.Button button1;
    }
}

