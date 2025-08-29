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

public class OrderProducer 
{
    private readonly ApplicationDbContext _context;
    private readonly IOrderMapper _mapper;
    private readonly IProducerService _producer;

    public OrderProducer(ApplicationDbContext context, IOrderMapper mapper, IProducerService producer)
    {
        _context = context;
        _mapper = mapper;
        _producer = producer;
    }
     
    public async Task<OrderResponseDTO> ChangeOrderStatusAsync(int id, Status.OrderStatus newStatus)
    {
        var or = await _context.Orders.FindAsync(id)
            ?? throw new KeyNotFoundException($"Không tìm thấy {id}");
        or.Status = newStatus;
        _ = await _context.SaveChangesAsync();
        var response = _mapper.EntityToResponse(or);
        return response;
    }

    public Task<string> CheckUniqueCodeAsync()
    {
        throw new NotImplementedException();
    }

    //public Task<bool> CreateOrderAsync(OrderCreateDTO create)
    //{
    //    throw new NotImplementedException();
    //}

    public async Task<bool> CreateOrderProducerAsync(OrderCreateDTO create)
    {
        
        //Produce message vào topic OrderCreated
        var topic = "PaymentCreated";
        
        var result = await _producer.ProducerKafka<OrderCreateDTO>(topic, create.Id, create);
        ///
        
        return true;
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
