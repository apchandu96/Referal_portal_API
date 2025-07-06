namespace JobReferral.Domain.Entities;

public class Referrer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int Experience { get; set; }
    public int SuccessRate { get; set; }
}
