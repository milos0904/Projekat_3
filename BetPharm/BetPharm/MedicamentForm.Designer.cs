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
            this.lblWorker = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtOdobrio = new System.Windows.Forms.TextBox();
            this.txtKodRadnika = new System.Windows.Forms.TextBox();
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
            this.lblName.Location = new System.Drawing.Point(16, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naziv";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(18, 78);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(81, 17);
            this.lblProducer.TabIndex = 1;
            this.lblProducer.Text = "Proizvodjac";
            // 
            // lblPhForm
            // 
            this.lblPhForm.AutoSize = true;
            this.lblPhForm.Location = new System.Drawing.Point(18, 186);
            this.lblPhForm.Name = "lblPhForm";
            this.lblPhForm.Size = new System.Drawing.Size(125, 17);
            this.lblPhForm.TabIndex = 2;
            this.lblPhForm.Text = "Farmaceutski oblik";
            // 
            // lblExDate
            // 
            this.lblExDate.AutoSize = true;
            this.lblExDate.Location = new System.Drawing.Point(18, 112);
            this.lblExDate.Name = "lblExDate";
            this.lblExDate.Size = new System.Drawing.Size(84, 17);
            this.lblExDate.TabIndex = 3;
            this.lblExDate.Text = "Rok trajanja";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 280);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 17);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Cena";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(16, 315);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 17);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Kolicina";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(18, 248);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(38, 17);
            this.lblDDD.TabIndex = 5;
            this.lblDDD.Text = "DDD";
            // 
            // lblAproved
            // 
            this.lblAproved.AutoSize = true;
            this.lblAproved.Location = new System.Drawing.Point(18, 216);
            this.lblAproved.Name = "lblAproved";
            this.lblAproved.Size = new System.Drawing.Size(59, 17);
            this.lblAproved.TabIndex = 4;
            this.lblAproved.Text = "Odobrio";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(18, 349);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(59, 17);
            this.lblWorker.TabIndex = 8;
            this.lblWorker.Text = "Vas kod";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(155, 44);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(120, 22);
            this.txtNaziv.TabIndex = 9;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(155, 78);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(120, 22);
            this.txtProizvodjac.TabIndex = 10;
            // 
            // txtOdobrio
            // 
            this.txtOdobrio.Location = new System.Drawing.Point(155, 216);
            this.txtOdobrio.Name = "txtOdobrio";
            this.txtOdobrio.Size = new System.Drawing.Size(120, 22);
            this.txtOdobrio.TabIndex = 11;
            // 
            // txtKodRadnika
            // 
            this.txtKodRadnika.Location = new System.Drawing.Point(155, 349);
            this.txtKodRadnika.Name = "txtKodRadnika";
            this.txtKodRadnika.Size = new System.Drawing.Size(120, 22);
            this.txtKodRadnika.TabIndex = 12;
            // 
            // DateTimeRokTrajanja
            // 
            this.DateTimeRokTrajanja.Location = new System.Drawing.Point(155, 112);
            this.DateTimeRokTrajanja.Name = "DateTimeRokTrajanja";
            this.DateTimeRokTrajanja.Size = new System.Drawing.Size(120, 22);
            this.DateTimeRokTrajanja.TabIndex = 13;
            // 
            // numericUpDownDDD
            // 
            this.numericUpDownDDD.Location = new System.Drawing.Point(155, 248);
            this.numericUpDownDDD.Name = "numericUpDownDDD";
            this.numericUpDownDDD.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDDD.TabIndex = 14;
            // 
            // numericUpDownCena
            // 
            this.numericUpDownCena.Location = new System.Drawing.Point(155, 280);
            this.numericUpDownCena.Name = "numericUpDownCena";
            this.numericUpDownCena.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCena.TabIndex = 15;
            // 
            // numericUpDownKolicina
            // 
            this.numericUpDownKolicina.Location = new System.Drawing.Point(155, 315);
            this.numericUpDownKolicina.Name = "numericUpDownKolicina";
            this.numericUpDownKolicina.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownKolicina.TabIndex = 16;
            // 
            // cmbFarmaceutskiOblik
            // 
            this.cmbFarmaceutskiOblik.FormattingEnabled = true;
            this.cmbFarmaceutskiOblik.Items.AddRange(new object[] {
            "Tableta",
            "Kapsula",
            "Sirup"});
            this.cmbFarmaceutskiOblik.Location = new System.Drawing.Point(155, 183);
            this.cmbFarmaceutskiOblik.Name = "cmbFarmaceutskiOblik";
            this.cmbFarmaceutskiOblik.Size = new System.Drawing.Size(121, 24);
            this.cmbFarmaceutskiOblik.TabIndex = 17;
            this.cmbFarmaceutskiOblik.Text = "Tableta";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(106, 398);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(104, 40);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dateTimeDatumDospeca
            // 
            this.dateTimeDatumDospeca.Location = new System.Drawing.Point(155, 149);
            this.dateTimeDatumDospeca.Name = "dateTimeDatumDospeca";
            this.dateTimeDatumDospeca.Size = new System.Drawing.Size(120, 22);
            this.dateTimeDatumDospeca.TabIndex = 20;
            // 
            // lblDatumDospeca
            // 
            this.lblDatumDospeca.AutoSize = true;
            this.lblDatumDospeca.Location = new System.Drawing.Point(18, 149);
            this.lblDatumDospeca.Name = "lblDatumDospeca";
            this.lblDatumDospeca.Size = new System.Drawing.Size(107, 17);
            this.lblDatumDospeca.TabIndex = 19;
            this.lblDatumDospeca.Text = "Datum dospeca";
            // 
            // MedicamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 498);
            this.Controls.Add(this.dateTimeDatumDospeca);
            this.Controls.Add(this.lblDatumDospeca);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbFarmaceutskiOblik);
            this.Controls.Add(this.numericUpDownKolicina);
            this.Controls.Add(this.numericUpDownCena);
            this.Controls.Add(this.numericUpDownDDD);
            this.Controls.Add(this.DateTimeRokTrajanja);
            this.Controls.Add(this.txtKodRadnika);
            this.Controls.Add(this.txtOdobrio);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblAproved);
            this.Controls.Add(this.lblExDate);
            this.Controls.Add(this.lblPhForm);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedicamentForm";
            this.Text = "MedicamentForm";
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
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtOdobrio;
        private System.Windows.Forms.TextBox txtKodRadnika;
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