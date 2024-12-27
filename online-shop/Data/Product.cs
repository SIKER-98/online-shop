using System.ComponentModel.DataAnnotations;

namespace online_shop.Data;

public class Product
{
    [Key] public int ProductId { get; set; }
    public string ProductCode { get; set; }

    public decimal NetValue { get; set; }

    public decimal GrossValue { get; set; }

    public ICollection<OrderPosition> OrderPositions { get; set; }
}