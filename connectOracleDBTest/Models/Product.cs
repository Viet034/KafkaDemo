using System.Runtime.CompilerServices;

namespace connectOracleDBTest.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price {get; set;}
    public int Quantity { get; set; }
    public long Offset { get; set; }
    public int Partition { get; set; }
}
