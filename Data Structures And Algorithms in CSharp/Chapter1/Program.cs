using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    using System.Collections;

    class Program
    {
        // Pg 14 
        //static void Main(string[] args)
        //{
        //    Collection names = new Collection();
        //    names.Add("David");
        //    names.Add("Bernica");
        //    names.Add("Raymond");
        //    names.Add("Clayton");

        //    foreach (Object name in names)
        //    {
        //        Console.WriteLine(name);
        //    }

        //    Console.WriteLine("Number of names: " + names.Count());
        //    names.Remove("Raymond");
        //    Console.WriteLine("Number of names: " + names.Count());
        //    names.Clear();
        //    Console.WriteLine("Number of names: " + names.Count());
        //    Console.ReadKey();
        //}

        // Pg 15
        //    static void Main(string[] args)
        //    {
        //        int num1 = 100;
        //        int num2 = 200;
        //        Console.WriteLine("num1: " + num1);
        //        Console.WriteLine("num2: " + num2);
        //        Swap<int>(ref num1, ref num2);
        //        Console.WriteLine("num1: " + num1);
        //        Console.WriteLine("num2: " + num2);
        //        string str1 = "Sam";
        //        string str2 = "Tom";
        //        Console.WriteLine("String 1: " + str1);
        //        Console.WriteLine("String 2: " + str2);
        //        Swap<string>(ref str1, ref str2);
        //        Console.WriteLine("String 1: " + str1);
        //        Console.WriteLine("String 2: " + str2);
        //        Console.ReadKey();
        //    }

        //    static void Swap<T>(ref T val1, ref T val2)
        //    {
        //        T temp;
        //        temp = val1;
        //        val1 = val2;
        //        val2 = temp;
        //    }
        //}

        // Pg 15
        //static void Main(string[] args)
        //{
        //    int[] nums = new int[100000];
        //    BuildArray(nums);
        //    Stopwatch sw = new Stopwatch();
        //    sw.Start();
        //    DisplayNums(nums);
        //    sw.Stop();
        //    Console.WriteLine();
        //    Console.WriteLine("Time: " + sw.Elapsed.ToString());
        //    Console.ReadKey();
        //}

        //static void BuildArray(int[] arr)
        //{
        //    for (int i = 0; i < 100000; i++)
        //        arr[i] = i;
        //}

        //static void DisplayNums(int[] arr)
        //{
        //    for (int i = 0; i < 100000; i++)
        //        Console.WriteLine(arr[i] + " ");
        //}

        // Exercise 3.
        static void Main(string[] args)
        {
            // Init # of ints.
            const int numInts = 1000000;

            // Test #1.
            var sw1 = new Stopwatch();
            sw1.Start();
            var arr = new ArrayList();
            for (int n = 0; n < numInts; n++)
                arr.Add(n);
            sw1.Stop();

            // Test #1.
            var sw2 = new Stopwatch();
            sw2.Start();
            var arr2 = new Collection();
            for (int n = 0; n < numInts; n++)
                arr2.Add(n);
            sw2.Stop();

            // Report.
            Console.WriteLine();
            Console.WriteLine("Test #1 (ArrayList) Time: " + sw1.Elapsed);
            Console.WriteLine("Test #2 (Collection) Time: " + sw2.Elapsed);

            if (sw1.Elapsed > sw2.Elapsed)
                Console.WriteLine("Test #1 (ArrayList) took {0} longer.", sw1.Elapsed - sw2.Elapsed);
            else
                Console.WriteLine("Test #2 (Collection) took {0} longer.", sw2.Elapsed - sw1.Elapsed);

            Console.ReadKey();

            //    int[] nums = new int[100000];
            //    BuildArray(nums);
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();
            //    DisplayNums(nums);
            //    sw.Stop();
            //    Console.WriteLine();
            //    Console.WriteLine("Time: " + sw.Elapsed.ToString());
            //    Console.ReadKey();
        }
    }
}