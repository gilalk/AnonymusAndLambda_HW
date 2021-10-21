using System;

namespace Delegate_HW_Lesson8
{
    // Q1 myFirstDelegate

    public delegate void MyFirstDelegate(); // Declaration

    //*******************************************************

    // Q2 Greet delegate

    public delegate void Greet(string str);


    class Program
    {
        #region func for Q1

        public static void SayShalom()
        {
            Console.WriteLine("Shalom!");
        }

        public static void Print2()
        {
            Console.WriteLine("Another function called with same delegate");
        }

        // Another way to create Instantiation

        static MyFirstDelegate myFirstDelegate1 = Print2;

        #endregion

        #region func for Q2

        public static void SaySHalomTo(string name)
        {
            Console.WriteLine("Shalom {0}", name);
        }

        public static void SayWelcomeTo(string name)
        {
            Console.WriteLine("Welcome {0}", name);
        }

        static Greet greet = SaySHalomTo;

        #endregion


        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            #region Q1 Answers

            Console.WriteLine("\n **************** Q1 ****************\n");

            MyFirstDelegate myFirstDelegate = new MyFirstDelegate(SayShalom); // Instantiation
            myFirstDelegate(); // Invocation

            myFirstDelegate1(); // Instantiation created outside the Main

            myFirstDelegate += Print2; // Combining attempts
            myFirstDelegate -= Print2;
            myFirstDelegate();

            #endregion

            #region Q2 Answers

            Console.WriteLine("\n **************** Q2 ****************\n");

            greet("Gil");

            Greet greet1 = new Greet(SayWelcomeTo);
            greet1("Gil");

            greet += SayWelcomeTo;
            greet("Gil");

            greet1 += SaySHalomTo;
            greet1("Gil");

            #endregion

            #region Q3 Answers

            Console.WriteLine("\n **************** Q3 ****************\n");

            Console.WriteLine("The Greet delegate won't work with 'Print2' because Greet gets arguments and the function doesn't");

            #endregion

        }
    }
}
