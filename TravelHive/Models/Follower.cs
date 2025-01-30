using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelHive.Models
{
    public class Follower
    {
        [Key]
        public int Id { get; set; }

        public int user_Id { get; set; }

        public int follower_user_id { get; set; }
    }
}