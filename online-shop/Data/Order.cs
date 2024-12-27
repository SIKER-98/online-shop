using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_shop.Data;

public class Order
{
    [Key] public int OrderId { get; set; }

    public int StoreId { get; set; }

    [ForeignKey("StoreId")] public Store Store { get; set; }

    public ICollection<OrderPosition> OrderPositions { get; set; }

    public Address CustomerAddress { get; set; }

    public PaymentMethod PaymentMethod { get; set; }

    public decimal TotalNetValue => OrderPositions.Sum(position => position.Product.NetValue * position.Quantity);

    public decimal TotalGrossValue => OrderPositions.Sum(position => position.Product.GrossValue * position.Quantity);
}