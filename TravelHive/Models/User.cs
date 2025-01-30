using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelHive.Models
{
    public class User
    {
        [Key]
        public int user_Id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }
        
        public string username { get; set; }
        
        public string email { get; set; }
        
        public string password { get; set; }
        
        public string bio { get; set; }
        
        public string profile_photo { get; set; }
    }
}