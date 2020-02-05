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
    public partial class FormForAdmin : Form
    {
        public FormForAdmin()
        {
            InitializeComponent();
        }

        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddWorker f = new AddWorker();
            f.ShowDialog();
            this.Show();
        }

        private void btnEditWorkers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAndEditWorker f = new ViewAndEditWorker();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
