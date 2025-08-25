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

    public async Task<CustomerResponseDTO> ChangeGenderAsync(int id, Status.Gender newStatus)
    {
        var cuId = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id)
            ?? throw new KeyNotFoundException($"Không tồn tại key {id}");
        cuId.Gender = newStatus;

        await _context.SaveChangesAsync();
        var response = _mapper.EntityToResponse(cuId);
        return response;
    }

    public Task<string> CheckUniqueCodeAsync()
    {
        throw new NotImplementedException();
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

    public Task<CustomerResponseDTO> FindCustomerByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CustomerResponseDTO>> GetAllCustomerAsync()
    {
        var cu = await _context.Customers.ToListAsync();
        var response = _mapper.ListEntityToResponse(cu);
        return response;
    }

    public Task<bool> HardDeleteCustomerAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CustomerResponseDTO>> SearchCustomerByKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerResponseDTO> UpdateCustomerAsync(int id, CustomerUpdateDTO update)
    {
        throw new NotImplementedException();
    }
}
