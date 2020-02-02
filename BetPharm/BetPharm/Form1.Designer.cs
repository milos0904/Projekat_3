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
            this.btnDodajRadnika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVanRokTrajanja = new System.Windows.Forms.Button();
            this.btnPronadjiLek = new System.Windows.Forms.Button();
            this.txtNazivLeka = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditWorkers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLekovi
            // 
            this.btnLekovi.Location = new System.Drawing.Point(7, 96);
            this.btnLekovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLekovi.Name = "btnLekovi";
            this.btnLekovi.Size = new System.Drawing.Size(139, 33);
            this.btnLekovi.TabIndex = 0;
            this.btnLekovi.Text = "Dodaj lek";
            this.btnLekovi.UseVisualStyleBackColor = true;
            this.btnLekovi.Click += new System.EventHandler(this.btnLekovi_Click);
            // 
            // btnDodajRadnika
            // 
            this.btnDodajRadnika.Location = new System.Drawing.Point(7, 45);
            this.btnDodajRadnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajRadnika.Name = "btnDodajRadnika";
            this.btnDodajRadnika.Size = new System.Drawing.Size(140, 32);
            this.btnDodajRadnika.TabIndex = 2;
            this.btnDodajRadnika.Text = "Dodaj radnika";
            this.btnDodajRadnika.UseVisualStyleBackColor = true;
            this.btnDodajRadnika.Click += new System.EventHandler(this.btnDodajRadnika_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnVanRokTrajanja);
            this.groupBox1.Controls.Add(this.btnLekovi);
            this.groupBox1.Controls.Add(this.btnPronadjiLek);
            this.groupBox1.Controls.Add(this.txtNazivLeka);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(773, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lekovi";
            // 
            // btnVanRokTrajanja
            // 
            this.btnVanRokTrajanja.Location = new System.Drawing.Point(7, 135);
            this.btnVanRokTrajanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVanRokTrajanja.Name = "btnVanRokTrajanja";
            this.btnVanRokTrajanja.Size = new System.Drawing.Size(139, 44);
            this.btnVanRokTrajanja.TabIndex = 2;
            this.btnVanRokTrajanja.Text = "Istekao rok trajanja";
            this.btnVanRokTrajanja.UseVisualStyleBackColor = true;
            this.btnVanRokTrajanja.Click += new System.EventHandler(this.btnVanRokTrajanja_Click);
            // 
            // btnPronadjiLek
            // 
            this.btnPronadjiLek.Location = new System.Drawing.Point(153, 17);
            this.btnPronadjiLek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPronadjiLek.Name = "btnPronadjiLek";
            this.btnPronadjiLek.Size = new System.Drawing.Size(100, 28);
            this.btnPronadjiLek.TabIndex = 1;
            this.btnPronadjiLek.Text = "Pronadji lek";
            this.btnPronadjiLek.UseVisualStyleBackColor = true;
            this.btnPronadjiLek.Click += new System.EventHandler(this.btnPronadjiLek_Click);
            // 
            // txtNazivLeka
            // 
            this.txtNazivLeka.CausesValidation = false;
            this.txtNazivLeka.Location = new System.Drawing.Point(0, 23);
            this.txtNazivLeka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNazivLeka.Name = "txtNazivLeka";
            this.txtNazivLeka.Size = new System.Drawing.Size(132, 22);
            this.txtNazivLeka.TabIndex = 0;
            this.txtNazivLeka.Text = "Naziv leka";
            this.txtNazivLeka.Click += new System.EventHandler(this.txtNazivLeka_Click);
            this.txtNazivLeka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNazivLeka_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnEditWorkers);
            this.groupBox2.Controls.Add(this.btnDodajRadnika);
            this.groupBox2.Location = new System.Drawing.Point(16, 320);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(773, 234);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Radnici";
            // 
            // btnEditWorkers
            // 
            this.btnEditWorkers.Location = new System.Drawing.Point(200, 45);
            this.btnEditWorkers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditWorkers.Name = "btnEditWorkers";
            this.btnEditWorkers.Size = new System.Drawing.Size(117, 44);
            this.btnEditWorkers.TabIndex = 4;
            this.btnEditWorkers.Text = "Izmena radnika";
            this.btnEditWorkers.UseVisualStyleBackColor = true;
            this.btnEditWorkers.Click += new System.EventHandler(this.btnEditWorkers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

