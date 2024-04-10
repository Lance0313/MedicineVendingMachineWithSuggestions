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
    public partial class Thankyou : Form
    {
        MotorControl motorControl = new MotorControl();
        public Thankyou()
        {
            InitializeComponent();
            
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
