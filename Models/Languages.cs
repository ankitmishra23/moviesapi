using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace weekendtask.Models
{
    public class Languages
    {
        [Key]
        public int languageId { get; set; }

        public string language { get; set; }
    }
}
