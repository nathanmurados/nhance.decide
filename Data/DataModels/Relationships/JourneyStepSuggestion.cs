using NhanceMap.Data.DataModels.Improvables;
using NhanceMap.Data.DataModels.Improvements;

namespace NhanceMap.Data.DataModels.Relationships;

public class JourneyStepSuggestion: IHasSuggestionId
{
    public JourneyStepSuggestion(JourneyStep js, Suggestion s)
    {
        SuggestionId = s.Id;
        StepId = js.Id;
    }
    public Guid StepId { get; set; }
    public Guid SuggestionId { get; set; }
}