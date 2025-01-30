﻿using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            #region Q1- Get first Product out of Stock 
            //var Result = ProductList.First(P => P.UnitsInStock == 0);
            //Console.WriteLine(Result);
            #endregion
            #region Q2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result);
            #endregion
            #region Q3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(N => N > 5).ElementAt(1);
            //Console.WriteLine(Result);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region Q1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(P => P % 2 != 0);
            //Console.WriteLine(Result);
            #endregion
            #region Q2. Return a list of customers and how many orders each has.
            //var Result = CustomerList.Select(C => new { C.CustomerID, OrderCount = C.Orders.Count()});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3. Return a list of categories and how many products each has.
            var Result = ProductList.Select(C => new { C.Category, ProductCount = C.ProductName.Count() });
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}