using System;

namespace C_Sharp_Udemy_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("Hi Ruhann Hello World!");
            string readLine = Console.ReadLine();
            Console.Clear(); //
            Console.WriteLine("Hello World! {0}", readLine);
            Console.Beep();
        }
        /// <summary>
        /// this is cool Method haha :)
        /// </summary>
        static void coolMethod()
        {

        }
    }
}
