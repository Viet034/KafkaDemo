using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using Microsoft.AspNetCore.Http.HttpResults;

namespace connectOracleDBTest.Mapper.Implementation;

public class OrderMapper : IOrderMapper
{
    public Order CreateToEntity(OrderCreateDTO create)
    {
        Order order = new Order();
        order.Id = create.Id;
        order.TotalAmount = create.TotalAmount;
        order.Status = create.Status;
        order.CustomerId = create.CustomerId;
        order.ProductId = create.ProductId;
        return order;

    }

    public OrderResponseDTO EntityToResponse(Order entity)
    {
        OrderResponseDTO response = new OrderResponseDTO();
        response.Id = entity.Id;
        response.TotalAmount = entity.TotalAmount;
        response.Status = entity.Status;
        response.CustomerId = entity.CustomerId;
        response.ProductId = entity.ProductId;
        return response;
    }

    public IEnumerable<OrderResponseDTO> ListEntityToResponse(IEnumerable<Order> entities)
    {
        return entities.Select(x => EntityToResponse(x)).ToList();
    }
}
