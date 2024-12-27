using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using online_shop.Models;

namespace online_shop.Pages;

public class WebServiceData : PageModel
{
    [BindProperty] public List<ApiDto>? ApiDtos { get; set; }

    public void OnGet()
    {
        using var client = new HttpClient();
        var response = client.GetStringAsync("https://localhost:44359/api/orders").Result;
        ApiDtos = JsonConvert.DeserializeObject<List<ApiDto>>(response);
    }
}