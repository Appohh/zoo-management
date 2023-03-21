﻿using System;
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

        public int LocationId { get; set; }

        public int DietId { get; set; }

        public int Species { get; set; }

        public string Type { get; set; }

        public int Sickness { get; set; }

        public string Notes { get; set; }

        public string? Deathdate { get; set; }

        public string ImageUrl { get; set; }

        public AnimalDTO()
        {

        }

        public AnimalDTO(int id, string name, string dob, string birthPlace, int? fatherId, int? motherId, int locationId, int dietId, int species, string? type, int sickness, string? notes, string? deathdate, string imageUrl)
        {
            Id = id;
            Name = name;
            Birthdate = dob;
            BirthPlace = birthPlace;
            FatherId = fatherId;
            MotherId = motherId;
            LocationId = locationId;
            DietId = dietId;
            Species = species;
            Type = type;
            Sickness = sickness;
            Notes = notes;
            Deathdate = deathdate;
            ImageUrl = imageUrl;
        }
    }
}
