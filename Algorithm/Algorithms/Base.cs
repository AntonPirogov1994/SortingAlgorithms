using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    public class Base
    {
        public int SwopCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;
        public List<int> Items { get; set; } = new List<int>();

        public Base(IEnumerable<int> items)
        {
            Items.AddRange(items);
        }

        public Base() { }

        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                SwopCount++;
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }

        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwopCount = 0;

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected virtual void MakeSort()
        {
            Items.Sort();
        }

        protected int Compare(int a, int b)
        {
            ComparisonCount++;
            return a.CompareTo(b);
        }
    }
}
