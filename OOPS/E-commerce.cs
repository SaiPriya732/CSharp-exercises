// using System;
// using System.Collections.Generic;

// abstract class Product
// {
//     public int ProductId { get; set; }
//     public string ProductName { get; set; }

//     protected double Price;

//     public Product(int productId, string productName, double price)
//     {
//         ProductId = productId;
//         ProductName = productName;
//         Price = price;
//     }

//     public abstract void CalculateDiscount();

//     public virtual void DisplayProduct()
//     {
//         Console.WriteLine(ProductName);
//     }
// }

// class Electronics : Product
// {
//     public Electronics(int productId, string productName, double price)
//         : base(productId, productName, price)
//     {
//     }

//     public override void CalculateDiscount()
//     {
//         double discount = Price * 0.10;
//         double finalPrice = Price - discount;

//         Console.WriteLine($"Original Price : {Price}");
//         Console.WriteLine("Discount : 10%");
//         Console.WriteLine($"Final Price : {finalPrice}");
//     }
// }

// class Clothing : Product
// {
//     public Clothing(int productId, string productName, double price)
//         : base(productId, productName, price)
//     {
//     }

//     public override void CalculateDiscount()
//     {
//         double discount = Price * 0.20;
//         double finalPrice = Price - discount;

//         Console.WriteLine($"Original Price : {Price}");
//         Console.WriteLine("Discount : 20%");
//         Console.WriteLine($"Final Price : {finalPrice}");
//     }
// }

// class Grocery : Product
// {
//     public Grocery(int productId, string productName, double price)
//         : base(productId, productName, price)
//     {
//     }

//     public override void CalculateDiscount()
//     {
//         double discount = Price * 0.05;
//         double finalPrice = Price - discount;

//         Console.WriteLine($"Original Price : {Price}");
//         Console.WriteLine("Discount : 5%");
//         Console.WriteLine($"Final Price : {finalPrice}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Product> products = new List<Product>();

//         products.Add(new Electronics(
//             1,
//             "Laptop",
//             50000));

//         products.Add(new Clothing(
//             2,
//             "T-Shirt",
//             1000));

//         products.Add(new Grocery(
//             3,
//             "Rice Bag",
//             2000));

//         foreach (Product product in products)
//         {
//             product.DisplayProduct();
//             product.CalculateDiscount();
//             Console.WriteLine();
//         }
//     }
// }