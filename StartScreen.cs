﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisBeta
{
    public partial class StartScreen : Form
    {
        public DataGridView DataGridViewCart { get { return DataGridViewCart; } }
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreenLabel_Click(object sender, EventArgs e)
        {

        }

        private void StartScreenPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Visible = false;
        }
    }
}
