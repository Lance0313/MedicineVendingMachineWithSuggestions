using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using ZXing.Common;
using ZXing;
using Google.Apis.Sheets.v4.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Net;

namespace ThesisBeta
{
    public partial class EcashPayment : Form
    {
        public string LMMNReceived;
        private string[] Scopes = { SheetsService.Scope.Spreadsheets, SheetsService.Scope.SpreadsheetsReadonly };
        private string ApplicationName = "Google Sheets API .NET Quickstart";
        private SheetsService service;
        private Timer checkDataTimer;
        private string spreadsheetId = "17D32Vn3uJ8cSnFd9aRmngXL9TujQYvunL0rIbVwXIGA"; // Update with your spreadsheet ID
        public EcashPayment()
        {
            InitializeComponent();
            InitializeGoogleSheetsService();
            InitializeEventListeners();
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
            // Initialize and start the timer to check for data periodically
            checkDataTimer = new Timer();
            checkDataTimer.Interval = 5000; // 5000 milliseconds = 5 seconds
            checkDataTimer.Tick += CheckDataTimer_Tick;
            checkDataTimer.Start();
        }
        // Initialize Google Sheets service
        private void InitializeGoogleSheetsService()
        {
            GoogleCredential credential;
            using (var stream = new FileStream(@"C:\Users\marct\source\repos\MedicineVendingMachineWithSuggestions212\Files\epayment-420521-46b551fd114c.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }
            // Create Google Sheets API service
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
        private void InitializeEventListeners()
        {
            LMMNAmountReceived.TextChanged += LMMNAmountReceived_TextChanged;
        }
        // Timer tick event handler
        private void CheckDataTimer_Tick(object sender, EventArgs e)
        {
            // Check Google Sheets for updated data
            CheckGoogleSheetsForData();
            // Update UI
            UpdateUI();
        }
        // Update UI based on LMMNAmountReceived value
        private void UpdateUI()
        {
            if (decimal.TryParse(LMMNAmountReceived.Text, out decimal amountReceived))
            {
                EcashProceed.Enabled = amountReceived >= Purchase.totalPrice;
            }
            else
            {
                EcashProceed.Enabled = false;
            }
        }
        // Proceed to next form
        private void ProceedToNextForm()
        {
            // Clear the specific cell in column 1, row 2 of the spreadsheet
            ClearRow(spreadsheetId);
            // Show the "Thank you" message
            Thankyou thankyou = new Thankyou();
            thankyou.Show();
            // Close the current form
            this.Close();
        }
        // Check Google Sheets for data
        private void CheckGoogleSheetsForData()
        {
            string spreadsheetId = "17D32Vn3uJ8cSnFd9aRmngXL9TujQYvunL0rIbVwXIGA";
            string range = "Sheet1!A2:B";
            try
            {
                // Read values from the spreadsheet
                var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
                var response = request.Execute();
                var values = response.Values;
                // Process the retrieved data and set LMMNAmountReceived if needed
                foreach (var row in values)
                {
                    // Check if the first cell has a non-null value and is not equal to 0
                    if (row.Count > 0 && !string.IsNullOrEmpty(row[0].ToString()) && int.TryParse(row[0].ToString(), out int value) && value != 0)
                    {
                        LMMNReceived = row[0].ToString();
                        LMMNAmountReceived.Text = LMMNReceived;

                        return; // Exit the method after processing data
                    }
                }
                // If no data found, set LMMNAmountReceived text to "0.00"
                LMMNAmountReceived.Text = "0.00";
            }
            catch (Exception ex)
            {

            }
        }
        // Clear row in Google Sheets
        // Clear row in Google Sheets
        // Clear column 1, row 2 in Google Sheets
        private void ClearRow(string spreadsheetId)
        {
            // Clear the value in column 1, row 2
            List<IList<object>> values = new List<IList<object>>();
            values.Add(new List<object>() { "0" }); // Replace the value in column 1, row 2 with "0"
            // Create the update request
            var requestBody = new Google.Apis.Sheets.v4.Data.ValueRange
            {
                Values = values
            };
            // Execute the update request
            var updateRequest = service.Spreadsheets.Values.Update(requestBody, spreadsheetId, "Sheet1!A2:A");
            updateRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
            var updateResponse = updateRequest.Execute();
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
            UpdateUI();
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
            ProceedToNextForm();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
