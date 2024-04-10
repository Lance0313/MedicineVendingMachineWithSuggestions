using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisBeta
{
    public class MotorControl
    {
        private SerialPort serialPort;
        public void ActivateMotor1()
        {
            Console.WriteLine("A");
        }

        public void ActivateMotor2()
        {
            Console.WriteLine("B");
        }
        public void ActivateMotor3()
        {
            Console.WriteLine("C");
        }

        public void ActivateMotor4()
        {
            Console.WriteLine("D");
        }
        public void ActivateMotor5()
        {
            Console.WriteLine("E");
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
            serialPort.WriteLine("H");
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
