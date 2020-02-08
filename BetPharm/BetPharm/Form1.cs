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
        private string kodRadnika;

        public Form1()
        {
            kodRadnika = "";
            InitializeComponent();
        }

        public Form1(string s)
        {
            kodRadnika = s;
            InitializeComponent();
        }


        private void btnLekovi_Click(object sender, EventArgs e)
        {
            MedicamentForm medicamentForm = new MedicamentForm(kodRadnika);
            medicamentForm.ShowDialog();
        }

        private void btnListaLekova_Click(object sender, EventArgs e)
        {
            MedicamentList m = new MedicamentList();
            m.ShowDialog();


        }



        private void btnPronadjiLek_Click(object sender, EventArgs e)
        {
            MedicamentList m = new MedicamentList(txtNazivLeka.Text,kodRadnika);
            m.ShowDialog();
            txtNazivLeka.Text = "Naziv leka";
        }


        private void txtNazivLeka_Click(object sender, EventArgs e)
        {
            txtNazivLeka.Text = "";
        }

        private void txtNazivLeka_MouseLeave(object sender, EventArgs e)
        {
            txtNazivLeka.Text = "Naziv leka";
        }

        private void txtNazivLeka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnVanRokTrajanja_Click(object sender, EventArgs e)
        {
            IstekaoRokTrajanja i = new IstekaoRokTrajanja();
            i.ShowDialog();
        }



        private void btnEditWorkers_Click(object sender, EventArgs e)
        {
            ViewAndEditWorker w = new ViewAndEditWorker();
            w.ShowDialog();
        }

        private void btnEvidencija_Click(object sender, EventArgs e)
        {
            EvidencijaOProdaji f = new EvidencijaOProdaji();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
