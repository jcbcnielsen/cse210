using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 Main St", "Richmond", "Virginia", 11223, "United States");
        Customer customer1 = new Customer("Albert Allison", address1);
        Product product1A = new Product("Apples", 2345, 0.83F, 5);
        Product product1B = new Product("Bananas", 2456, 1.06F, 3);
        Product product1C = new Product("Canned Beans", 6789, 1.27F, 1);
        List<Product> productList1 = new List<Product>();
        productList1.Add(product1A);
        productList1.Add(product1B);
        productList1.Add(product1C);
        Order order1 = new Order(customer1, productList1);

        Address address2 = new Address("5678 Side Rd", "Munich", "Bavaria", 0, "Germany");
        Customer customer2 = new Customer("Joseph Kaufmann", address2);
        Product product2A = new Product("Flatbread", 5432, 1.12F, 2);
        Product product2B = new Product("Kosher Salt", 9135, 2.23F, 1);
        Product product2C = new Product("Dill Pickles", 3111, 1.53F, 1);
        List<Product> productList2 = new List<Product>();
        productList2.Add(product2A);
        productList2.Add(product2B);
        productList2.Add(product2C);
        Order order2 = new Order(customer2, productList2);

        Console.WriteLine("First Order:");
        Console.WriteLine($"{order1.GetPackingLabel()}");
        Console.WriteLine($"{order1.GetShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine("\n");
        Console.WriteLine("Second Order:");
        Console.WriteLine($"{order2.GetPackingLabel()}");
        Console.WriteLine($"{order2.GetShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}