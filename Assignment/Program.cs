using static Assignment.ListGenerator;
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
            var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            Console.WriteLine(Result);
            #endregion
            #endregion
        }
    }
}