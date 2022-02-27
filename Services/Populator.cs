using NhanceMap.Data.DataModels;
using NhanceMap.Data.DataModels.Improvables;
using NhanceMap.Data.DataModels.Improvements;
using NhanceMap.Data.ViewModels;

namespace NhanceMap.Services;

public static class Populator
{
    public static void Copy<T>(this T target, T source) where T : IImprovable, new()
    {
        target.Id = source.Id;
        target.Description = source.Description;
        target.Name = source.Name;
    }

    public static T1 Clone<T, T1>(this T source)
        where T1 : IImprovable, new()
        where T : IImprovable, new()
    {
        return new T1
        {
            Id = source.Id,
            Description = source.Description,
            Name = source.Name
        };
    }

    public static Suggestion GetSuggestion(this IHasSuggestionId s, Repository repo)
    {
        return repo.Suggestions.First(x => x.Id == s.SuggestionId);
    }

    public static PopulatedJourney Populate(this Journey journey, Repository repo)
    {
        var cloned = journey.Clone<Journey, PopulatedJourney>();

        cloned.PopulatedSteps = journey.Steps.Select(js => js.Clone<JourneyStep, PopulatedJourneyStep>()).ToList();

        cloned.PopulatedSteps.ForEach(step =>
        {
            var matchingSuggestions = repo.StepSuggestions.Where(sug => sug.StepId == step.Id).Select(s => s.SuggestionId);

            step.Suggestions = repo.Suggestions.Where(sug => matchingSuggestions.Contains(sug.Id));
        });

        return cloned;
    }

    public static PopulatedArea Populate(this Area area, Repository repo)
    {
        var cloned = area.Clone<Area, PopulatedArea>();

        var ideas = repo.AreaSuggestions.Where(ai => ai.AreaId == area.Id).Select(ai => ai.SuggestionId);

        cloned.Suggestions = repo.Suggestions.Where(i => ideas.Contains(i.Id));

        return cloned;
    }
}