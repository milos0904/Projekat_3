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
            this.btnProdaj = new System.Windows.Forms.Button();
            this.btnDodajRadnika = new System.Windows.Forms.Button();
            this.btnListaLekova = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLekovi
            // 
            this.btnLekovi.Location = new System.Drawing.Point(34, 46);
            this.btnLekovi.Name = "btnLekovi";
            this.btnLekovi.Size = new System.Drawing.Size(138, 39);
            this.btnLekovi.TabIndex = 0;
            this.btnLekovi.Text = "Dodaj lek";
            this.btnLekovi.UseVisualStyleBackColor = true;
            this.btnLekovi.Click += new System.EventHandler(this.btnLekovi_Click);
            // 
            // btnProdaj
            // 
            this.btnProdaj.Location = new System.Drawing.Point(34, 171);
            this.btnProdaj.Name = "btnProdaj";
            this.btnProdaj.Size = new System.Drawing.Size(138, 38);
            this.btnProdaj.TabIndex = 1;
            this.btnProdaj.Text = "Prodaj lek";
            this.btnProdaj.UseVisualStyleBackColor = true;
            // 
            // btnDodajRadnika
            // 
            this.btnDodajRadnika.Location = new System.Drawing.Point(34, 105);
            this.btnDodajRadnika.Name = "btnDodajRadnika";
            this.btnDodajRadnika.Size = new System.Drawing.Size(140, 44);
            this.btnDodajRadnika.TabIndex = 2;
            this.btnDodajRadnika.Text = "Dodaj radnika";
            this.btnDodajRadnika.UseVisualStyleBackColor = true;
            // 
            // btnListaLekova
            // 
            this.btnListaLekova.Location = new System.Drawing.Point(331, 46);
            this.btnListaLekova.Name = "btnListaLekova";
            this.btnListaLekova.Size = new System.Drawing.Size(117, 44);
            this.btnListaLekova.TabIndex = 3;
            this.btnListaLekova.Text = "Lista lekova";
            this.btnListaLekova.UseVisualStyleBackColor = true;
            this.btnListaLekova.Click += new System.EventHandler(this.btnListaLekova_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListaLekova);
            this.Controls.Add(this.btnDodajRadnika);
            this.Controls.Add(this.btnProdaj);
            this.Controls.Add(this.btnLekovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLekovi;
        private System.Windows.Forms.Button btnProdaj;
        private System.Windows.Forms.Button btnDodajRadnika;
        private System.Windows.Forms.Button btnListaLekova;
    }
}

