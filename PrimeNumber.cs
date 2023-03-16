using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void FindPrimeNumber()
        {
            Console.WriteLine("Please Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());

            for (int i=2; i<(num/2); i++) 
            {
                int ans = num % i;
                if (ans == 0)
                {
                    Console.WriteLine("The {0} is not a prime number" ,num);
                }
                else 
                {
                    Console.WriteLine("The {0} is a prime number", num);
                }

            }
        }
    }
}
