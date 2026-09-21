namespace OrderFactory;

record Order(string Id, CustomerType Type, decimal Total, decimal DiscountRate);
