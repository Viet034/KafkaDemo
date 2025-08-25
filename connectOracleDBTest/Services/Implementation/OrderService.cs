using connectOracleDBTest.Data;
using connectOracleDBTest.Mapper;
using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using connectOracleDBTest.Ultilites;
using Microsoft.EntityFrameworkCore;
using Confluent.Kafka;
using Microsoft.AspNetCore.Http.HttpResults;
using static Confluent.Kafka.ConfigPropertyNames;

namespace connectOracleDBTest.Services.Implementation;

public class OrderService : IOrderService
{
    private readonly ApplicationDbContext _context;
    private readonly IOrderMapper _mapper;
    private readonly IProducerService _producer;

    public OrderService(ApplicationDbContext context, IOrderMapper mapper, IProducerService producer)
    {
        _context = context;
        _mapper = mapper;
        _producer = producer;
    }
     
    public Task<OrderResponseDTO> ChangeOrderStatusAsync(int id, Status.OrderStatus newStatus)
    {
        throw new NotImplementedException();
    }

    public Task<string> CheckUniqueCodeAsync()
    {
        throw new NotImplementedException();
    }
    
    public async Task<OrderResponseDTO> CreateOrderAsync(OrderCreateDTO create)
    {
        var cusID = await _context.Customers.FindAsync(create.CustomerId)
            ?? throw new KeyNotFoundException($"Không có customer với Id {create.CustomerId}");
        var proID = await _context.Products.FindAsync(create.ProductId)
            ?? throw new KeyNotFoundException($"Không có Product nào với Id {create.ProductId}");

        var topic = "OrderCreated";
        
        var result = await _producer.ProducerKafka<OrderCreateDTO>(topic, create.Id, create);
        
        Order order = _mapper.CreateToEntity(create);
        order.Offset = result.Offset;
        order.Partition = result.Partition;

        _ = await _context.Orders.AddAsync(order);
        _ = await _context.SaveChangesAsync();
        
        var response = _mapper.EntityToResponse(order);
        Console.WriteLine($"topic: {result.ToString()},{order.Offset}, {order.Partition}");
        return response;
    }
    public Task<OrderResponseDTO> FindOrderByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<OrderResponseDTO>> GetAllOrderAsync()
    {
        var order = await _context.Orders.ToListAsync();
        var response = _mapper.ListEntityToResponse(order);
        return response;

    }

    public Task<bool> HardDeleteOrderAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderResponseDTO>> SearchOrderByKeyAsync(string key)
    {
        throw new NotImplementedException();
    }
    
}
