using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using Microsoft.AspNetCore.Http.HttpResults;

namespace connectOracleDBTest.Mapper.Implementation;

public class CustomerMapper : ICustomerMapper
{
    public Customer CreateToEntity(CustomerCreateDTO create)
    {
        Customer cus = new Customer();
        cus.Id = create.Id;
        cus.Name = create.Name;
        cus.Phone = create.Phone;
        cus.Gender = create.Gender;
        cus.Email = create.Email;
        return cus;
    }

    public CustomerResponseDTO EntityToResponse(Customer entity)
    {
        CustomerResponseDTO response = new CustomerResponseDTO();
        response.Id = entity.Id;
        response.Name = entity.Name;
        response.Phone = entity.Phone;
        response.Gender = entity.Gender;
        response.Email = entity.Email;
        return response;
    }

    public IEnumerable<CustomerResponseDTO> ListEntityToResponse(IEnumerable<Customer> entities)
    {
        return entities.Select(x => EntityToResponse(x)).ToList();
    }

    public Customer UpdateToEntity(CustomerUpdateDTO update)
    {
        Customer cus = new Customer();
        cus.Id = update.Id;
        cus.Name = update.Name;
        cus.Phone = update.Phone;
        cus.Gender = update.Gender;
        cus.Email = update.Email;
        return cus;
    } 
}
