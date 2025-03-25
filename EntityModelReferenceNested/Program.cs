using EntityModelReferenceNested.Model;

namespace EntityModelReferenceNested;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var _Order = new Order()
        {
            CustomerNavigation = new Customer()
            {
                Password =  "password", Id = 1, EmailAddress = "email@email.com", FullName =  "full name"
            },
            CustomerId = 1, OrderDate = DateTime.Now.AddDays(-10), OrderTotal = 100,
            ShipDate = DateTime.Now.AddDays(10), Id = 1
        };

        var _OrderDetail = new OrderDetail()
        {
            OrderId = _Order.Id, OrderNavigation = _Order, Id = 1, Quantity = 1000, UnitCost = 1, LineItemTotal = 2
        };
        
        
    }
}