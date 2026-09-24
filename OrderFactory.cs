namespace OrderFactoryPattern;

public enum ShippingType
{
    Standard,
    Express,
}

internal static class OrderFactory
{


    public static Order Create(string id, CustomerType customer, decimal total, ShippingType shipping) => shipping switch
    {
        ShippingType.Standard => new StandardOrder(id, customer, total),
        ShippingType.Express => new ExpressOrder(id, customer, total),
        _ => throw new ArgumentOutOfRangeException(nameof(shipping))
    };
}
