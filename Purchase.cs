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
    public partial class Purchase : Form
    {
        private bool isPanelVisible = false;
        public Purchase()
        {
            InitializeComponent();
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


        }

        private void PurchaseCartButton_Click(object sender, EventArgs e)
        {
            if (isPanelVisible)
            {
                // If panel is currently visible, hide it
                PurchaseCartPanel.Visible = false;
            }
            else
            {
                // If panel is currently hidden, show it
                PurchaseCartPanel.Visible = true;
            }

            // Toggle the visibility state
            isPanelVisible = !isPanelVisible;

        }
        private int PurchaseBiogesicQuantity = 0;
        private int PurchaseNeozepQuantity = 0;
        private int PurchaseMefenamicQuantity = 0;
        private int PurchaseDiatabsQuantity = 0;
        private int PurchaseAdvilQuantity = 0;
        private int PurchaseCetirizineQuantity = 0;
        private int PurchaseBiofluQuantity = 0;
        private int PurchaseAscorbicQuantity = 0;
        private int PurchaseIbuprofenQuantity = 0;
        private const int BiogesicPrice = 68;
        private const int NeozepPrice = 75;
        private const int MefenamicPrice = 100;
        private const int DiatabsPrice = 90;
        private const int AdvilPrice = 60;
        private const int CetirizinePrice = 70;
        private const int BiofluPrice = 56;
        private const int AscorbicPrice = 83;
        private const int IbuprofenPrice = 62;
        private int GetQuantity(string productName)
        {
            switch (productName)
            {
                case "Biogesic":
                    return Math.Max(0, PurchaseBiogesicQuantity);
                case "Neozep":
                    return Math.Max(0, PurchaseNeozepQuantity);
                case "Mefenamic":
                    return Math.Max(0, PurchaseMefenamicQuantity);
                case "Diatabs":
                    return Math.Max(0, PurchaseDiatabsQuantity);
                case "Advil":
                    return Math.Max(0, PurchaseAdvilQuantity);
                case "Cetirizine":
                    return Math.Max(0, PurchaseCetirizineQuantity);
                case "Bioflu":
                    return Math.Max(0, PurchaseBiofluQuantity);
                case "Ascorbic":
                    return Math.Max(0, PurchaseAscorbicQuantity);
                case "Ibuprofen":
                    return Math.Max(0, PurchaseIbuprofenQuantity);
                default:
                    return 0;
            }
        }
        private int CalculateTotalPrice()
        {
            int total = PurchaseBiogesicQuantity * BiogesicPrice +
                        PurchaseNeozepQuantity * NeozepPrice +
                        PurchaseMefenamicQuantity * MefenamicPrice +
                        PurchaseDiatabsQuantity * DiatabsPrice +
                        PurchaseAdvilQuantity * AdvilPrice +
                        PurchaseCetirizineQuantity * CetirizinePrice +
                        PurchaseBiofluQuantity * BiofluPrice +
                        PurchaseAscorbicQuantity * AscorbicPrice +
                        PurchaseIbuprofenQuantity * IbuprofenPrice;
            return total;
        }

        private void UpdateLabel(string productName, int totalPrice)
        {
            //Ensures non-negative
            totalPrice = Math.Max(0, totalPrice);
            // Check if a label for the product already exists
            int quantity = GetQuantity(productName);

            if (quantity == 0)
            {
                // Remove the label if it exists
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
                    existingLabel.Text = $"{productName}: {quantity} - \u20B1{totalPrice}";
                }
                else
                {
                    // Create and configure the label
                    Label newLabel = new Label();
                    newLabel.Name = productName + "Label";
                    newLabel.Text = $"{productName}: {quantity} - \u20B1{totalPrice}";
                    newLabel.AutoSize = true;

                    // Calculate Y-position for the label
                    int newY = PurchaseCartText.Controls.Count * newLabel.Height;

                    // Set the location of the label
                    newLabel.Location = new System.Drawing.Point(0, newY);

                    // Add the label to the panel
                    PurchaseCartText.Controls.Add(newLabel);
                }
            }
        }

        private void PurchaseProceed_Click(object sender, EventArgs e)
        {
            if (PurchaseCartText.Controls.Count == 0)
            {
                MessageBox.Show("Please add items to the order before checking out.");
                return;
            }
            int totalPrice = CalculateTotalPrice();
            this.Hide();

        }

        private void PurchaseAddAdvil_Click(object sender, EventArgs e)
        {
            PurchaseAdvilQuantity++;
            UpdateLabel("Advil", PurchaseAdvilQuantity * AdvilPrice);
            PurchaseMinusAdvil.Visible = true;
        }

        private void PurchaseMinusAdvil_Click(object sender, EventArgs e)
        {
            PurchaseAdvilQuantity--;
            UpdateLabel("Advil", PurchaseAdvilQuantity * AdvilPrice);
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
    }
}
