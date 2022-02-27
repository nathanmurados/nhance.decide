namespace Nhance.Decide.Data.DataModels;

public interface IImprovable : IIdentifiable, IHasDescription
{
    string? Name { get; set; }
}