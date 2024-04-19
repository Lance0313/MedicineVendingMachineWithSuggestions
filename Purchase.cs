using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ThesisBeta
{
    public partial class Purchase : Form
    {
        private bool isPanelVisible = false;
        public static int totalPrice;
        public static List<string> itemNames;
        public static List<int> quantities;
        public static List<float> prices;
        private int item1 = 0;
        private int item2 = 0;
        private int item3 = 0;
        private int item4 = 0;
        private int item5 = 0;
        private int item6 = 0;
        private int item7 = 0;
        private int item8 = 0;
        private int item9 = 0;
        private int item0 = 0;
        private const int item1Price = 45;
        private const int item2Price = 65;
        private const int item3Price = 190;
        private const int item4Price = 130;
        private const int item5Price = 90;
        private const int item6Price = 200;
        private const int item7Price = 45;
        private const int item8Price = 85;
        private const int item9Price = 75;
        private const int item0Price = 110;

        public Purchase()
        {
            InitializeComponent();
            //Hide components
            PurchaseCartPanel.Visible = false;
            PurchaseMinusitem6.Visible = false;
            PurchaseMinusitem1.Visible = false;
            PurchaseMinusitem2.Visible = false;
            PurchaseMinusitem3.Visible = false;
            PurchaseMinusitem0.Visible = false;
            PurchaseMinusitem4.Visible = false;
            PurchaseMinusitem9.Visible = false;
            PurchaseMinusitem8.Visible = false;
            PurchaseMinusitem7.Visible = false;
            PurchaseMinusitem5.Visible = false;
            item1Quantity.Visible = false;
            item2Quantity.Visible = false;
            item3Quantity.Visible = false;
            item4Quantity.Visible = false;
            item5Quantity.Visible = false;
            item6Quantity.Visible = false;
            item7Quantity.Visible = false;
            item8Quantity.Visible = false;
            item9Quantity.Visible = false;
            item0Quantity.Visible = false;
            //End of hide components
        }

        //Toggling cart panel visibility
        private void PurchaseCartButton_Click(object sender, EventArgs e)
        {
            if (isPanelVisible)
            {
                //Sets to false if it was true
                PurchaseCartPanel.Visible = false;
            }
            else
            {
                //Sets to true if it was false
                PurchaseCartPanel.Visible = true;
            }
            //Toggles the visibility
            isPanelVisible = !isPanelVisible;
        }
        //End of toggling cart panel visibility

        //Get Quantity of products
        private int GetQuantity(string productName)
        {
            switch (productName)
            {
                case "Ascof Forte":
                    return Math.Min(3, Math.Max(0, item1));
                case "Biogesic":
                    return Math.Min(3, Math.Max(0, item2));
                case "Bonamine":
                    return Math.Min(3, Math.Max(0, item3));
                case "Cetirizine":
                    return Math.Min(3, Math.Max(0, item4));
                case "Fern C":
                    return Math.Min(3, Math.Max(0, item5));
                case "Imodium":
                    return Math.Min(3, Math.Max(0, item6));
                case "Kremil S":
                    return Math.Min(3, Math.Max(0, item7));
                case "Medicol":
                    return Math.Min(3, Math.Max(0, item8));
                case "Neozep Non Drowsy":
                    return Math.Min(3, Math.Max(0, item9));
                case "Neozep Forte":
                    return Math.Min(3, Math.Max(0, item0));
                default:
                    return 0;
            }
        }
        //End of get quantity of products

        //Calculate TotalPrice
        public int CalculateTotalPrice()
        {
            int total = item1 * item1Price +
                        item2 * item2Price +
                        item3 * item3Price +
                        item4 * item4Price +
                        item5 * item5Price +
                        item6 * item6Price +
                        item7 * item7Price +
                        item8 * item8Price +
                        item9 * item9Price +
                        item0 * item0Price;
            return total;
        }
        //End of calculating total price

        //Update cart text function
        private void UpdateLabel(string productName, int totalPrice)
        {
            //Ensures non-negative
            totalPrice = Math.Max(0, totalPrice);

            // Check if a label for the product already exists
            int quantity = GetQuantity(productName);

            // Remove the label if it exists
            if (quantity == 0)
            {
                //Look for children of PurchaseCartText that is a label
                Label existingLabel = PurchaseCartText.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == productName + "Label");
                if (existingLabel != null)
                {
                    PurchaseCartText.Controls.Remove(existingLabel);
                }
            }
            else
            {
                // Check if a label for the product already exists
                Label existingLabel = PurchaseCartText.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == productName + "Label");
                if (existingLabel != null)
                {
                    // Update the existing label with new information
                    existingLabel.Text = $"{productName} - {quantity} - \u20B1{totalPrice}";
                }
                else
                {
                    // Create and configure the label
                    Label newLabel = new Label();
                    newLabel.Name = productName + "Label";
                    newLabel.Text = $"{productName} - {quantity} - \u20B1{totalPrice}";
                    newLabel.AutoSize = true;

                    // Calculate Y-position for the label
                    int newY = PurchaseCartText.Controls.Count * newLabel.Height;
                    newLabel.Location = new Point(0, newY);
                    PurchaseCartText.Controls.Add(newLabel);
                }
            }
        }
        //End of update cart text function

        //Get contents of the panel
        public void GetPanelContents()
        {
            List<string> itemNames_ = new List<string>();
            List<int> quantities_ = new List<int>();
            List<float> prices_ = new List<float>();

            foreach (Control control in PurchaseCartText.Controls)
            {
                string[] parts = control.Text.Split('-');

                if (parts.Length >= 3)
                {
                    string itemName = parts[0].Trim();
                    Console.WriteLine(parts[1]);
                    int quantity = int.Parse(parts[1].Trim());
                    float price = float.Parse(parts[2].Trim().Replace("₱", string.Empty));
                    Console.WriteLine(price);

                    // Add item name, quantity, and price to their respective lists
                    itemNames_.Add(itemName);
                    quantities_.Add(quantity);
                    prices_.Add(price);
                }
            }
            itemNames = itemNames_;
            quantities = quantities_;
            prices = prices_;
        }
        //Proceed
        private void PurchaseProceed_Click(object sender, EventArgs e)
        {
            if (PurchaseCartText.Controls.Count == 0)
            {
                MessageBox.Show("Please add items to the order before checking out.");
                return;
            }
            totalPrice = CalculateTotalPrice();
            GetPanelContents();
            CartSummary cartSummary = new CartSummary();
            cartSummary.Show();
        }


        //Start of Add/Minus Function
        private void PurchaseAdditem5_Click(object sender, EventArgs e)
        {
            //Add quantity
            item5++;
            //Call UpdateLabel
            UpdateLabel("Fern C", item5 * item5Price);
            //Show Minus button
            PurchaseMinusitem5.Visible = true;
            //Show Quantity Label 
            item5Quantity.Visible = true;
            //Update quantity label
            item5Quantity.Text = item5.ToString();
        }

        private void PurchaseMinusitem5_Click(object sender, EventArgs e)
        {
            //Substract quantity 
            item5--;
            //Call UpdateLabel
            UpdateLabel("Fern C", item5 * item5Price);
            //Hide minus button when quantity value is 0
            PurchaseMinusitem5.Visible = item5 > 0;
            //Hide quantity label when quantity value is 0
            item5Quantity.Visible = item5 > 0;
            //Update quantity label
            item5Quantity.Text = item5.ToString();
        }

        private void PurchaseMinusitem3_Click(object sender, EventArgs e)
        {
            item3--;
            UpdateLabel("Bonamine", item3 * item3Price);
            PurchaseMinusitem3.Enabled = item3 > 0;
            PurchaseMinusitem3.Visible = item3 > 0;
            item3Quantity.Visible = item3 > 0;
            item3Quantity.Text = item3.ToString();
        }

        private void PurchaseAdditem3_Click(object sender, EventArgs e)
        {
            item3++;
            UpdateLabel("Bonamine", item3 * item3Price);
            PurchaseMinusitem3.Enabled = true;
            PurchaseMinusitem3.Visible = true;
            item3Quantity.Visible = true;
            item3Quantity.Text = item3.ToString();
        }

        private void PurchaseAdditem1_Click(object sender, EventArgs e)
        {
            item1++;
            UpdateLabel("Ascof Forte", item1 * item1Price);
            PurchaseMinusitem1.Visible = true;
            item1Quantity.Visible = true;
            item1Quantity.Text = item1.ToString();
        }

        private void PurchaseMinusitem1_Click(object sender, EventArgs e)
        {
            item1--;
            UpdateLabel("Ascof Forte", item1 * item1Price);
            PurchaseMinusitem1.Visible = item1 > 0;
            item1Quantity.Visible = item1 > 0;
            item1Quantity.Text = item1.ToString();
        }

        private void PurchaseMinusitem9_Click(object sender, EventArgs e)
        {
            item9--;
            UpdateLabel("Neozep Forte", item9 * item9Price);
            PurchaseMinusitem9.Visible = item9 > 0;
            item9Quantity.Visible = item9 > 0;
            item9Quantity.Text = item9.ToString();
        }

        private void PurchaseAdditem9_Click(object sender, EventArgs e)
        {
            item9++;
            UpdateLabel("Neozep Forte", item9 * item9Price);
            PurchaseMinusitem9.Visible = true;
            item9Quantity.Visible = true;
            item9Quantity.Text = item9.ToString();
        }

        private void PurchaseMinusitem7_Click(object sender, EventArgs e)
        {
            item7--;
            UpdateLabel("Kremil S", item7 * item7Price);
            PurchaseMinusitem7.Visible = item7 > 0;
            item7Quantity.Visible = item7 > 0;
            item7Quantity.Text = item7.ToString();
        }

        private void PurchaseAdditem7_Click(object sender, EventArgs e)
        {
            item7++;
            UpdateLabel("Kremil S", item7 * item7Price);
            PurchaseMinusitem7.Visible = true;
            item7Quantity.Visible = true;
            item7Quantity.Text = item7.ToString();
        }


        private void PurchaseMinusitem6_Click(object sender, EventArgs e)
        {
            item6--;
            UpdateLabel("Imodium", item6 * item6Price);
            PurchaseMinusitem6.Visible = item6 > 0;
            item6Quantity.Visible = item6 > 0;
            item6Quantity.Text = item6.ToString();
        }

        private void PurchaseAdditem6_Click(object sender, EventArgs e)
        {
            item6++;
            UpdateLabel("Imodium", item6 * item6Price);
            PurchaseMinusitem6.Visible = true;
            item6Quantity.Visible = true;
            item6Quantity.Text = item6.ToString();
        }

        private void PurchaseMinusitem4_Click(object sender, EventArgs e)
        {
            item4--;
            UpdateLabel("Cetirizine", item4 * item4Price);
            PurchaseMinusitem4.Visible = item4 > 0;
            item4Quantity.Visible = item4 > 0;
            item4Quantity.Text = item4.ToString();
        }

        private void PurchaseAdditem4_Click(object sender, EventArgs e)
        {
            item4++;
            UpdateLabel("Cetirizine", item4 * item4Price);
            PurchaseMinusitem4.Visible = true;
            item4Quantity.Visible = true;
            item4Quantity.Text = item4.ToString();
        }

        private void PurchaseMinusitem2_Click(object sender, EventArgs e)
        {
            item2--;
            UpdateLabel("Biogesic", item2 * item2Price);
            PurchaseMinusitem2.Visible = item2 > 0;
            item2Quantity.Visible = item2 > 0;
            item2Quantity.Text = item2.ToString();
        }

        private void PurchaseAdditem2_Click(object sender, EventArgs e)
        {
            item2++;
            UpdateLabel("Biogesic", item2 * item2Price);
            PurchaseMinusitem2.Visible = true;
            item2Quantity.Visible = true;
            item2Quantity.Text = item2.ToString();
        }

        private void PurchaseMinusitem8_Click(object sender, EventArgs e)
        {
            item8--;
            UpdateLabel("Medicol Advance 400", item8 * item8Price);
            PurchaseMinusitem8.Visible = item8 > 0;
            item8Quantity.Visible = item8 > 0;
            item8Quantity.Text = item8.ToString();
        }

        private void PurchaseAdditem8_Click(object sender, EventArgs e)
        {
            item8++;
            UpdateLabel("Medicol Advance 400", item8 * item8Price);
            PurchaseMinusitem8.Visible = true;
            item8Quantity.Visible = true;
            item8Quantity.Text = item8.ToString();
        }

        private void PurchaseMinusitem0_Click(object sender, EventArgs e)
        {
            item0--;
            UpdateLabel("Neozep Non-Drowsy", item0 * item0Price);
            PurchaseMinusitem0.Visible = item0 > 0;
            item0Quantity.Visible = item0 > 0;
            item0Quantity.Text = item0.ToString();
        }

        private void PurchaseAdditem0_Click(object sender, EventArgs e)
        {
            item0++;
            UpdateLabel("Neozep Non-Drowsy", item0 * item0Price);
            PurchaseMinusitem0.Visible = true;
            item0Quantity.Visible = true;
            item0Quantity.Text = item0.ToString();
        }
        //End of Add/Minus function

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
        }

    }
}