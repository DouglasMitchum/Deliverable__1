using System;
namespace Deliverable__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 1 and 100: ");
            try
            {
                int input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <=100)
                {
                    Console.WriteLine("Specify the series type: Even or Odd");
                    string series = Console.ReadLine();

                    if (series == "Odd")
                    {
                        Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                        for (int i = 1; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    if (series == "Even")
                    {
                        Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                        for (int i = 0; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Your Integer is out of range");
                }
                Console.WriteLine("Type any key to exit");
                
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
            
           
        }
    }
}