using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Order order1 = new Order();
        order1.SetCustomerDetails("Russell M. Nelson", "Church Avenue", "SLC", "UT", "USA");
        order1.AddProductDetails("Chair", 1234, 120, 1);
        order1.AddProductDetails("Candy", 1235, 2, 20);

        Order order2 = new Order();
        order2.SetCustomerDetails("Ulisses Soares", "Avenida Paulista", "Sao Paulo", "SP", "Brazil");
        order2.AddProductDetails("Flag", 8888, 20, 1);
        order2.AddProductDetails("Candy", 1235, 2, 20);

        Order order3 = new Order();
        order3.SetCustomerDetails("Albus Percival Wulfric Brian Dumbledore", "Hogwarts", "Hogsmeade", "NA", "UK");
        order3.AddProductDetails("Flag", 8888, 20, 1);
        order3.AddProductDetails("Socks", 5972, 5, 2);


        List<Order> _ordersList = new List<Order>{order1, order2, order3};

        foreach (Order order in _ordersList)
        {
            Console.WriteLine($"{order.GetShippingLabel()}\n{order.GetPackingLabel()}\nTotal: ${order.CalculateCost()}\n-----------------");            
        }
    }
}