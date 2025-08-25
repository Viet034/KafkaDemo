using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;

namespace connectOracleDBTest.Mapper;

public interface ICustomerMapper
{

    Customer CreateToEntity(CustomerCreateDTO create);
    Customer UpdateToEntity(CustomerUpdateDTO update);

    CustomerResponseDTO EntityToResponse(Customer entity);
    IEnumerable<CustomerResponseDTO> ListEntityToResponse(IEnumerable<Customer> entities);
}
