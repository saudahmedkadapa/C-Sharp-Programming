namespace CheckLeapYearOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year =");
            year =Convert.ToInt32(Console.ReadLine());
            if(year %4==0)
            {
                Console.WriteLine("{0} is leap year ",year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
        }
    }
}