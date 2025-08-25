using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Models.DTO.ResponseDTO;

public class OrderResponseDTO
{
    public int Id { get; set; }
    public double TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }

}
