namespace NhanceMap.Data.DataModels;

public interface IImprovement : IIdentifiable, IHasDescription
{
    string? Headline { get; set; }

    int WeightOfPotential { get; set; }
}