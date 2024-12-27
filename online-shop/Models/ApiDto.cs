using online_shop.Data;

namespace online_shop.Models;

public record ApiDto(
    string StoreName,
    string City,
    IEnumerable<OrderPosition> OrderPositions,
    decimal TotalNetValue);