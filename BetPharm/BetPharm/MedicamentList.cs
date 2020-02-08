using MongoDB.Bson;
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
    public partial class MedicamentList : Form
    {
        private string nazivLeka;
        private string kodRadnika;
        public MedicamentList()
        {
            nazivLeka = "";
            kodRadnika = "";
            InitializeComponent();
        }

        public MedicamentList(string s, string kod)
        {
            kodRadnika = kod;
            nazivLeka = s;
            InitializeComponent();          
        }

        private void UcitajSveLekove()
        {
            var db = DataLayer.GetDataBase();

            var collection = db.GetCollection<Medicament>("lekovi");
            
            listView1.Items.Clear();
            if (nazivLeka == "" || nazivLeka== "Naziv leka")
            {
                foreach (Medicament m in collection.FindAll())
                {
                    if(m.Quantity > 0)
                    {
                        ListViewItem item = new ListViewItem(new string[] { m.Name, m.Producer, m.ExpirationDate.ToShortDateString(), m.MaturityDate.ToShortDateString(), m.PharmaceuticalForm, m.Approved, m.DDD.ToString(), m.Price.ToString(), m.Quantity.ToString(), m.Id.ToString() }); ;
                        listView1.Items.Add(item);
                    }                    
                }
            }
            else
            {
                foreach (Medicament m in collection.Find(Query.EQ("Name", BsonValue.Create(nazivLeka))))
                {
                    if (m.Quantity > 0)
                    {
                        ListViewItem item = new ListViewItem(new string[] { m.Name, m.Producer, m.ExpirationDate.ToShortDateString(), m.MaturityDate.ToShortDateString(), m.PharmaceuticalForm, m.Approved, m.DDD.ToString(), m.Price.ToString(), m.Quantity.ToString(), m.Id.ToString() }); ;
                        listView1.Items.Add(item);
                    }
                }
            }           
            listView1.Refresh();
        }      

        private void ProdajLek(ObjectId id,string kodR)
        {
             
            SoldInfo p = new SoldInfo(id,kodR);
            p.ShowDialog();
            this.UcitajSveLekove();
           
        }

        private void MedicamentList_Load(object sender, EventArgs e)
        {
            this.UcitajSveLekove();
        }

        private void btnProdajLek_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite lek");
                return;
            }
            ObjectId  id = MongoDB.Bson.ObjectId.Parse(listView1.SelectedItems[0].SubItems[9].Text);
 
            this.ProdajLek(id,kodRadnika);
        }
    }
}
