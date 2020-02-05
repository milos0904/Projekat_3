using System;
using BetPharm.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Bson;

namespace BetPharm
{
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();

            /*MongoDatabase db = DataLayer.GetDataBase();
            var collection = db.GetCollection<Admin>("admin");

            Admin admin = new Admin
            {
                Type = "Admin",
                UserName = "admin",
                AdminCode = "123456"
            };

            collection.Insert(admin);*/
        }


        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            MongoDatabase db = DataLayer.GetDataBase();
            var collection = db.GetCollection<Worker>("radnici");
            var collectionAdmin = db.GetCollection<Admin>("admin");

            Worker worker = new Worker
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                DateBirth = (DateTime)dtpBirth.Value,
                DateEmployment = (DateTime)dtpEmploy.Value,
                Sex = cbSex.Text,
                Address = txtAddress.Text,
                Type = "Worker",
                Pay = (double)numPay.Value,
                Position = txtPosition.Text,
                WorkerCode = txtCode.Text,
                UserName = txtUsername.Text,
                Employed = true
            };

            Worker w = collection.FindOne(Query.EQ("UserName", BsonValue.Create(txtUsername.Text)));
            Admin a = collectionAdmin.FindOne(Query.EQ("UserName", BsonValue.Create(txtUsername.Text)));  //mozda je to korisnicko ime vec zauzeto za admina
            if (w == null && a == null)
            {
                collection.Insert(worker);
                MessageBox.Show("Uspesno ste dodali radnika");
                this.Close();
            }
            else
            {
                MessageBox.Show("Unesite neko drugo korisnicko ime za radnika");
            }

        }


    }
}
