using OrderFactory.Models;
using Factory = global::OrderFactory.OrderFactory;

Console.WriteLine("Hello, World!");

Order order = new Order("Holaº", CustomerType.Regular, 50.00m, 0.00m);
Order order2 = new Order("Hola", CustomerType.Premium, 50.00m, 0.20m);

Order orderFromFactory = Factory.Create("Hola123", CustomerType.Premium, 100.00m);

Console.WriteLine($"El descuento de {orderFromFactory.Id}es de {orderFromFactory.DiscountRate}");

