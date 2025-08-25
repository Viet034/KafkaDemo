using connectOracleDBTest.Data;
using connectOracleDBTest.Mapper;
using connectOracleDBTest.Models;
using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using Microsoft.EntityFrameworkCore;

namespace connectOracleDBTest.Services.Implementation;

public class ProductService : IProductService
{
    private readonly ApplicationDbContext _context;
    private readonly IProductMapper _mapper;
    private readonly IProducerService _producer;

    public ProductService(ApplicationDbContext context, IProductMapper mapper, IProducerService producer)
    {
        _context = context;
        _mapper = mapper;
        _producer = producer;
    }
    public Task<string> CheckUniqueCodeAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ProductResponseDTO> CreateProductAsync(ProductCreateDTO create)
    {
        var topic = "ProductCreated";
        var result = await _producer.ProducerKafka<ProductCreateDTO>(topic, create.Id, create);
        Product product = _mapper.CreateToEntity(create);
        product.Offset = result.Offset;
        product.Partition = result.Partition;
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        var response = _mapper.EntityToResponse(product);
        return response;
    }

    public Task<ProductResponseDTO> FindProductByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ProductResponseDTO>> GetAllProductAsync()
    {
        var cu = await _context.Products.ToListAsync();
        var response = _mapper.ListEntityToResponse(cu);
        return response;
    }

    public Task<bool> HardDeleteProductAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductResponseDTO>> SearchProductByKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductResponseDTO> UpdateProductAsync(int id, ProductUpdateDTO update)
    {
        var cuId = await _context.Products.FindAsync(id)
            ?? throw new KeyNotFoundException($"Không có Id {id}");
        var result = _mapper.UpdateToEntity(update);
        result.Name = update.Name;
        result.Description = update.Description;
        result.Quantity = update.Quantity;
        result.Price = update.Price;
        var response = _mapper.EntityToResponse(cuId);
        return response;

        
    }
}
