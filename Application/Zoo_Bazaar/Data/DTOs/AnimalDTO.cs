using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataCL.DTOs
{
    public class AnimalDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Birthdate { get; set; }

        public string BirthPlace { get; set; }

        public int? FatherId { get; set; }

        public int? MotherId { get; set; }

        public string Location { get; set; }

        public string Diet { get; set; }

        public string Species { get; set; }

        public string Type { get; set; }

        public int Sick { get; set; }

        public string Notes { get; set; }

        public string? Deathdate { get; set; }

        public string ImageUrl { get; set; }

        public AnimalDTO()
        {

        }

        public AnimalDTO(int id, string name, string dob, string birthPlace, int? fatherId, int? motherId, string location, string diet, string species, string? type, int sick, string? notes, string? deathdate, string imageUrl)
        {
            Id = id;
            Name = name;
            Birthdate = dob;
            BirthPlace = birthPlace;
            FatherId = fatherId;
            MotherId = motherId;
            Location = location;
            Diet = diet;
            Species = species;
            Type = type;
            Sick = sick;
            Notes = notes;
            Deathdate = deathdate;
            ImageUrl = imageUrl;
        }
    }
}
