using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Services;

public interface IOrderService
{
    public Task<IEnumerable<OrderResponseDTO>> GetAllOrderAsync();
    //public Task<IEnumerable<OrderResponseDTO>> SearchOrderByKeyAsync(string key);
    //public Task<OrderResponseDTO> UpdateOrderAsync(int id, ProductUpdateDTO update);
    public Task<OrderResponseDTO> CreateOrderAsync(OrderCreateDTO create, long offset, int partition);
    public Task<bool> CreateOrderProducerAsync(OrderCreateDTO create);
    //public Task<bool> HardDeleteOrderAsync(int id);

    public Task<OrderResponseDTO> ChangeOrderStatusAsync(int id, OrderStatus newStatus);
    //public Task<OrderResponseDTO> FindOrderByIdAsync(int id);
    //public Task<string> CheckUniqueCodeAsync();
}
