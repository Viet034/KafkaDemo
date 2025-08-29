
using Confluent.Kafka;
using connectOracleDBTest.Data;
using connectOracleDBTest.Mapper;
using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.EntityDTO;
using connectOracleDBTest.Models.DTO.RequestDTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace connectOracleDBTest.Services.Implementation;

public class OrderCreatedConsumer : ConsumerGenericService<string, OrderCreateDTO>
{
    private readonly IServiceScopeFactory _scope;
    


    public OrderCreatedConsumer(IConfiguration config, IServiceScopeFactory scope)
        : base(config, "PaymentCreated", "PaymentCreatedId")
    {
        _scope = scope;
       
    }

    protected override async Task HandleMessage(string key, OrderCreateDTO value,long offset, int partition)
    {
        
        Console.WriteLine($"[OrderCreatedConsumer] Key={key}, Value={JsonSerializer.Serialize(value)}");
        var scope = _scope.CreateScope();
        //cách 1 tách logic
        var service = scope.ServiceProvider.GetRequiredService<IOrderService>();
        await service.CreateOrderAsync(value, offset, partition);

        //cách 2 làm trực tiếp
        //var scopemap = scope.ServiceProvider.GetRequiredService<IOrderMapper>();

        //var pro = await service.Products.FirstOrDefaultAsync(c => c.Id == value.ProductId)
        //    ?? throw new KeyNotFoundException("Không có sản phẩm nào");
        //var cus = await service.Customers.FirstOrDefaultAsync(c => c.Id == value.CustomerId)
        //    ?? throw new KeyNotFoundException("Không có khách hàng nào");

        //var co = scopemap.CreateToEntity(value);
        //co.Offset = offset;
        //co.Partition = partition;

        //await service.Orders.AddAsync(co);
        //await service.SaveChangesAsync();
        //var response = scopemap.EntityToResponse(co);

        await Task.CompletedTask;
    }
}
