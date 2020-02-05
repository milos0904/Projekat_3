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
using MongoDB.Driver.Builders;

namespace BetPharm
{
    public partial class EvidencijaOProdaji : Form
    {
        public EvidencijaOProdaji()
        {
            InitializeComponent();
        }

        private void EvidencijaOProdaji_Load(object sender, EventArgs e)
        {
            PrikaziEvidenciju();
        }

        private void PrikaziEvidenciju()
        {
            var db = DataLayer.GetDataBase();

            var collection = db.GetCollection<Sold>("prodato");

            listView1.Items.Clear();

            foreach (Sold s in collection.FindAll())
            {
                var collectionM = db.GetCollection<Medicament>(s.Medicament.CollectionName);
                var query = Query.EQ("_id", s.Medicament.Id);
                Medicament m = collectionM.FindOne(query);

                var collectionW = db.GetCollection<Worker>(s.Worker.CollectionName);
                var query1 = Query.EQ("_id", s.Worker.Id);
                Worker w = collectionW.FindOne(query1);
                ListViewItem item = new ListViewItem(new string[] { m.Name, s.Quantity.ToString(), m.Price.ToString(), m.Producer, w.Name + " " + w.Surname, s.DateOfSale.ToShortDateString()});
                listView1.Items.Add(item);

            }
            listView1.Refresh();
        }
    }
}
