using Microsoft.AspNetCore.Mvc;
using online_shop.Services;

namespace online_shop.Api;

[Route("api/orders")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderService _orderService;

    public OrderController(OrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult GetFilteredOrders()
    {
        var orders = _orderService.GetFilteredOrderForApi();

        return Ok(orders);
    }
}