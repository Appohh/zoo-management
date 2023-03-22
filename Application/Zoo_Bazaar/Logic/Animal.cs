﻿namespace Logic
{
    public class Animal
    {
        //NEEDS TO BE UPDATED, USERFRIENDLY
        public int Id { get; set; }

        public string Name { get; set; }

        public string Birthdate { get; set; }

        public string BirthPlace { get; set; }

        public int? FatherId { get; set; }

        public int? Mother { get; set; }

        public string Location { get; set; }

        public string Diet { get; set; }

        public string Species { get; set; }

        public string Type { get; set; }

        public int Sick { get; set; }

        public string Notes { get; set; }

        public string? DeceasedDate { get; set; }

        public string ImageUrl { get; set; }




        public Animal(int id, string name, string birthdate, string birthPlace, int? fatherId, int? motherId, string location, string diet, string species, string type, int sick, string notes, string? deathdate, string imageUrl)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
            BirthPlace = birthPlace;
            FatherId = fatherId;
            Mother = motherId;
            Location = location;
            Diet = diet;
            Species = species;
            Type = type;
            Sick = sick;
            Notes = notes;
            DeceasedDate = deathdate;
            ImageUrl = imageUrl;

        }
    }
}