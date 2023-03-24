using System;
using System.Collections.Generic;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unordered list: ");
            List<int> list = new List<int>(100);
            for (int i = 0; i < 100; i++)
            {
                list.Add(Utils.random.Next());
                Console.WriteLine(list[i]);
            }

            list = Sort(list);
            Console.WriteLine("Ordered list: ");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static public List<int> Sort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++) 
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] <= list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;

                        //(list[i], list[j]) = (list[j], list[i]);
                    }
                }
            }
            return list;
        }
    }
}
