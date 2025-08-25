using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Services;

public interface ICustomerService
{
    public Task<IEnumerable<CustomerResponseDTO>> GetAllCustomerAsync();
    public Task<IEnumerable<CustomerResponseDTO>> SearchCustomerByKeyAsync(string key);
    public Task<CustomerResponseDTO> UpdateCustomerAsync(int id, CustomerUpdateDTO update);
    public Task<CustomerResponseDTO> CreateCustomerAsync(CustomerCreateDTO create);
    public Task<bool> HardDeleteCustomerAsync(int id);

    public Task<CustomerResponseDTO> ChangeGenderAsync(int id, Gender newStatus);
    public Task<CustomerResponseDTO> FindCustomerByIdAsync(int id);
    public Task<string> CheckUniqueCodeAsync();
}
