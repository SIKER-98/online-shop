using online_shop.Data;
using online_shop.Models;

namespace online_shop.Services;

public class OrderService
{
    private readonly OrderContext _orderContext;

    public OrderService(OrderContext orderContext)
    {
        _orderContext = orderContext;
    }

    public IEnumerable<ApiDto> GetFilteredOrderForApi()
    {
        // TODO: zrobić mapper na dto
        return _orderContext.Orders
            .Where(order => order.Store.StoreName.Contains("Sklep") && order.Store.StoreId % 2 == 0)
            .Where(order => order.CustomerAddress.City.Contains("w") && order.CustomerAddress.City.Contains("W"))
            .ToList()
            .Select(order => new ApiDto(
                order.Store.StoreName,
                order.CustomerAddress.City,
                order.OrderPositions,
                order.TotalNetValue
            ));
    }

    public IEnumerable<EntityDto> GetFilteredOrderForEntity()
    {
        // TODO: zrobić mapper na dto
        return _orderContext.Orders
            .ToList()
            .Where(o => o.TotalGrossValue >= 100)
            .GroupBy(o => o.PaymentMethod)
            .ToList()
            .Select(g => new EntityDto(
                g.Key,
                g.Count(),
                g.Sum(o => o.TotalGrossValue)
            ));
    }
}