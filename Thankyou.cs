using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ThesisBeta
{
    public partial class Thankyou : Form
    {
        MotorControl motorControl = new MotorControl();
        public Thankyou()
        {
            InitializeComponent();


            for (int i = 0; i < Purchase.itemNames.Count; i++)
            {
                string itemName = Purchase.itemNames[i];
                int quantity = Purchase.quantities[i];

                switch (itemName)
                {
                    case "Ascof Forte":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor1);
                        break;
                    case "Biogesic":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor2);
                        break;
                    case "Bonamine":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor3);
                        break;
                    case "Cetirizine":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor4);
                        break;
                    case "Fern C":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor5);
                        break;
                    case "Imodium":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor6);
                        break;
                    case "Kremil S":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor7);
                        break;
                    case "Medicol Advance 400":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor8);
                        break;
                    case "Neozep Forte":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor9);
                        break;
                    case "Neozep Non-Drowsy":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor10);
                        break;
                    // Add cases for other items
                    default:
                        Console.WriteLine($"No motor activation found for item: {itemName}");
                        break;
                }
            }
        }
        private void ActivateMotorBasedOnQuantity(MotorControl motorControl, int quantity, Action activateMotor)
        {
            // Activate the motor based on the quantity
            for (int i = 0; i < quantity; i++)
            {
                activateMotor();
                Thread.Sleep(700);
            }
        }

        private void BacktoStartButton_Click(object sender, EventArgs e)
        {
            CartSummary cartSummary = new CartSummary();
            cartSummary.Close();
            Purchase purchase = new Purchase();
            purchase.Close();
            this.Close();
            StartScreen startScreen = new StartScreen();
            startScreen.Visible = true;

        }
    }
}