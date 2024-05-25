namespace InheritanceMultiple
{
    internal class Program
    {
        class Chairman
        {
           public void work()
            {
                Console.WriteLine("Chairman");
            }
        }
        class teacher:Chairman
        {
            public void work()
            {
                Console.WriteLine("Teacher");
            }
        }
        class asstTeacher:Chairman
        {
           public void work()
            {
                Console.WriteLine("Asst Teacher");
            }

        }
   
        static void Main(string[] args)
        {
            asstTeacher obj = new asstTeacher();
            obj.work();
            Console.ReadLine();

            
        }

       
    }
}