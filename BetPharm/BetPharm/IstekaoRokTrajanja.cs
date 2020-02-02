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
    public partial class IstekaoRokTrajanja : Form
    {
        public IstekaoRokTrajanja()
        {
            InitializeComponent();
        }

        private void UcitajLekoviVanRok()
        {
            var db = DataLayer.GetDataBase();

            var collection = db.GetCollection<Medicament>("lekovi");

            listView1.Items.Clear();

            foreach (Medicament m in collection.FindAll())
            {
                if (m.Quantity > 0 && m.ExpirationDate < System.DateTime.Now)
                {
                    ListViewItem item = new ListViewItem(new string[] { m.Name, m.Producer, m.ExpirationDate.ToString(), m.MaturityDate.ToString(), m.PharmaceuticalForm, m.Approved, m.DDD.ToString(), m.Price.ToString(), m.Quantity.ToString(), m.Id.ToString() }); ;
                    listView1.Items.Add(item);
                }
            }
           listView1.Refresh();
        }

        private void UkloniLek(ObjectId id)
        {
            var db = DataLayer.GetDataBase();

            var collection = db.GetCollection<Medicament>("lekovi");

            var query = Query.EQ("_id", BsonValue.Create(id));            
            var update = MongoDB.Driver.Builders.Update.Set("Quantity", BsonValue.Create(0));

            collection.Update(query, update);

            this.UcitajLekoviVanRok();
        }

        private void IstekaoRokTrajanja_Load(object sender, EventArgs e)
        {
          
            this.UcitajLekoviVanRok();
        }

        private void btnUkloniLek_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite lek");
                return;
            }
            ObjectId id = MongoDB.Bson.ObjectId.Parse(listView1.SelectedItems[0].SubItems[9].Text);

            this.UkloniLek(id);
        }
    }
}
