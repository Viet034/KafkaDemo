using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Models.DTO.RequestDTO;

public class OrderCreateDTO
{
    public string Id { get; set; }
    public double TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public string CustomerId { get; set; }
    public string ProductId { get; set; }

}
