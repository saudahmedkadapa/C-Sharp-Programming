using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOPSInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColdDrink obj = new ColdDrink();
            Console.WriteLine(obj.GetDrink());
            Console.ReadLine();
        }
        public interface IDrink
        {
            string  GetDrink();   
        }
        public class ColdDrink:IDrink {
            public string GetDrink()
            {
                return "Coke";
            }
        }
        public class HotDrink:IDrink
        {
            public string GetDrink()
            {
                return "Coffee";
            }
        }
        public class Mocktails:IDrink
        {
            public string GetDrink()
            {
                return "Mojito";
            }
        }
        
    }
}
