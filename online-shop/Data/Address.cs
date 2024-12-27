using System.ComponentModel.DataAnnotations;

namespace online_shop.Data;

public class Address
{
    [Key] public int AddressId { get; set; }

    public required string Street { get; set; }

    public required string City { get; set; }

    public required string PostalCode { get; set; }
}