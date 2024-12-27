using System.ComponentModel.DataAnnotations;

namespace online_shop.Data;

public class Store
{
    [Key] public int StoreId { get; set; }

    public string StoreName { get; set; }

    public ICollection<Order> Orders { get; set; }
}