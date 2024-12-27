using online_shop.Data;

namespace online_shop.Seeds;

public class DatabaseDataInitializer
{
    private readonly OrderContext _orderContext;

    public DatabaseDataInitializer(OrderContext orderContext)
    {
        _orderContext = orderContext;
    }

    public void FillDatabase()
    {
        var stores = new List<Store>();
        for (var i = 1; i <= 10; i++) stores.Add(new Store { StoreName = $"Sklep {i}" });

        _orderContext.Stores.AddRange(stores);
        _orderContext.SaveChanges();

        var products = new List<Product>
        {
            new() { ProductCode = "P1", NetValue = 10, GrossValue = 12.3m },
            new() { ProductCode = "P2", NetValue = 20, GrossValue = 24.6m }
        };
        _orderContext.Products.AddRange(products);
        _orderContext.SaveChanges();

        var orders = new List<Order>();

        for (var i = 1; i <= 10; i++)
        {
            var orderLines = new List<OrderPosition>
            {
                new() { Product = products[0], Quantity = 5 },
                new() { Product = products[1], Quantity = 3 }
            };

            var order = new Order
            {
                Store = stores[i - 1],
                CustomerAddress = new Address
                {
                    Street = "Ulica Testowa",
                    City = i % 2 == 0 ? "Warszawa" : "Krakow",
                    PostalCode = "00-001"
                },
                PaymentMethod = (PaymentMethod)(i % 3),
                OrderPositions = orderLines
            };
            orders.Add(order);
        }

        orders.ForEach(o => _orderContext.Orders.Add(o));
        _orderContext.SaveChanges();
    }
}