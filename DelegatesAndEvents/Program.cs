using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class Program
    {
        public delegate void mydelegate(string name);
        static void Main(string[] args)
        {
            Name obj = new Name();
            number nobj=new number();
            mydelegate delobj = new mydelegate (obj.Firstname);
            obj.Firstname("SaudAhmed");
            obj.Eventname += nobj.no;
            obj.Firstname("kadapa");
            obj.Eventname += nobj.no;
            


            Console.ReadLine();
            
        }

        public class Name
        {
            public event mydelegate Eventname;
            public void Firstname(string name)
            {
                Console.WriteLine("First Name ="+name +" ");
            }

            
        }
        public class number
        {
            public void no(string n)
            {
                Console.WriteLine("number= " + n);
            }

        }
    }
}
