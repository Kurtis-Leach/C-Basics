using System;
using System.Collections.Generic;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteLineHello();

            // Apple GrannySmith = new Apple("Granny Smith", "Green");
            // Apple Gala = new Apple("Gala");
            // GrannySmith.info();
            // Gala.info();

            // List<string> fruits = new List<string>();
            // fruits.Add("Banana");
            // fruits.Add("Apple");
            // fruits.Add("Orange");
            // forEachItem(fruits);
            // fruits.Remove("Banana");
            // forEachItem(fruits);

            // Queue<int> numbersQue = new Queue<int>();
            // numbersQue.Enqueue(1);
            // numbersQue.Enqueue(5);
            // numbersQue.Enqueue(10);
            // numbersQue.Enqueue(15);
            // numbersQue.Enqueue(20);
            // numbersQue.Dequeue();
            // foreach (int i in numbersQue)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine(numbersQue.Contains(10));
            // int[] numbersArr = new int[numbersQue.Count];
            // numbersQue.CopyTo(numbersArr, 0);
            // foreach (int i in numbersArr)
            // {
            //     Console.WriteLine(i);
            // }

            // Stack<int> numberStk = new Stack<int>();
            // numberStk.Push(1);
            // numberStk.Push(5);
            // numberStk.Push(10);
            // numberStk.Push(15);
            // numberStk.Push(20);
            // numberStk.Peek();
            // foreach (int i in numberStk)
            // {
            //     Console.WriteLine(i);
            // }

            // LinkedList<string> names = new LinkedList<string>();
            // names.AddLast("Kurtis");
            // names.AddFirst("Brianna");
            // names.AddFirst("Todd");
            // names.AddLast("Shae");
            // LinkedListNode<string> brianna = names.Find("Brianna");
            // names.AddBefore(brianna, "Garrett");
            // foreach (var name in names)
            // {
            //     Console.WriteLine(name);
            // }

            int[] randomNumbers = randomNumberGenerator(100);
            Console.WriteLine(Environment.NewLine + "Unsorted: " + Environment.NewLine);
            foreach (int num in randomNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Press Enter");
            Console.ReadLine();
            quickSort(randomNumbers, 0, randomNumbers.Length - 1);
            Console.WriteLine(Environment.NewLine + "Sorted: " + Environment.NewLine);
            foreach (int num in randomNumbers)
            {
                Console.Write($"{num} ");
            }
        }

        private static int[] randomNumberGenerator(int lengthOfArr)
        {
            int[] randomNumbers = new int[lengthOfArr];
            byte i = 0;
            Random random = new Random();
            bool addToArr = true;
            while (i < lengthOfArr)
            {
                int randomNumber = random.Next(1,lengthOfArr + 1);
                addToArr = true;
                for (int j = 0; j < i; j++)
                {
                    if (randomNumbers[j] == randomNumber)
                    {
                        addToArr = false;
                        break;
                    }
                }
                if (addToArr)
                {
                    randomNumbers[i] = randomNumber;
                    i++;
                }
            }
            return randomNumbers;
        }
        
        public static void quickSort(int[] randomNumbers, int leftNum, int rightNum)
        {
            int l = leftNum;
            int r = rightNum;
            int pivot = randomNumbers[(l + r) / 2];

            while (l <= r)
            {
                while (randomNumbers[l] < pivot)
                {
                    l++;
                }
                while (pivot < randomNumbers[r])
                {
                    r--;
                }
                if (l <= r)
                {
                    int temp = randomNumbers[l];
                    randomNumbers[l] = randomNumbers[r];
                    randomNumbers[r] = temp;
                    l++;
                    r--;
                }
                if ( leftNum < r)
                {
                    quickSort(randomNumbers, leftNum, r);
                }
                if (l < rightNum)
                {
                    quickSort(randomNumbers, l, rightNum);
                }
            }
        }

        // public static void forEachItem(List<string> list){
        //     foreach (string item in list)
        //     {
        //         Console.Write(item + " ");
        //     }
        //     Console.WriteLine();
        // }
        // public static void WriteLineHello()
        // {
        //     Console.WriteLine("Hello World!");
        // } 
        // class Apple
        // {
        //     private string color;
        //     private string type;

        //     //Constructor Method
        //     public Apple(string t, string c)
        //     {
        //         type = t;
        //         color = c;
        //     }
        //     //Second Contructor Method Called Overloading Constructors
        //     public Apple(string t)
        //     {
        //         type = t;
        //         color = "Red";
        //     }
        //     public void info()
        //     {
        //         Console.WriteLine($"Type: {type}");
        //         Console.WriteLine($"Color: {color}");
        //     }
        // }
    }
}
