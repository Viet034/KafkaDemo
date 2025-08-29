using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace connectOracleDBTest.Controller;
[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _service;

    public CustomerController(ICustomerService service)
    {
        _service = service;
    }

    [HttpPost("add-Customer")]
    [ProducesResponseType(typeof(IEnumerable<Customer>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
    //[Authorize(Roles = "Admin,Nurse")]
    public async Task<IActionResult> AddCustomer([FromBody] CustomerCreateDTO create)
    {
        try
        {
            var response = await _service.CreateCustomerProducerAsync(create);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpGet("get-all")]
    [ProducesResponseType(typeof(IEnumerable<Customer>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
    public async Task<ActionResult<IEnumerable<Customer>>> GetAllCustomer()
    {
        try
        {
            var response = await _service.GetAllCustomerAsync();
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }
}
