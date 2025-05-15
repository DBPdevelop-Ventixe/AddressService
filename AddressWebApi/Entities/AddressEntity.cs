using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Entities;

public class AddressEntity
{
    [Key]
    public string Id { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string City { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
}
