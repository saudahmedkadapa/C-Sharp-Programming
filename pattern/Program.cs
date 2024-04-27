namespace pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,i,j;
            Console.WriteLine("Enter the  number");
            num=Convert.ToInt32(Console.ReadLine());
            for(i=0;i<num;i++)
            {
                for(j=0;j<i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}