using AddressWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AddressWebApi.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<AddressEntity> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AddressEntity>(entity =>
        {
            entity.HasData(new AddressEntity
            {
                Id = "1",
                Street = "123 Sunset St",
                City = "Miami",
                ZipCode = "4153",
                State = "FL",
                Country = "USA"
            });
        });
    }
}