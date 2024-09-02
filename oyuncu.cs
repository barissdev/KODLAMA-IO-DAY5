public class Player
{
    public int PlayerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalId { get; set; }
    public DateTime DateOfBirth { get; set; }
}

public interface IPlayerService
{
    void Register(Player player);
    void Update(Player player);
    void Delete(Player player);
}
