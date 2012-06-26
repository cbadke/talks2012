using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    class Sort
    {
        public static IEnumerable<int> InsertionSort(IEnumerable<int> list, Func<int,int,bool> isRightOf )
        {
            var newList = new List<int>();

            foreach (var thing in list)
            {
                int i = 0;
                while (i < newList.Count() && isRightOf(thing, newList[i]))
                {
                    ++i;
                }
                newList.Insert(i, thing);
            }

            return newList;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {4, 3, 1, 2};

            Func<int,int,bool> isRightOf = (a, b) =>
                {
                    return a >= b;
                };

            List<int> sorted = Sort.InsertionSort(list, isRightOf).ToList();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
