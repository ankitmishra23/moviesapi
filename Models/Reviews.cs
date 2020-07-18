using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace weekendtask.Models
{
    public class Reviews
    {
        [Key]
        public int reviewId { get; set; }
        public string reviews { get; set; }

        public string movieName { get; set; }
    }
}
