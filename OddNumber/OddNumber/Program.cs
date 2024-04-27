using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the  number =");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Odd number =");
            for(int i=0;i<=num;i++)
            {
                if(i%2==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
