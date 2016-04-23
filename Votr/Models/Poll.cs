using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Votr.Models
{
    public class Poll
    {
        public int PollId { get; set; }

        [MaxLength(500)]
        [Required]
        string Title { get; set;}

        [Required]
        public DateTime     Startdate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        //need Options Relation
        public virtual ICollection<Option> Options { get; set; }
        //Tag Relation
        //User Relation
        //vote Relation
    }
}