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
using MongoDB.Driver.Linq;

namespace BetPharm
{
    public partial class ViewAndEditWorker : Form
    {
        List<Worker> workers;
        public ViewAndEditWorker()
        {

            InitializeComponent();

            var db = DataLayer.GetDataBase();
            var collection = db.GetCollection<Worker>("radnici");
            workers = collection.FindAll().ToList<Worker>();
            showWorkers(workers);
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listWorkers.SelectedIndices.Count > 0)
            {
                Worker worker = workers[listWorkers.SelectedIndices[0]];

                editWorker w = new editWorker(worker);
                w.ShowDialog();

                listWorkers.Items.Clear();

                var db = DataLayer.GetDataBase();
                var collection = db.GetCollection<Worker>("radnici");
                workers = collection.FindAll().ToList<Worker>();
                showWorkers(workers);

            }
            else
            {
                MessageBox.Show("Niste izabrali ni jednog radnika.");
            }

        }

        private void showWorkers(List<Worker> worker)
        {
            foreach (Worker w in worker)
            {
                ListViewItem item = new ListViewItem(new string[] { w.Name, w.Surname, w.Address, w.DateBirth.ToShortDateString(), w.Sex,w.DateEmployment.ToShortDateString() ,w.Position, w.Pay.ToString(), w.WorkerCode, w.Employed? "Da" : "Ne"});
                listWorkers.Items.Add(item);
            }
            listWorkers.Refresh();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            var db = DataLayer.GetDataBase();
            var collection = db.GetCollection<Worker>("radnici");

            workers = (from worker in collection.AsQueryable<Worker>()
                           where worker.Name == txtName.Text && worker.Surname == txtSurname.Text
                           select worker).ToList<Worker>();
            if (workers.Count > 0)
            {
                listWorkers.Items.Clear();
                showWorkers(workers);
            }
            else
            {
                MessageBox.Show("Trazeni radnik ne postoji");
            }

            txtName.Text = "";
            txtSurname.Text = "";

        }
    }
}
