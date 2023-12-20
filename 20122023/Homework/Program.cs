using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 23, 25, 34, 56, 78 };

            int n = 10;
            int wantedIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    wantedIndex = i;
                    break;
                }
            }


            if (wantedIndex != -1)
            {
                Console.WriteLine($"Axtarilan eded {wantedIndex} index-de yerlesir");
            }
            else
            {
                Console.WriteLine("axtarilan eded tapilmadi");
            }
        }
    }
}
