namespace BetPharm
{
    partial class ViewAndEditWorker
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
            this.listWorkers = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listWorkers
            // 
            this.listWorkers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSurname,
            this.chAddress,
            this.chBirth,
            this.chSex,
            this.chDateEmp,
            this.chPosition,
            this.chPay,
            this.chCode,
            this.columnHeader1});
            this.listWorkers.HideSelection = false;
            this.listWorkers.Location = new System.Drawing.Point(12, 15);
            this.listWorkers.Name = "listWorkers";
            this.listWorkers.Size = new System.Drawing.Size(893, 397);
            this.listWorkers.TabIndex = 0;
            this.listWorkers.UseCompatibleStateImageBehavior = false;
            this.listWorkers.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Ime";
            this.chName.Width = 80;
            // 
            // chSurname
            // 
            this.chSurname.Text = "Prezime";
            this.chSurname.Width = 96;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Adresa";
            this.chAddress.Width = 75;
            // 
            // chBirth
            // 
            this.chBirth.Text = "Datum rodjenja";
            this.chBirth.Width = 100;
            // 
            // chSex
            // 
            this.chSex.Text = "Pol";
            // 
            // chDateEmp
            // 
            this.chDateEmp.Text = "Datum zaposlenja";
            this.chDateEmp.Width = 113;
            // 
            // chPosition
            // 
            this.chPosition.Text = "Pozicija";
            this.chPosition.Width = 76;
            // 
            // chPay
            // 
            this.chPay.Text = "Plata";
            this.chPay.Width = 102;
            // 
            // chCode
            // 
            this.chCode.Text = "Kod radnika";
            this.chCode.Width = 117;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(911, 145);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(251, 24);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Izmeni izabranog";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(911, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pronadji radnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(6, 71);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(239, 24);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Pronadji";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(124, 36);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(122, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zaposlen";
            // 
            // ViewAndEditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listWorkers);
            this.Name = "ViewAndEditWorker";
            this.Text = "ViewAndEditWorker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listWorkers;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSurname;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chBirth;
        private System.Windows.Forms.ColumnHeader chSex;
        private System.Windows.Forms.ColumnHeader chDateEmp;
        private System.Windows.Forms.ColumnHeader chPosition;
        private System.Windows.Forms.ColumnHeader chPay;
        private System.Windows.Forms.ColumnHeader chCode;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}