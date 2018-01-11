using System;




class Program
{
    static void Main(string[] args)
    {
        //This writes the menu to the user
        Console.WriteLine("1: Start Calculator\n2: About \n3: Quit");

        Console.Write("\nUser Input:");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            GameCalculator.StartCalculator();
        }
        else if (userInput == "2")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hey I'm Hannes, I made this");
            Console.WriteLine("Brap Brap");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        else if (userInput == "3")
        {
            Console.Write("Quiting after 3 seconds");
            System.Threading.Thread.Sleep(3000); //Pause the thread for 3 secounds, written in miliseconds
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR NO MENU ITEM");

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            System.Threading.Thread.Sleep(3000); //Pause the thread for 3 secounds, written in miliseconds
        }
    }//End of void Main
}//End of class Program
