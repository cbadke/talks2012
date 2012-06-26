using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Product
    {
        public string Name;
        public int Price;

        public override string ToString()
        {
            return String.Format("Product: {0}, Price: {1}", Name, Price);
        }
    }

    class Sort
    {
        public static IEnumerable<T> InsertionSort<T>(IEnumerable<T> list, Func<T,T,bool> isRightOf )
        {
            var newList = new List<T>();

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
            List<Product> list = new List<Product>() {
                new Product {Name = "Apple", Price = 4}, 
                new Product {Name = "Orange", Price = 3},
                new Product {Name = "Pear", Price = 1},
                new Product {Name = "Lime", Price = 2}};

            Func<Product,Product,bool> isRightOf = (a, b) =>
                {
                    return a.Name.Length >= b.Name.Length;
                };

            List<Product> sorted = Sort.InsertionSort<Product>(list, isRightOf).ToList();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
