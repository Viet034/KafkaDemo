using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Controller;
[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _service;

    public OrderController(IOrderService service)
    {
        _service = service;
    }
    /// <summary>
    /// Tạo hóa đơn mới
    /// </summary>
    /// <param name="create"> Truyền vào các tham số </param>
    /// <returns> </returns>
    [HttpPost("create-order")]
    [ProducesResponseType(typeof(IEnumerable<Order>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
    //[Authorize(Roles = "Admin,Nurse")]
    public async Task<IActionResult> CreateOrder([FromBody] OrderCreateDTO create)
    {
        try
        {
            var response = await _service.CreateOrderProducerAsync(create);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpGet("get-all")]
    [ProducesResponseType(typeof(IEnumerable<Order>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
    public async Task<ActionResult<IEnumerable<Order>>> GetAllOrder()
    {
        try
        {
            var response = await _service.GetAllOrderAsync();
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpPut("cahnge")]
    [ProducesResponseType(typeof(IEnumerable<Order>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> ChangeStatus(int id, OrderStatus orderStatus)
    {
        try
        {
            var response = await _service.ChangeOrderStatusAsync(id, orderStatus);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

}
