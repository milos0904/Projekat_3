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
using MongoDB.Driver.Builders;
using MongoDB.Bson;

namespace BetPharm
{
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
           
            /*IMongoDatabase db = DataLayer.GetDataBase();
            var collection = db.GetCollection<Admin>("admin");

            Admin admin = new Admin
            {
                AdminCode = "123456"
            };

            collection.InsertOne(admin);*/
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            IMongoDatabase db = DataLayer.GetDataBase();
            var collection = db.GetCollection<Worker>("radnici");
            var collectionAdmin = db.GetCollection<Admin>("Admin");

            var query1 = from admin in collectionAdmin.AsQueryable<Admin>()
                         where admin.AdminCode == txtCodeAdmin.Text
                         select admin;

            

            Worker worker = new Worker
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                DateBirth = (DateTime)dtpBirth.Value,
                DateEmployment = (DateTime)dtpEmploy.Value,
                Sex = cbSex.Text,
                Address = txtAddress.Text,
                Pay = (double)numPay.Value,
                Position = txtPosition.Text,
                WorkerCode = txtCode.Text
            };

            collection.InsertOne(worker);

        }
     }
}
