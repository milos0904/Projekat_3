namespace BetPharm
{
    partial class FormForAdmin
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
            this.btnEditWorkers = new System.Windows.Forms.Button();
            this.btnDodajRadnika = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditWorkers
            // 
            this.btnEditWorkers.Location = new System.Drawing.Point(160, 40);
            this.btnEditWorkers.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditWorkers.Name = "btnEditWorkers";
            this.btnEditWorkers.Size = new System.Drawing.Size(111, 26);
            this.btnEditWorkers.TabIndex = 4;
            this.btnEditWorkers.Text = "Izmena radnika";
            this.btnEditWorkers.UseVisualStyleBackColor = true;
            this.btnEditWorkers.Click += new System.EventHandler(this.btnEditWorkers_Click);
            // 
            // btnDodajRadnika
            // 
            this.btnDodajRadnika.Location = new System.Drawing.Point(29, 40);
            this.btnDodajRadnika.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajRadnika.Name = "btnDodajRadnika";
            this.btnDodajRadnika.Size = new System.Drawing.Size(105, 26);
            this.btnDodajRadnika.TabIndex = 2;
            this.btnDodajRadnika.Text = "Dodaj radnika";
            this.btnDodajRadnika.UseVisualStyleBackColor = true;
            this.btnDodajRadnika.Click += new System.EventHandler(this.btnDodajRadnika_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Odjavite se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 149);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditWorkers);
            this.Controls.Add(this.btnDodajRadnika);
            this.Name = "FormForAdmin";
            this.Text = "FormForAdmin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditWorkers;
        private System.Windows.Forms.Button btnDodajRadnika;
        private System.Windows.Forms.Button button1;
    }
}