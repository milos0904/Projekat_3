

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
            AddWorker add = new AddWorker();
            add.ShowDialog();
        }

        private void btnPronadjiLek_Click(object sender, EventArgs e)
        {
            MedicamentList m = new MedicamentList(txtNazivLeka.Text);
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
    }
}
