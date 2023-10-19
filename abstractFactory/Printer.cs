using System;

namespace abstractFactory
{
    public class Printer
    {
        private static Printer instance;
        private static int serialNumber;

        private Printer(int num)
        {
            this.serialNumber = num;
        }

        public static Printer GetPrinter(int num)
        {
            if (instance == null)
            {
                instance = new Printer(num);
            }
            return instance;
        }

        public void GetSerialNumber()
        {
            Console.WriteLine(serialNumber);
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
            // Output: print out the string message
        }
    }
}