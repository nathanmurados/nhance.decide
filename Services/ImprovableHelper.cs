using Nhance.Decide.Data.DataModels;

namespace Nhance.Decide.Services;

internal static class ImprovableHelper
{
    private const string Description =
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ultrices ligula a euismod convallis. Quisque consectetur diam id condimentum euismod. Aliquam velit enim, ornare eu lobortis et, convallis id nibh. Pellentesque habitant morbi tristique senectus et netus et malesuada fames.";

    public static void AddIdAndDescription<T>(this T imp) where T : IIdentifiable, IHasDescription
    {
        imp.Id = Guid.NewGuid();
        imp.Description = Description;
    }
}