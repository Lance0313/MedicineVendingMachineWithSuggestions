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
                    case "Advil":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor1);
                        break;
                    case "Neozep":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor2);
                        break;
                    case "Biogesic":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor3);
                        break;
                    case "Diatabs":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor4);
                        break;
                    case "Ascorbic":
                        ActivateMotorBasedOnQuantity(motorControl, quantity, motorControl.ActivateMotor5);
                        break;
                    // Add cases for other items
                    default:
                        Console.WriteLine($"No motor activation found for item: {itemName}");
                        break;
                }
            }
        }

        private void BacktoStartButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ActivateMotorBasedOnQuantity(MotorControl motorControl, int quantity, Action activateMotor)
        {
            // Activate the motor based on the quantity
            for (int i = 0; i < quantity; i++)
            {
                activateMotor();
            }
        }
    }
}

