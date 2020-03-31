﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures2.Models;

namespace LanguageFeatures2.Controllers
{
    public class HomeController : Controller
    {
        //bool FilterByPrice(Product p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}

        //public ViewResult Index()
        //{
        //    //List<string> results = new List<string>();
        //    //foreach (Product p in Product.GetProducts())
        //    //{
        //    //    string name = p?.Name ?? "<No Name>";
        //    //    decimal? price = p?.Price ?? 0;
        //    //    string relatedName = p?.Related?.Name ?? "<None>";
        //    //    //results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
        //    //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
        //    //}

        //    //return View(results);

        //    //string[] names = new string[] { "Bob", "Joe", "Alice" };

        //    //return View("Index", new string[] { "Bob", "Joe", "Alice" });

        //    //Dictionary<string, Product> products = new Dictionary<string, Product>
        //    //{
        //    //    {
        //    //        "Kayak", new Product
        //    //        {
        //    //            Name = "Kayak", Price = 275M
        //    //        }
        //    //    },
        //    //    {
        //    //        "Lifejacket", new Product
        //    //        {
        //    //            Name = "Lifejacket", Price = 48.95M
        //    //        }
        //    //    }
        //    //};

        //    //return View("Index", products.Keys);

        //    //Dictionary<string, Product> products = new Dictionary<string, Product>
        //    //{
        //    //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //    //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        //    //};

        //    //return View("Index", products.Keys);

        //    //object[] data = new object[]
        //    //{
        //    //    275M, 29.95M, "apple", "orange", 100, 10
        //    //};
        //    //decimal total = 0;
        //    //for (int i = 0; i < data.Length; i++)
        //    //{
        //    //    if (data[i] is decimal d)
        //    //    {
        //    //        total += d;
        //    //    }
        //    //}

        //    //return View("Index", new string[] { $"Total: {total:C2}" });


        //    //object[] data = new object[]
        //    //{
        //    //    275M, 29.95M, "apple", "orange", 100, 10
        //    //};
        //    //decimal total = 0;
        //    //for (int i = 0; i < data.Length; i++)
        //    //{
        //    //    switch (data[i])
        //    //    {
        //    //        case decimal decimalValue:
        //    //            total += decimalValue;
        //    //            break;
        //    //        case int intValue when intValue > 50:
        //    //            total += intValue;
        //    //            break;
        //    //    }
        //    //}

        //    //return View("Index", new string[] { $"Total: {total:C2}" });


        //    //ShoppingCart cart = new ShoppingCart
        //    //{
        //    //    Products = Product.GetProducts()
        //    //};

        //    //decimal cartTotal = cart.TotalPrices();

        //    //return View("Index", new string[] { $"Total: {cartTotal:C2}" });


        //    //ShoppingCart cart = new ShoppingCart
        //    //{
        //    //    Products = Product.GetProducts()
        //    //};

        //    //Product[] productArray =
        //    //{
        //    //    new Product { Name = "Kayak", Price = 275M },
        //    //    new Product { Name = "Lifejacket", Price = 48.95M },
        //    //    new Product { Name = "Soccer ball", Price = 19.50M },
        //    //    new Product { Name = "Corner flag", Price = 34.95M }
        //    //};

        //    //Func<Product, bool> nameFilter = delegate (Product prod)
        //    //{
        //    //    return prod?.Name?[0] == 'S';
        //    //};

        //    //decimal cartTotal = cart.TotalPrices();
        //    //decimal arrayTotal = productArray.TotalPrices();
        //    //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
        //    //decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
        //    //decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();


        //    //// ohne lambda
        //    //decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();
        //    //decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();

        //    //// mit lambda ausdruck
        //    //priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
        //    //nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();

        //    //return View("Index", new string[] 
        //    //{
        //    //    //$"Cart Total: {cartTotal:C2}",
        //    //    //$"Array Total: {arrayTotal:C2}"
        //    //    $"Price Total: {priceFilterTotal:C2}",
        //    //    $"Name Total: {nameFilterTotal:C2}"
        //    //});


        //    return View(Product.GetProducts().Select(p => p?.Name));
        //}



        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));

        //public ViewResult Index()
        //{
        //    var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
        //    return View(names);
        //}


        //public ViewResult Index()
        //{
        //    var products = new[]
        //    {
        //        new { Name = "Kayak", Price = 275M },
        //        new { Name = "Lifejacket", Price = 48.95M },
        //        new { Name = "Soccer ball", Price = 19.95M },
        //        new { Name = "Corner flag", Price = 34.95M }
        //    };

        //    return View(products.Select(p => p.Name));

        //    //return View(products.Select(p => p.GetType().Name));
        //}

        public async Task<ViewResult> Index()
        {
            //long? length = await MyAsyncMethods.GetPageLength();
            //return View(new string[]
            //{
            //    $"Length: {length}"
            //});

            var products = new[] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };
            //return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
            return View(products.Select(p => 
                $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}