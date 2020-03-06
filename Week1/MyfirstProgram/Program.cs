using System;

namespace repos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your given name?");

            string name = Console.ReadLine();

            Console.WriteLine("What is your surname name?");

            string surname = Console.ReadLine();
            
            Console.WriteLine("What is your studentID?");

            int studentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("When is your year of birth?");

            int year = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("What is the current year?");

             int Cyear = Convert.ToInt32(Console.ReadLine());

            
            string message = "OH so your full name is " + name + " " + surname + 
            ", and your studentID is " + studentID + " and your year of birth is " + year + 
            " and the current year is " + Cyear + " and your current age is ";

            Console.WriteLine(message +((Cyear - year)));
            
            Console.ReadKey();
        }
    }
}
