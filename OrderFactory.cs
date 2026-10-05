namespace OrderFactoryPattern;

internal static class OrderFactory
{
    public static Order Create(string id, decimal total, ShippingType shipping) => shipping switch
    {
        ShippingType.Standard => new Order(id, total),
        ShippingType.Express => new Order(id, total),
        _ => throw new ArgumentOutOfRangeException(nameof(shipping))
    };
}
