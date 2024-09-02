public interface IGovernmentValidationService
{
    bool Validate(Player player);
}

public class GovernmentValidationService : IGovernmentValidationService
{
    public bool Validate(Player player)
    {
        
        return player.NationalId.Length == 11 && player.DateOfBirth.Year < DateTime.Now.Year;
    }
}
