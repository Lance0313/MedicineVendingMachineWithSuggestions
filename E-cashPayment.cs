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
using System.Net;

namespace ThesisBeta
{
    public partial class EcashPayment : Form
    {
        public string LMMNReceived;
        public EcashPayment()
        {
            InitializeComponent();
            if (LMMNReceived != null)
            {
                LMMNAmountReceived.Text = LMMNReceived;
            }
            else
            {
                LMMNAmountReceived.Text = "0.00";
            }
            LMMNTotal.Text = Purchase.totalPrice.ToString();
            string text = LMMNTotal.Text;
            Bitmap qrCodeBitmap = GenerateQRCode(text);
            LMMNQRImage.Image = qrCodeBitmap;
        }

        //Start of E-payment QR Code Generation
        private Bitmap GenerateQRCode(string text)
        {
            //Set up the size
            EncodingOptions options = new EncodingOptions
            {
                Width = 288,
                Height = 288,
                Margin = 0
            };
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = options
            };
            //Generate QR
            Bitmap qrCodeBitmap = writer.Write(text);
            return qrCodeBitmap;
        }
        //End of E-payment QR Code Generation

        private void LMMNAmountReceived_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LMMNAmountReceived.Text.Trim(), out int amountInserted))
            {
                if (Purchase.totalPrice <= amountInserted)
                {
                    EcashProceed.Visible = true;
                }
                else
                {
                    EcashProceed.Visible = false;
                }
            }
            else
            {
                EcashProceed.Visible = false;
            }
        }
        private void InitializeEventListeners(object sender, EventArgs e)
        {
            LMMNAmountReceived.TextChanged += LMMNAmountReceived_TextChanged;
        }

        private void EcashProceed_Click(object sender, EventArgs e)
        {
            Thankyou thankyou = new Thankyou();
            thankyou.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
