



////Q1


//using System;
//using System.Collections.Generic;

//namespace AdvancedCSharpAssignment
//{
//    // Product Model
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Category { get; set; }
//        public double Price { get; set; }
//        public int Stock { get; set; }
//    }

//    // Smart Product Search
//    public class ProductSearch
//    {
//        public static List<Product> SearchProducts(
//            List<Product> products,
//            Func<Product, bool> filter)
//        {
//            List<Product> result = new List<Product>();

//            foreach (Product product in products)
//            {
//                if (filter(product))
//                {
//                    result.Add(product);
//                }
//            }

//            return result;
//        }
//    }

//    // Main Program
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Product> products = new List<Product>
//            {
//                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
//                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 15 },
//                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 25, Stock = 50 },
//                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 30 },
//                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 100 },
//                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 20, Stock = 40 },
//                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 25 },
//                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 15, Stock = 8 },
//                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 90, Stock = 18 },
//                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 150, Stock = 5 }
//            };

//            // 1. Search for Electronics
//            Console.WriteLine("Electronics Products:");

//            var electronics = ProductSearch.SearchProducts(
//                products,
//                p => p.Category == "Electronics");

//            foreach (var product in electronics)
//            {
//                Console.WriteLine(product.Name);
//            }

//            // 2. Search for Products Under $50
//            Console.WriteLine("\nProducts Under $50:");

//            var cheapProducts = ProductSearch.SearchProducts(
//                products,
//                p => p.Price < 50);

//            foreach (var product in cheapProducts)
//            {
//                Console.WriteLine(product.Name);
//            }

//            // 3. Search for Products In Stock
//            Console.WriteLine("\nProducts In Stock:");

//            var availableProducts = ProductSearch.SearchProducts(
//                products,
//                p => p.Stock > 0);

//            foreach (var product in availableProducts)
//            {
//                Console.WriteLine(product.Name);
//            }

//            // 4. Search for Clothing Under $100
//            Console.WriteLine("\nClothing Products Under $100:");

//            var clothingProducts = ProductSearch.SearchProducts(
//                products,
//                p => p.Category == "Clothing" && p.Price < 100);

//            foreach (var product in clothingProducts)
//            {
//                Console.WriteLine(product.Name);
//            }
//        }
//    }
//}








//Q2



//using System;
//using System.Collections.Generic;

//namespace AdvancedCSharpAssignment
//{
//    // Product Model
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Category { get; set; }
//        public double Price { get; set; }
//        public int Stock { get; set; }
//    }

//    // Report Service
//    public class ProductReport
//    {
//        // Action is used because this method performs an operation
//        // without returning a value.
//        public static void PrintReport(
//            List<Product> products,
//            Action<Product> action)
//        {
//            foreach (Product product in products)
//            {
//                action(product);
//            }
//        }
//    }

//    // Main Program
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Product> products = new List<Product>
//            {
//                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
//                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 15 },
//                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 25, Stock = 50 },
//                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 30 },
//                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 100 },
//                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 20, Stock = 40 },
//                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 25 },
//                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 15, Stock = 8 },
//                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 90, Stock = 18 },
//                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 150, Stock = 5 }
//            };

//            // Scenario 1: Short Report
//            Console.WriteLine("=== Short Report ===");

//            ProductReport.PrintReport(
//                products,
//                p => Console.WriteLine($"{p.Name} - ${p.Price}")
//            );

//            // Scenario 2: Detailed Report
//            Console.WriteLine("\n=== Detailed Report ===");

//            ProductReport.PrintReport(
//                products,
//                p => Console.WriteLine(
//                    $"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"
//                )
//            );
//        }
//    }
//}