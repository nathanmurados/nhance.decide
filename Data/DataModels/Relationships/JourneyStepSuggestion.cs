using Nhance.Decide.Data.DataModels.Improvables;
using Nhance.Decide.Data.DataModels.Improvements;

namespace Nhance.Decide.Data.DataModels.Relationships;

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