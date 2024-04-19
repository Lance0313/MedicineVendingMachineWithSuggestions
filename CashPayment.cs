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
    public partial class CashPayment : Form
    {
        private SerialPort serialPort;
        public CashPayment()
        {
            InitializeComponent();
            InitializeSerialPort();
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
            TotalAmountValue.Text = "Php " +Purchase.totalPrice.ToString();
            CashPaymentProceed.Visible = true;
        }
        private void InitializeSerialPort()

        {
            serialPort = new SerialPort("COM4", 9600);
            serialPort.DataReceived += SerialPort_DataReceived; 
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();

            TotalInsertedAmount.Invoke((MethodInvoker)(() => TotalInsertedAmount.Text = data));
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalInsertedAmount_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TotalInsertedAmount.Text.Trim(), out int amountInserted))
            {
                if (Purchase.totalPrice <= amountInserted)
                {
                    CashPaymentProceed.Visible = true;
                }
                else
                {
                    CashPaymentProceed.Visible = false;
                }
            }
            else
            {
                CashPaymentProceed.Visible = false;
                Console.WriteLine("MAli");
            }
        }

        private void InitializeEventListeners(object sender, EventArgs e)
        {
            TotalInsertedAmount.TextChanged += TotalInsertedAmount_TextChanged;
        }

        private void CashPaymentProceed_Click(object sender, EventArgs e)
        {
            Thankyou thankyou = new Thankyou();
            thankyou.Show();
            this.Close();
        }
    }
}
