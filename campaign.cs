public class Campaign
{
    public int CampaignId { get; set; }
    public string Name { get; set; }
    public decimal DiscountRate { get; set; }
}

public interface ICampaignService
{
    void Add(Campaign campaign);
    void Update(Campaign campaign);
    void Delete(Campaign campaign);
}

public class CampaignService : ICampaignService
{
    private List<Campaign> _campaigns = new List<Campaign>();

    public void Add(Campaign campaign)
    {
        _campaigns.Add(campaign);
        Console.WriteLine($"Campaign '{campaign.Name}' added.");
    }

    public void Update(Campaign campaign)
    {
        var existingCampaign = _campaigns.FirstOrDefault(c => c.CampaignId == campaign.CampaignId);
        if (existingCampaign != null)
        {
            existingCampaign.Name = campaign.Name;
            existingCampaign.DiscountRate = campaign.DiscountRate;
            Console.WriteLine($"Campaign '{campaign.Name}' updated.");
        }
    }

    public void Delete(Campaign campaign)
    {
        _campaigns.Remove(campaign);
        Console.WriteLine($"Campaign '{campaign.Name}' deleted.");
    }
}
