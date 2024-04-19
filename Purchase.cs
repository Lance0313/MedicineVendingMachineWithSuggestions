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
        
        public Purchase()
        {
            InitializeComponent();
            //Hide minus button
            PurchaseCartPanel.Visible = false;
            PurchaseMinusMefenamic.Visible = false;
            PurchaseMinusAdvil.Visible = false;
            PurchaseMinusBiogesic.Visible = false;
            PurchaseMinusBioflu.Visible = false;
            PurchaseMinusIbuprofen.Visible = false;
            PurchaseMinusCetirizine.Visible = false;
            PurchaseMinusNeozep.Visible = false;
            PurchaseMinusDiatabs.Visible = false;
            PurchaseMinusKremilS.Visible = false;
            PurchaseMinusAscorbic.Visible = false;
            //End of hide minus button
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

        //Variables
        private int PurchaseBiogesicQuantity = 0;
        private int PurchaseNeozepQuantity = 0;
        private int PurchaseMefenamicQuantity = 0;
        private int PurchaseDiatabsQuantity = 0;
        private int PurchaseAdvilQuantity = 0;
        private int PurchaseCetirizineQuantity = 0;
        private int PurchaseBiofluQuantity = 0;
        private int PurchaseAscorbicQuantity = 0;
        private int PurchaseIbuprofenQuantity = 0;
        private int PurchaseKremilSQuantity = 0;
        private const int BiogesicPrice = 45;
        private const int NeozepPrice = 65;
        private const int MefenamicPrice = 190;
        private const int DiatabsPrice = 130;
        private const int AdvilPrice = 90;
        private const int CetirizinePrice = 200;
        private const int BiofluPrice = 45;
        private const int AscorbicPrice = 85;
        private const int IbuprofenPrice = 75;
        private const int KremilSPrice = 110;
        //End of variables

        //Get Quantity of products
        private int GetQuantity(string productName)
        {
            switch (productName)
            {
                case "Biogesic":
                    return Math.Max(0, PurchaseBiogesicQuantity);
                case "Neozep Forte":
                    return Math.Max(0, PurchaseNeozepQuantity);
                case "Imodium":
                    return Math.Max(0, PurchaseMefenamicQuantity);
                case "Medicol Advance 400":
                    return Math.Max(0, PurchaseDiatabsQuantity);
                case "Ascof Forte":
                    return Math.Max(0, PurchaseAdvilQuantity);
                case "Cetirizine":
                    return Math.Max(0, PurchaseCetirizineQuantity);
                case "Bonamine":
                    return Math.Max(0, PurchaseBiofluQuantity);
                case "Fern-C":
                    return Math.Max(0, PurchaseAscorbicQuantity);
                case "Neozep Non-Drowsy":
                    return Math.Max(0, PurchaseIbuprofenQuantity);
                case "KremilS":
                    return Math.Max(0, PurchaseKremilSQuantity);
                default:
                    return 0;
            }
        }
        //End of get quantity of products

        //Calculate TotalPrice
        public int CalculateTotalPrice()
        {
            int total = PurchaseBiogesicQuantity * BiogesicPrice +
                        PurchaseNeozepQuantity * NeozepPrice +
                        PurchaseMefenamicQuantity * MefenamicPrice +
                        PurchaseDiatabsQuantity * DiatabsPrice +
                        PurchaseAdvilQuantity * AdvilPrice +
                        PurchaseCetirizineQuantity * CetirizinePrice +
                        PurchaseBiofluQuantity * BiofluPrice +
                        PurchaseAscorbicQuantity * AscorbicPrice +
                        PurchaseIbuprofenQuantity * IbuprofenPrice +
                        PurchaseKremilSQuantity * KremilSPrice;
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
    private void PurchaseAddAdvil_Click(object sender, EventArgs e)
    {
        //Add quantity
        PurchaseAdvilQuantity++;
        //Call UpdateLabel
        UpdateLabel("Advil", PurchaseAdvilQuantity * AdvilPrice);
        //Show Minus button
        PurchaseMinusAdvil.Visible = true;
    }

    private void PurchaseMinusAdvil_Click(object sender, EventArgs e)
    {
        //Substract quantity 
        PurchaseAdvilQuantity--;
        //Call UpdateLabel
        UpdateLabel("Advil", PurchaseAdvilQuantity * AdvilPrice);
        //Hide minus button when quantity value is 0
        PurchaseMinusAdvil.Visible = PurchaseAdvilQuantity > 0;
    }

    private void PurchaseMinusMefenamic_Click(object sender, EventArgs e)
    {
        PurchaseMefenamicQuantity--;
        UpdateLabel("Mefenamic", PurchaseMefenamicQuantity * MefenamicPrice);
        PurchaseMinusMefenamic.Enabled = PurchaseMefenamicQuantity > 0;
        PurchaseMinusMefenamic.Visible = PurchaseMefenamicQuantity > 0;
    }

    private void PurchaseAddMefenamic_Click(object sender, EventArgs e)
    {
        PurchaseMefenamicQuantity++;
        UpdateLabel("Mefenamic", PurchaseMefenamicQuantity * MefenamicPrice);
        PurchaseMinusMefenamic.Enabled = true;
        PurchaseMinusMefenamic.Visible = true;
    }

    private void PurchaseAddBiogesic_Click(object sender, EventArgs e)
    {
        PurchaseBiogesicQuantity++;
        UpdateLabel("Biogesic", PurchaseBiogesicQuantity * BiogesicPrice);
        PurchaseMinusBiogesic.Visible = true;
    }

    private void PurchaseMinusBiogesic_Click(object sender, EventArgs e)
    {
        PurchaseBiogesicQuantity--;
        UpdateLabel("Biogesic", PurchaseBiogesicQuantity * BiogesicPrice);
        PurchaseMinusBiogesic.Visible = PurchaseBiogesicQuantity > 0;
    }

    private void PurchaseMinusIbuprofen_Click(object sender, EventArgs e)
    {
        PurchaseIbuprofenQuantity--;
        UpdateLabel("Ibuprofen", PurchaseIbuprofenQuantity * IbuprofenPrice);
        PurchaseMinusIbuprofen.Visible = PurchaseIbuprofenQuantity > 0;
    }

    private void PurchaseAddIbuprofen_Click(object sender, EventArgs e)
    {
        PurchaseIbuprofenQuantity++;
        UpdateLabel("Ibuprofen", PurchaseIbuprofenQuantity * IbuprofenPrice);
        PurchaseMinusIbuprofen.Visible = true;
    }

    private void PurchaseMinusBioflu_Click(object sender, EventArgs e)
    {
        PurchaseBiofluQuantity--;
        UpdateLabel("Bioflu", PurchaseBiofluQuantity * BiofluPrice);
        PurchaseMinusBioflu.Visible = PurchaseBiofluQuantity > 0;
    }

    private void PurchaseAddBioflu_Click(object sender, EventArgs e)
    {
        PurchaseBiofluQuantity++;
        UpdateLabel("Bioflu", PurchaseBiofluQuantity * BiofluPrice);
        PurchaseMinusBioflu.Visible = true;
    }

    private void PurchaseMinusCetirizine_Click(object sender, EventArgs e)
    {
        PurchaseCetirizineQuantity--;
        UpdateLabel("Cetirizine", PurchaseCetirizineQuantity * CetirizinePrice);
        PurchaseMinusCetirizine.Visible = PurchaseCetirizineQuantity > 0;
    }

    private void PurchaseAddCetirizine_Click(object sender, EventArgs e)
    {
        PurchaseCetirizineQuantity++;
        UpdateLabel("Cetirizine", PurchaseCetirizineQuantity * CetirizinePrice);
        PurchaseMinusCetirizine.Visible = true;
    }

    private void PurchaseMinusDiatabs_Click(object sender, EventArgs e)
    {
        PurchaseDiatabsQuantity--;
        UpdateLabel("Diatabs", PurchaseDiatabsQuantity * DiatabsPrice);
        PurchaseMinusDiatabs.Visible = PurchaseDiatabsQuantity > 0;
    }

    private void PurchaseAddDiatabs_Click(object sender, EventArgs e)
    {
        PurchaseDiatabsQuantity++;
        UpdateLabel("Diatabs", PurchaseDiatabsQuantity * DiatabsPrice);
        PurchaseMinusDiatabs.Visible = true;
    }

    private void PurchaseMinusNeozep_Click(object sender, EventArgs e)
    {
        PurchaseNeozepQuantity--;
        UpdateLabel("Neozep", PurchaseNeozepQuantity * NeozepPrice);
        PurchaseMinusNeozep.Visible = PurchaseNeozepQuantity > 0;
    }

    private void PurchaseAddNeozep_Click(object sender, EventArgs e)
    {
        PurchaseNeozepQuantity++;
        UpdateLabel("Neozep", PurchaseNeozepQuantity * NeozepPrice);
        PurchaseMinusNeozep.Visible = true;
    }

    private void PurchaseMinusAscorbic_Click(object sender, EventArgs e)
    {
        PurchaseAscorbicQuantity--;
        UpdateLabel("Ascorbic", PurchaseAscorbicQuantity * AscorbicPrice);
        PurchaseMinusAscorbic.Visible = PurchaseAscorbicQuantity > 0;
    }

    private void PurchaseAddAscorbic_Click(object sender, EventArgs e)
    {
        PurchaseAscorbicQuantity++;
        UpdateLabel("Ascorbic", PurchaseAscorbicQuantity * AscorbicPrice);
        PurchaseMinusAscorbic.Visible = true;
    }

    private void PurchaseMinusKremilS_Click(object sender, EventArgs e)
    {
        PurchaseKremilSQuantity--;
        UpdateLabel("KremilS", PurchaseKremilSQuantity * KremilSPrice);
        PurchaseMinusKremilS.Visible = PurchaseKremilSQuantity > 0;
    }

    private void PurchaseAddKremilS_Click(object sender, EventArgs e)
    {
        PurchaseKremilSQuantity++;
        UpdateLabel("KremilS", PurchaseKremilSQuantity * KremilSPrice);
        PurchaseMinusKremilS.Visible = true;
    }
    //End of Add/Minus function
    }
}