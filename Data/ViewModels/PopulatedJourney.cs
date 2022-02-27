using Nhance.Decide.Data.DataModels;

namespace Nhance.Decide.Data.ViewModels;

public class PopulatedJourney : IImprovable
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public List<PopulatedJourneyStep> PopulatedSteps { get; set; } = new List<PopulatedJourneyStep>();    
}