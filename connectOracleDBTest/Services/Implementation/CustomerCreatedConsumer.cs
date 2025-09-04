using connectOracleDBTest.Models.DTO.RequestDTO;

namespace connectOracleDBTest.Services.Implementation;

public class CustomerCreatedConsumer : ConsumerGenericService<string, CustomerCreateDTO>
{
    private readonly IServiceScopeFactory _scope;

    public CustomerCreatedConsumer(IConfiguration config, IServiceScopeFactory scope)
        : base(config, "CustomerCreation", "CustomerCreationId")
    {
        _scope = scope;

    }

    protected override async Task HandleMessage(string key, CustomerCreateDTO value, long offset, int partition)
    {
        var scope = _scope.CreateScope();
        var service = scope.ServiceProvider.GetRequiredService<ICustomerService>();
        await service.CreateCustomerAsync(value, offset, partition);
        await Task.CompletedTask;

    }
}
