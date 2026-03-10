using System;

class Program
{

        private bool isRunning = true;
        public void Run()
        {
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listening");
                Console.WriteLine("4. Quit");
                Console.Write("Select a choice from the menu: ");

                string input = Console.ReadLine();
                if (input == "1") 
                {
                    Breathing b1 = new Breathing();
                    Console.Clear();
                    b1.RunBreath();
                }
                else if(input == "2") 
                {
                    Reflection f1= new Reflection();
                    Console.Clear();
                    f1.RunReflect();
                }
                else if (input == "3") 
                {
                    Listening l1 = new Listening();
                    Console.Clear();
                    l1.RunListen();
                }
                else if (input == "4") isRunning = false;
                else Console.WriteLine("Please select a valid option from the menu.");
            }

        }
        static void Main() 
        {
            Program p = new Program();
            p.Run();
        }
}
