﻿using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
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
    }
}
