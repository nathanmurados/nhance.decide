using Nhance.Decide.Data.ViewModels;

namespace Nhance.Decide.Services;

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