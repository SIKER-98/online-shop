using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using online_shop.Models;
using online_shop.Services;

namespace online_shop.Pages;

public class EntityFrameworkData : PageModel
{
    private readonly OrderService _orderService;

    public EntityFrameworkData(OrderService orderService)
    {
        _orderService = orderService;
    }

    [BindProperty] public IEnumerable<EntityDto> EntityDto { get; set; }

    public void OnGet()
    {
        EntityDto = _orderService.GetFilteredOrderForEntity();
    }
}