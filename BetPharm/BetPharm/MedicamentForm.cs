using BetPharm.Entities;
using MongoDB.Driver;
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
    public partial class MedicamentForm : Form
    {
        public MedicamentForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
             var database = DataLayer.GetDataBase();

            Medicament m = new Medicament
            {
                Name = txtNaziv.Text,
                Producer = txtProizvodjac.Text,
                ExpirationDate = DateTimeRokTrajanja.Value,
                MaturityDate=dateTimeDatumDospeca.Value,
                PharmaceuticalForm=cmbFarmaceutskiOblik.Text,
                Approved=txtOdobrio.Text,
                DDD=(float)numericUpDownDDD.Value,
                Price=(float)numericUpDownCena.Value,
                Quantity=(int)numericUpDownKolicina.Value

            };

            var radniciCollection = database.GetCollection<Worker>("radnici");
            var workers = from radnik in radniciCollection.AsQueryable<Worker>() select radnik;

      
            foreach (Worker w in workers)
            {
                if (w.WorkerCode.Equals(txtKodRadnika))
                {
                    m.Worker = new MongoDBRef("radnici", w.Id);
                    break;
                }
            }

            var collection = database.GetCollection<Medicament>("lekovi");
            collection.InsertOne(m);

            MessageBox.Show("Uspesno ste dodali lek");

            txtNaziv.Text = "";
            txtProizvodjac.Text = "";
            DateTimeRokTrajanja.Value = System.DateTime.Now;
            dateTimeDatumDospeca.Value = System.DateTime.Now;
            cmbFarmaceutskiOblik.Text = "Tableta";
            numericUpDownDDD.Value = 0;
            numericUpDownCena.Value = 0;
            numericUpDownKolicina.Value = 0;
            txtKodRadnika.Text = "";
            txtOdobrio.Text = "";

            //Close();
        }
    }
}
