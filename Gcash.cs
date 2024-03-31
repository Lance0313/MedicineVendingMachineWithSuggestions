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
    public partial class Gcash : Form
    {

        public Gcash()
        {
            InitializeComponent();
            GcashAmountReceived.Text = "0.00";
            GcashTotal.Text = Purchase.totalPrice.ToString();
        }

        private void CartSummaryBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
