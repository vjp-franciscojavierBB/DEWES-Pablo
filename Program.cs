namespace OrderFactoryPattern;

internal record Product(string Code, string Name, decimal Price);
internal record Order(string Id, decimal Total);

internal class RecentItems<T>
{
    private readonly List<T> _items = [];

    public RecentItems(int capacity)
    {
        Capacity = capacity;
    }

    public int Capacity { get; }
    public IReadOnlyList<T> Items => _items;

    public void Add(T item)
    {
        _items.Remove(item);
        _items.Insert(0, item);

        if (_items.Count > Capacity)
        {
            _items.RemoveAt(_items.Count - 1);
        }
    }
}

internal static class Program
{
    private static void Main()
    {
        var recentProducts = new RecentItems<Product>(capacity: 3);
        var recentSearches = new RecentItems<string>(capacity: 3);
        var recentOrders = new RecentItems<Order>(capacity: 2);

        recentProducts.Add(new Product("SKU-1001", "Camiseta", 12.50m));
        recentProducts.Add(new Product("SKU-2044", "Gorra", 18.90m));
        recentProducts.Add(new Product("SKU-7890", "Botas", 59.00m));
        recentProducts.Add(new Product("SKU-2044", "Gorra", 18.90m));

        recentSearches.Add("smartphone");
        recentSearches.Add("teclado");
        recentSearches.Add("monitor");
        recentSearches.Add("mouse");

        recentOrders.Add(new Order("ORD-101", 120.00m));
        recentOrders.Add(new Order("ORD-102", 250.00m));
        recentOrders.Add(new Order("ORD-103", 80.00m));

        PrintAll("Vistos recientemente", recentProducts);
        PrintAll("Búsquedas recientes", recentSearches);
        PrintAll("Pedidos consultados", recentOrders);
    }

    private static void PrintAll<T>(string title, RecentItems<T> recent)
    {
        Console.WriteLine($"{title} ({recent.Items.Count}/{recent.Capacity}):");

        foreach (var item in recent.Items)
        {
            Console.WriteLine($" - {item}");
        }
    }
}
