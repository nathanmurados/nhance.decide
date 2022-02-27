using NhanceMap.Data.ViewModels;

namespace NhanceMap.Services;

public static class PotentialCalculator
{
    public static int Potential(this PopulatedJourney j)
    {
        return j.PopulatedSteps.Sum(ps => ps.Suggestions.Sum(s => s.WeightOfPotential));
    }
    public static int Potential(this PopulatedJourneyStep j)
    {
        return j.Suggestions.Sum(s => s.WeightOfPotential);
    }

    public static int Potential(this PopulatedArea j)
    {
        return j.Suggestions.Sum(i => i.WeightOfPotential);
    }
}