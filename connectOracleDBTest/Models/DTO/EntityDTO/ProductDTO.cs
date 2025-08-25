namespace connectOracleDBTest.Models.DTO.EntityDTO;

public class ProductDTO
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public long Offset { get; set; }
    public int Partition { get; set; }
}
