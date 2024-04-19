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
        //Open Serial Port
        public void OpenSerial()
        {
            serialPort = new SerialPort("COM8", 9600);
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }
        //Close Serial port
        public void CloseSerial()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close(); 
                serialPort.Dispose();  
            }
        }

        public void ActivateMotor1()
        {
            Console.WriteLine("A");
            OpenSerial();
            serialPort.WriteLine("A");
            CloseSerial();

        }

        public void ActivateMotor2()
        {
            Console.WriteLine("B");
            OpenSerial();
            serialPort.WriteLine("B");
            CloseSerial();

        }
        public void ActivateMotor3()
        {
            Console.WriteLine("C");
            OpenSerial();
            serialPort.WriteLine("C");
            CloseSerial();
        }

        public void ActivateMotor4()
        {
            Console.WriteLine("D");
            OpenSerial();
            serialPort.WriteLine("D");
            CloseSerial();
        }
        public void ActivateMotor5()
        {
            Console.WriteLine("E");
            OpenSerial();
            serialPort.WriteLine("E");
            CloseSerial();
        }

        public void ActivateMotor6()
        {
            Console.WriteLine("F");
            OpenSerial();
            serialPort.WriteLine("F");
            CloseSerial();
        }
        public void ActivateMotor7()
        {
            Console.WriteLine("G");
            OpenSerial();
            serialPort.WriteLine("G");
            CloseSerial();
        }

        public void ActivateMotor8()
        {
            Console.WriteLine("H");
            OpenSerial();
            serialPort.WriteLine("H");
            CloseSerial();
        }
        public void ActivateMotor9()
        {
            Console.WriteLine("I");
            OpenSerial();
            serialPort.WriteLine("I");
            CloseSerial();
        }

        public void ActivateMotor10()
        {
            Console.WriteLine("J");
            OpenSerial();
            serialPort.WriteLine("J");
            CloseSerial();
        }
    }
}
