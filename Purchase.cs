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
                        PurchaseIbuprofenQuantity * IbuprofenPrice +
                        PurchaseKremilSQuantity * KremilSPrice;
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
            UpdateLabel("Ascof Forte", PurchaseAdvilQuantity * AdvilPrice);
            PurchaseMinusAdvil.Visible = true;
        }

        private void PurchaseMinusAdvil_Click(object sender, EventArgs e)
        {
            PurchaseAdvilQuantity--;
            UpdateLabel("Ascof Forte", PurchaseAdvilQuantity * AdvilPrice);
            PurchaseMinusAdvil.Visible = PurchaseAdvilQuantity > 0;

        }

        private void PurchaseMinusMefenamic_Click(object sender, EventArgs e)
        {
            PurchaseMefenamicQuantity--;
            UpdateLabel("Imodium", PurchaseMefenamicQuantity * MefenamicPrice);
            PurchaseMinusMefenamic.Enabled = PurchaseMefenamicQuantity > 0;
            PurchaseMinusMefenamic.Visible = PurchaseMefenamicQuantity > 0;
        }

        private void PurchaseAddMefenamic_Click(object sender, EventArgs e)
        {
            PurchaseMefenamicQuantity++;
            UpdateLabel("Imodium", PurchaseMefenamicQuantity * MefenamicPrice);
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();

            this.Hide();
        }

        private void PurchaseAddIbuprofen_Click(object sender, EventArgs e)
        {
            PurchaseIbuprofenQuantity++;
            UpdateLabel("Neozep Non-Drowsy", PurchaseIbuprofenQuantity * IbuprofenPrice);

            PurchaseMinusIbuprofen.Visible = true;
        }

        private void PurchaseMinusIbuprofen_Click(object sender, EventArgs e)
        {
            PurchaseIbuprofenQuantity--;
            UpdateLabel("Neozep Non-Drowsy", PurchaseIbuprofenQuantity * IbuprofenPrice);
            PurchaseMinusIbuprofen.Visible = PurchaseIbuprofenQuantity > 0;
        }

        private void PurchaseAddBioflu_Click(object sender, EventArgs e)
        {
            PurchaseBiofluQuantity++;
            UpdateLabel("Bonamine", PurchaseBiofluQuantity * BiofluPrice);

            PurchaseMinusBioflu.Visible = true;
        }

        private void PurchaseMinusBioflu_Click(object sender, EventArgs e)
        {
            PurchaseBiofluQuantity--;
            UpdateLabel("Bonamine", PurchaseBiofluQuantity * BiofluPrice);
            PurchaseMinusBioflu.Visible = PurchaseBiofluQuantity > 0;
        }

        private void PurchaseAddCetirizine_Click(object sender, EventArgs e)
        {
            PurchaseCetirizineQuantity++;
            UpdateLabel("Cetirizine", PurchaseCetirizineQuantity * CetirizinePrice);

            PurchaseMinusCetirizine.Visible = true;
        }

        private void PurchaseMinusCetirizine_Click(object sender, EventArgs e)
        {
            PurchaseCetirizineQuantity--;
            UpdateLabel("Cetirizine", PurchaseCetirizineQuantity * CetirizinePrice);
            PurchaseMinusCetirizine.Visible = PurchaseCetirizineQuantity > 0;
        }

        private void PurchaseAddDiatabs_Click(object sender, EventArgs e)
        {
            PurchaseDiatabsQuantity++;
            UpdateLabel("Medicol Advance 400", PurchaseDiatabsQuantity * DiatabsPrice);

            PurchaseMinusDiatabs.Visible = true;
        }

        private void PurchaseMinusDiatabs_Click(object sender, EventArgs e)
        {
            PurchaseDiatabsQuantity--;
            UpdateLabel("Medicol Advance 400", PurchaseDiatabsQuantity * DiatabsPrice);
            PurchaseMinusDiatabs.Visible = PurchaseDiatabsQuantity > 0;
        }

        private void PurchaseAddNeozep_Click(object sender, EventArgs e)
        {
            PurchaseNeozepQuantity++;
            UpdateLabel("Neozep Forte", PurchaseNeozepQuantity * NeozepPrice);

            PurchaseMinusNeozep.Visible = true;
        }

        private void PurchaseMinusNeozep_Click(object sender, EventArgs e)
        {
            PurchaseNeozepQuantity--;
            UpdateLabel("Neozep Forte", PurchaseNeozepQuantity * NeozepPrice);
            PurchaseMinusNeozep.Visible = PurchaseNeozepQuantity > 0;
        }

        private void PurchaseAddAscorbic_Click(object sender, EventArgs e)
        {
            PurchaseAscorbicQuantity++;
            UpdateLabel("Fern-C", PurchaseAscorbicQuantity * AscorbicPrice);

            PurchaseMinusAscorbic.Visible = true;
        }

        private void PurchaseMinusAscorbic_Click(object sender, EventArgs e)
        {
            PurchaseAscorbicQuantity--;
            UpdateLabel("Fern-C", PurchaseAscorbicQuantity * AscorbicPrice);
            PurchaseMinusAscorbic.Visible = PurchaseAscorbicQuantity > 0;
        }

        private void PurchaseAddKremilS_Click(object sender, EventArgs e)
        {
            PurchaseKremilSQuantity++;
            UpdateLabel("KremilS", PurchaseKremilSQuantity * KremilSPrice);

            PurchaseMinusKremilS.Visible = true;
        }

        private void PurchaseMinusKremilS_Click(object sender, EventArgs e)
        {
            PurchaseKremilSQuantity--;
            UpdateLabel("KremilS", PurchaseKremilSQuantity * KremilSPrice);
            PurchaseMinusKremilS.Visible = PurchaseKremilSQuantity > 0;
        }

        private void PurchaseCartPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseCartText_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseTabPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
