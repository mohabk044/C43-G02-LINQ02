using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            #region Q1- Get first Product out of Stock 
            var Result = ProductList.First(P => P.UnitsInStock == 0);
            Console.WriteLine(Result);
            #endregion
            #endregion
        }
    }
}