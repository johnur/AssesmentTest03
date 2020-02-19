using System;

namespace AssessmentTest03.Domain
{
    public class PoliticalParty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Founded { get; set; }
        public int? Members { get; set; }
        public string AbbreviatedName { get; set; }
        public Person Chairman { get; set; }
        public Country Country { get; set; }
    }
}
