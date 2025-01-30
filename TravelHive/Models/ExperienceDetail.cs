using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelHive.Models
{
    public class ExperienceDetail
    {
        [Key]
        public int Id { get; set; }

        public int user_Id { get; set; }

        public string place_name { get; set; }

        public string country { get; set; }

        public string type_of_place { get; set; }

        public string Experience_title { get; set; }

        public string personal_exp { get; set; }

        public string duration_of_visit { get; set; }

        public string season_start { get; set; }

        public string season_end { get; set; }

        public string must_see_heighlit { get; set; }

        public string Dos_and_Donts { get; set; }

        public string nearby_attraction { get; set; }

        public string budget { get; set; }

        public int satisfaction { get; set; }

        public int cleanliness { get; set; }

        public int Accessibility { get; set; }

        public int Crowd { get; set; }

        public int Food { get; set; }

        public string packing_essentials { get; set; }

        public string accessibility_information {  get; set; }

        public string food_and_Cult { get; set; }

        public string img1 {  get; set; }

        public int img2 { get; set; }

        public string img3 { get; set; }

        public string img4 { get; set; }

        public string video { get; set; }
    }
}