using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void OneThur255()
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);//prints 1-255 as i iterates
            }
        }
        public static void Odd1thr255()
        {
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 != 0)//conditional for odds
                {
                    Console.WriteLine(i);//prints odds 1-255 as i iterates
                }
            }
        }
        public static void Sum()
        {
            int sum = 0;
            for  (int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine("num :" + (int)i + "," + "sum :" + (int)sum);
            }
        }
        public static void IterateArray(int[] arr)//accepts int arr as parameter
        {
            for (int i = 0; i <= (arr.Length-1); i++)//iterates arr
            {
                Console.WriteLine(arr[i]);//logs idx val
            }
        }
        public static void FindMax(int[] arr)//declares func with int arr as parameter
        {
            int max = arr[0];//declares int max to be value of 0 idx
            for (int i = 0; i <= (arr.Length-1); i++)//iterates arr
            {
                if (arr[i] > max)//conditional check for max for each idx
                {
                    max = arr[i];//replaces max if condition is met
                }
            }
            Console.WriteLine(max);//prints final max outside of for loop
        }
        public static void GetAvg(int[] arr)
        {
            float sum = 0;
            for (int i = 0; i <= (arr.Length-1); i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum/arr.Length);
        }
        public static void OddArray()
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < 256; i++)
            {
                if (i % 2 != 0)
                {
                    newList.Add(i);
                }
            }
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
        public static void GreatThanY(int[] arr, int Y)
        {
            int count = 0;
            for (int i = 0; i <= (arr.Length-1); i++)
            {
                if (arr[i] > Y)
                {
                    count += 1;
                }
            }
            System.Console.WriteLine(count);
        }
        public static void SquareVals(int[] arr)
        {
            for (int i = 0; i <= (arr.Length-1); i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);        
            }
        }
        public static void RemoveNegs(int[] arr)
        {
            for (int i = 0; i <= (arr.Length-1); i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
        }
        public static void MinMaxAvg(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            float sum = 0;
            for (int i = 0; i <= (arr.Length-1); i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum += arr[i];
            }
            System.Console.WriteLine("min =" + min);
            System.Console.WriteLine("max =" + max);
            System.Console.WriteLine("avg =" + sum/arr.Length);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //OneThur255();//Calls func defined above
            //Odd1thr255();//Calls func defined above
            //Sum();
            int[] X = {1,3,30,7,9,13};//declares an integer arr called X
            //IterateArray(X);//calls the func defined with X as argument
            //FindMax(X);//calls the func defined with X as argument
            //GetAvg(X);
            //OddArray();
            //int Y = 1;
            //GreatThanY(X,Y);
            //SquareVals(X);
            //RemoveNegs(X);
            //MinMaxAvg(X);
        }
    }
}
