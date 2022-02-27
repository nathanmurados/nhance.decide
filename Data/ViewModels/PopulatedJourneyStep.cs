using Nhance.Decide.Data.DataModels;
using Nhance.Decide.Data.DataModels.Improvements;

namespace Nhance.Decide.Data.ViewModels;

public class PopulatedJourneyStep : IImprovable
{
    public Guid Id { get; set; }
    
    public string? Description { get; set; }
    
    public string? Name { get; set; }

    public IEnumerable<Suggestion> Suggestions { get; set; } = new List<Suggestion>();
}