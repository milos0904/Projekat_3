namespace BetPharm
{
    partial class MedicamentForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblPhForm = new System.Windows.Forms.Label();
            this.lblExDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblAproved = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtOdobrio = new System.Windows.Forms.TextBox();
            this.DateTimeRokTrajanja = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownDDD = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCena = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKolicina = new System.Windows.Forms.NumericUpDown();
            this.cmbFarmaceutskiOblik = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dateTimeDatumDospeca = new System.Windows.Forms.DateTimePicker();
            this.lblDatumDospeca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 36);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naziv";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(14, 63);
            this.lblProducer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(62, 13);
            this.lblProducer.TabIndex = 1;
            this.lblProducer.Text = "Proizvodjac";
            // 
            // lblPhForm
            // 
            this.lblPhForm.AutoSize = true;
            this.lblPhForm.Location = new System.Drawing.Point(14, 151);
            this.lblPhForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhForm.Name = "lblPhForm";
            this.lblPhForm.Size = new System.Drawing.Size(95, 13);
            this.lblPhForm.TabIndex = 2;
            this.lblPhForm.Text = "Farmaceutski oblik";
            // 
            // lblExDate
            // 
            this.lblExDate.AutoSize = true;
            this.lblExDate.Location = new System.Drawing.Point(14, 91);
            this.lblExDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExDate.Name = "lblExDate";
            this.lblExDate.Size = new System.Drawing.Size(64, 13);
            this.lblExDate.TabIndex = 3;
            this.lblExDate.Text = "Rok trajanja";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 228);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Cena";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 256);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(44, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Kolicina";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(14, 202);
            this.lblDDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 5;
            this.lblDDD.Text = "DDD";
            // 
            // lblAproved
            // 
            this.lblAproved.AutoSize = true;
            this.lblAproved.Location = new System.Drawing.Point(14, 176);
            this.lblAproved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAproved.Name = "lblAproved";
            this.lblAproved.Size = new System.Drawing.Size(44, 13);
            this.lblAproved.TabIndex = 4;
            this.lblAproved.Text = "Odobrio";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(116, 36);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(91, 20);
            this.txtNaziv.TabIndex = 9;
            this.txtNaziv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNaziv_KeyPress);
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(116, 63);
            this.txtProizvodjac.Margin = new System.Windows.Forms.Padding(2);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(91, 20);
            this.txtProizvodjac.TabIndex = 10;
            this.txtProizvodjac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProizvodjac_KeyPress);
            // 
            // txtOdobrio
            // 
            this.txtOdobrio.Location = new System.Drawing.Point(116, 176);
            this.txtOdobrio.Margin = new System.Windows.Forms.Padding(2);
            this.txtOdobrio.Name = "txtOdobrio";
            this.txtOdobrio.Size = new System.Drawing.Size(91, 20);
            this.txtOdobrio.TabIndex = 11;
            this.txtOdobrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdobrio_KeyPress);
            // 
            // DateTimeRokTrajanja
            // 
            this.DateTimeRokTrajanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeRokTrajanja.Location = new System.Drawing.Point(116, 91);
            this.DateTimeRokTrajanja.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimeRokTrajanja.Name = "DateTimeRokTrajanja";
            this.DateTimeRokTrajanja.Size = new System.Drawing.Size(91, 20);
            this.DateTimeRokTrajanja.TabIndex = 13;
            // 
            // numericUpDownDDD
            // 
            this.numericUpDownDDD.Location = new System.Drawing.Point(116, 202);
            this.numericUpDownDDD.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownDDD.Name = "numericUpDownDDD";
            this.numericUpDownDDD.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownDDD.TabIndex = 14;
            // 
            // numericUpDownCena
            // 
            this.numericUpDownCena.Location = new System.Drawing.Point(116, 228);
            this.numericUpDownCena.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCena.Name = "numericUpDownCena";
            this.numericUpDownCena.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownCena.TabIndex = 15;
            // 
            // numericUpDownKolicina
            // 
            this.numericUpDownKolicina.Location = new System.Drawing.Point(116, 256);
            this.numericUpDownKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownKolicina.Name = "numericUpDownKolicina";
            this.numericUpDownKolicina.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownKolicina.TabIndex = 16;
            // 
            // cmbFarmaceutskiOblik
            // 
            this.cmbFarmaceutskiOblik.FormattingEnabled = true;
            this.cmbFarmaceutskiOblik.Items.AddRange(new object[] {
            "Tableta",
            "Kapsula",
            "Sirup"});
            this.cmbFarmaceutskiOblik.Location = new System.Drawing.Point(116, 149);
            this.cmbFarmaceutskiOblik.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFarmaceutskiOblik.Name = "cmbFarmaceutskiOblik";
            this.cmbFarmaceutskiOblik.Size = new System.Drawing.Size(92, 21);
            this.cmbFarmaceutskiOblik.TabIndex = 17;
            this.cmbFarmaceutskiOblik.Text = "Tableta";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(116, 294);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(90, 32);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dateTimeDatumDospeca
            // 
            this.dateTimeDatumDospeca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDatumDospeca.Location = new System.Drawing.Point(116, 121);
            this.dateTimeDatumDospeca.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDatumDospeca.Name = "dateTimeDatumDospeca";
            this.dateTimeDatumDospeca.Size = new System.Drawing.Size(91, 20);
            this.dateTimeDatumDospeca.TabIndex = 20;
            // 
            // lblDatumDospeca
            // 
            this.lblDatumDospeca.AutoSize = true;
            this.lblDatumDospeca.Location = new System.Drawing.Point(14, 121);
            this.lblDatumDospeca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumDospeca.Name = "lblDatumDospeca";
            this.lblDatumDospeca.Size = new System.Drawing.Size(82, 13);
            this.lblDatumDospeca.TabIndex = 19;
            this.lblDatumDospeca.Text = "Datum dospeca";
            // 
            // MedicamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 370);
            this.Controls.Add(this.dateTimeDatumDospeca);
            this.Controls.Add(this.lblDatumDospeca);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbFarmaceutskiOblik);
            this.Controls.Add(this.numericUpDownKolicina);
            this.Controls.Add(this.numericUpDownCena);
            this.Controls.Add(this.numericUpDownDDD);
            this.Controls.Add(this.DateTimeRokTrajanja);
            this.Controls.Add(this.txtOdobrio);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblAproved);
            this.Controls.Add(this.lblExDate);
            this.Controls.Add(this.lblPhForm);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedicamentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medicament form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblPhForm;
        private System.Windows.Forms.Label lblExDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblAproved;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtOdobrio;
        private System.Windows.Forms.DateTimePicker DateTimeRokTrajanja;
        private System.Windows.Forms.NumericUpDown numericUpDownDDD;
        private System.Windows.Forms.NumericUpDown numericUpDownCena;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicina;
        private System.Windows.Forms.ComboBox cmbFarmaceutskiOblik;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dateTimeDatumDospeca;
        private System.Windows.Forms.Label lblDatumDospeca;
    }
}