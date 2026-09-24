namespace OrderFactoryPattern;

class StandardOrder : Order
{
    public StandardOrder(string id, CustomerType customer, decimal total) : base(id, customer, total)
    {

    }

    public override decimal CalculateShippingCost(double weightKg)
    {
        return 3.50m + (decimal)weightKg * 0.80m;
    }
}
