using System;

namespace TestModule
{
    public class ArrayMan
    {
        public static int FindMax(int[] a) {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }
    }
}
