namespace OrderFactoryPattern;

interface ITrackable
{
	string GetTrackingUrl();
	void PrintTrackingInfo() => Console.WriteLine($"Track at: {GetTrackingUrl()}");
}
