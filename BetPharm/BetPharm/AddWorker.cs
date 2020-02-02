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
            MongoDatabase db = DataLayer.GetDataBase();
            var collection = db.GetCollection<Worker>("radnici");
            var collectionAdmin = db.GetCollection<Admin>("admin");


            Admin admin = collectionAdmin.FindOne(Query.EQ("AdminCode", BsonValue.Create(txtCodeAdmin.Text)));

            if (admin != null)
            {
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
                    WorkerCode = txtCode.Text,
                    Employed = true
                };

                Worker w = collection.FindOne(Query.EQ("WorkerCode", BsonValue.Create(txtCode.Text)));
                if (w == null)
                {
                    collection.Insert(worker);
                    MessageBox.Show("Uspesno ste dodali radnika");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unesite neki drugi kod za radnika");
                }
            }
            else
            {
                MessageBox.Show("Niste administrator!");
            }

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void numPay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtCodeAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpEmploy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
