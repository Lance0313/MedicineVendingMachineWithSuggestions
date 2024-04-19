using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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
            //Call total price
            CartSummaryTotal.Text = "Total Price: Php " + Purchase.totalPrice.ToString();

            //Call the list of orders
            /*foreach (var itemName in Purchase.itemNames)
            {
                Label itemNameLabel = new Label();
                itemNameLabel.Name = CartSummaryItemName + "Label";
                itemNameLabel.Text = itemName;
                itemNameLabel.AutoSize = true;

                // Calculate Y-position for the label
                int newY = CartSummaryItemName.Controls.Count * itemNameLabel.Height;
                itemNameLabel.Location = new System.Drawing.Point(0, newY);
                CartSummaryItemName.Controls.Add(itemNameLabel);
            }
            foreach (var quantity in Purchase.quantities)
            {
                Label quantityLabel = new Label();
                quantityLabel.Name = CartSummaryQuantity + "Label";
                quantityLabel.Text = quantity.ToString();
                quantityLabel.AutoSize = true;

                int newY = CartSummaryQuantity.Controls.Count * quantityLabel.Height;
                quantityLabel.Location = new Point(0, newY);
                CartSummaryQuantity.Controls.Add(quantityLabel);
            }
            foreach (var price in Purchase.prices)
            {
                Label prodPrice = new Label();
                prodPrice.Name = CartSummaryPrice + "Label";
                prodPrice.Text = "₱ "+price.ToString();
                prodPrice.AutoSize = true;

                int newY = CartSummaryPrice.Controls.Count * prodPrice.Height;
                prodPrice.Location = new Point(0, newY);
                CartSummaryPrice.Controls.Add(prodPrice);
            }*/
            for (int i = 0; i < Purchase.itemNames.Count; i++)
            {
                string itemName = Purchase.itemNames[i];
                int quantity = Purchase.quantities[i];
                float price = Purchase.prices[i];

                Label itemNameLabel = new Label();
                itemNameLabel.Name = CartSummaryItemName + "Label";
                itemNameLabel.Text = itemName;
                itemNameLabel.AutoSize = true;

                // Calculate Y-position for the label
                int newY = CartSummaryItemName.Controls.Count * itemNameLabel.Height;
                itemNameLabel.Location = new Point(0, newY);
                CartSummaryItemName.Controls.Add(itemNameLabel);

                Label quantityLabel = new Label();
                quantityLabel.Name = CartSummaryQuantity + "Label";
                quantityLabel.Text = quantity.ToString();
                quantityLabel.AutoSize = true;

                quantityLabel.Location = new Point(0, newY);
                CartSummaryQuantity.Controls.Add(quantityLabel);

                Label prodPrice = new Label();
                prodPrice.Name = CartSummaryPrice + "Label";
                prodPrice.Text = "₱ " + price;
                prodPrice.AutoSize = true;

                prodPrice.Location = new Point(0, newY);
                CartSummaryPrice.Controls.Add(prodPrice);
            }


        }
        //Back button of the form
        private void CartSummaryBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Proceed to payment form button
        private void CartSummaryProceed_Click(object sender, EventArgs e)
        {
            PaymentOption paymentOption = new PaymentOption();
            paymentOption.Show();
        }
    }
}





