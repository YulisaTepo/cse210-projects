using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Daniel Alcides", "Guadalupe", "Pacasmayo", "Peru");
        Customer customer1 = new Customer("Maria", address);

        Product product1 = new Product("Dove", 4142, 10, 2);
        Product product2 = new Product("Pantene", 4366, 5, 3);
        Product product3 = new Product("Sedal", 4511, 2, 4);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Product product4 = new Product("Notebook", 1203, 2, 8);
        Product product5 = new Product("Pencil", 1478, 1, 4);
        Product product6 = new Product("Eraser", 1063, 1, 2);

        Console.WriteLine("___________________________________________________________________");
        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetResult());

        Address address2 = new Address("St. Mark's place", "New York City", "New York", "USA");
        Customer customer2 = new Customer("Alex" , address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("___________________________________________________________________");
        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetResult());
        Console.Write("___________________________________________________________________");
    }
}