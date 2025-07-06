namespace JobReferral.Domain.Entities;

public class Profile
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int ProfileComplete { get; set; }
}
