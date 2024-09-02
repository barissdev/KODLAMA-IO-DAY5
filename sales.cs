public class Game
{
    public int GameId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public interface ISalesService
{
    void Sell(Game game, Player player, Campaign campaign = null);
}

public class SalesService : ISalesService
{
    public void Sell(Game game, Player player, Campaign campaign = null)
    {
        decimal finalPrice = game.Price;
        if (campaign != null)
        {
            finalPrice -= (game.Price * campaign.DiscountRate / 100);
        }
        Console.WriteLine($"Game '{game.Name}' sold to {player.FirstName} {player.LastName} for {finalPrice:C}.");
    }
}
