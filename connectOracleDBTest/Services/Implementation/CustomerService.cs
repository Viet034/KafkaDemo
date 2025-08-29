using connectOracleDBTest.Data;
using connectOracleDBTest.Mapper;
using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using connectOracleDBTest.Ultilites;
using Microsoft.EntityFrameworkCore;

namespace connectOracleDBTest.Services.Implementation;

public class CustomerService : ICustomerService
{
    private readonly ApplicationDbContext _context;
    private readonly ICustomerMapper _mapper;
    private readonly IProducerService _producer;

    public CustomerService(ApplicationDbContext context, ICustomerMapper mapper, IProducerService producer)
    {
        _context = context;
        _mapper = mapper;
        _producer = producer;
    }


    public async Task<CustomerResponseDTO> CreateCustomerAsync(CustomerCreateDTO create)
    {
        var topic = "CustomerCreated";
        var result = await _producer.ProducerKafka<CustomerCreateDTO>(topic, create.Id, create);
        Customer customer = _mapper.CreateToEntity(create);
        customer.Offset = result.Offset;
        customer.Partition = result.Partition;
        
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
        var response = _mapper.EntityToResponse(customer);
        return response;

    }

    public async Task<CustomerResponseDTO> CreateCustomerAsync(CustomerCreateDTO create, long offset, int partition)
    {
        Customer customer = _mapper.CreateToEntity(create);
        customer.Offset = offset;
        customer.Partition = partition;

        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
        var response = _mapper.EntityToResponse(customer);
        return response;
    }

    public async Task<bool> CreateCustomerProducerAsync(CustomerCreateDTO create)
    {
        //Produce message vào topic OrderCreated
        var topic = "PaymentCreated";

        var result = await _producer.ProducerKafka<CustomerCreateDTO>(topic, create.Id, create);
        ///

        return true;
    }

    public async Task<IEnumerable<CustomerResponseDTO>> GetAllCustomerAsync()
    {
        var cu = await _context.Customers.ToListAsync();
        var response = _mapper.ListEntityToResponse(cu);
        return response;
    }


    public Task<CustomerResponseDTO> UpdateCustomerAsync(string id, CustomerUpdateDTO update)
    {
        throw new NotImplementedException();
    }
}
