using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Models;

public class Customer
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public Gender Gender { get; set; }
    public string Email { get; set; }   
    public long Offset { get; set; }
    public int Partition { get; set; }

}
