using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetPharm.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace BetPharm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MongoDatabase db = DataLayer.GetDataBase();
            var collection = db.GetCollection<Worker>("radnici");
            var collectionAdmin = db.GetCollection<Admin>("admin");

            Worker w = collection.FindOne(Query.EQ("UserName", BsonValue.Create(txtUsername.Text)));
            Admin a = collectionAdmin.FindOne(Query.EQ("UserName", BsonValue.Create(txtUsername.Text)));
            if (w != null)
            {
                if (w.WorkerCode == txtCode.Text)
                {
                    if (w.Employed == true)
                    {
                        this.Hide();
                        Form1 f = new Form1(txtCode.Text);
                        f.ShowDialog();
                        txtUsername.Text = "";
                        txtCode.Text = "";
                        this.Show();
                    }
                    else 
                    {
                        MessageBox.Show("Vas nalog vise nije u funkciji");  //ako je radnik dao otkaz
                    }
                }
                else
                {
                    MessageBox.Show("Uneli ste pogresan kod");
                }
            }

            else if (a != null)
            {
                if (a.AdminCode == txtCode.Text)
                {
                    this.Hide();
                    FormForAdmin f = new FormForAdmin();
                    f.ShowDialog();
                    txtUsername.Text = "";
                    txtCode.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Uneli ste pogresan kod");
                }
            }
            else
            {
                MessageBox.Show("Pogresili ste korisnicko ime");
            }
        }
    }
}
