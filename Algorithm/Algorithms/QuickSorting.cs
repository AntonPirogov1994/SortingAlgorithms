using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class QuickSorting :Base
    {
        public QuickSorting(IEnumerable<int> items) : base(items) { }

        public QuickSorting() { }

        protected override void MakeSort()
        {
            Qsort(0, Items.Count - 1);
        }

        private void Qsort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var pivot = Sorting(left, right);
            Qsort(left, pivot - 1);
            Qsort(pivot + 1, right);
        }

        private int Sorting(int left, int right)
        {
            var pointer = left;
            
            for (int i = left; i <= right; i++)
            {
                if (Compare(Items[i], Items[right]) == -1)
                {
                    Swop(pointer, i);
                    pointer++;
                }
            }

            Swop(pointer, right);
            return pointer;
        }
    }
}
