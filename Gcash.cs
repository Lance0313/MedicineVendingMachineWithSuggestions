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
    public partial class Gcash : Form
    {
        public string GcashReceived;
        public Gcash()
        {
            InitializeComponent();
            //Gcash Generate QR Code
            if (GcashReceived != null)
            {
                GcashAmountReceived.Text = GcashReceived;
            }
            else
            {
                GcashAmountReceived.Text = "0.00";
            }
            GcashTotal.Text = Purchase.totalPrice.ToString();
            string text = GcashTotal.Text;
            Bitmap qrCodeBitmap = GenerateQRCode(text);
            GcashQRImage.Image = qrCodeBitmap;
            //Communicate to MIT
            //StartListening();
        }
        //Communication ti MIT App
        private void StartListening()
        {
            // Set up a local server to listen for incoming HTTP requests
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/"); // Adjust the port number if needed
            listener.Start();

            // Start listening for incoming requests
            while (true)
            {
                try
                {
                    // Wait for a request to come in
                    HttpListenerContext context = listener.GetContext();
                    // Process the request
                    string requestText;
                    using (System.IO.Stream body = context.Request.InputStream)
                    {
                        using (System.IO.StreamReader reader = new System.IO.StreamReader(body, context.Request.ContentEncoding))
                        {
                            requestText = reader.ReadToEnd();
                        }   
                    }

                    // Handle the request data
                    MessageBox.Show("Received from MIT App Inventor: " + requestText);

                    // Send a response back to the MIT App Inventor app if needed
                    string responseText = "Response from WinForms application";
                    byte[] buffer = Encoding.UTF8.GetBytes(responseText);
                    context.Response.ContentLength64 = buffer.Length;
                    context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                    context.Response.OutputStream.Close();
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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
    }
}
