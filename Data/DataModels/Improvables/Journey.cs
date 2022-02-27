namespace NhanceMap.Data.DataModels.Improvables;

public class Journey : IImprovable
{
    public Journey()
    {
        
    }
    public Journey(string name)
    {
        Name = name;
    }
    public Journey(string name, List<JourneyStep> steps)
    {
        Name = name;
        Steps = steps;
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public string? Description { get; set; }

    public List<JourneyStep> Steps { get; set; } = new();
}