namespace OrderFactoryPattern;

/// <summary>
/// Represents an order with its details.
/// </summary>
/// <param name="Id">The unique identifier for the order.</param>
/// <param name="Customer">The type of customer placing the order.</param>
/// <param name="Total">The total amount of the order.</param>
/// <param name="DiscountRate">The discount rate applied to the order.</param>
internal record Order(string Id, CustomerType Customer, decimal Total, decimal DiscountRate);
