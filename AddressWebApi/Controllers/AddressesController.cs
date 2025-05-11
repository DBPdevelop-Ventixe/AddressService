using AddressWebApi.Entities;
using AddressWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddressWebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddressesController(AddressService addressService) : ControllerBase
{
    private readonly AddressService _addressService = addressService;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAddress(string id)
    {
        var address = await _addressService.GetAddress(id);
        if (address == null)
            return NotFound();

        return Ok(address);
    }

    [HttpPost]
    public async Task<IActionResult> AddAddress([FromBody] AddressEntity address)
    {
        if (address == null)
            return BadRequest("Address cannot be null");

        var result = await _addressService.AddAddress(address);
        if (!result)
            return StatusCode(500, "Internal server error");

        return Ok(result);
    }
}
