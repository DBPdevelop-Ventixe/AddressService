using AddressWebApi.Data;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;

namespace AddressWebApi.Services;

public class ProtoAddressService(DataContext context) : AddressHandler.AddressHandlerBase
{
    private readonly DataContext _context = context;

    public override async Task<GetAddressReply> GetAddressById(GetAddressByIdRequest request, ServerCallContext context)
    {
        var address = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == request.Id);
        if (address == null)
            return null!;
        

        var reply = new GetAddressReply
        {
            Id = address.Id,
            Street = address.Street,
            City = address.City,
            State = address.State,
            ZipCode = address.ZipCode
        };

        return reply;
    }
}
