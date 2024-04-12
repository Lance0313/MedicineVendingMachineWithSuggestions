using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisBeta
{
    public class MotorControl
    {
        SerialPort serialPort;

        public void ActivateMotor1()
        {
            Console.WriteLine("A");
            serialPort = new SerialPort("COM4", 9600); // Change COM port and baud rate as needed
            try
            {
                serialPort.Open(); // Open the serial port
                serialPort.WriteLine("A");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }

        public void ActivateMotor2()
        {
            Console.WriteLine("B");
            serialPort = new SerialPort("COM4", 9600); // Change COM port and baud rate as needed
            try
            {
                serialPort.Open(); // Open the serial port
                serialPort.WriteLine("B");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }
        public void ActivateMotor3()
        {
            Console.WriteLine("C");
            serialPort = new SerialPort("COM4", 9600); // Change COM port and baud rate as needed
            try
            {
                serialPort.Open(); // Open the serial port
                serialPort.WriteLine("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }

        public void ActivateMotor4()
        {
            Console.WriteLine("D");
            serialPort = new SerialPort("COM4", 9600); // Change COM port and baud rate as needed
            try
            {
                serialPort.Open(); // Open the serial port
                serialPort.WriteLine("D");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }
        public void ActivateMotor5()
        {
            Console.WriteLine("E");
            serialPort = new SerialPort("COM4", 9600); // Change COM port and baud rate as needed
            try
            {
                serialPort.Open(); // Open the serial port
                serialPort.WriteLine("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }

        public void ActivateMotor6()
        {
            Console.WriteLine("F");
        }
        public void ActivateMotor7()
        {
            Console.WriteLine("G");
        }

        public void ActivateMotor8()
        {
            Console.WriteLine("H");
        }
        public void ActivateMotor9()
        {
            Console.WriteLine("I");
        }

        public void ActivateMotor10()
        {
            Console.WriteLine("J");
        }
    }
}
