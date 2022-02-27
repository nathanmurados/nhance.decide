namespace NhanceMap.Data.DataModels.Improvables
{
    public class Avatar : IImprovable
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImgSrc { get; set; }
    }
}