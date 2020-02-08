using BetPharm.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetPharm
{
    public partial class SoldInfo : Form
    {
        ObjectId idLeka;
        string kodRadnika;
        public SoldInfo()
        {
            kodRadnika = "";
            InitializeComponent();
        }
        public SoldInfo(ObjectId id,string kod)
        {
            idLeka = id;
            kodRadnika = kod;
            InitializeComponent();
        }

        private void btnProdajLek_Click(object sender, EventArgs e)
        {
            var db = DataLayer.GetDataBase();

            if(numericUpDown1.Value == 0 )
            {
                MessageBox.Show("Kolicina mora biti veca od 0");
                return;
            }
           

            var collectionWorker = db.GetCollection<Worker>("radnici");

            Worker w = null;
            w = collectionWorker.FindOne(Query.EQ("WorkerCode", BsonValue.Create(kodRadnika)));

            if(w == null)
            {
                MessageBox.Show("Ne postoji radnik sa tim kodom");
                return;
            }

            var collection = db.GetCollection<Medicament>("lekovi");

            var query = Query.EQ("_id", BsonValue.Create(idLeka));
            Medicament m = collection.FindOne(query);

            if(numericUpDown1.Value > m.Quantity)
            {
                MessageBox.Show("Ne postoji toliko lekova");
                return;
            }

            var collectionSold = db.GetCollection<Sold>("prodato");
            Sold s = new Sold()
            {
                DateOfSale = System.DateTime.Now,
                Quantity = (int)numericUpDown1.Value,
                Worker = new MongoDBRef("radnici", w.Id),
                Medicament = new MongoDBRef("lekovi", m.Id)
            };

            collectionSold.Insert(s);

            int novaKolicina = m.Quantity - (int)numericUpDown1.Value;
            var update = MongoDB.Driver.Builders.Update.Set("Quantity", BsonValue.Create(novaKolicina));

            collection.Update(query, update);

            numericUpDown1.Value = 0;
         

            MessageBox.Show("Uspesno ste prodali lek. Zatvaram...");
            this.Close();
        }

        
    }
}
