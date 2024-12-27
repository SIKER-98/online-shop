using online_shop.Data;

namespace online_shop.Models;

public record EntityDto(
    PaymentMethod PaymentMethod,
    int OrderCount,
    decimal TotalGrossValue
);