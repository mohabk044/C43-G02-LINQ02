using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 01 - Element Operator
            var result = ProductList.First();
            Console.WriteLine(result);
            var result1 = ProductList.Last();
            Console.WriteLine(result1);
            ProductList = new List<Product>();
            var result2 = ProductList.FirstOrDefault(new Product { ProductName = "Chai" });
            Console.WriteLine(result2?.ProductName ?? "Not Found");
            var result3 = ProductList.LastOrDefault();
            Console.WriteLine(result3?.ProductName ?? "Not Found");

            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result?.ProductName);
            var result4 = ProductList.LastOrDefault(p => p.UnitsInStock == 0);
            Console.WriteLine(result4?.ProductName);
            var result5 = ProductList.FirstOrDefault(p => p.UnitsInStock == 1000);
            Console.WriteLine(result5?.ProductName);
            var result6 = ProductList.LastOrDefault(p => p.UnitsInStock == 1000);
            Console.WriteLine(result6?.ProductName ?? "Not Found");
            var result7 = ProductList.ElementAtOrDefault(1000);
            Console.WriteLine(result7?.ProductName ?? "Not Found");
            var discount = new List<Product>();
            var result8 = discount.SingleOrDefault(); // Handled if empty
            //var result = ProductList.SingleOrDefault();
            Console.WriteLine(result8?.ProductName ?? "No Data");
            var discount1 = new List<Product>();
            var result9 = discount1.SingleOrDefault(); // Handled if empty
            //var result = ProductList.SingleOrDefault(p => p.UnitPrice > 20);
            Console.WriteLine(result9?.ProductName ?? "No Data");
            #endregion
        }
    }
}