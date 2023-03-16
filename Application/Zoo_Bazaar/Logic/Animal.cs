namespace Logic
{
    public class Animal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Dob { get; set; }

        public string BirthPlace { get; set; }

        public int FatherId { get; set; }

        public int MotherId { get; set; }

        public int LocationId { get; set; }

        public int DietId { get; set; }

        public Species Species { get; set; }

        public Type Type { get; set; }

        public string Sickness { get; set; }

        public string Notes { get; set; }

        public DateTime DeceasedDate { get; set; }

        public Animal(int id, string name, DateTime dob, string birthPlace, int fatherId, int motherId, int locationId, int dietId, Species species, Type type, string sickness, string notes, DateTime deceasedDate)
        {
            Id = id;
            Name = name;
            Dob = dob;
            BirthPlace = birthPlace;
            FatherId = fatherId;
            MotherId = motherId;
            LocationId = locationId;
            DietId = dietId;
            Species = species;
            Type = type;
            Sickness = sickness;
            Notes = notes;
            DeceasedDate = deceasedDate;
        }
    }
}