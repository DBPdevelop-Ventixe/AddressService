using System.ComponentModel.DataAnnotations;

namespace AddressWebApi.Entities;

public class AccountAddressEntity
{
    [Key]
    public string Id { get; set; } = null!;
    public string AccountId { get; set; } = null!;
    public string AddressId { get; set; } = null!;
}
