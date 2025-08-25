using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Models;

public class Order
{
    public int Id { get; set; }
    public double TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public long Offset { get; set; }
    public int Partition { get; set; }

}
