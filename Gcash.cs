using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;

namespace ThesisBeta
{
    public partial class Gcash : Form
    {
        public string GcashReceived;
        public Gcash()
        {
            InitializeComponent();
            if (GcashReceived != null)
            {
                GcashAmountReceived.Text = GcashReceived;
            }
            else
            {
                GcashAmountReceived.Text = "0.00";
            }
            GcashTotal.Text = Purchase.totalPrice.ToString();
            // Get the text from the textbox
            string text = GcashTotal.Text;

            // Generate QR code bitmap
            Bitmap qrCodeBitmap = GenerateQRCode(text);

            // Display QR code in a PictureBox
            GcashQRImage.Image = qrCodeBitmap;
            Console.WriteLine(text);
        }
        private void CartSummaryBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GcashProceed_Click(object sender, EventArgs e)
        {
            Thankyou thankyou = new Thankyou();
            thankyou.Show();
        }
        private Bitmap GenerateQRCode(string text)
        {
            // Set up the options for QR code generation
            EncodingOptions options = new EncodingOptions
            {
                Width = 288, // Adjust the width as needed
                Height = 288, // Adjust the height as needed
                Margin = 0
            };
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = options
            };
            // Generate QR code bitmap
            Bitmap qrCodeBitmap = writer.Write(text);
            return qrCodeBitmap;
        }
    }
}
