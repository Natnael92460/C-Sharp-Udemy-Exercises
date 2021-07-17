using System;

namespace C_Sharp_Udemy_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            E1("Enter a Word"); // parsser
            E2(); //ways of printing 
            E3();
           
        }

        /**
       * Parssing
       */
        static void E3()
        {
            
        }
        /**
        * ways of printing 
        */
        static void E2()
        {
            String myString_1 = "15";//if coverting to int String can't be in a Double style - casting is not helping
            String myString_2 = "16.15";//if coverting to int String can't be in a Double style - casting is not helping
            int num1 = Int32.Parse(myString_1); //converts String to int
            double num2 = Double.Parse(myString_2); //converts String to double
            Console.WriteLine($"E2 : Int = {num1} Double {num2}"); //String interpolation 
            Console.WriteLine("E2 : Int = {1} Double {0}",num1,num2); //Sting formating uses indexes
            Console.WriteLine("E2 : Int = " + num1 + " Double = " + num2); //String concatenation

            //verbatim String 
            //usefull when you want to ignore \ , \n .....  
            // if we dont add @ it will think we want to escpe something by using \ and will be unvalid resulting in error
            // for new line just press enter, we cant use \n
            Console.WriteLine(@"C: \user\admin\dog pictures\super.png"); 
        }

        /**
         * @param Print holdes value to be printed
        * changes color of background and the output
         */
        static void E1(String Print)
        {
            Console.ForegroundColor = ConsoleColor.Red; //changes The Color of the output
            Console.BackgroundColor = ConsoleColor.Gray; //changes the Background colore of the output
            Console.Clear(); //it makes all the Background Color are the same ....
           
            Console.WriteLine(Print);
            string readLine = Console.ReadLine();
            Console.WriteLine("E1 : Hello World! {0}", readLine);
            Console.Beep(); //makes a beep sound
        }
    }
}
