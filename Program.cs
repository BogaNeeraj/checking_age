using System;

namespace checking_age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
            if(age>18)
            {
                Console.WriteLine("ALLOWED FOR VOTE");

            }
            else
            {
                Console.WriteLine("not allowed");

            }
        }
    }
}
