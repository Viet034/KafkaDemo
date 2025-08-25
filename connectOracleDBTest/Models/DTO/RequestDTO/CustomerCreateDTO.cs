using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Models.DTO.RequestDTO;

public class CustomerCreateDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public Gender Gender { get; set; }
    public string Email { get; set; }

}
