namespace ListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Integer value-----");

            List<int>obj=new List<int>();
            obj.Add(1);
            obj.Add(3);
            obj.Add(4);
            obj.Add(5);
            foreach(int i in obj)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----String value -----");
            List<string> list = new List<string>();
            list.Add("Saud");
            list.Add("AHmed");
            list.Add("India");
            list.Add("Cricket");
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----Float value-----");
            List<float>ff=new List<float>();
            ff.Add(1.0f);
            ff.Add(5.5f);
            ff.Add(7.5f);
            ff.Add(6.66f);
            ff.Add(7.77f);
            foreach(float f in ff)
            {
                Console.WriteLine(f);
            }




            Console.ReadLine();


        }
    }
}