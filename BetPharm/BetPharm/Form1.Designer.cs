﻿namespace BetPharm
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
            this.btnDodajRadnika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVanRokTrajanja = new System.Windows.Forms.Button();
            this.btnPronadjiLek = new System.Windows.Forms.Button();
            this.txtNazivLeka = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditWorkers = new System.Windows.Forms.Button();
            this.btnEvidencija = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLekovi
            // 
            this.btnLekovi.Location = new System.Drawing.Point(5, 78);
            this.btnLekovi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLekovi.Name = "btnLekovi";
            this.btnLekovi.Size = new System.Drawing.Size(104, 27);
            this.btnLekovi.TabIndex = 0;
            this.btnLekovi.Text = "Dodaj lek";
            this.btnLekovi.UseVisualStyleBackColor = true;
            this.btnLekovi.Click += new System.EventHandler(this.btnLekovi_Click);
            // 
            // btnDodajRadnika
            // 
            this.btnDodajRadnika.Location = new System.Drawing.Point(5, 58);
            this.btnDodajRadnika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajRadnika.Name = "btnDodajRadnika";
            this.btnDodajRadnika.Size = new System.Drawing.Size(105, 26);
            this.btnDodajRadnika.TabIndex = 2;
            this.btnDodajRadnika.Text = "Dodaj radnika";
            this.btnDodajRadnika.UseVisualStyleBackColor = true;
            this.btnDodajRadnika.Click += new System.EventHandler(this.btnDodajRadnika_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEvidencija);
            this.groupBox1.Controls.Add(this.btnVanRokTrajanja);
            this.groupBox1.Controls.Add(this.btnLekovi);
            this.groupBox1.Controls.Add(this.btnPronadjiLek);
            this.groupBox1.Controls.Add(this.txtNazivLeka);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lekovi";
            // 
            // btnVanRokTrajanja
            // 
            this.btnVanRokTrajanja.Location = new System.Drawing.Point(5, 110);
            this.btnVanRokTrajanja.Name = "btnVanRokTrajanja";
            this.btnVanRokTrajanja.Size = new System.Drawing.Size(104, 36);
            this.btnVanRokTrajanja.TabIndex = 2;
            this.btnVanRokTrajanja.Text = "Istekao rok trajanja";
            this.btnVanRokTrajanja.UseVisualStyleBackColor = true;
            this.btnVanRokTrajanja.Click += new System.EventHandler(this.btnVanRokTrajanja_Click);
            // 
            // btnPronadjiLek
            // 
            this.btnPronadjiLek.Location = new System.Drawing.Point(115, 14);
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
            this.txtNazivLeka.Location = new System.Drawing.Point(0, 19);
            this.txtNazivLeka.Name = "txtNazivLeka";
            this.txtNazivLeka.Size = new System.Drawing.Size(100, 20);
            this.txtNazivLeka.TabIndex = 0;
            this.txtNazivLeka.Text = "Naziv leka";
            this.txtNazivLeka.Click += new System.EventHandler(this.txtNazivLeka_Click);
            this.txtNazivLeka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNazivLeka_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnEditWorkers);
            this.groupBox2.Controls.Add(this.btnDodajRadnika);
            this.groupBox2.Location = new System.Drawing.Point(540, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 190);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Radnici";
            // 
            // btnEditWorkers
            // 
            this.btnEditWorkers.Location = new System.Drawing.Point(5, 99);
            this.btnEditWorkers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditWorkers.Name = "btnEditWorkers";
            this.btnEditWorkers.Size = new System.Drawing.Size(88, 36);
            this.btnEditWorkers.TabIndex = 4;
            this.btnEditWorkers.Text = "Izmena radnika";
            this.btnEditWorkers.UseVisualStyleBackColor = true;
            this.btnEditWorkers.Click += new System.EventHandler(this.btnEditWorkers_Click);
            // 
            // btnEvidencija
            // 
            this.btnEvidencija.Location = new System.Drawing.Point(134, 117);
            this.btnEvidencija.Name = "btnEvidencija";
            this.btnEvidencija.Size = new System.Drawing.Size(124, 23);
            this.btnEvidencija.TabIndex = 3;
            this.btnEvidencija.Text = "Evidencija o prodaji";
            this.btnEvidencija.UseVisualStyleBackColor = true;
            this.btnEvidencija.Click += new System.EventHandler(this.btnEvidencija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLekovi;
        private System.Windows.Forms.Button btnDodajRadnika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPronadjiLek;
        private System.Windows.Forms.TextBox txtNazivLeka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVanRokTrajanja;
        private System.Windows.Forms.Button btnEditWorkers;
        private System.Windows.Forms.Button btnEvidencija;
    }
}

