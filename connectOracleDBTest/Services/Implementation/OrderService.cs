using Confluent.Kafka;
using connectOracleDBTest.Data;
using connectOracleDBTest.Mapper;
using connectOracleDBTest.Models.DTO.EntityDTO;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using connectOracleDBTest.Ultilites;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace connectOracleDBTest.Services.Implementation;

public class OrderService : IOrderService
{
    private readonly IOrderMapper _mapper;
    private ILogger<OrderDTO> _logger;
    private readonly IServiceScopeFactory _scope;
    private readonly ApplicationDbContext _context;
    private readonly IProducerService _producer;

    public OrderService(IOrderMapper mapper, ILogger<OrderDTO> logger, IServiceScopeFactory scope, ApplicationDbContext context, IProducerService producer)
    {
        _mapper = mapper;
        _logger = logger;
        _scope = scope;
        _context = context;
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

    public async Task<OrderResponseDTO> CreateOrderAsync(OrderCreateDTO create, long offset, int partition)
    {
        //var scope = _scope.CreateScope();
        //var dbcontext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        var pro = await _context.Products.FirstOrDefaultAsync(c=>c.Id == create.ProductId)
            ?? throw new KeyNotFoundException("Không có sản phẩm nào");
        var cus = await _context.Customers.FirstOrDefaultAsync(c => c.Id == create.CustomerId)
            ?? throw new KeyNotFoundException("Không có khách hàng nào");

        var co = _mapper.CreateToEntity(create);
        co.Offset = offset;
        co.Partition = partition;
        await _context.Orders.AddAsync(co);
        await _context.SaveChangesAsync();
        var response = _mapper.EntityToResponse(co);
        return response;
    }

    //public Task<OrderResponseDTO> FindOrderByIdAsync(int id)
    //{
    //    throw new NotImplementedException();
    //}

    public async Task<IEnumerable<OrderResponseDTO>> GetAllOrderAsync()
    {
        var co = await _context.Orders.ToListAsync();
        var response = _mapper.ListEntityToResponse(co);
        return response;
    }

    

    public async Task<bool> CreateOrderProducerAsync(OrderCreateDTO create)
    {
        //Produce message vào topic OrderCreated
        var topic = "PaymentCreated";

        var result = await _producer.ProducerKafka<OrderCreateDTO>(topic, create.Id, create);
        ///

        return true;
    }

    //public Task<bool> HardDeleteOrderAsync(int id)
    //{
    //    throw new NotImplementedException();
    //}

    //public Task<IEnumerable<OrderResponseDTO>> SearchOrderByKeyAsync(string key)
    //{
    //    throw new NotImplementedException();
    //}
}
