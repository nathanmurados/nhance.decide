namespace Nhance.Decide.Data.DataModels.Improvements;

public class Suggestion : IImprovement, IHasDescription
{
    public Guid Id { get; set; }

    public string Headline { get; set; }

    public string? Description { get; set; }

    public int WeightOfPotential { get; set; }
}