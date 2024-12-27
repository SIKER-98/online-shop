using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_shop.Data;

public class OrderPosition
{
    [Key] public int OrderPositionId { get; set; }

    public int ProductId { get; set; }

    [ForeignKey("ProductId")] public Product Product { get; set; }


    public int OrderId { get; set; }

    [ForeignKey("OrderId")] public Order Order { get; set; }

    public decimal Quantity { get; set; }
}