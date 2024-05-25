using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEx
{
    internal class Program
    {
       public delegate int CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {
            CalculateDelegate del = Add;
            myclass.Execute(del);
            CalculateDelegate del2 = subtract;
            myclass.Execute(del2);
            Console.ReadLine();


        }
        public static int Add(int x, int y)
        {
            return x + y;

        }
        public static int subtract(int x, int y)
        {
            return x - y;
        }
        class myclass
        {
            public static void Execute(CalculateDelegate del)
            {
                Console.WriteLine(del(5, 4));
            }
        }
       
       

        }
    }


