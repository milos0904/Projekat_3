

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnLekovi_Click(object sender, EventArgs e)
        {          
            MedicamentForm medicamentForm = new MedicamentForm();
            medicamentForm.ShowDialog();
        }

        private void btnListaLekova_Click(object sender, EventArgs e)
        {
            MedicamentList m = new MedicamentList();
            m.ShowDialog(); 
            

        }

        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {
            AddWorker w = new AddWorker();
            w.ShowDialog();
        }

        private void btnEditWorkers_Click(object sender, EventArgs e)
        {
            ViewAndEditWorker w = new ViewAndEditWorker();
            w.ShowDialog();
        }
    }
}
