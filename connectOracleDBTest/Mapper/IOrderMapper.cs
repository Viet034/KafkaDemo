using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using connectOracleDBTest.Models;

namespace connectOracleDBTest.Mapper;

public interface IOrderMapper
{
    Order CreateToEntity(OrderCreateDTO create);
    OrderResponseDTO EntityToResponse(Order entity);
    IEnumerable<OrderResponseDTO> ListEntityToResponse(IEnumerable<Order> entities);
}
