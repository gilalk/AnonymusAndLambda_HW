using System;

namespace AnonymusMethods_Lesson12
{

    public delegate void MyDelegate();

    public delegate void Greet(string str);

    public delegate void CalcDelegate(int x, int y);

    class Program
    {

        #region Q1

        static MyDelegate myDelegate = delegate ()
        {
            Console.WriteLine("Shalom");
        };

        static MyDelegate myDelegate1 = delegate ()
        {
            Console.WriteLine("Another function called with same delegate");
        };

        static MyDelegate myDelegate2 = () => { Console.WriteLine("Shalom"); };
        static MyDelegate myDelegate3 = () => { Console.WriteLine("Another function called with same delegate"); };

        #endregion

        #region Q2

        // Anonymus
        static Greet greet = delegate (string str)
        {
            Console.WriteLine("Shalom {0}", str);
        };

        static Greet greet1 = delegate (string str)
        {
            Console.WriteLine("welcome {0}", str);
        };

        // Lambda

        static Greet greet2 = (string name) => { Console.WriteLine($"Shalom {name}"); };
        static Greet greet3 = (string name) => { Console.WriteLine($"Welcome {name}"); };

        #endregion

        #region Q4

        //Anonymus

        static CalcDelegate AddDelegate = delegate (int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        };

        static CalcDelegate SubDelegate = delegate (int x, int y)
        {
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        };

        // Lambda 

        static CalcDelegate calcAddLambda = (int x, int y) => { Console.WriteLine($"{x} + {y} = {x + y}"); };
        static CalcDelegate calcSubLambda = (int x, int y) => { Console.WriteLine($"{x} + {y} = {x - y}"); };

        #endregion



        static void Main(string[] args)
        {
            // Calling question 1

            myDelegate();
            myDelegate1();

            // Calling question 2

            greet("Gil");
            greet1("Gil");

            // Calling question 4

            AddDelegate(32, 43);
            SubDelegate(32, 43);


        }
    }
}
