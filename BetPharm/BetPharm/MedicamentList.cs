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
        public MedicamentList()
        {
            InitializeComponent();
        }

        private void UcitajSviLekovi()
        {
            var db = DataLayer.GetDataBase();

            var collection = db.GetCollection<Medicament>("lekovi");

            //var lekovi = from radnik in collection.AsQueryable<Worker>() select radnik;

            //foreach (Medicament m in collection.)
        }


        private void MedicamentList_Load(object sender, EventArgs e)
        {

        }
    }
}
