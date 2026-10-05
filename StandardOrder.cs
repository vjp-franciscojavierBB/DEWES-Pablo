namespace OrderFactoryPattern;

internal sealed class StandardOrder
{
    public StandardOrder(string id, decimal total)
    {
        Id = id;
        Total = total;
    }

    public string Id { get; }
    public decimal Total { get; }
}
