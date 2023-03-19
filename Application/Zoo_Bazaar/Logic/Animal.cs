namespace Logic
{
    public class Animal
    {
        //NEEDS TO BE UPDATED, USERFRIENDLY
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Dob { get; set; }

        public string BirthPlace { get; set; }

        public int FatherId { get; set; }

        public int MotherId { get; set; }

        public int LocationId { get; set; }

        public int DietId { get; set; }

        public string Species { get; set; }

        public string Type { get; set; }

        public string Sickness { get; set; }

        public string Notes { get; set; }

        public DateTime DeceasedDate { get; set; }

        public Animal(int id, string name, DateTime dob, string birthPlace, int fatherId, int motherId, int locationId, int dietId, string species, string type, string sickness, string notes, DateTime deceasedDate)
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