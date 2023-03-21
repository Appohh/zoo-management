namespace Logic
{
    public class Animal
    {
        //NEEDS TO BE UPDATED, USERFRIENDLY
        public int Id { get; set; }

        public string Name { get; set; }

        public string Birthdate { get; set; }

        public string BirthPlace { get; set; }

        public int FatherId { get; set; }

        public int MotherId { get; set; }

        public int LocationId { get; set; }

        public int DietId { get; set; }

        public string Species { get; set; }

        public string Type { get; set; }

        public string Sick { get; set; }

        public string Notes { get; set; }

        public string DeceasedDate { get; set; }

        public Animal(int id, string name, string dob, string birthPlace, int fatherId, int motherId, int locationId, int dietId, string species, string type, string sickness, string notes, DateTime deceasedDate)
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