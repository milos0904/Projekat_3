using BetPharm.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
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
        string kodRadnika;
        public MedicamentForm()
        {
            kodRadnika = "";
            InitializeComponent();
        }
        public MedicamentForm(string s)
        {
            kodRadnika = s;
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

            bool fleg = false;
            foreach (Worker w in workers)
            {
                if (w.WorkerCode.Equals(kodRadnika))
                {
                    m.Worker = new MongoDBRef("radnici", w.Id);
                    fleg = true;
                    break;
                }
            }
            if (fleg)
            {
                var collection = database.GetCollection<Medicament>("lekovi");
                collection.Insert(m);
                fleg = false;

                MessageBox.Show("Uspesno ste dodali lek");

                txtNaziv.Text = "";
                txtProizvodjac.Text = "";
                DateTimeRokTrajanja.Value = System.DateTime.Now;
                dateTimeDatumDospeca.Value = System.DateTime.Now;
                cmbFarmaceutskiOblik.Text = "Tableta";
                numericUpDownDDD.Value = 0;
                numericUpDownCena.Value = 0;
                numericUpDownKolicina.Value = 0;
                txtOdobrio.Text = "";
            }
            else
                MessageBox.Show("Ne postoji radnik sa tim kodom.");
            
            //Close();
        }

        private void txtNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtProizvodjac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtOdobrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
