using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummOfRandoms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);
            int summ = 0;
            int multiplicity1 = 5;
            int multiplicity2 = 3;

            for (int i = number; i > 0; i--) 
            {
                if (i % multiplicity1 == 0 || i % multiplicity2 == 0) 
                {
                    summ = summ + i;
                }
            }
                    Console.WriteLine(summ); 
        }
    }
}
