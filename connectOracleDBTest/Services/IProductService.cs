using connectOracleDBTest.Models.DTO.RequestDTO;
using connectOracleDBTest.Models.DTO.ResponseDTO;
using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Services;

public interface IProductService
{
    public Task<IEnumerable<ProductResponseDTO>> GetAllProductAsync();
    public Task<IEnumerable<ProductResponseDTO>> SearchProductByKeyAsync(string key);
    public Task<ProductResponseDTO> UpdateProductAsync(int id, ProductUpdateDTO update);
    public Task<ProductResponseDTO> CreateProductAsync(ProductCreateDTO create);
    public Task<bool> HardDeleteProductAsync(int id);

    //public Task<ProductResponseDTO> ChangeGenderAsync(int id, Gender newStatus);
    public Task<ProductResponseDTO> FindProductByIdAsync(int id);
    public Task<string> CheckUniqueCodeAsync();
}
