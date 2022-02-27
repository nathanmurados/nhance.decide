namespace NhanceMap.Data.DataModels.Relationships;

public class AreaSuggestion : IHasSuggestionId
{
    public Guid AreaId { get; set; }
    public Guid SuggestionId { get; set; }
}