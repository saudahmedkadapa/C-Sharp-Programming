using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sauddbEntities dbobj = new sauddbEntities();
            //var allcust=dbobj.Customers.ToList();
            //foreach(var cust in allcust)
            //{
            //    Console.WriteLine(cust.CName);
            //}
            //var instcust=dbobj.Customers.ToList();
            //dbobj.Customers.Add(
            //    new Customer() { CNo = 25, CName = "Hritik" });
            //dbobj.SaveChanges();
            //foreach(var cust in instcust)
            //{
            //    Console.WriteLine(cust.CName+"|"+cust.CNo);
            //}
            var updatecust =( from Customer in dbobj.Customers.ToList()
                             where Customer.CNo==3
                             select Customer).First();
            updatecust.CName = "amitabh";
            dbobj.SaveChanges();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
