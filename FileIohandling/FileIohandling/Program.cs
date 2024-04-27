using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIohandling

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger log = Logger.GetObj();

            FileStream fs;
            string path = @"D:\c# assign\demo.txt";
            if (File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                Console.WriteLine(log.getLogger("same file"));
            }
            else
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);   //file creation
                Console.WriteLine(log.getLogger("text file generated"));
            }
            StreamWriter wr = new StreamWriter(fs); //text editer is created to implement the text

            Console.WriteLine("Write content here :");

            wr.WriteLine(Console.ReadLine() + "    ---> " + log.getLogger("active FileLogger") + " " + DateTime.Now.ToString());

            wr.Close();
            fs.Close();
            Console.WriteLine("Done");

            Console.ReadLine();
        }
        class Logger    //singleton
        {
            static Logger log = new Logger();   //obj creation

            private Logger() { }    //no other can be created

            public static Logger GetObj()
            {
                return log;
            }
            public string getLogger(string mes)
            {
                return mes;
            }
        }
    }
}