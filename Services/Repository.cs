using Nhance.Decide.Data.DataModels.Improvables;
using Nhance.Decide.Data.DataModels.Improvements;
using Nhance.Decide.Data.DataModels.Relationships;

namespace Nhance.Decide.Services;

public class Repository
{
    public List<Avatar> Avatars { get; set; }
    public List<Area> Areas { get; set; }
    public List<Journey> Journeys { get; set; }

    public List<Suggestion> Suggestions { get; set; }

    public List<JourneyStepSuggestion> StepSuggestions { get; set; }
    public List<AreaSuggestion> AreaSuggestions { get; set; }

    public Repository()
    {
        Avatars = new List<Avatar>()
        {
            new()
            {
                Name = "VIP Customers",
                ImgSrc = "https://eu.ui-avatars.com/api/?name=VIP+Customers"
            },

            new()
            {
                Name = "Mexicans",
                ImgSrc = "https://eu.ui-avatars.com/api/?name=Mexicans"
            }
        };

        var j1S1 = new JourneyStep("Step 1");
        
        var j2S1 = new JourneyStep("Step 1");
        
        var j3S1 = new JourneyStep("Step 1");

        var j4S1 = new JourneyStep("Decide what the focus of the software is");
        var j4S2 = new JourneyStep("Create PoC");
        var j4S3 = new JourneyStep("Improve until happy to release");
        var j4S4 = new JourneyStep("Release software");
        var j4S5 = new JourneyStep("Market software");

        var j6S1 = new JourneyStep("Step 1");

        var j1 = new Journey("Sell Software", new List<JourneyStep> { j1S1 });
        var j2 = new Journey("Sell Courses", new List<JourneyStep> { j2S1 });
        var j3 = new Journey("Hire Staff", new List<JourneyStep> { j3S1 });
        var j4 = new Journey("Create New Software", new List<JourneyStep> { j4S1,j4S2,j4S3,j4S4,j4S5 });
        var j5 = new Journey("Disassociate income from time");
        var j6 = new Journey("Research free energy", new List<JourneyStep> { j6S1 });

        Journeys = new List<Journey> { j1, j2, j3, j4, j5, j6 };

        Areas = new List<Area>
        {
            new() { Name = "Image Capture" },
            new() { Name = "Calibration" },
            new() { Name = "Maintenance", Icon = "wrench" }
        };

        Suggestions = new List<Suggestion>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Headline = "Create PoC",
                WeightOfPotential = 4
            },
            new()
            {
                Id = Guid.NewGuid(),
                Headline = "Define a course",
                WeightOfPotential = 8
            },
            new()
            {
                Id = Guid.NewGuid(),
                Headline = "Create separated suggestion map",
                WeightOfPotential = 4
            },
            new()
            {
                Id = Guid.NewGuid(),
                Headline = "Create separated planning tool",
                WeightOfPotential = 8
            },
            new()
            {
                Id = Guid.NewGuid(),
                Headline = "Ask friends",
                WeightOfPotential = 20
            },
            new()
            {
                Id = Guid.NewGuid(),
                Headline = "Do the work",
                WeightOfPotential = 2
            },
            new()
            {
                Id = Guid.NewGuid(),
                Headline = "Try infrascopic tech.",
                WeightOfPotential = 8
            },
            new()
            {
                Id = Guid.NewGuid(),
                Headline = "Use automated laser calibration",
                WeightOfPotential = 20
            },
            new()
            {
                Id = Guid.NewGuid(),
                Headline = "Use automated grease injection",
                WeightOfPotential = 2
            }
        };

        // Give everything an ID
        Suggestions.ForEach(s => s.AddIdAndDescription());
        Areas.ForEach(a => a.AddIdAndDescription());
        Journeys.ForEach(j => { j.AddIdAndDescription(); j.Steps.ForEach(js => js.AddIdAndDescription()); });
        Avatars.ForEach(a => a.AddIdAndDescription());

        // Stitch them together
        StepSuggestions = new List<JourneyStepSuggestion>
        {
            new(j1S1, Suggestions[2]),
            new(j1S1, Suggestions[3]),
            new(j1S1, Suggestions[0]),
            new(j2S1, Suggestions[5]),
            new(j3S1, Suggestions[4]),
            new(j4S3, Suggestions[1])
        };

        AreaSuggestions = new List<AreaSuggestion>
        {
            new ()
            {
                AreaId = Journeys[0].Id,
                SuggestionId = Suggestions[6].Id
            },
            new ()
            {
                AreaId = Journeys[1].Id,
                SuggestionId = Suggestions[7].Id
            },
            new ()
            {
                AreaId = Journeys[2].Id,
                SuggestionId = Suggestions[8].Id
            }
        };
    }
}