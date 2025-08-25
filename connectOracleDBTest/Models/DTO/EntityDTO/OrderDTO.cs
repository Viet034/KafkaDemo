namespace connectOracleDBTest.Models.DTO.EntityDTO;

public class OrderDTO
{
    public string Id { get; set; }
    public double TotalAmount { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public long Offset { get; set; }
    public int Partition { get; set; }
}
