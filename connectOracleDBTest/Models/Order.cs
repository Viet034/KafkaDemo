using connectOracleDBTest.Ultilites;
using System.Text.Json.Serialization;
using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Models;

public class Order
{
   
    public string Id { get; set; }
    public double TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public string CustomerId { get; set; }
    public string ProductId { get; set; }
    public long Offset { get; set; }
    public int Partition { get; set; }

}
