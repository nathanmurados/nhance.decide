using NhanceMap.Data.DataModels;
using NhanceMap.Data.DataModels.Improvements;

namespace NhanceMap.Data.ViewModels;

public class PopulatedJourneyStep : IImprovable
{
    public Guid Id { get; set; }
    
    public string? Description { get; set; }
    
    public string? Name { get; set; }

    public IEnumerable<Suggestion> Suggestions { get; set; } = new List<Suggestion>();
}