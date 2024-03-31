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
    public partial class CartSummary : Form
    {
        public CartSummary()
        {
            InitializeComponent();
            CartSummaryTotal.Text = "Total Price: Php "+Purchase.totalPrice.ToString();
        }

        private void CartSummaryBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void CartSummaryProceed_Click(object sender, EventArgs e)
        {
            PaymentOption paymentOption = new PaymentOption();
            paymentOption.Show();
        }
    }
}