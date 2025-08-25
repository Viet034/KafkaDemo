using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using Microsoft.AspNetCore.Http.HttpResults;

namespace connectOracleDBTest.Mapper.Implementation;

public class ProductMapper : IProductMapper
{
    public Product CreateToEntity(ProductCreateDTO create)
    {
        Product product = new Product();
        product.Id = create.Id;
        product.Name = create.Name;
        product.Description = create.Description;
        product.Price = create.Price;
        product.Quantity = create.Quantity;

        return product;
    }

    public ProductResponseDTO EntityToResponse(Product entity)
    {
        ProductResponseDTO response = new ProductResponseDTO();
        response.Id = entity.Id;
        response.Name = entity.Name;
        response.Description = entity.Description;
        response.Price = entity.Price;
        response.Quantity = entity.Quantity;
        return response;
    }

    public IEnumerable<ProductResponseDTO> ListEntityToResponse(IEnumerable<Product> entities)
    {
        return entities.Select(x => EntityToResponse(x)).ToList();
    }

    public Product UpdateToEntity(ProductUpdateDTO update)
    {
        Product product = new Product();
        product.Id = update.Id;
        product.Name = update.Name;
        product.Description = update.Description;
        product.Price = update.Price;
        product.Quantity = update.Quantity;
        return product;
    }
}
