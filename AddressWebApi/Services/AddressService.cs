using AddressWebApi.Data;
using AddressWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AddressWebApi.Services;

public class AddressService(DataContext context)
{
    private readonly DataContext _context = context;

    public async Task<AddressEntity> GetAddress(string id)
    {
        var address = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == id);
        return address ?? null!;
    }

    public async Task<bool> AddAddress(AddressEntity address)
    {
        if (address == null)
            return false;

        await _context.Addresses.AddAsync(address);
        var result = await _context.SaveChangesAsync();
        return result > 0;
    }
}
