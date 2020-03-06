using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string StaticUserName = ("YeetusDeletus");
            const string StaticPassword = ("asdfghjkl");


        Console.WriteLine("Enter username:");
        string UserName = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string Password = Console.ReadLine();


        if (UserName == StaticUserName)
        {
            if (Password == StaticPassword)
            {
          Console.WriteLine("Login Successful");

            }
            else
            {
         Console.WriteLine("Login Unsuccessful");
            }
        }
        else
        {
            Console.WriteLine("Login Unsuccessful");   
        }
        }
    }
}


        
