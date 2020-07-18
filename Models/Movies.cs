using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace weekendtask.Models
{
    public class Movies
    {
        [Key]
        public int movieId { get; set; }

        public string movieName { get; set; }

        [ForeignKey("Languages")]
        public int languageId { get; set; }
        public Languages Languages { get; set; }

    }
}
