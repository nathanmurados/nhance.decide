namespace NhanceMap.Data.DataModels.Improvables;

public class JourneyStep : IImprovable
{
    public JourneyStep()
    {
        
    }
    public JourneyStep(string name)
    {
        Name = name;
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}