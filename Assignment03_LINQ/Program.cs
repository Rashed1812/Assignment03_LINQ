using Assignment03_LINQ.Data;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static Assignment03_LINQ.ListGenerator;

namespace Assignment03_LINQ
{
    class compare : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return Sort(x) == Sort(y);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return Sort(obj).GetHashCode();
        }

        string Sort(string obj)
        {
            var word = obj.ToCharArray();
            Array.Sort(word);
            return new string(word);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            //var result = ProducstList.Select(p => p.Category).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var result = ProducstList.Select(p => p.ProductName[0]).Union(CustomersList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProducstList.Select(p => p.ProductName[0]).Union(CustomersList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProducstList.Select(p => p.ProductName[0]).Except(CustomersList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProducstList.Select(p => p.ProductName[^3..]).Concat(CustomersList.Select(c => c.CustomerName[^3..]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington
            //var result = CustomersList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var result = CustomersList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((x, i) => x > i);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(x => x % 3 != 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5.Get the elements of the array starting from the first element less than its position
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((x, i) => x > i);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ – Quantifiers Operators

            #region 1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Any(w => w.Contains("ei"));

            //Console.WriteLine(result);

            #endregion

            #region 2.Return a grouped list of products only for categories that have at least one product that is out of stock.

            //var result = ProducstList.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock == 0)).Select(p => p);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);

            //    foreach (var p in item)
            //        Console.WriteLine(p);
            //}
            #endregion

            #region 3.Return a grouped list of products only for categories that have all of their products in stock.

            //var result = ProducstList.GroupBy(p => p.Category).Where(c => c.All(p => p.UnitsInStock > 0)).Select(p => p);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var p in item)
            //        Console.WriteLine(p);
            //}

            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region 1.Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(x => x % 5);

            //foreach (var number in result)
            //{
            //    Console.WriteLine($"Numbers with remainder of {number.Key} when divided by 5");

            //    foreach (var x in number)
            //        Console.WriteLine(x);
            //}

            #endregion

            #region 2.Uses group by to partition a list of words by their first letter(Use dictionary_english.txt for Input).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.GroupBy(word => word[0]);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine(); 
            //}



            #endregion

            #region 3.Consider this Array as an Input

            //string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            //var result = Arr.GroupBy(w => w.Trim(), new compare());

            //foreach (var item in result)
            //{
            //    foreach (var w in item)
            //        Console.WriteLine(w);
            //    Console.WriteLine("..........");
            //}

            #endregion


            #endregion

        }
    }
}
