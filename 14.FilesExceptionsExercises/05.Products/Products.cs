using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.Products
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }

    public class Products
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var food = new Dictionary<string, Dictionary<decimal, int>>();
            var electronics = new Dictionary<string, Dictionary<decimal, int>>();
            var domestics = new Dictionary<string, Dictionary<decimal, int>>();
            var analyze = new Dictionary<string, List<Product>>();
            var saleDict = new Dictionary<string, decimal>();

            //read baseData

            while (input != "exit")
            {
                var inputLine = input.Split(' ').ToArray();
                if (inputLine.Length == 4)
                {
                    var name = inputLine[0];
                    var type = inputLine[1];
                    var price = decimal.Parse(inputLine[2]);
                    var quantity = int.Parse(inputLine[3]);

                    switch (type)
                    {
                        case "Food":
                            if (!food.ContainsKey(name))
                            {
                                food[name] = new Dictionary<decimal, int>();
                            }

                            food[name][price] = quantity;
                            break;

                        case "Electronics":
                            if (!electronics.ContainsKey(name))
                            {
                                electronics[name] = new Dictionary<decimal, int>();
                            }

                            electronics[name][price] = quantity;
                            break;

                        case "Domestics":
                            if (!domestics.ContainsKey(name))
                            {
                                domestics[name] = new Dictionary<decimal, int>();
                            }

                            domestics[name][price] = quantity;
                            break;
                    }
                }
                else if (input == "stock")
                {
                    if (!File.Exists("output.txt"))
                    {
                        File.Create("output.txt").Close();
                    }
                    string productData = string.Empty;
                    foreach (var stock in food)
                    {
                        var priceAndQuantity = stock.Value;
                        foreach (var kvp in priceAndQuantity)
                        {
                            productData = $"Food {stock.Key} {kvp.Key} {kvp.Value}";
                            File.AppendAllText("output.txt", productData + Environment.NewLine);
                        }
                    }

                    foreach (var stock in electronics)
                    {
                        var priceAndQuantity = stock.Value;
                        foreach (var kvp in priceAndQuantity)
                        {
                            productData = $"Electronics {stock.Key} {kvp.Key} {kvp.Value}";
                            File.AppendAllText("output.txt", productData + Environment.NewLine);
                        }
                    }

                    foreach (var stock in domestics)
                    {
                        var priceAndQuantity = stock.Value;
                        foreach (var kvp in priceAndQuantity)
                        {
                            productData = $"Domestics {stock.Key} {kvp.Key} {kvp.Value}";
                            File.AppendAllText("output.txt", productData + Environment.NewLine);
                        }
                    }
                }
                else if (input == "analyze")
                {
                    try
                    {
                        var products = File.ReadAllLines("output.txt");

                        foreach (var product in products)
                        {
                            var tokens = product.Split(' ');
                            var type = tokens[0];
                            var name = tokens[1];
                            var price = decimal.Parse(tokens[2]);
                            var quantity = int.Parse(tokens[3]);

                            Product currentProduct = new Product
                            {
                                Name = name,
                                Price = price,
                                Quantity = quantity
                            };
                            if (!analyze.ContainsKey(type))
                            {
                                analyze[type] = new List<Product>();
                            }
                            analyze[type].Add(currentProduct);
                        }

                        foreach (var product in analyze.OrderBy(x => x.Key))
                        {
                            var prodResult = product.Value;
                            foreach (var printProduct in prodResult)
                            {
                                Console.WriteLine($"{product.Key}, Product: {printProduct.Name}");
                                Console.WriteLine($"Price: ${printProduct.Price}, Amount Left: {printProduct.Quantity}");
                            }
                        }
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("No products stocked");
                    }
                }
                else if (input == "sales")
                {
                    File.Create("sales.txt").Close();
                    decimal sumElectronics = 0;
                    decimal sumFood = 0;
                    decimal sumDomestics = 0;

                    foreach (var stock in electronics)
                    {
                        var priceValue = stock.Value;
                        if (electronics.Count > 0)
                        {
                            foreach (var price in priceValue)
                            {
                                sumElectronics += (price.Key * price.Value);
                            }
                        }
                    }
                    if (sumElectronics > 0)
                    {
                        File.AppendAllText("sales.txt", $"Electronics: ${sumElectronics:F2}" + Environment.NewLine);
                    }

                    foreach (var stock in domestics)
                    {
                        var priceValue = stock.Value;
                        if (domestics.Count > 0)
                        {
                            foreach (var price in priceValue)
                            {
                                sumDomestics += (price.Key * price.Value);
                            }
                        }
                    }
                    if (sumDomestics > 0)
                    {
                        File.AppendAllText("sales.txt", $"Domestics: ${sumDomestics:F2}" + Environment.NewLine);
                    }

                    foreach (var stock in food)
                    {
                        var priceValue = stock.Value;
                        if (food.Count > 0)
                        {
                            foreach (var price in priceValue)
                            {
                                sumFood += (price.Key * price.Value);
                            }
                        }
                    }
                    if (sumFood > 0)
                    {
                        File.AppendAllText("sales.txt", $"Food: ${sumFood:F2}" + Environment.NewLine);
                    }

                    var saleFile = File.ReadAllLines("sales.txt");

                    foreach (var name in saleFile)
                    {
                        var splitted = name.Split(new char[] { ' ', ':', '$' }, StringSplitOptions.RemoveEmptyEntries);

                        saleDict[splitted[0]] = decimal.Parse(splitted[1]);
                    }

                    foreach (var kvp in saleDict.OrderByDescending(x => x.Value))
                    {
                        if (kvp.Value > 0)
                        {
                            Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}