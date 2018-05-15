using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Printreceipt();    
        }

        private static void Printreceipt()
        {
            PrintReceiptHeader();
            PrintReciptBody();
            PrintReceiptFooter();
        }

        private static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        private static void PrintReciptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
            Console.WriteLine("------------------------------");
        }

        private static void PrintReceiptFooter()
        {
            string c = "\u00A9";
            Console.WriteLine("{0} SoftUni",c);
        }
    }
}
