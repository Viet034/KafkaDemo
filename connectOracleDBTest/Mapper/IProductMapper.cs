using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using connectOracleDBTest.Models;

namespace connectOracleDBTest.Mapper;

public interface IProductMapper
{

    Product CreateToEntity(ProductCreateDTO create);
    Product UpdateToEntity(ProductUpdateDTO update);

    ProductResponseDTO EntityToResponse(Product entity);
    IEnumerable<ProductResponseDTO> ListEntityToResponse(IEnumerable<Product> entities);
}
