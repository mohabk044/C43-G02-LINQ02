using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 01 - Element Operator
            //var result = ProductList.First();
            //Console.WriteLine(result);
            //var result1 = ProductList.Last();
            //Console.WriteLine(result1);
            //ProductList = new List<Product>();
            //var result2 = ProductList.FirstOrDefault(new Product { ProductName = "Chai" });
            //Console.WriteLine(result2?.ProductName ?? "Not Found");
            //var result3 = ProductList.LastOrDefault();
            //Console.WriteLine(result3?.ProductName ?? "Not Found");

            ////var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            ////Console.WriteLine(result?.ProductName);
            //var result4 = ProductList.LastOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result4?.ProductName);
            //var result5 = ProductList.FirstOrDefault(p => p.UnitsInStock == 1000);
            //Console.WriteLine(result5?.ProductName);
            //var result6 = ProductList.LastOrDefault(p => p.UnitsInStock == 1000);
            //Console.WriteLine(result6?.ProductName ?? "Not Found");
            //var result7 = ProductList.ElementAtOrDefault(1000);
            //Console.WriteLine(result7?.ProductName ?? "Not Found");
            //var discount = new List<Product>();
            //var result8 = discount.SingleOrDefault(); // Handled if empty
            ////var result = ProductList.SingleOrDefault();
            //Console.WriteLine(result8?.ProductName ?? "No Data");
            //var discount1 = new List<Product>();
            //var result9 = discount1.SingleOrDefault(); // Handled if empty
            ////var result = ProductList.SingleOrDefault(p => p.UnitPrice > 20);
            //Console.WriteLine(result9?.ProductName ?? "No Data");
            #endregion

            #region Video 2 - Aggregate Operators
            //var result = ProductList.Count;
            //Console.WriteLine(result);
            //var result1 = ProductList.Sum(p => p.UnitPrice);
            //Console.WriteLine(result1);
            //var result2 = ProductList.Average(p => p.UnitPrice);
            //Console.WriteLine(result2);
            //var result3 = ProductList.Min(p => p.UnitPrice);
            //Console.WriteLine(result3);
            //var result4 = ProductList.MinBy(p => p.UnitPrice);
            //Console.WriteLine(result4);
            //string[] Names = { "Mostafa", "Mohamed", "Mohamed", "Habib" };
            //string FullName = Names.Aggregate((str01, str02) => $"{str01} {str02}");
            //Console.WriteLine(FullName);
            #endregion

            #region Video 3 - Casting Operators
            //List<Product> list = ProductList.Where(p => p.UnitsInStock == 0).ToList();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Product[] products = ProductList.Where(p => p.UnitsInStock == 0).ToArray();
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            //Dictionary<long, Product> products2 = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);
            //foreach (var item in products2)
            //{
            //    Console.WriteLine(item);
            //}
            //Dictionary<long, string?> products3 = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID, p => p.ProductName);
            //foreach (var item in products3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Video 4 - Generation Operators(Differed Execution)
            //    //Range:
            //    var result = Enumerable.Range(0, 100).Where(p => p % 2 == 0);
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            ////Repeat:
            //    var result1 = Enumerable.Repeat(new Product() { Category = "Meat" }, 10);
            //    foreach (var item in result1)
            //    {
            //        Console.WriteLine(item);
            //    }
            ////Empty:
            //    var result2 = Enumerable.Empty<Product>();
            //    foreach (var item in result2)
            //    {
            //        Console.WriteLine(item);
            //    }
            #endregion

            #region Video 5 - Set Operators
            var Seq01 = Enumerable.Range(0, 100);
            var Seq02 = Enumerable.Range(50, 100);
            var result = Seq01.Union(Seq02);
            var result1 = Seq01.Concat(Seq02);
            var result2 = Seq01.Intersect(Seq02);
            var result3 = Seq01.Except(Seq02);
            foreach (var item in result)
            {
                Console.WriteLine(item);
                #endregion
            }
        }
    }
}