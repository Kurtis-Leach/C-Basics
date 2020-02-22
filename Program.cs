using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLineHello();
            Apple GrannySmith = new Apple("Granny Smith", "Green");
            Apple Gala = new Apple("Gala");
            GrannySmith.info();
            Gala.info();
        }
        public static void WriteLineHello()
        {
            Console.WriteLine("Hello World!");
        } 
        class Apple
        {
            private string color;
            private string type;

            //Constructor Method
            public Apple(string t, string c)
            {
                type = t;
                color = c;
            }
            //Second Contructor Method Called Overloading Constructors
            public Apple(string t)
            {
                type = t;
                color = "Red";
            }
            public void info()
            {
                Console.WriteLine($"Type: {type}");
                Console.WriteLine($"Color: {color}");
            }
        }
    }
}
