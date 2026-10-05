namespace OrderFactoryPattern;

internal sealed class ExpressOrder : ITrackable
{
    public ExpressOrder(string id, decimal total)
    {
        Id = id;
        Total = total;
    }

    public string Id { get; }
    public decimal Total { get; }

    public string GetTrackingUrl()
    {
        return $"https://worldtracking.com/api/orders/{Id}";
    }
}
