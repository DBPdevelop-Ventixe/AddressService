using AddressWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AddressWebApi.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<AddressEntity> Addresses { get; set; }
}