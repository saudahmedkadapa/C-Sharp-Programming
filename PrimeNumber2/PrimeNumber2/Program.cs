using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number=");
            num = Convert.ToInt32(Console.ReadLine());
            //if (num == 0|| num==1) {
            //    Console.WriteLine("NOt a prime number!!");
            //}
            for (int i=2;i<=num;i++)
            {
                if (num % i == 0)
                {
                    break;
                }
            }

            if(num==0||num==1)
            {
                Console.WriteLine("IS prime number");
            }
            else
            {
                Console.WriteLine("Is not a prime  number");
            }


            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
