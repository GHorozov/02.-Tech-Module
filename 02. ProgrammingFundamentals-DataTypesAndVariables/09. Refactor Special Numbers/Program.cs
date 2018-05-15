using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool IsSpecial = false;
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int digit = i;
                while (digit > 0)
                {  
                    sum +=(digit % 10);
                    digit = digit / 10;
                }
               
                IsSpecial = (sum == 5 || sum == 7 || sum == 11);
                if (IsSpecial==true )
                {                 
                    Console.WriteLine("{0} -> {1}", i, IsSpecial);
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", i,IsSpecial);
                }
                         
            }

        }
    }
}
