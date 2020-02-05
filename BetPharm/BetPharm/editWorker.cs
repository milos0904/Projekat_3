using System;
using System.Collections.Generic;
using BetPharm.Entities;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BetPharm
{
    public partial class editWorker : Form
    {
        Worker worker;
        public editWorker(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            txtName.Text = worker.Name;
            txtSurname.Text = worker.Surname;
            dtpBirth.Value = worker.DateBirth;
            dtpEmploy.Value = worker.DateEmployment;
            cbSex.Text = worker.Sex;
            txtAddress.Text = worker.Address;
            txtUsername.Text = worker.UserName;
            numPay.Value = (decimal)worker.Pay;
            txtPosition.Text = worker.Position;
            txtCode.Text = worker.WorkerCode;
            if (worker.Employed == false)
            {
                dtpStopWork.Value = (DateTime)worker.StoppedWorking;
                cbEmployed.Checked = true;
            }
            else
            {
                cbEmployed.Checked = false;
            }
        }

        private void btnEditWorker_Click(object sender, EventArgs e)
        {
            MongoDatabase db = DataLayer.GetDataBase();
            var collection = db.GetCollection<Worker>("radnici");
            var collectionAdmin = db.GetCollection<Admin>("admin");





            var query = Query.EQ("_id", worker.Id);
            UpdateBuilder update = MongoDB.Driver.Builders.Update.Set("Name", txtName.Text);
            update.Set("Surname", txtSurname.Text);
            update.Set("DateBirth", dtpBirth.Value);
            update.Set("DateEmployment", dtpEmploy.Value);
            update.Set("Sex", cbSex.Text);
            update.Set("Address", txtAddress.Text);
            update.Set("Pay", (double)numPay.Value);
            update.Set("Position", txtPosition.Text);
            update.Set("StoppedWorking", dtpStopWork.Value);
            update.Set("WorkerCode", txtCode.Text);
            update.Set("UserName", txtUsername.Text);
            update.Set("Employed", !cbEmployed.Checked);
            if (txtUsername.Text == worker.UserName)
            {
                collection.Update(query, update);
                MessageBox.Show("Uspesno ste izmenili informacije o radniku");
                this.Close();
            }
            else
            {
                Worker w = collection.FindOne(Query.EQ("UserName", BsonValue.Create(txtUsername.Text)));
                Admin a = collectionAdmin.FindOne(Query.EQ("UserName", BsonValue.Create(txtUsername.Text)));
                if (w == null && a == null)
                {
                    collection.Update(query, update);
                    MessageBox.Show("Uspesno ste izmenili informacije o radniku");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unesite neki drugi kod za radnika.");
                }
            }

        }

    }
}
