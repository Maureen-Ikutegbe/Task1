using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            string gender;
            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();
            if (name.ToLower() == "ali") 
            {
                Console.WriteLine("Hello " + name + ", welcome.");
            }
            if (name == "Bob")
            {
                Console.WriteLine("Hello " + name + ", welcome.");
            }
            Console.WriteLine("What is your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are a minor!");
            }
            else
            { 
                    Console.WriteLine("You can drink if you would like to!");
            }
            Console.WriteLine("What is your gender: ");
            gender = Console.ReadLine();


        }
    }
}
