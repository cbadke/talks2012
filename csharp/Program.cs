using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    class Sort
    {
        public static IEnumerable<int> InsertionSort(IEnumerable<int> list)
        {
            var newList = new List<int>();

            foreach (var thing in list)
            {
                int i = 0;
                while (i < newList.Count() && thing >= newList[i])
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

            List<int> sorted = Sort.InsertionSort(list).ToList();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
