namespace OrderFactory;

class OrderFactory
{
    public static global::OrderFactory.Models.Order Create(string id, global::OrderFactory.Models.CustomerType type, decimal total) => type switch
    {
        global::OrderFactory.Models.CustomerType.Regular => new global::OrderFactory.Models.Order(id, type, total, DiscountRate: 0.00m),
        global::OrderFactory.Models.CustomerType.Premium => new global::OrderFactory.Models.Order(id, type, total, DiscountRate: 0.10m),
        global::OrderFactory.Models.CustomerType.Vip => new global::OrderFactory.Models.Order(id, type, total, DiscountRate: 0.20m),
        _ => throw new ArgumentOutOfRangeException(nameof(type))
    };

}
                