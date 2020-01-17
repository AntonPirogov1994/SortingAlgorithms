using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms;

namespace sorting
{
    class Program
    {
        static void  row()
        {
            Console.WriteLine("__________________________________________________");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> Items = new List<int>();
            var count = 1000;

            Items.Clear();
            for (int i = 0; i < count; i++)
            {
                Items.Add(rnd.Next(0, 1000));
            }
            Console.WriteLine("Колличество элементов списка " + count);
            row();

            var bubble = new BubbleSorting();
            bubble.Items.AddRange(Items);
            Console.WriteLine("Bubble");
            var time = bubble.Sort();
            Console.WriteLine("Сортировка заняла времени = " + time.TotalSeconds + "c");
            Console.WriteLine("Колличество перестановок " + bubble.SwopCount);
            Console.WriteLine("Колличество сравнений " + bubble.ComparisonCount);
            row();

            var shell = new ShellSorting();
            shell.Items.AddRange(Items);
            Console.WriteLine("Shell");
            time = shell.Sort();
            Console.WriteLine("Сортировка заняла времени = " + time.TotalSeconds + "c");
            Console.WriteLine("Колличество перестановок " + shell.SwopCount);
            Console.WriteLine("Колличество сравнений " + shell.ComparisonCount);
            row();

            var quick = new QuickSorting();
            quick.Items.AddRange(Items);
            Console.WriteLine("Quick");
            time = quick.Sort();
            Console.WriteLine("Сортировка заняла времени = " + time.TotalSeconds + "c");
            Console.WriteLine("Колличество перестановок " + quick.SwopCount);
            Console.WriteLine("Колличество сравнений " + quick.ComparisonCount);
            row();
            

            Console.ReadLine();
        }
    }
}
