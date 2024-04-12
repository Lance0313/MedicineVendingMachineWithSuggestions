using System;
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
    public partial class PaymentOption : Form
    {
        
        public PaymentOption()
        {
            InitializeComponent();
        }

        private void PaymentOptionClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Purchase purchase = new Purchase();
            purchase.Visible = true;
        }

        private void PaymentOptionGcash_Click(object sender, EventArgs e)
        {
            Gcash gcash = new Gcash();
            gcash.Visible = true;
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CashPayment cashPayment = new CashPayment();
            cashPayment.Visible = true;
            this.Hide();
        }
    }
}
