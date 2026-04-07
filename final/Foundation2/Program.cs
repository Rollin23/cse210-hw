using System;

class Program
{
    static void Main(string[] args)
    {

        Address addr1 = new Address("6643 Grey St", "Arvada", "CO", "USA");
        Customer cust1 = new Customer("John Wick", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Products("Laptop", "slkdfjs", 899.99, 1));
        order1.AddProduct(new Products("Dongle", "lsdlkfj", 19.99, 2));

        //I don't actually know any places in Canada
        Address addr2 = new Address("65 S 1st West", "Rexburg", "ID", "Canada");
        Customer cust2 = new Customer("Emily Johnson", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Products("Desk Lamp", "54dfsf45", 29.99, 1));
        order2.AddProduct(new Products("Candles", "sdfv1235", 4.99, 5));


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
