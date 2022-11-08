namespace AppliedActivity2.Models
{
    public class Province
    {
        public int Id { get; set; }
        public string NameEn { get; set; }

        public string NameFr { get; set; }

        public string SourceLink { get; set; }

        public string SourceEn { get; set; }

        public Province(int id, string nameEn, string nameFr, string sourceLink, string sourceEn)
        {
            Id = id;
            NameEn = nameEn;
            NameFr = nameFr;
            SourceLink = sourceLink;
            SourceEn = sourceEn;
        }
    }
}