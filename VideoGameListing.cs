using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EAD2CA2
{
    public class VideoGameListing
    {
        [Required]
        [Key]
        public int ID { get; set; }
        public String Title { get; set; }
        private int AgeRating { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
