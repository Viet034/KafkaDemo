using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Services;

public interface ICustomerService
{
    public Task<IEnumerable<CustomerResponseDTO>> GetAllCustomerAsync();

    public Task<CustomerResponseDTO> UpdateCustomerAsync(string id, CustomerUpdateDTO update);
    public Task<CustomerResponseDTO> CreateCustomerAsync(CustomerCreateDTO create, long offset, int partition);
    public Task<bool> CreateCustomerProducerAsync(CustomerCreateDTO create);

}
